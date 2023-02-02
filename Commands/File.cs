using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Sys = Cosmos.System;

namespace SynOS.Commands
{
    public class File : Command
    {
        public File (string name) : base (name) { }

        public override string execute(string[] args)
        {
            string response = "";

            switch(args[0])
            {
                case "create":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile(args[1]);
                        response = "Your file " + args[1] + " was sucessfully created.";
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;

                case "delete":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteFile(args[1]);
                        response = "Your file " + args[1] + " was sucessfully removed.";
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;

                case "mkdir":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateDirectory(args[1]);
                        response = "Sucessfully created directory " + args[1];
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;

                case "remdir":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteDirectory(args[1],true);
                        response = "Sucessfully removed directory " + args[1];
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;

                case "edit":
                    try
                    {
                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();

                        if(fs.CanWrite)
                        {
                            int ctr = 0;
                            StringBuilder sb = new StringBuilder();

                            foreach(string s in args)
                            {
                                if(ctr>1)
                                {
                                    sb.Append(s+' ');
                                }
                                ctr++;
                            }

                            string txt = sb.ToString();
                            Byte[] data = Encoding.ASCII.GetBytes(txt.Substring(0, txt.Length - 1));

                            fs.Write(data, 0, data.Length);
                            fs.Close();

                            response = "Sucessfully wrote to file!";
                        }
                        else
                        {
                            response = "Unable to write to file. Not open for writing";
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;

                case "read":
                    try
                    {
                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();

                        if(fs.CanRead)
                        {
                            Byte[] data = new Byte[256];

                            fs.Read(data, 0, data.Length);
                            response = Encoding.ASCII.GetString(data);
                            break;
                        }
                        else
                        {
                            response = "Unexpected argument: " + args[0];
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;

                case "help":
                    try
                    {
                        Console.WriteLine("To create text file: file create (cosmos location)(filename).txt");
                        Console.WriteLine("To delete text file: file delete (cosmos location)(filename).txt");
                        Console.WriteLine("To write text to text file: file edit (cosmos location)(filename).txt (text)");
                        Console.WriteLine("To read text in text file: file read (cosmos location)(filename).txt");
                        Console.WriteLine("To create directory: file mkdir (cosmos location)(directory name)");
                        Console.WriteLine("To delete/remove directory: file remdir (cosmos location)(directory name)");
                        break;
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;

                default:
                    response = "Unexpected argument: " + args[0];
                    break;
            } 
            return response;
        }
    }
}
