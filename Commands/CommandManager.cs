using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class CommandManager
    {
        private List<Command> commands;

        public CommandManager()
        {
            this.commands = new List<Command>(1);
            this.commands.Add(new Help("help"));
            this.commands.Add(new Version("ver"));
            this.commands.Add(new CosmosInfo("kernel"));
            this.commands.Add(new Clear("clear"));
            this.commands.Add(new File("file"));
            this.commands.Add(new Reboot("reboot"));
            this.commands.Add(new Shutdown("shutdown"));
            this.commands.Add(new Kodi("kodi"));
        }

        public string processInput(string input)
        {
            string[] split = input.Split(' ');

            string label = split[0];

            List<string> args=new List<string>();

            int ctr = 0;
            foreach(string s in split)
            {
                if(ctr!=0)
                {
                    args.Add(s);
                }
                ctr++;
            }

            foreach(Command cmd in this.commands)
            {
                if(cmd.name==label)
                {
                    return cmd.execute(args.ToArray());
                }
            }
            return "Your command \""+label+"\" does not exist!";
        }
    }
}
