import keyfile.py as key
import requests

API_KEY = key.API_KEY

Origin = input("Starting Location: ")
Destination = input("Ending Location: ")
URL = "https://maps.googleapis.com/maps/api/directions/json?origin="
URL += Origin + "&destination="
URL += Destination + "&key="
URL += API_KEY

res = requests.get(url = URL)
if res.ok:
    print("POST Success")
    print(res.json())