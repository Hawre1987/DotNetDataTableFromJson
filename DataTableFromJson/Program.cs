// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace DataTableFromJson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var filePath = new StreamReader("../../../items.json");
            JObject jsonObject = JObject.Parse(filePath.ReadToEnd());
            var items = JsonConvert.SerializeObject(jsonObject["items"]);
            DataTable tester = (DataTable)JsonConvert.DeserializeObject(items, (typeof(DataTable)));
            Console.WriteLine("Hello, World!");
        }
    }
}

