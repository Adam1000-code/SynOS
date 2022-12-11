using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Version : Command
    {
        public Version (String name) : base(name) { }

        public override String execute(String[] args)
        {
            Console.WriteLine(" _______  __   __  __    _  _______  _______");
            Console.WriteLine("|       ||  | |  ||  |  | ||       ||       |");
            Console.WriteLine("|  _____||  |_|  ||   |_| ||   _   ||  _____|");
            Console.WriteLine("| |_____ |       ||       ||  | |  || |_____ ");
            Console.WriteLine("|_____  ||_     _||  _    ||  |_|  ||_____  |");
            Console.WriteLine(" _____| |  |   |  | | |   ||       | _____| |");
            Console.WriteLine("|_______|  |___|  |_|  |__||_______||_______|");
            return "SynOS beta 0.0.5, Created by Adam Zeiser.";
        }
    }
}
