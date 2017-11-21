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
            list.Add("odd");
            list.Add("even");
            list.Add("odd");
            list.Add("even");
            list.Add("odd");
            list.Add("even");
            list.Add("odd");
            list.Add("even");
            list.Add("odd");
            list.Add("even");
            list.Add("odd");
            list.Add("even");
            list.Add("odd");
            list.Add("even");
            list.Add("odd");
            list.Add("even");





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
                {
                    done = true;
                }
                else
                {
                    list.Add(word);
                }
            }


            // TODO:  Print out the list
            Console.WriteLine("\n");
            list.ListNodes();


            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            Console.WriteLine("\n enter words to put in the front");

            while (true)
            {
                String newNode = Console.ReadLine();
                if (newNode == "done")
                {
                    break;
                }
                list.Add(newNode);
            }

            // TODO:  Print out the list
            Console.WriteLine("\n **********");
            list.ListNodes();

            /*/TODO:  Remove every word with an odd length
            String thing = list.ElementAt(3).Data.ToString();/*/
            Console.WriteLine();
            // list.RemoveAt(0);
            // list.ListNodes();

            String words;
            for (int i =0;i<list.Count;i++)
            {
                



                words = list.ElementAt(i).Data.ToString();

                if (words.Length % 2 != 0 || words.Length == 1)
                {
                    list.RemoveAt(i);

                    Console.WriteLine("*"+words+"*");

                    if (i == 0)
                        i = 0;
                    else
                        i--;
                }

                Console.WriteLine("\n" + words + "\n");


            }
            

            // TODO:  Print out the list
            Console.WriteLine("\n hi");
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
