using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Version : Command
    {
        public Version (string name) : base(name) { }

        public override string execute(string[] args)
        {
            Console.WriteLine(@"  _____              ____   _____ ");
            Console.WriteLine(@" / ____|            / __ \ / ____|");
            Console.WriteLine(@"| (___  _   _ _ __ | |  | | (___  ");
            Console.WriteLine(@" \___ \| | | | '_ \| |  | |\___ \ ");
            Console.WriteLine(@" ____) | |_| | | | | |__| |____) |");
            Console.WriteLine(@"|_____/ \__, |_| |_|\____/|_____/ ");
            Console.WriteLine(@"         __/ |                    ");
            Console.WriteLine(@"        |___/                     ");
            return "SynOS beta 0.0.8, Created by Adam Zeiser.";
        }
    }
}
