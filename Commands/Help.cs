using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Help : Command
    {
        public Help(String name) : base(name) { }

        public override String execute(String[] args)
        {
            return "Welcome to the SynOS help command. Commands: 'help', 'ver', 'kernel.info'.";
        }
    }
}
