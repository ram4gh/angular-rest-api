**Application Setup and Overview**

**Prerequisites**
To run this application, you need to have Node.js installed.

**Getting Started**
1.	Clone the repository to your local machine.

2.	Open the project in Microsoft Visual Studio.

3.	Click the "Run" button in Visual Studio.

    •	This will start both the API and the Front End automatically.

**Application Workflow**

**Front End (Angular)**

•	The front-end is built using Angular and communicates with the backend via HTTP calls (CreateEdit and GetAll). 

•	The front end interacts with a REST API that pulls data from an in-memory database. It performs the following operations:

  •	Adds new entries to the database.
  
  •	Fetches and displays all current entries in a Mat Table.

The main components of the front end:

  •	app.component.ts: Handles data fetching, updating, and UI logic.
  
  •	app.component.html: Contains the HTML structure, including input fields for "Name"          (required) and "Address", along with a button to add new addresses to the database.
  
  •	The front-end updates dynamically to reflect changes in the database.

**API (ASP.NET)**

The API is managed by AddressController.cs, which processes incoming API requests. It interacts with the in-memory database using the IDataTransform interface, implemented in DataTransform.cs, to handle operations:

  •	Add a new entry to the database.
  
  •	Retrieve all entries from the database.

The backend is set up in program.cs, where:

  •	The in-memory database is initialized.
  
  •	The IDataTransform interface is scoped.
  
  •	CORS policy is configured to allow communication between the front end and API.

**Technical Overview**

•	**API**: The backend is a .NET application utilizing an in-memory database to simulate persistent storage.

•	**Front End**: The Angular front end uses Material Design components, specifically Mat Table, to display and manage address entries.

•	**Communication**: The API and front end communicate via HTTP using REST principles.

**Running the Application**

Once the repository is cloned and opened in Visual Studio, ensure Node.js is installed, and simply run the project from Visual Studio to launch both the API and front end.
