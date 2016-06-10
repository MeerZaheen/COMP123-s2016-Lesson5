using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson5
{

    /**
    * <summary>
    * This class extends the List<Card> generic type
    * </summary>
    *
    * @class Deck
    */

    class Deck : List<Card>
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the default constructor for the Deck class
        * </summary>
        *
        * @constructor Deck
        */

        public Deck()
        {
            // create my deck of cards
            this._create();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method loads a list of cards with Card objects
         * </summary>
         * 
         * @private
         * @method _create
         * @returns {void}
         */
        private void _create()
        {

            foreach (Suits suit in Enum.GetValues(typeof(Suits))) // for each suit in Suits
            {
                foreach (Faces face in Enum.GetValues(typeof(Faces)))
                {
                    this.Add(new Card(face, suit)); // anonymous card object to the list
                }
            }

        } // end CreateDeck method

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method displays a List of Card objects to the Console
         * </summary>
         * 
         * @method Display
         * @returns {void}
         */
        public void Display() //deck related to Deck in program class
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+Current Deck");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this) //foreach TABTAB. For each(Card) card in deck
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

        /**
        * <summary>
        * This method randomly shuffles a list of Card objects
        * </summary>
        *
        * @method shuffleDeck
        * @param {list<Card>deck
        * @returns {void}
        */
        public void Shuffle()
        {
            // this creats a sudo random number sequence and stores it in random
            Random random = new Random(); // new: create a new type of random and assign it to the shape of random
            // record the number of cards in the deck
            int cardCount = this.Count;

            Console.WriteLine("Card count: {0}", cardCount);

            //iterate through the list of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                // swapping algorithm

                Card tempCard = this[currentCard]; // takes the current card and places it in tempcard
                int randomCard = random.Next(0, cardCount); // get a random card index
                this[currentCard] = this[randomCard]; // copy value from randomCard to currentCard
                this[randomCard] = tempCard; // copy current card to random card
            }
        }

        /**
        * <summary>
        * This method will remove the 0th item from the deck and return it to the caller
        * </summary>
        *
        * @method Deak
        * @returns {Card}
        */

        public Card Deal()
        {
            Card returnedCard = this[0]; // copy the 0th card in the stack to the returnedCard
            // check to see if the deck is not empty
            if (this.Count > 0)
            {
                this.RemoveAt(0); // remove the 0th Card from deck
            }
            return returnedCard;
        }
    }
}
