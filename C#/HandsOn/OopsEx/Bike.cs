using System;
using System.Collections.Generic;
using System.Text;

namespace OopsEx
{
    class Bike
    {
        string name;
        string color;
        public void setDetails(string name,string color)
        {

        }
        public void StartEngine()
        {
            Console.WriteLine("Bike Started:" + DateTime.Now.Hour);
        }
        public void FileGas(int litre)
        {
            Console.WriteLine("Bike filled with:" + litre + "litres");
        }
        public int Travel(int distance,int speed)
        {
            int time = (int)distance / speed;
            Console.WriteLine("you will reach the destination:" +time);
            return time;
        }

    }
}
