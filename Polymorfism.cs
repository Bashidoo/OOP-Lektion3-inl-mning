using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningVecka37
{
    public class Person //Polymorfism
    {
        public string namePerson;

        public virtual void Punch() //Virtual is an indicator of polymorphism
        {
            Console.WriteLine(" Punch !");
        }



    }

    public class Busher : Person
    {
        public int kickingPower;

        public override void Punch() //Polymorfism
        {
            Console.WriteLine($"Busher does not punch. He kicks, his kicking power is {kickingPower}");
        }


    }

    public class Nemanja : Person
    {
        public int height;
        public int slappingPower;

        public override void Punch()
        {
            base.Punch();
            Console.WriteLine($"{namePerson} also slaps, his slapping power is {slappingPower} and his height is {height}cm");
        }

    }
}
