using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Menu
    { 
        public List<Option> _options { get; set; }
        public Menu()

        {   
            _options = new List<Option>
            {
                new Option("Thing", () => WriteTemporaryMessage("Hi")),
                new Option("Another Thing", () => WriteTemporaryMessage("How Are You")),
                new Option("Yet Another Thing", () => WriteTemporaryMessage("Today")),
                new Option("Exit", () => Environment.Exit(0)),
            };
            
            int index = 0;

           
            WriteMenu(_options, _options[index]);

            
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < _options.Count)
                    {
                        index++;
                        WriteMenu(_options, _options[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(_options, _options[index]);
                    }
                }
               
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    _options[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();

        }
        public void MenuList()
        {


            

           

        }
        public void WriteTemporaryMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(3000);
            WriteMenu(_options, _options.First());
        }



        public void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();

            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(option.Name);
            }
        }

        
    }
}
