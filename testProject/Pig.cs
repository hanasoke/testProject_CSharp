using System;
using System.Collections.Generic;
using System.Text;  

namespace testProject
{
    internal class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: kro kro kro");
        }
    }
}
