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
         * the main method for our driver class Program. Added a small do while loop for the user to play again if wanted
         * 
         * @method Main
         * @param {sting[]} args
         * @returns {void}
         */
        public static void Main(string[] args)
        {
            string playAgain = " ";
            do
            {
                Deck deck = new Deck(); // create a deck of cards
            deck.Display(); // display the initial state of the deck
            deck.Shuffle(); // shuffle the deck
            deck.Display(); // display the deck after shuffling

            Card cardDealth = deck.Deal();
            Console.WriteLine("Card Delt: {0} of {1}", cardDealth.Face, cardDealth.Suit);
            Console.WriteLine();
            deck.Display();
                Console.WriteLine("*         Type 'play' to play again!          *");
                playAgain = Console.ReadLine();
            } while (playAgain == "play") ;

        } // end Main

    } // end Program

} // end namespace


//        // PUBLIC STATIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++

//        /**
//         * <summary>
//         * This method loads a list of cards with Card objects
//         * </summary>
//         * 
//         * @method CreateDeck
//         * @param {List<Card>} deck
//         * @returns {void}
//         */
//        public static void CreateDeck(List<Card> deck)
//        {
//            string suit = "";
//            for (int i = 0; i < 4; i++)
//            {
//                switch (i)
//                {
//                    case 0:
//                        suit = "hearts";
//                        break;
//                    case 1:
//                        suit = "clubs";
//                        break;
//                    case 2:
//                        suit = "diamonds";
//                        break;
//                    case 3:
//                        suit = "spades";
//                        break;
//                } // end suit switch
//                for (int face = 1; face < 14; face++)
//                {
//                    deck.Add(new Card(face, suit));
//                } //end for -face
//            } //end for -suit
//        } // end CreateDeck method

//        /**
//        * <summary>
//        * This method displays a list of Card objects to the console.
//        * </summary>
//        *
//        * @method DisplayDeck
//        * @param {list<
//        */
//        public static void DisplayDeck(List<Card>deck) //deck related to Deck in program class
//        {
//            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
//            Console.WriteLine("+Current Deck");
//            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
//            foreach (Card card in deck) //foreach TABTAB. For each(Card) card in deck
//            {
//                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
//            }
//            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
//            Console.WriteLine();
//        }

//        /**
//        * <summary>
//        * This method randomly shuffles a list of Card objects
//        * </summary>
//        *
//        * @method shuffleDeck
//        * @param {list<Card>deck
//        * @returns {void}
//        */
//        public static void ShuffleDeck(List<Card>deck)
//        {
//            // this creats a sudo random number sequence and stores it in random
//            Random random = new Random(); // new: create a new type of random and assign it to the shape of random
//            // record the number of cards in the deck
//            int cardCount = deck.Count;

//            Console.WriteLine("Card count: {0}", cardCount);

//            //iterate through the list of cards
//            for(int currentCard = 0; currentCard < cardCount; currentCard++)
//            {
//                // swapping algorithm

//                Card tempCard = deck[currentCard]; // takes the current card and places it in tempcard
//                int randomCard = random.Next(0, cardCount); // get a random card index
//                deck[currentCard] = deck[randomCard]; // copy value from randomCard to currentCard
//                deck[randomCard] = tempCard; // copy current card to random card
//            }
//        }
//    } // end Program
//} // End namespace

///* MY CODE MISTAKES

//public static void Main(string[] args)
//{
//    Person person;

//    // create a new instance for the Person class
//    person = new Person();

//    //Console.WriteLine(person.Name);

//    // set a value in the Name properly of the Person class
//    //person.Name = ("Meer");
//    //person.Age = (26);

//    // get the Name Value and print to console
//    Console.WriteLine("{0} says hello", person.Name);
//    Console.WriteLine("{0} is {1} years old", person.Name, person.Age);
//}
//*/
