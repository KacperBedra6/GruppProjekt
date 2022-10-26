using Grupparbete.Model;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Grupparbete
{
    public class JsonFileTaskService
    {
        public JsonFileTaskService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "task.json");

        public IEnumerable<Task> GetTasks()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<Task[]>(jsonFileReader.ReadToEnd(),
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

        }
    }
}
