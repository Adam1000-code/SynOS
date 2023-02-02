using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class CosmosInfo : Command
    {
        public CosmosInfo (string name) : base (name) { }

        public override string execute(string[] args)
        {
            return "Cosmos Kernel. Created by the Cosmos Project.";
        }
    }
}
