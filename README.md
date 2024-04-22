-Application for ordering food and delivering using .NET6 AND ASP.NET CORE MVC.
-Requirements for project:
ImgConstant for base path in BusarovsQuickBite.Infrastructure.Constants.ImgConstants.ImgBasePath should be set beforehand in order to run the project(Example: C:/Users/Admin/BusarovsQuckBite/wwwroot/Images).
downloaded the following images - https://drive.google.com/drive/folders/1pglU_AKdw8SKPgoN0KjTLcX3ZeddqYz3?usp=drive_link and pasted them in wwwroot/Images directory(Images directory should be created beforehand)
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
Configuration is needed for unit tests as well as for the main project.
Update-Database should be run like the following:
Update-Database --migration "LatestMigrationInMigrationsFolder"
Note: Path variable should be with / and ending with /
For testing purposes the following smtp configuration can be used:
"EmailConfiguration": {
  "SmtpServer": "email-smtp.eu-west-2.amazonaws.com",
  "SmtpPort": "25",
  "SmtpUsername": "AKIA5FTY7Y4RCA7PDGWR",
  "SmtpPassword": "BL3vFFON4AUKRGgZ44G14TPq7DQWB19jY1HLVTmI6OSu"
