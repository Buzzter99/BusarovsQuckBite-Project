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
3.There is a working api which downloads all the base images for the db seed which works on the following endpoint:
http://baseurl/api/ExportBaseImg (GET)
-This api may or may not change in future releases.
-For the api it is used the minimal api architecture with asp.net core .net 6.
-Api gets the files ready and exports them in .zip extenstion.
MVC Currently hosted in OCI with Autonomous Oracle Database and Ubuntu OS with reverse proxy:
http://138.3.247.158 - MVC
http://138.3.247.158/app/swagger/index.html - Swagger API (GET Request works with or without /app in the URL)
