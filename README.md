# API Testing Challenge

## Overview
This project contains test cases for validating a RESTful API using NUnit and RestSharp. The API used for testing is JSONPlaceholder, which provides a fake online REST API for testing and prototyping.

## Objective

The primary goal of this project is to automate the testing of the JSONPlaceholder API by validating the following functionalities:

- **GET Request**: Ensure that the API returns the correct post data.
- **POST Request**: Verify the successful creation of a new post.
- **PUT Request**: Validate the updating of an existing post.
- **DELETE Request**: Confirm the successful deletion of a post.

## Set Up Environment
1. Install .NET SDK
To check if the .NET SDK is installed, run the following command in your terminal:dotnet --version

### Project Structure:
ApiTests/
ApiTests.csproj
- GetPostTests.cs
- CreatePostTests.cs
- UpdatePostTests.cs
- DeletePostTests.cs

The following API test cases have been implemented:

1. **GET Request**:
   - Endpoint: `/posts/1`
   - Validates that the response status code is 200.
   - Checks if the response body contains the expected post data (`userId`, `id`, `title`, and `body`).

2. **POST Request**:
   - Endpoint: `/posts`
   - Validates that a new post can be created successfully.
   - Confirms the response status code is 201 and verifies the details of the created post.

3. **PUT Request**:
   - Endpoint: `/posts/1`
   - Tests updating an existing post.
   - Validates that the response status code is 200 and checks the updated post details.

4. **DELETE Request**:
   - Endpoint: `/posts/1`
   - Tests deleting a post.
   - Confirms the response status code is either 200 or 204.

## Running the Tests
Due to some encountered errors, the test cases have not been executed yet, build fails all the time.But The setup requires the following:
- **NUnit**: For writing and executing the tests.
- **RestSharp**: For making HTTP requests to the API.

## Getting Started
To get started with this project, you will need to:
1. Clone this repository to your local machine.
2. Open the project in your IDE (e.g., Visual Studio or VS Code).
3. Ensure the necessary dependencies are installed(e.g.
4. Attempt to run the tests.

