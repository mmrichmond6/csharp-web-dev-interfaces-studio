using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD myCD = new CD("Rose", "music");
            CD myCD2 = new CD("Daisy", "music");
            CD myCD3 = new CD("Petunia", "music");

            DVD myDVD = new DVD("Carrot", "video");
            DVD myDVD2 = new DVD("Pumpkin", "video");
            DVD myDVD3 = new DVD("Cucumber", "video");

            List<AbstractBaseDisc> list = new List<AbstractBaseDisc>();
            list.Add(myCD);
            list.Add(myCD2);
            list.Add(myCD3);
            list.Add(myDVD);
            list.Add(myDVD2);
            list.Add(myDVD3);

            for (int i = 0; i < list.Count; i++)
            {
                list[i].PrintMediaInfo();
            }

            // TODO: Call each CD and DVD method to verify that they work as expected.


        }
    }
}
