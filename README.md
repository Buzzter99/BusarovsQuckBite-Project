-Application for ordering food and delivering using .net6 with ASP.NET CORE.
-Requirements for project:
ImgConstant for base path should be set beforehand in order to run the project.
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
"RootFullPath": "pathtowwwrootwith\\"
Configuration is needed for unit tests as well as for the main project.
