import keyfile as key
import requests
import math
import urllib
import sys
#from cv2 import *

URLs = []

def decode_polyline(polyline_str):
    index, lat, lng = 0, 0, 0
    coordinates = []
    changes = {'latitude': 0, 'longitude': 0}

    # Coordinates have variable length when encoded, so just keep
    # track of whether we've hit the end of the string. In each
    # while loop iteration, a single coordinate is decoded.
    while index < len(polyline_str):
        # Gather la/lo changes, store them in a dictionary to apply them later
        for unit in ['latitude', 'longitude']:
            shift, result = 0, 0

            while True:
                byte = ord(polyline_str[index]) - 63
                index += 1
                result |= (byte & 0x1f) << shift
                shift += 5
                if not byte >= 0x20:
                    break

            if (result & 1):
                changes[unit] = ~(result >> 1)
            else:
                changes[unit] = (result >> 1)

        lat += changes['latitude']
        lng += changes['longitude']

        coordinates.append((lat / 100000.0, lng / 100000.0))

    return coordinates


def bearing(a1, a2, b1, b2):
    TWOPI = 6.2831853071795865
    RAD2DEG = 57.2957795130823209
    if (a1 == b1 and a2 == b2):
        print("Origin & Destination cannot match!")
    theta = math.atan2(b1 - a1, a2 - b2)
    if (theta < 0.0):
        theta += TWOPI
    return RAD2DEG * theta


def form_picture(decoded):
#"https://maps.googleapis.com/maps/api/streetview?size=800x600&location=" #Image API
#"https://maps.googleapis.com/maps/api/streetview/metadata?size=600x300&location=" #Metadata
    for i in range(0, len(decoded) - 1):
        URL = "https://maps.googleapis.com/maps/api/streetview/metadata?size=1920x1080&location="  # Metadata
        lat = decoded[i][0]
        lon = decoded[i][1]
        lat2 = decoded[i + 1][0]
        lon2 = decoded[i + 1][1]
        heading = bearing(lat, lon, lat2, lon2)
        URL += "{},{}&fov=360&heading={}&pitch=0&key={}".format(lat, lon, heading, key.VIEW_KEY)
        res = requests.get(url=URL)
        if res.ok:
            data = res.json()
            if data['status'] == "OK":
                URL = "https://maps.googleapis.com/maps/api/streetview?size=1920x1080&location="
                URL += "{},{}&fov=360&heading={}&pitch=0&key={}".format(lat, lon, heading, key.VIEW_KEY)
                img = requests.get(url=URL)
                # print(URL)
                if img.ok:
                    URLs.append(URL)

def runThis(initial, destination):

    API_KEY = key.API_KEY
    # Test input: Disneyland
    # Test input: Universal Studios Hollywood
    #testURL = "https://maps.googleapis.com/maps/api/directions/json?origin=Disneyland&destination=Universal+Studios+Hollywood4&key={}".format(API_KEY)
    #   User Input
    Origin = initial #input("Starting Location: ")
    Destination = destination #input("Ending Location: ")
    URL = "https://maps.googleapis.com/maps/api/directions/json?origin="
    URL += Origin + "&destination="
    URL += Destination + "&key="
    URL += API_KEY
    print(URL)
    res = requests.get(url=URL)
    data = {}
    decoded = []
    count = 0
    if res.ok:
        # print("POST Success")
        data = res.json()
        decoded = decode_polyline(data['routes'][0]['overview_polyline']['points'])
        print(decoded)
        print("Coordinates from {} to {}".format(Origin, Destination))
        form_picture(decoded)
        while count < len(URLs):
            print("count: " + str(count))
            urllib.request.urlretrieve(URLs[count], str(Origin) + str(Destination) + str(count) + ".jpg")
            count = count + 1

    # Video Generation
    # count = 0
    # img1 = cv2.imread('0.jpg')
    # height, width, layers = img1.shape
    # video = cv2.VideoWriter('video.avi', -1, 1, (width, height))
	# print("~Forming Video~")
    # while count < len(URLs):
    #     img1 = cv2.imread(str(count) + '.jpg')
    #     video.write(img1)
    #     count = count + 1
    # fps = 24
    # cv2.destroyAllWindows()
    # video.release()

    #Journey searcher: Returns picture at position searched for e.x. 50% = 134.jpg
def tripHunter(percent):
    num_URLs = len(URLs)
    target = num_URLs*percent
    target = int(target)
    results = []
    results.append(str(target) + ".jpg")
    results.append(URLs[target])
    return results

if __name__ == "__main__":
    runThis(sys.argv[1], sys.argv[2])
