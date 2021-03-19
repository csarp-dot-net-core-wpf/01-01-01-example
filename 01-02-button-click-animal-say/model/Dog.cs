using System;
using System.Collections.Generic;
using System.Text;

namespace _01_02_button_click_animal_say.model
{
    // <summary>
    /// S2.01 Kutya - a kutya köszinti gazdáját
    /// </summary>
    class Dog
    {

        /// <summary>
        /// A kutya neve
        /// </summary>
        private string name;
        /// <summary>
        /// A kutya így köszönti gazdáját
        /// </summary>
        private string greet;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">A kutya neve</param>
        public Dog(string name)
        {
            this.name = name;
            this.greet = "vau-vau";
        }

        /// <summary>
        /// A kutya köszöntése stringként
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = name + " kutya mondja: " + greet + ".";
            return output;
        }
    }
}
