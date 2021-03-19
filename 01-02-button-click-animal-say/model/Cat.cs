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
        private string name;
        /// <summary>
        /// A macska így köszönti gazdáját
        /// </summary>
        private string greet;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">A macska neve</param>
        public Cat(string name)
        {
            this.name = name;
            this.greet = "miaú-miaú";
        }

        /// <summary>
        /// A macska köszöntése stringként
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // S2.10 Javítjuk az osztályt (refactoring). Magyarul köszön. Adattagok private.
            string output = name + " macska mondja: " + greet+".";
            return output;
        }
    }
}
