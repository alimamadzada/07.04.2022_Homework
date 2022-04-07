using System;
using System.Collections;

namespace GenericTypesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> ml = new MyList<string>();
            ml.AddItems("Salam", "Necesen", "ne", "var", "ala", "heyva");
            //ml.RemoveLast();
            //ml.Reverse();
            //ml.IndexOf("Necesen");
            ml.Print();
        }
    }
}
