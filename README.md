# VehicleManagementSystem

Full-Stack Web application with a React front-end and a .NET Core back-end for a simple Vehicle management system.

To run the application:
    Download the source code and open the .sln file using Visual Studio. The app can then be started from Visual Studio.

Backend: 
Built using .NET Core 3.1. 
    Structure:
        1. Models: Contains an abstract vehicle class to cater to different types of vehicles (Cars for now).
        2. Services: Contains a vehicle services class for the read/write functionalitie. This can be updated to support different     vehicles in the future.
        3. Controller: Consists of the get and post endpoints to add cars and retrieve all cars.

    Testing:
        Xunit test has been used in the project. Unit tests for the available business logics have been added

    Documentation:
        Swagger has been integrated to the project. The endpoints details can be found and tested on https://localhost:5001/swagger

Frontend:
Built using ReactJS. User can only add a car currently.
    Structure:
        1. Components:
            1. Home: Dropdown to create a new vehicle
            2. Add Car: Contains the form to get car details from user
        2. Styles: contains the css files of the application
        
    Styling:
        Bootstrap has been used for styling the dropdown and form components.

    API calls:
        AXIOS has been used for communicating with the backend (to add new car here).
        
     


