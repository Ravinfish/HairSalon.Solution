# Salon Serenity App

#### By Ravin Fisher

### Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* MySQL
* MySQL Workbench

### Description
This is a simple website for a fictional hair salon, where a user can add stylists to the sites database as well as add clients for a specific hair stylist at the salon. Users can view all available stylists and view a list of cliets for each specific stylist.


## Instalation/Setup

Install Tools:

This project assumes you have MySQL Server and MySQL Workbench installed on your system. If you do not have these tools installed, follow along with the installation steps for the the necessary tools introduced in the series of lessons found here (https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

Set Up the Database: 

And an appsetting.json with the following contents, replacing the following values with your own:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

[YOUR-USER-HERE] with your username
[YOUR-PASSWORD-HERE] with your password
[YOUR-DB-NAME] with the name of your database

## Known Bugs
Page is not set up yet, so nothing is functional at this time.

## Licence
Code Licenced under GPL

Copyright (c) February 2024 Ravin Fisher