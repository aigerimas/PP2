using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace far
{
    class Program
    {
        static public void ShowDirectory(DirectoryInfo curr, int pos = 0)
        {
           // Console.WriteLine("name\t\tExtension\t\tCreation Time");
            DirectoryInfo[] dirs = curr.GetDirectories();
            FileInfo[] files = curr.GetFiles();
            for(int i = 0; i < dirs.Length; i++)
            {                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = pos == i ? ConsoleColor.White : ConsoleColor.Black;
                Console.WriteLine(dirs[i].Name + "\t" + dirs[i].Extension + "\t" + dirs[i].CreationTime);
            }
            for (int i = 0; i < files.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = pos - dirs.Length == i ? ConsoleColor.White : ConsoleColor.Black;                
                Console.WriteLine(files[i].Name + "\t" + files[i].Extension + "\t" + files[i].CreationTime);
            }
        }
        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\admin\Desktop\KBTU");
            int pos = 0;
            while(true)
            {
                Console.Clear();
                ShowDirectory(dir, pos);
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 0)
                            pos = dir.GetFileSystemInfos().Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos >= dir.GetFileSystemInfos().Length)
                            pos = 0;
                        break;
                    case ConsoleKey.Enter:
                        if (pos >= 0 && pos < dir.GetDirectories().Length)
                        {
                            string path = dir.GetDirectories()[pos].FullName;
                            dir = new DirectoryInfo(path);
                        }
                        else
                        {
                            Console.Clear();
                            string path = dir.GetFiles()[(pos - dir.GetDirectories().Length)].FullName;
                            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(fs);
                            Console.Write(sr.ReadToEnd());
                            sr.Close();
                            fs.Close();
                            ConsoleKeyInfo exit = Console.ReadKey();
                            if(exit.Key == ConsoleKey.Escape)
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        if (dir.Parent == null)
                        {
                            Console.Clear();
                            Console.WriteLine("No Parrent");
                            dir = dir.Root;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            dir = dir.Parent;
                        }
                        break;
                }

            }
        }
    }
}
