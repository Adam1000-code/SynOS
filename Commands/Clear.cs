using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Clear : Command
    {
        public Clear (string name) : base (name) { }

        public override string execute(string[] args)
        {
            Console.Clear();
            return "";
        }
    }
}
