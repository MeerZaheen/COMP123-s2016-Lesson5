using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson5
{
    /**
    * This class is the "driver" class for our Program
    *
    * @class Program
    */
    public class Program
    {
        /**
        * the main method for our driver class Program
        *
        * @method Main
        * @param {string[]} args
        */
        public static void Main(string[] args)
        {
            //list that reps a deck of cards
           
            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);
        }

        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;
                } // end suit switch
                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                } //end for -face
            }
        }
    }
}

/* MY CODE MISTAKES

public static void Main(string[] args)
{
    Person person;

    // create a new instance for the Person class
    person = new Person();

    //Console.WriteLine(person.Name);

    // set a value in the Name properly of the Person class
    //person.Name = ("Meer");
    //person.Age = (26);

    // get the Name Value and print to console
    Console.WriteLine("{0} says hello", person.Name);
    Console.WriteLine("{0} is {1} years old", person.Name, person.Age);
}
*/
