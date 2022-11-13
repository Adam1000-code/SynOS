using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class CosmosInfo : Command
    {
        public CosmosInfo(String name) : base(name) { }

        public override String execute(String[] args)
        {
            return "Cosmos Kernel. Created by the Cosmos Project.";
        }
    }
}
