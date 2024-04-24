using System.IO.Compression;
namespace BusarovsQuckBite.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAuthorization();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapGet("api/ExportBaseImg", () =>
            {
                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Files");

                if (!Directory.Exists(directoryPath))
                {
                    return Results.NotFound("Directory not found.");
                }
                var files = Directory.GetFiles(directoryPath);
                if (files.Length == 0)
                {
                    return Results.NotFound("No files found in the directory.");
                }
                var zipFileName = "BaseImages_files.zip";
                
                var zipFilePath = Path.Combine(Directory.GetCurrentDirectory() ,"Files", zipFileName);

                using (var zipArchive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
                {
                    foreach (var filePath in files)
                    {
                        var entryName = Path.GetFileName(filePath);
                        zipArchive.CreateEntryFromFile(filePath, entryName);
                    }
                }
                var zipFileBytes = File.ReadAllBytes(zipFilePath);
                File.Delete(zipFilePath);
                return Results.File(new MemoryStream(zipFileBytes), "application/zip", zipFileName, enableRangeProcessing: true);
            });
            app.Run();
        }
    }
}
