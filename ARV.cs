using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningVecka37
{

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
}
