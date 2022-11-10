// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace DataTableFromJson
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using(HttpClient client = new())
            {
                var response = await client.GetStringAsync("https://crmscf.vidyasystems.com/api/gen/items.php");
                JObject jsonObject = JObject.Parse(response);
                var items = JsonConvert.SerializeObject(jsonObject["items"]);
                DataTable tester = (DataTable)JsonConvert.DeserializeObject(items, (typeof(DataTable)));
            }
            Console.WriteLine("Hello, World!");
        }
    }
}

