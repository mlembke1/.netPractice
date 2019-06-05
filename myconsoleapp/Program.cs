using System;
using Newtonsoft.Json;
using myclasslib;


namespace myconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { First = "Mitch", Last = "Lembke" };
            string json = JsonConvert.DeserializeObject(p, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
