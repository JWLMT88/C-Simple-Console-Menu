using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srvlocal
{
    internal class Menu
    {
        public Menu() 
        {
            
        }

        public string[] menuItems = { "Start", "Advanced Start", "Account", "Settings", "Help", "Quit" };

        public void Show()
        {
            ConsoleKeyInfo key;
            int selectedIndex = 0;
            int top = Console.CursorTop;
            int left = Console.CursorLeft;

            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("----------------");

            do
            {
                
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.CursorTop = top + 4 + i;
                    Console.CursorLeft = left;
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(menuItems[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(menuItems[i]);
                    }
                }

                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedIndex > 0)
                        {
                            selectedIndex--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedIndex < menuItems.Length - 1)
                        {
                            selectedIndex++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("\nYou selected " + menuItems[selectedIndex]);
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                        break;
                }
            } while (key.Key != ConsoleKey.Escape && menuItems[selectedIndex] != "Quit");

        }
    }
}
