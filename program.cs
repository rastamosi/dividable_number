using System;
using System.Collections.Generic;
namespace dividable
{
    class Program
    {

           var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
            
             }

    }
