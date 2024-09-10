using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningVecka37
{
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
