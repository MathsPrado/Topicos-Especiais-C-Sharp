using System;

namespace TopicosEspecial
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = 10;
            //var y = 20.0;
            //var z = "Matheus";


            //Console.WriteLine(x + "-"+ y + "-" + z);

            //int a = int.Parse(Console.ReadLine());
            //string day;

            //if(a == 1)
            //{
            //    day = "Sunday";
            //}
            //else if( a == 2)
            //{
            //    day = "Monday";
            //}
            //else if(a == 3)
            //{
            //    day = "Tuesday";
            //}
            //else if (a == 4)
            //{
            //    day = "Wednesday";
            //}
            //else if (a == 5)
            //{
            //    day = "Thursday";
            //}
            //else if (a == 6)
            //{
            //    day = "Friday";
            //}
            //else if (a == 7)
            //{
            //    day = "Saturday";
            //}
            //else
            //{
            //    day = "Valor invalido";
            //}
            //Console.WriteLine("Day:"+day);



            //int b = int.Parse(Console.ReadLine());

            //string daay;
            //switch (b) {
            //    case 1: daay = "Sunday";
            //        break;

            //    case 2: daay = "Monday";
            //        break;

            //    case 3: daay = "Tuesday";
            //        break;

            //    case 4: daay = "Wednesday";
            //        break;

            //    case 5: daay = "Thursday";
            //        break;

            //    case 6: daay = "Friday";
            //        break;

            //    case 7: daay = "Saturday";
            //        break;

            //    default: daay = "Invalid value";
            //        break; }

            //Console.WriteLine("Day: " + daay);


            //double preco = 34.5;
            //double desconto;
            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}

            //---------------Condicão ternaria----------------------------

            //double preco1 = 34.5;               //true         false
            //double desconto1 = (preco1 < 20.0) ? preco1 * 0.1 : preco1 * 0.05;

            //------------Funções com String---------------------------------
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();

            string s2 = original.ToLower();

            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");

            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);

            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');

            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);

            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");

            Console.WriteLine("ToUpper: -" + s1 + "-");

            Console.WriteLine("ToLower: -" + s2 + "-");

            Console.WriteLine("Trim: -" + s3 + "-");

            Console.WriteLine("IndexOf('bc'): " + n1);

            Console.WriteLine("LastIndexOf('bc'): " + n2);

            Console.WriteLine("Substring(3): -" + s4 + "-");

            Console.WriteLine("Substring(3, 5): -" + s5 + "-");

            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");

            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");

            Console.WriteLine("IsNullOrEmpty: " + b1);

            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}
