# Todo Application

This project is a full-stack web application that allows users to create, view, and delete tasks. It was initially based on a tutorial by Art of Engineer, which can be found [here](https://www.youtube.com/watch?v=O5hKoBV3vaU). The original tutorial was followed as a foundation, but slight modifications have been made to tailor the project to personal learning objectives and preferences.

## Modifications from Original Tutorial

- **Database Replacement**: The cloud-based database used in the tutorial has been replaced with a class in the backend designed to mimic database functionalities. This change was made to simplify the setup process and reduce dependencies on external services.
- **Port and Launch URL**: In the launch settings, the port has been changed to `8080`, and the launch URL has been switched from swagger to the root, making the project easier to run locally.
- **Project Structure**: The original tutorial treated the React frontend and .NET backend as separate projects. This version merges both into a single project, allowing for a simplified development process where only Visual Studio is needed to run the entire application.
- **Component Architecture**: All class components demonstrated in the tutorial have been converted to functional components. This change was made because functional components are easier to understand and use, especially with hooks.
- **Notifications**: Instead of using default alerts for notifications, this project utilizes the `react-toastify` library. This enhancement makes notifications more aesthetically pleasing and user-friendly.
- **Future Plans**: There are plans to add error handling with try-catch blocks, implement additional styling, and possibly introduce more features to enhance the application's functionality.
- **Docker Integration**: As part of the learning process, Docker was used to containerize the application. The goal is to deploy the application to a hosting service for practical experience in software deployment.

## Running the Project

To run this project locally, you will need to have Visual Studio and Docker installed on your machine. Follow these steps:

1. Clone the repository to your local machine.
2. Open the solution file in Visual Studio.
3. Build the solution to restore NuGet packages and prepare the application.
4. Ensure Docker Desktop is running.
5. Use the Docker CLI to build and run the containerized application.
6. Access the application by navigating to `http://localhost:8080` in your web browser.

## Contributions

Contributions to this project are welcome. Please consider the following guidelines:

- Fork the repository and create your branch from `master`.
- If you've added code that should be tested, add tests.
- Ensure your code lints.
- Issue pull requests with detailed descriptions of changes.

## Acknowledgments

Special thanks to Art of Engineer for the initial tutorial that inspired this project. The original video can be found [here](https://www.youtube.com/watch?v=O5hKoBV3vaU).
