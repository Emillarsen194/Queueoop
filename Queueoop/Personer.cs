using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueoop
{
    class Personer
    {

        Queue<Personer> fest = new Queue<Personer> { }; // queue of persons of our party 

        private int age;
        private String name;


        #region Make All Public
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }

        #endregion

        public Personer()
        {

        }

        public Personer(int ag, String na) //constructor that adds age and name 
        {
            this.age = ag;
            this.name = na;

            fest.Enqueue(this);
        }

        public Queue<Personer> Returnfest() // return our queue
        {
            return fest;
        }



        public void AddpeapleToParty(int age, String name) // creates objects in our queue asking for name and age 
        {
            fest.Enqueue(new Personer(age, name));

        }

        public void RemovePeapleFromParty() // remove first person in queue from our party 
        {
            fest.Dequeue();
        }

        public void ShowHowManypeapinQueue() // show how many peaps at our paaarty 
        {
            fest.Count();
        }
        public void Firsttogethere() // shows the first to get into the party 
        {
            Personer first = fest.Dequeue();
            Console.WriteLine(first);
        }
       


    }
}
