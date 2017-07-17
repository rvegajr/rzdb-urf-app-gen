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
- Either create a new connection or use an existing one, but do not save the connection string unless you mean to.  When you work with other people with different connection strings,  you may run into some problems if you commit this change. Click Next.
- Select Tables, do not check views or stored procedures. Leave Pluralize or Singularize Object Names Empty, Check Include foriegn keys, uncheck Import Selected Stored Procedures and functions into entity model.
- Select Finish and in a minute or so, you will see your objects and their relationship. Click Ctrl+S to start the save.    This should trigger the t4 template that handles the code generation found in \DataAccess\Models\CodeGenerations.tt.  The app may ask you to reload the solutions (this is in order to handle adding/removing songs from the project).  Click Reload All and if it asks you to save DataAccess project, select yes.
- I have noticed some quirkiness when it coems to this method of code generation.  Just to be safe,  Go to \DataAccess\Models\CodeGenerations.tt, add a space at the end of a line of code and press Ctrl+S or Save.  This will trigger another code generation process.   I am working in a removing edmx entirely from this build pipeline as it appears to be phased out by microsoft,  but right now all the benefits outweigh this pain. 
- Once the application has reloaded,  right click on the soluton and build.  Swagger UI will come up and your will be able to interact with your app using OData.
- NOTE:  Currently, there is a bug where [InverseProperty("LastEditedBy")] causes an error.  This can be solved by change all instances of [InverseProperty("LastEditedBy")] to [InverseProperty("LastEditedByPerson")]

### Conventions to keep in mind
- Your column names cannot match any object names.  This is because when generator writes the POCO classes,  having properties with the same names in one object will cause issues.
- Object names must be unique (meaning SchemaA.Tablename and SchemaB.Tablename) will cause the same issue as above.  This goes for schema objects in tables/views/stored procs/etc.  
- Odata works with properly defined forigh keys.  You will get the best benefit if you adhere to standard normalization principles.  
- POCO classes will not be generated for temporal tables
- Composite Keys are not fully supported yet

## Built With

* [URF Framework](https://genericunitofworkandrepositories.codeplex.com/) - The framework that made it easy for me to apply code generation
* [RazorEngine](https://antaris.github.io/RazorEngine/) - The Template framework that allows me to debug code templates (and beats the pants of T4 templates)
* [RazorEngine Database Code Generator](https://github.com/rvegajr/rzdb-code-gen) - Code generator built of RazorEngine that consumes EDMX files into a simplified schema thus making it easier to work with

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/rvegajr/rzdb-urf-app-gen/tags). 

## Authors

* Ricky Vega - *Initial work* - [rvegajr](https://github.com/rvegajr)

See also the list of [contributors](https://github.com/rvegajr/rzdb-urf-app-gen/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Known Issues
- Spatial Datatypes could not be rendered - Making a call to Cities may trigger an error where the Api cannot render DbGeometry.  The root of the project contains a version of the SQL clr data types that will install them in the GAC.  You might get luck and not have to restart after you install them,  but I wasn't that lucky.

## How can I deal with SoftDeletes?  What if I have a field called IsDeleted and DateCreated that I want to have in the model but not surfaces in the api and swagger interface?

Navigate to Generators/RzDbCodeGen/Ef6Models/Ef6ModelsTemplate.cshtml

Add the following lines after line 55 which should say:
@(property.Name == "SysStartTime" || property.Name == "SysEndTime" ? @"<t>[DatabaseGenerated(DatabaseGeneratedOption.Computed)]<t/>" : "")

```cs
    @(property.Name == "IsDeleted" || property.Name == "DateCreated" ? @"<t>[NotMapped]<t/>" : "")
	@(!property.IsNullable ? @"<t>[Required]<t/>" : "")
```

 It should look like this
```cs
    foreach (Property property in _Model[entityName].Properties.Values)
    {
        <t>/// <summary></summary>
		@(property.Name == "SysStartTime" || property.Name == "SysEndTime" ? @"<t>[DatabaseGenerated(DatabaseGeneratedOption.Computed)]<t/>" : "")
        @(property.Name == "IsDeleted" || property.Name == "DateCreated" ? @"<t>[NotMapped]<t/>" : "")
		@(!property.IsNullable ? @"<t>[Required]<t/>" : "")
        @(property.IsKey ? "[Key] " : "")<t />public @property.Type.ToNetType(property.IsNullable)<t /> @property.Name { get; set; }</t>
    }
```

Trigger a code regeneration by adding a space in CodeGenerations.tt and saving the file.  This should be what you need

