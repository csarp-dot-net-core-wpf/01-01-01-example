using System;
using System.Collections.Generic;
using System.Text;

namespace _01_02_button_click_animal_say.model
{
    /// <summary>
    /// S2.01 Macska osztály - a macska köszinti gazdáját
    /// </summary>
    class Cat
    {

        /// <summary>
        /// A macska neve
        /// </summary>
        public string name;
        /// <summary>
        /// A macska így köszönti gazdáját
        /// </summary>
        public string greet;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">A macska neve</param>
        public Cat(string name)
        {
            this.name = name;
            this.greet = " meow meow";
        }

        /// <summary>
        /// A macska köszöntése stringként
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = name + " cat says: " + greet;
            return output;
        }
    }
}
