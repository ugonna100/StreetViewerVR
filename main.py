import math
import keyfile.py as key

import requests


API_KEY = key.API_KEY

Origin = input("Starting Location: ")
Destination = input("Ending Location: ")
URL = "https://maps.googleapis.com/maps/api/directions/json?origin="
URL += Origin + "&destination="
URL += Destination + "&key="
URL += API_KEY

res = requests.get(url=URL)

# Computes the bearing in degrees from the point A(a1,a2) to
# the point B(b1,b2). Note that A and B are given in terms of
# screen coordinates.
def bearing(a1, a2, b1, b2):
    TWOPI = 6.2831853071795865
    RAD2DEG = 57.2957795130823209
    if (a1==b1 and a2==b2):
        print("Origin & Destination cannot match!")
    theta = math.atan2(b1 - a1, a2 - b2)
    if (theta < 0.0):
        theta += TWOPI
    return RAD2DEG * theta

if res.ok:
#     print(bearing(100,200,1,5))
    print("POST Success")
    print(res.json())
