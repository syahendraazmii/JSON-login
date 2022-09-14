using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Login
{
    public class inputClient
    {
        public string UName { get; set; }
        public string Pass { get; set; }

        public int LengthUser, LengthPassword;
    }
    class Client
    {
        static void Main()
        {
            inputClient client = new inputClient();
            Console.WriteLine("Your Username : ");
            client.UName = Console.ReadLine();

            Console.WriteLine("Your Password : ");
            client.Pass = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(client.UName.Length + "_" + client.UName + " " + client.Pass.Length + "_" + client.Pass);
            string jsonString = JsonSerializer.Serialize(client);

            Console.WriteLine(jsonString);
            Console.ReadLine();
        }
    }
}