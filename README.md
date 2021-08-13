# mongodb_crud
This is an example of Mongodb CRUD in VB Net

## Open MongoDB Compass
Connect to localhost

    mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false
    
## Create a new Database & Collection
Give it a name: admin, collection name: fakultas

Import file fakultas.json to fakultas collection

## MongoDB Driver
Install MongoDB Driver on Visual Basic Project using Nuget Package Manager

     Install-Package MongoDB.Driver -Version 2.7.3
