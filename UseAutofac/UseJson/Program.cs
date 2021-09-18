using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace UseJson
{
    public class Program
    {
        class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }

            [JsonIgnore]
            public string MyProperty { get; set; }
        }

        public static async Task Main(string[] args)
        {

            //The System.Text.Json types are thread-safe, including:
            //JsonSerializer
            //Utf8JsonReader
            //Utf8JsonWriter
            //JsonDocument
            Person person = new Person { Name = "Hello", Age = 123, MyProperty = "adfljflsad" };

            var str = JsonSerializer.Serialize(person, new JsonSerializerOptions(JsonSerializerDefaults.General));
            await File.WriteAllTextAsync(Path.Combine(AppContext.BaseDirectory, "person.json"), str);

            using var stream = new FileStream(Path.Combine(AppContext.BaseDirectory, "person.json"), FileMode.Open, FileAccess.Read);

            //从流中异步
            var deserialObj = await JsonSerializer.DeserializeAsync<Person>(stream);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
