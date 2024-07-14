using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Hello
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //These are comments
            /*
             data types in c sharp
            Interger - int harry;
            Float - float that;
            Boolean - bool isGreat = true;
            String - string inp = "Harry";



             */
            int  a = 34;
            float b = 34.4f;
            double c = 34.5d;
            bool isGreat = true;
            char d = 'r';
            string e = "this is a string";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(isGreat);
            Console.WriteLine(d);
            Console.WriteLine(e);


            // Console.WriteLine(harry);

            /*
             Type casting
            1.implicit casting 
            char to int to long to float to double
            2.explicit casting
             */
            float x = (int) 3.5; //explicit casting
            double y = x; // implicit casting 
            float z = 'y'; // implicit casting
            double x1 = (double) 3.5; //explicit casting
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}