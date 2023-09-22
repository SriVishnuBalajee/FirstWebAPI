using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient
{
    internal class EmpCLient
    {
        static Uri uri = new Uri("http://localhost:5031");
        
        public static async Task CallGetEmployee()
        {
            using(var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("Get");
                response.EnsureSuccessStatusCode();
                if(response.IsSuccessStatusCode)
                {
                    String x=await response.Content.ReadAsStringAsync();
                    await Console.Out.WriteLineAsync(x);
                }
            }
        }
    }
}
