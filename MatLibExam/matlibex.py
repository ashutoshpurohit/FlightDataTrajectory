import matplotlib.pyplot as plt
import requests
import json
#plt.plot([1, 2, 3, 4,100], [1, 4, 9, 16,200])
Latitudes = []
Longitudes = []
Latitude = []
Longitude = []
mysecondresp = requests.get('https://bikercourierlink.herokuapp.com/AirFlight')
#mysecondresp = requests.get('http://localhost/GetAirFlight/IGO566')
#mysecondresp = requests.get('http://localhost/GetAirFlight/AIC173')

if(mysecondresp.ok):
    
    print( mysecondresp.status_code)
    
    json2data = mysecondresp.json()
    
    for j in range(99):
        for i in range(len(json2data[j]["AirFlightPath"])):
            for key in json2data[j]["AirFlightPath"][i]:
                #print(key)
                Longitude.append(json2data[j]["AirFlightPath"][i]["Longitude"])
                Latitude.append(json2data[j]["AirFlightPath"][i]["Latitude"])
        Latitudes.append(Latitude)
        Longitudes.append(Longitude)
    #for i in range(len(json2data)):
        #print("Tecaher Count : " + str(i))
        #print(json2data[i])
        #for key in json2data[i]:
            #pass
            #print(key)
            #print(json2data[i][key])
for k in range(len(Latitudes)) : 
    plt.plot(Latitudes[k],Longitudes[k])

plt.show()