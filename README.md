# rzdb-urf-app-gen

Razor Database Unit of Work Framework Application Generator - This project will generate a full working middle tier application.  This middle tier application supports the unit of work design pattern standards that the URF framework brings in addition to OData v4 surfaced through SwaggerUI.   

## Getting Started

This applicaiton will compile in both VS2015 and VS2017.  There is a known issue with VS2017 where you cannot debut the cshtml templates using the project in Generators/RzDbCodeGen.  If you use VS2015,  you can set a breakpoint in a cshtml tmeplate when you change the project to a Console Application and set it as the default project.  Running that app this way will allow you to debug code templates.  Remember to change it back to "Class Library" when you are ready to continue code generation after edmx refeesh.  

- [Download the WideWorldImporters Standard Database from here](https://github.com/Microsoft/sql-server-samples/releases/download/wide-world-importers-v1.0/WideWorldImporters-Standard.bak) - Restore this .bak file in MSSQL 2016
- Execute the following query in the database.  This is because the object names must be unique across the database,  there are 3 views in this database that match the table names they abstract. 
```sql
    EXEC sp_rename 'Website.Customers', 'vwCustomers';
    EXEC sp_rename 'Website.Suppliers', 'vwSuppliers';
    EXEC sp_rename 'Website.VehicleTemperatures', 'vwVehicleTemperatures';
```
- Navigate to DataServices\DataAccess\Models\WideWorldImporters.edmx
- On the Diagram Canvas,  select Edit->Select All or click anywhere in the canvas and press Ctrl+A (to select all objects).  Then Delete them all (acknowledging that you want them all deleted),  BUT DO NOT SAVE!! 
- Once cleared, click on the edmx designer canvas again, right click and select "Update Model from Database"
- Either create a new connection or use an existing one, but do not save the connection string unless you mean to.  When you work with other people with different connection strings,  you may run into some if you commit this change. Click Next.
- Select Tables and Views, leave Pluralize or Singularize Object Names Empty, Check Include foriegn keys, uncheck Import Selected Stored Procedures and functions into entity model.
- Select Finish and in a minute or so, you will see your objects and their relationship. Click Ctrl+S to start the save.    This should trigger the t4 template that handles the code generation found in \DataAccess\Models\CodeGenerations.tt.  The app may ask you to reload the solutions (this is in order to handle adding/removing songs from the project).  Click Reload All and if it asks you to save DataAccess project, select yes.
- NAvigate to \DataAccess\Models\WideWorldImporters.tt, 
 

### Conventions to keep in mind
- Your column names cannot match any object names.  This is because when generator writes the POCO classes,  having properties with the same names in one object will cause issues.
- Object names must be unique (meaning SchemaA.Tablename and SchemaB.Tablename) will cause the same issue as above.  This goes for schema objects in tables/views/stored procs/etc.  
- Odata works with properly defined forigh keys.  You will get the best benefit if you adhere to standard normalization principles.  


### Prerequisites

What things you need to install the software and how to install them

```
Give examples
```

### Installing

A step by step series of examples that tell you have to get a development env running

Say what the step will be

```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```

## Deployment

Add additional notes about how to deploy this on a live system

## Built With

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - The web framework used
* [Maven](https://maven.apache.org/) - Dependency Management
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone who's code was used
* Inspiration
* etc
