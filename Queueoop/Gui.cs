using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueoop
{
    class Gui
    {
        Personer Logic = new Personer();
        public void Menu()
        {
            #region queuesign
            Console.WriteLine(@" 
  __ _ _   _  ___ _   _  ___ 
 / _` | | | |/ _ \ | | |/ _ \
| (_| | |_| |  __/ |_| |  __/
 \__, |\__,_|\___|\__,_|\___|
    | |                      
    |_|                      ");
            #endregion

            Console.WriteLine("\n\r 1. Add persons to queue");
            Console.WriteLine("\n\r 2. Delete persons to queue");
            Console.WriteLine("\n\r 3. show persons in queue");
            Console.WriteLine("\n\r 4. find person in queue");
            Console.WriteLine("\n\r 5. Print all person in queue");
            Console.WriteLine("\n\r 6. exit");

            Console.WriteLine("\n\rEnter your choice: ");

        }

        public void Whichmenu()
        {
            
            Personer Logic = new Personer();
            int choose = int.Parse(Console.ReadLine());
            Logic.Returnfest();
            switch (choose)
            {
                case 1:
                    Console.WriteLine("\n\n Add a person to ur party: ");

                    Console.Write("Whats the name of the person ur adding to ur party: ");
                    String name = Console.ReadLine();

                    Console.Write("Whats the age of {0} : ", name);
                    int age = int.Parse(Console.ReadLine());
                    Logic.AddpeapleToParty(age, name);

                    foreach (Personer item in Logic.Returnfest())
                    {
                        Console.WriteLine(item.Name);
                    }

                    break;
    
                case 2:
                    //code
                    break;
                case 3:
                    //code 
                    break;
                case 4:
                    //code
                    break;
                case 5:
                    Logic.Returnfest();
                    Printall();
                    
                    break;
                case 6:
                    break;
                default:
                    break;
            }
        }

        public void AddPeapleGui()
        {

            Console.WriteLine("\n\n Add a person to ur party: ");

            Console.Write("Whats the name of the person ur adding to ur party: ");
            String name = Console.ReadLine();

            Console.Write("Whats the age of {0} : ", name);
            int age = int.Parse(Console.ReadLine());
            Logic.AddpeapleToParty(age, name);
        }

        public void Printall()
        {
            while (Logic.Returnfest().Count > 0)
            {
            Personer total = Logic.Returnfest().Dequeue();
            Console.WriteLine(total);

            }
        }





    }
}
