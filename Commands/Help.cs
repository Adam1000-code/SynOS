using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Help : Command
    {
        public Help (String name) : base (name) { }

        public override String execute(String[] args)
        {
            Console.WriteLine("Welcome to the SynOS help command.");
            Console.WriteLine("Commands:");
            Console.WriteLine("help");
            Console.WriteLine("ver");
            Console.WriteLine("clear");
            Console.WriteLine("kernel");
            Console.WriteLine("file");
            Console.WriteLine("reboot");
            Console.WriteLine("shutdown");
            return "kodi";
        }
    }
}
