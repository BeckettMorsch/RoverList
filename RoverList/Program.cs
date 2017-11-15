using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            RoverList list = new RoverList();
            list.Add("Hello");
            list.Add("World");
            list.Add("I");
            list.Add("want");
            list.Add("to");
            list.Add("kill");
            list.Add("an");
            list.Add("apple");
            list.Add("with");
            list.Add("my");
            list.Add("spare");
            list.Add("noose");
            list.Add("also");
            list.Add("kill");
            list.Add("my");
            list.Add("mind");



            //  TODO:  Print out the list
            list.ListNodes();



            // TODO:  Remove every 3rd word
            for (int i = 2; i < list.Count; i = i+2)
            {
                list.RemoveAt(i);
            }

            // TODO:  Print out the list
            Console.WriteLine("\n");
            list.ListNodes();


            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            Console.WriteLine("\n Add words to the list");
            bool done = false;
            String word;
            while (done == false)
            {
                word = Console.ReadLine();
                if (word == "done")
                    done = true;

                else
                list.Add(word);
            }


            // TODO:  Print out the list
            Console.WriteLine("\n");
            list.ListNodes();


            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"




            // TODO:  Print out the list
            Console.WriteLine("\n");
            list.ListNodes();

             //TODO:  Remove every word with an odd length
            String words;
            for (int i =0;i<list.Count;i++)
            {
                words = list.ElementAt.ToString(i);
                if ( words.Length % 2 != 0)
                    list.RemoveAt(i);

            }


            // TODO:  Print out the list
            Console.WriteLine("\n");
            list.ListNodes();

            // TODO:  Clear the list
            
            list.Clear();


            // TODO:  Print out the list
            Console.WriteLine("\n");
            list.ListNodes();
            Console.WriteLine("\n HELLO!!1");

        }
    }
}
