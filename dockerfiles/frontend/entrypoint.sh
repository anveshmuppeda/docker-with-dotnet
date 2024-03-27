#!/bin/bash

# Replace placeholders in environment.ts with actual environment variable values
if [ -z "$API_URL" ]; then
  echo "API_URL environment variable is not set. Using default value."
  export API_URL="http://127.0.0.1:8081"
else
  echo "Using API_URL from environment variable: $API_URL"
fi

# Run envsubst to replace placeholders in environment.ts with actual environment variable values
envsubst < src/environments/environment.ts > src/environments/environment.tmp.ts && \
mv src/environments/environment.tmp.ts src/environments/environment.ts

# Start the Angular application
exec "$@"
