# Add Two Numbers

This project is a sample two-layered application which simply adds two numbers and displays the sum and has the ability to persist the history of past opertaions in a sql server database.

# Implementation Details

The layers of this application are presentation and data access. 
The presentation layer is a windows forms project and the data access layer is a class library which utilises entity framework to connect to sql server and uses database first approach. These two layers are decoupled via dependency injection. Data access layer instance is passed to the presentation layer through constructor injection.


