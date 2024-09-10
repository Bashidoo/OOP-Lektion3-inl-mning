using System.Runtime.CompilerServices;

namespace InlämningVecka37
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            

            MotorCycle myMotorCycle = new MotorCycle(); //ARV
            myMotorCycle.Start(); //ARV
            myMotorCycle.Beep();// ARV


            // Polymorfism exempel
            Busher myBusher = new Busher();
            {

            myBusher.namePerson = "Busher"; // ARV exempel från Person klassen (namePerson)
            myBusher.kickingPower = 400;
            }
            myBusher.Punch();
            Nemanja myNemanja = new Nemanja();
            {
                myNemanja.namePerson = "Nemanja";
                myNemanja.slappingPower = 300000;
                myNemanja.height = 200;
            }
            myNemanja.Punch();

            BankAccount bankAccountObj = new BankAccount("Busher", 1234, 988216641); //Encapsulation
            bankAccountObj.userDisplayInfo();




            SavingAccount savingAccountObj = new SavingAccount(); //Abstraction
            savingAccountObj.Showtype();
            DepositAccount depositAccountObj = new DepositAccount(); //Abstraction
            depositAccountObj.Showtype();

        }


        public class Vehicle // ARV
        {
            string vehicleBrand;
            int vehicleWheels;
            string vehicleColor;

            public void Start()
            {
                Console.WriteLine("This vehicle has started");
            }


        }

        public class MotorCycle : Vehicle //ARV
        {

            int motorHorsePower;

            public void Start()
            {
                base.Start();
                Console.WriteLine("Vrom Vrom");

            }

            public void Beep()
            {
                Console.WriteLine("Beep!");

            }

        }



        public class Person
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

        abstract class typeOfBankAccount
        {
           
            public abstract void Showtype();


        }

        class SavingAccount : typeOfBankAccount
        {

            public override void Showtype()
            {
                Console.WriteLine($"This is a saving account");
            }

        }

        class DepositAccount : typeOfBankAccount
        {
            public override void Showtype()
            {
                Console.WriteLine("This is a despositing account");
            }
        }


    }
}
