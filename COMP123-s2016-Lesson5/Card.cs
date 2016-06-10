using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson5
{
    /**\\Mac\Home\Documents\COMP123-PROGRAMMING 2\COMP123-s2016-Lesson5\COMP123-s2016-Lesson5\Card.cs
    * <summary>
    * This class creates an object that represent a playing card
    * </summary>
    * 
    * @class Card
    */
    public class Card
    {
        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public Faces Face { get; set; }     // prop TAB TAB
        public Suits Suit { get; set; }

        /**
        * <summary>
        * This constructor takes two paramaters: face and suit to instantiate a Card object
        * </summary>
        *
        * @constructor Card
        * @param Faces face
        * @param Suits suit
        */

        public Card(Faces face, Suits suit)      // cc TAB TAB
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
