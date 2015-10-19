using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJenkins {
    class Program {
        static void Main(string[] args) {
            var x = JsonConvert.SerializeObject(new { A = "A", B = "B" });
            Console.WriteLine("Jenkins is up! " + x);
            Console.ReadKey();
        }
    }
}
