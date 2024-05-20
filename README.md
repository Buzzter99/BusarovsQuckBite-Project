-Application for ordering food and delivering using .NET6 AND ASP.NET CORE MVC. ORM used is EF and DB Provider is MS SQL.
-Requirements for the project to be built:
Configuration in the following pattern:

{
  "EncryptionKeys": {
    "DefaultKey": "randomkey"
  },
  "ConnectionStrings": {
    "DefaultConnection": "<yourConnectionString>"
  },
  "EmailConfiguration": {
    "SmtpServer": "SmtpServer",
    "SmtpPort": "SmtpPort",
    "SmtpUsername": "SmtpUsername",
    "SmtpPassword": "SmtpPassword"
  }
},
"RootFullPath": "C:/Admin/PathTowwwroot/"
2.Configuration is needed for unit tests as well as for the main project.
3.For testing purposes the following smtp configuration can be used:
"EmailConfiguration": {
  "SmtpServer": "email-smtp.eu-west-2.amazonaws.com",
  "SmtpPort": "25",
  "SmtpUsername": "AKIA5FTY7Y4RCA7PDGWR",
  "SmtpPassword": "BL3vFFON4AUKRGgZ44G14TPq7DQWB19jY1HLVTmI6OSu"
4.There is a working api which downloads all the base images for the db seed which works on the following endpoint:
http://baseurl/api/ExportBaseImg (GET)
-This api may or may not change in future releases.
-For the api it is used the minimal api architecture with asp.net core .net 6.
-Api gets the files ready and exports them in .zip extenstion.
MVC Currently/Temporary hosted in OCI:
http://130.61.253.188/quickbite - MVC
http://130.61.253.188/quickbiteapi/swagger/index.html - Swagger API
