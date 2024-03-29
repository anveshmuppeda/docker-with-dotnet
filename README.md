# Dotnet & Angular with Docker [![GitHub](https://img.shields.io/github/license/anveshmuppeda/docker-with-dotnet?color=blue)](https://github.com/anveshmuppeda/docker-with-dotnet/blob/main/LICENSE)


Exciting News! We’ve developed an Angular application intricately intertwined with Dotnet for a robust backend experience. Featuring essential components like login, signup pages, and an engaging homepage showcasing our team’s details, our application is now ready for deployment. Leveraging Docker’s power, we’ve seamlessly migrated our Angular application into containers.  

To streamline deployment, we’ve crafted custom Docker images for both the backend and frontend. With these images in hand, we’ve assembled a Docker Compose file, simplifying the process of deploying our application into the Docker environment.  

## Deploying with Docker Compose  
### Deploy Your Application:  
Open a terminal and navigate to the directory containing your docker-compose.yml file.  
Run the docker-compose up command to start the deployment.  

```
docker-compose up -d
```   

### Verify Deployment:  
Access your application using the specified ports (e.g., http://localhost:port).  
Verify that both frontend and backend services are running correctly.  

## Building Docker Images  
You can directly clone the all docker files and dependent code by using the below command.  
```
git clone https://github.com/anveshmuppeda/docker-with-dotnet.git  
```

### Build Docker Image for Frontend:  
Run the **docker build** command to build the Docker image for the frontend.  
```
cd dockerfiles/frontend  
docker build -t frontend-image-name --file angular.Dockerfile .  
```   

### Build Docker Image for Backend:  
```
cd dockerfiles/frontend  
docker build -t backend-image-name --file dotnet.Dockerfile .
```   

## Project Maintainers & Contributors  
<table>
  <tr>
    <td align="center"><a href="https://anveshmuppeda.github.io/profile/"><img src="https://avatars.githubusercontent.com/u/115966808?v=4" width="100px;" alt=""/><br /><sub><b>Anvesh Muppeda</b></sub></a></td>
    <td align="center"><a href="https://github.com/saimanasak"><img src="https://avatars.githubusercontent.com/u/47205414?v=4" width="100px;" alt=""/><br /><sub><b>Sai Manasa Kota</b></sub></a></td>
    <td align="center"><a href="https://github.com/khajjayamteja"><img src="https://avatars.githubusercontent.com/u/151116058?v=4" width="100px;" alt=""/><br /><sub><b>Teja Sai Srinivas</b></sub></a></td>
    <td align="center"><a href="https://github.com/sakethvardhineni"><img src="https://avatars.githubusercontent.com/u/132186396?v=4" width="100px;" alt=""/><br /><sub><b>Saketh Rao Vardhineni</b></sub></a></td>
    <td align="center"><a href="https://github.com/Vishwasena-Raidu-Nyaramneni"><img src="https://avatars.githubusercontent.com/u/120606838?v=4" width="100px;" alt=""/><br /><sub><b>Vishwasena Raidu Nyaramneni</b></sub></a></td>
  </tr>
</table>  