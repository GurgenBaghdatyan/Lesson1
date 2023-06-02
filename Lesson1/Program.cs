using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 5;
            byte b2 = 10;
            Console.Write($"{b2 + b1} ");
            Console.Write($"{b2 - b1} ");
            Console.Write($"{b2 * b1} ");
            Console.Write($"{b2 / b1} ");
            Console.Write($"{b2 % b1} ");
            Console.Write($"{b2 >> b1} ");
            Console.Write($"{b2 << b1} ");
            Console.Write($"{b2 & b1} ");
            Console.Write($"{b2 | b1} ");
            Console.Write($"{b2 ^ b1} ");
            Console.WriteLine();
            sbyte sb1 = 5;
            sbyte sb2 = 10;
            Console.Write($"{sb2 + sb1} ");
            Console.Write($"{sb2 - sb1} ");
            Console.Write($"{sb2 * sb1} ");
            Console.Write($"{sb2 / sb1} ");
            Console.Write($"{sb2 % sb1} ");
            Console.Write($"{sb2 >> sb1} ");
            Console.Write($"{sb2 << sb1} ");
            Console.Write($"{sb2 & sb1} ");
            Console.Write($"{sb2 | sb1} ");
            Console.Write($"{sb2 ^ sb1} ");
            Console.WriteLine();
            short s1 = 5;
            short s2 = 10;
            Console.Write($"{s2 + s1} ");
            Console.Write($"{s2 - s1} ");
            Console.Write($"{s2 * s1} ");
            Console.Write($"{s2 / s1} ");
            Console.Write($"{s2 % s1} ");
            Console.Write($"{s2 >> s1} ");
            Console.Write($"{s2 << s1} ");
            Console.Write($"{s2 & s1} ");
            Console.Write($"{s2 | s1} ");
            Console.Write($"{s2 ^ s1} ");
            Console.WriteLine();
            ushort us1 = 5;
            ushort us2 = 10;
            Console.Write($"{us2 + us1} ");
            Console.Write($"{us2 - us1} " );
            Console.Write($"{us2 * us1} ");
            Console.Write($"{us2 / us1} ");
            Console.Write($"{us2 % us1} ");
            Console.Write($"{us2 >> us1} ");
            Console.Write($"{us2 << us1} ");
            Console.Write($"{us2 & us1} ");
            Console.Write($"{us2 | us1} ");
            Console.Write($"{us2 ^ us1} ");
            Console.WriteLine();
            int i1 = 5;
            int i2 = 10;
            Console.Write($"{i2 + i1} ");
            Console.Write($"{i2 - i1} ");
            Console.Write($"{i2 * i1} ");
            Console.Write($"{i2 / i1} ");
            Console.Write($"{i2 % i1} ");
            Console.Write($"{i2 >> i1} ");
            Console.Write($"{i2 << i1} ");
            Console.Write($"{i2 & i1} ");
            Console.Write($"{i2 | i1} ");
            Console.Write($"{i2 ^ i1} ");
            Console.WriteLine();
            uint ui1 = 5;
            uint ui2 = 10;
            Console.Write($"{ui2 + ui1} ");
            Console.Write($"{ui2 - ui1} ");
            Console.Write($"{ui2 * ui1} ");
            Console.Write($"{ui2 / ui1} ");   
            Console.Write($"{ui2 % ui1} ");   
            //>>
            //<<
            Console.Write($"{ui2 & ui1} ");
            Console.Write($"{ui2 | ui1} ");
            Console.Write($"{ui2 ^ ui1} ");
            Console.WriteLine();
            long l1 = 5;
            long l2 = 10;
            Console.Write($"{l2 + l1} ");
            Console.Write($"{l2 - l1} ");
            Console.Write($"{l2 * l1} ");
            Console.Write($"{l2 / l1} ");
            Console.Write($"{l2 % l1} ");
            //>>
            //<<
            Console.Write($"{l2 ^ l1} ");
            Console.Write($"{l2 | l1} ");
            Console.Write($"{l2 & l1} ");
            Console.WriteLine();
            ulong ul1 = 5;
            ulong ul2 = 10;
            Console.Write($"{ul2 + ul1} ");
            Console.Write($"{ul2 - ul1} ");
            Console.Write($"{ul2 * ul1} ");
            Console.Write($"{ul2 / ul1} ");
            Console.Write($"{ul2 % ul1} ");
            //>>
            //<<
            Console.Write($"{ul2 ^ ul1} ");
            Console.Write($"{ul2 | ul1} ");
            Console.Write($"{ul2 & ul1} ");
            Console.WriteLine("-------------------");

            float f1=654.65463f;
            float f2 = 541.13546f;
            Console.Write($"{f2 + f1} ");
            Console.Write($"{f2-f1} ");
            Console.Write($"{f2 * f1} ");
            Console.Write($"{f2 / f1} ");
            Console.Write($"{f2 % f1} ");
            //>>
            //<<
            //^
            //&
            //|
            Console.WriteLine();

            double d1 = 654.65463;
            double d2 = 541.135466;
            Console.Write($"{ d2 + d1} ");
            Console.Write($"{d2 - d1} ");
            Console.Write($"{d2 * d1} ");
            Console.Write($"{d2 / d1} ");
            Console.Write($"{d2 % d1} ");
            Console.WriteLine();

            //>>
            //<<
            //^
            //&
            //|
            decimal dd1 = 654.65463m;
            decimal dd2 = 541.13546m;
            Console.Write($"{dd2 + dd1} ");
            Console.Write($"{dd2 - dd1} ");
            Console.Write($"{dd2 * dd1} ");
            Console.Write($"{dd2 / dd1} ");
            Console.Write($"{dd2 % dd1} ");
            Console.WriteLine();

            //>>
            //<<
            //^
            //&
            //|

            string bar1 = "writeggjjh34gsdlfigjsekvgmjslekr77gh";
            string bar2 = " jkhsdjhwkjdwdwjh7hsdhdhdhe7hjeh6ydjhfkfekkk595";
            Console.Write(bar1+ bar2);
            Console.WriteLine();
            int x;
            Console.Write("Enter number x: ");
            x=Convert.ToInt32(Console.ReadLine());
            if (x>0)
            {
                Console.WriteLine("y="+Math.Sin(x));
            }
            else 
            {
                Console.WriteLine("y="+Math.Cos(x));
            }
            int a, b;
            Console.Write("Enter number a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("a>b");
            }
            else if (a<b)
            {
                Console.WriteLine("b>a"); 
            }
            else Console.WriteLine("a=b");
            int f, k;
            Console.Write("Enter kilometres: ");
            k=Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter futs: ");
            f= Convert.ToInt32( Console.ReadLine() );
            if (f * 0.305 > k)
            {
                Console.Write("f>k");
            }
            else if (f * 0.305 < k)
            {
                Console.Write("k>f");
            }
            else Console.WriteLine("k=f");










            Console.ReadKey();
        }
    }
}
