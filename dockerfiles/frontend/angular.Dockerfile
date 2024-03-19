# Use Ubuntu as the base image
FROM ubuntu:latest

# Set the working directory
WORKDIR /app

# Update package index and install necessary packages
RUN apt-get update && apt-get install -y \
    curl \
    gnupg \
    && rm -rf /var/lib/apt/lists/*

# Install Node.js
RUN curl -fsSL https://deb.nodesource.com/setup_lts.x | bash -
RUN apt-get install -y nodejs

# Install Angular CLI
RUN npm install -g @angular/cli

# Display Node.js, npm, and Angular CLI versions for verification
RUN node -v
RUN npm -v
RUN ng version

# Expose port 4200 (default port used by ng serve)
EXPOSE 4200

# Copy the current directory contents into the container at /app
COPY . .

# Change working directory to the client folder
WORKDIR /app/client

# Install dependencies for the Angular application
RUN npm install

# By default, start the Angular application using ng serve
CMD ["ng", "serve", "--host", "0.0.0.0"]