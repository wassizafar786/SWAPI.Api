using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;

namespace SWAPI.Shared.Helper
{
    public class JsonFileReader
    {
        private static IWebHostEnvironment _env;

        public static void Initialize(IWebHostEnvironment env)
        {
            _env = env;
        }

        public static T ReadJsonFromFile<T>(string relativePath)
        {
            if (_env == null)
            {
                throw new InvalidOperationException("IWebHostEnvironment is not initialized.");
            }

            var filePath = Path.Combine(_env.WebRootPath, relativePath);

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(json);
            }
            else
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
        }
    }
}
