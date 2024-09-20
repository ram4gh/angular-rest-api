Node.JS must be installed for the application oto work.

To get the app running you should only need to download the repository and open it in Microsoft Visual Studio. Click the run button and both the API and Front end should open.

How to works:
  The Angular front end utilizes Http calls of CreateEdit and GetAll to pull from our Rest API data from an in Memory Database. It will then have that API call either add a new entry or send back all entries in the DB to the frontend. The front end will then update the data source to the new information and display it within a Mat Table.

API:
The API utilizes a controller that can be found at AddressController.cs to take in the api calls. It will then use an interface that can be found at IDataTransform which is implemented in DataTransform to either add a new entry to the DB or return all existing API_Test objects within the DB. The program.cs file for the API is where the In memory DB is established and the scope for the Interface is defined as well as the Cors policy that needed to be opened to allow for direct contact between the two local systems.

Front End:
The Angular Front end Defined within the app.components.ts file uses the Angular imports for Datasource, Http calls and Mat Tables. This front end consists of the Mat table, 2 text boxes to add the name(required field) and address and a button to add the addresses. The HTML for these items can be found within app.component.html. I then have the button call a function called add address which will append the new entry into the DB and then call the get method to update the data source from the DB.
