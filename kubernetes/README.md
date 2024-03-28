# Manual Testing Commands  

export API_URL="http://165.232.144.187:8081"  


apt-get update && apt-get install -y gettext-base


## ENV Substitute command  
```
envsubst < environment.ts > environment.tmp.ts && mv environment.tmp.ts environment.ts
```  

## Net Cat Command  
```
nc -zv pod-b-service 80
```  

## Curl Command  
### Curl for login  
```
curl -X POST -H "Content-Type: application/json" -d '{"Username":"srinu", "Password":"teja"}' http://165.232.144.187:8081/api/Auth/login
```  

### Curl for Signup  
```
curl -X POST -H "Content-Type: application/json" -d '{"Username":"your_username", "Password":"password", "ConfirmPassword": "password "}' http://dotnet-svc:5106/api/Auth/signup
```   

## Http POST command  
```
http POST http://165.232.144.187:8081/api/Auth/login Username=your_username Password=your_password
```  
