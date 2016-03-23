#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Server
{
    class Program
    {
        static void PrintHelp()
        {
            Console.WriteLine("Usage: \"Server Port\"");
        }
        static void Main(string[] args)
        {
            int port;
            try
            {
                port = int.Parse(args[0]);
            }
            catch (Exception)
            {
                PrintHelp();
                return;
            }
            var serv = new Server(port);
            Console.WriteLine("Le serveur à démarré.");
            Console.CancelKeyPress += delegate {
                serv.Disconnect();
            };
            while (true)
                serv.SendMessage(Console.ReadLine());
        }
    }
}
