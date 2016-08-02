using System;
using Newtonsoft.Json;
using ONEbook.NG2.API.DTO;

namespace ONEbook.NG2.API.TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var request = new Request();
            var response = new Response();

            var req = JsonConvert.SerializeObject(request);
            var res = JsonConvert.SerializeObject(response);

            Console.WriteLine(req);
            Console.WriteLine(res);            
        }
    }
}
