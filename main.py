import keyfile as key
import requests

def decode_polyline(polyline_str):
    index, lat, lng = 0, 0, 0
    coordinates = []
    changes = {'latitude': 0, 'longitude': 0}

    # Coordinates have variable length when encoded, so just keep
    # track of whether we've hit the end of the string. In each
    # while loop iteration, a single coordinate is decoded.
    while index < len(polyline_str):
        # Gather lat/lon changes, store them in a dictionary to apply them later
        for unit in ['latitude', 'longitude']:
            shift, result = 0, 0

            while True:
                byte = ord(polyline_str[index]) - 63
                index+=1
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

API_KEY = key.API_KEY

#eOrigin = input("Starting Location: ")
#Test input: Disneyland
#Destination = input("Ending Location: ")
#Test input: Universal Studios Hollywood
testURL = "https://maps.googleapis.com/maps/api/directions/json?origin=Disneyland&destination=Universal+Studios+Hollywood4&key="
testURL += API_KEY
#URL = "https://maps.googleapis.com/maps/api/directions/json?origin="
#URL += Origin + "&destination="
#URL += Destination + "4&key="
#URL += API_KEY

res = requests.get(url = testURL)
if res.ok:
    print("POST Success")
    data = res.json()
    print(data['routes'][0]['overview_polyline']['points'])
    decoded = decode_polyline(data['routes'][0]['overview_polyline']['points'])
    print(decoded)
