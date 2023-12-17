using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Echo : Command
    {
        public Echo (string name) : base (name) { }

        public override string execute(string[] args)
        {
            if(args.Length == 0)
            {
                return "Error: echo command requires an argument.";
            }

            string message = string.Join(" ", args);

            return message;
        }
    }
}
