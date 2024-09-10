using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningVecka37
{
    public class BankAccount // Encapsulation
    {

        private string name;
        private int cardPin;
        private double cardNumber;

        public BankAccount(string name, int cardPin, double cardNumber)
        {
            Name = name;
            CardPin = cardPin;
            CardNumber = cardNumber;


        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public int CardPin
        {
            get { return cardPin; }
            set { cardPin = value; }
        }

        public double CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public void userDisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, CardNumber: {CardNumber}, CardPin: {CardPin}");

        }

    }

}
