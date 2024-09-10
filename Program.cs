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

            myBusher.namePerson = "Busher"; //  attribut exempel från Person klassen (namePerson)
            myBusher.kickingPower = 400;//  attribut
            }
            myBusher.Punch();
            Nemanja myNemanja = new Nemanja(); // ny Nemanja object 
            {
                myNemanja.namePerson = "Nemanja";//  attribut
                myNemanja.slappingPower = 300000;//  attribut
                myNemanja.height = 200;//  attribut
            }
            myNemanja.Punch();

            BankAccount bankAccountObj = new BankAccount("Busher", 1234, 988216641); //Encapsulation the object asks for the parameters of the BankAccount.
            bankAccountObj.userDisplayInfo();




            SavingAccount savingAccountObj = new SavingAccount(); //Abstraction
            savingAccountObj.Showtype();
            DepositAccount depositAccountObj = new DepositAccount(); //Abstraction
            depositAccountObj.Showtype();

        }


    }


}
