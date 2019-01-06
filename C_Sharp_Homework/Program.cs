using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Homework
{

    class Program
    {

        static void Main(string[] args)
        {
            DVD dvd = new DVD();
            HDD hdd = new HDD();
            Flash flash = new Flash();
            dvd.GetInformation(true);
            dvd.InformationDevice("data", 5);
            dvd.MemoryCapacity(12);
            Console.ReadLine();
        }
    }
}


