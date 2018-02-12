using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{    
    class Program
    {
        public static void ShowDirectory(DirectoryInfo dir, int pos = 0)
        {
            FileSystemInfo[] data = dir.GetFileSystemInfos();
            for(int i = 0; i < data.Length; i++)
            {
                Console.ForegroundColor = data[i].GetType() == typeof(DirectoryInfo) ? ConsoleColor.White : ConsoleColor.Green;
                Console.BackgroundColor = i == pos ? ConsoleColor.DarkCyan : ConsoleColor.Blue;
                Console.WriteLine(data[i].Name);
            }
        }
        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int pos = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\admin\Desktop\KBTU");
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
                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];
                        if(f.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(f.FullName);                            
                        }
                        else 
                        {
                            Console.Clear();                            
                            Console.CursorVisible = true;                            
                            FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.ReadWrite);
                            StreamReader sr = new StreamReader(fs);
                            StreamWriter sw = new StreamWriter(fs);
                            Console.Write(sr.ReadToEnd());
                            int x = 0, y = 0;
                            bool b = true;
                            while (b)
                            {
                                Console.SetCursorPosition(x, y);
                                ConsoleKeyInfo btn_write = Console.ReadKey();
                                switch(btn_write.Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        --y;
                                        break;
                                    case ConsoleKey.DownArrow:
                                        y++;
                                        break;
                                    case ConsoleKey.LeftArrow:
                                        x--;
                                        break;
                                    case ConsoleKey.RightArrow:
                                        x++;
                                        break;
                                    case ConsoleKey.Escape:
                                        b = false;
                                        break;
                                    default:
                                        string str = Console.ReadLine();
                                        sw.Write(str);
                                        break;
                                }
                            }
                            sw.Close();
                            sr.Close();
                            fs.Close();
                        }
                        break;

                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                }
            }
        }
    }
}
