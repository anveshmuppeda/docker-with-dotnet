# Angular & Dotnet  
## Dynamic Docker Environments: Angular & .NET Edition 🔄  
### Optimizing Angular & .NET Apps with Runtime Variables  

Welcome back to the second part of our Docker journey with Angular and .NET! In the previous part, we explored the process of migrating our Angular and .NET application into Docker containers. We delved into accessing and managing these applications within Docker, laying a solid foundation for seamless deployment.  

In this continuation, we aim to enhance the flexibility and adaptability of our setup by dynamically parameterizing Angular and .NET environment variables within Docker. Our focus lies in understanding how to modify these variables during runtime and seamlessly integrate them into Docker's environment.  

Angular applications traditionally embed environment variables during the build process, making them static and requiring separate builds for different environments. However, within the containerized world, configuring applications through environment variables is a prevalent practice. We'll explore how to transition from static to dynamic configuration, empowering us to effortlessly manage our Angular application across diverse Docker environments.  

Let's dive into the intricacies of this process and uncover the steps to achieve seamless environment variable management within Docker. By the end, you'll be equipped with the knowledge to streamline your Angular and Dotnet application's adaptability and resilience in any Docker environment.  

## Understanding Angular and .NET Environment Variables:  

Delve deeper into how environment variables are traditionally handled in Angular and .NET applications during the build process.  
Highlight the challenges posed by static configurations and the need for dynamic adaptability in modern containerized environments.  

The above is our login.component.ts file from angular application. So in this component file we have a line "this.http.post<any>('http://165.232.144.187:8081/api/Auth/login', this.loginData)" this will connect to the backend that is dotnet. so this would be change environment to environment also the port might be different if we expose it differntly in docker. So this URL might not be the static one, so we need to change this to dynamic which means we can pass this URL as a environment variable during the run time. So that we can run this appliaction any where.  

Same for signup.component.ts file.  

## 1. Understanding Angular and .NET Environment Variables:  
The Angular and .NET applications utilize hardcoded URLs to connect to the backend during the login and signup processes.  
However, relying on static URLs presents challenges, especially in dynamic deployment environments like Docker.  
To address this, we'll transition from static URLs to dynamic configuration using environment variables.  
By doing so, we ensure flexibility in specifying backend URLs during runtime, facilitating seamless application deployment across different environments.  

