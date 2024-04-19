using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Menu
    { 
        public List<Option> _options { get; set; }
        public Menu(int level)

        {
            int index = 0;
            switch (level) {
                case 0:
            _options = new List<Option>
            {
                new Option("Eleve", () => new Menu(1)),
                new Option("Cours", () =>  new Menu(2)),

                new Option("Exit", () => Environment.Exit(0)),
            };

            
            break;
                case 1:
                    _options = new List<Option>
            {
                new Option("Lister les élèves", () => new Menu(2)),
                new Option("Créer un nouvel élève", () => WriteTemporaryMessage("How Are You Mister Cours de l' Eleve?")),
                new Option("Consulter un élève", () => new Menu(2)),
                new Option("Ajouter une note et une appréciation", () => new Menu(2)),
                new Option("Menu Principal", () => new Menu(0)),
                new Option("Exit", () => Environment.Exit(0)),
            };

                    int index2 = level;
                    break;
                case 2:
                    _options = new List<Option>
            {
                new Option("Lister les cours", () => WriteTemporaryMessage("How Are You Mister Eleve2?")),
                new Option("Ajouter un nouveau cours", () => WriteTemporaryMessage("How Are You Mister Cours2?")),
                new Option("Supprimer un cours", () => new Menu(2)),
                new Option("Menu Principal", () => new Menu(0)),
                new Option("Exit", () => Environment.Exit(0)),
            };

                    int index3 = level;
                    break;

            }

        WriteMenu(_options, _options[index]);
            MenuList(index);
            
        
        
            
           

        }
       /* public Menu(int _menu)
        {
            switch (_menu)
            {
                case 1:
                    _options = new List<Option>
            {
                new Option("Menu eleve option1", () => WriteTemporaryMessage("2",1)),
                new Option("Menu eleve option2", () => WriteTemporaryMessage("Hello",0)),

                new Option("Exit", () => Environment.Exit(0)),
            };
                     int index1 = _menu;
                    WriteMenu(_options, _options[index1]);
                    break;
                case 2:
                    _options = new List<Option>
            {
                new Option("Menu cours option1", () => WriteTemporaryMessage("3",2)),
                new Option("Menu cours option2", () => WriteTemporaryMessage("How Are You",0)),

                new Option("Exit", () => Environment.Exit(0)),
            };
                    int index2 = _menu;
                    WriteMenu(_options, _options[index2]);
                    break;
                 case 3: Console.WriteLine("Nous y sommes");
                    break;
                default: new Menu();
                    break;
            }
        }*/
        public void MenuList(int index)
        {


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
                if (keyinfo.Key == ConsoleKey.Backspace)
                {
                    //_options[index].Selected.Invoke();
                    new Menu(0);
                }
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();



        }
        public void WriteTemporaryMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
           /* switch (message)
            {
                case "1":
                    break;
                case "2":
                    break;
               default:
                    break;
            }*/
            /*new Menu(level);*/
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
