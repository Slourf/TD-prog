#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LibNetCat;

#endregion

namespace ClientCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add What You want Here :)
            var client = new Client(IPAddress.Parse("127.0.0.1"));
            Console.CancelKeyPress += delegate {
                client.Disconnect();
            };
            client.MessageReceived += delegate(object sender, MessageEvent e)
            {
                Console.WriteLine(e.Content);
            };
            client.Disconnected += delegate
            {
                Console.WriteLine("Le serveur s'est déconnecté...");
                Environment.Exit(0);
            };
            while (true)
                client.SendMessage(Console.ReadLine());
        }
    }
}
