using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueoop
{
    class Program
    {
        static void Main(string[] args)
        {
           Gui Gui = new Gui();

          Personer Logic = new Personer();
            while (true)
            {

            Gui.Menu();
                int choose = int.Parse(Console.ReadLine());
                Logic.Returnfest(); // returns our queue 

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("\n\n Add a person to ur party: ");

                        Console.Write("Whats the name of the person ur adding to ur party: "); 
                        String name = Console.ReadLine();

                        Console.Write("Whats the age of {0} : ", name);
                        int age = int.Parse(Console.ReadLine());
                        Logic.AddpeapleToParty(age, name); //creates a new object new person 
                        break;


                    case 2:
                        Console.WriteLine("removed : " + Logic.Returnfest().Peek().Name + " From the party "); // show who we removed from the party fifo 
                        Logic.RemovePeapleFromParty(); // remove first in the party from the party 
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("persons in queue: ");
                        Console.Write(Logic.Returnfest().Count()); // prints how many personons in queue right now 
                        break;
                    case 4:
            
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Queue of all peaple: "); 
                        foreach (Personer item in Logic.Returnfest()) // prints all of the persons in queue 
                        {
                            Console.WriteLine("Name: " + item.Name + " Age : " + item.Age);
                        }

                        break;
                    case 6:
                        break;
                    default:
                        break;
                   
                }

                       




            



            }


            }
  
        }
    }

