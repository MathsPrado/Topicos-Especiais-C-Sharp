using System;
using System.Globalization;

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

            //string original = "abcde FGHIJ ABC abc DEFG   ";

            //string s1 = original.ToUpper();

            //string s2 = original.ToLower();

            //string s3 = original.Trim();

            //int n1 = original.IndexOf("bc");

            //int n2 = original.LastIndexOf("bc");

            //string s4 = original.Substring(3);

            //string s5 = original.Substring(3, 5);

            //string s6 = original.Replace('a', 'x');

            //string s7 = original.Replace("abc", "xy");

            //bool b1 = String.IsNullOrEmpty(original);

            //bool b2 = String.IsNullOrWhiteSpace(original);


            //Console.WriteLine("Original: -" + original + "-");

            //Console.WriteLine("ToUpper: -" + s1 + "-");

            //Console.WriteLine("ToLower: -" + s2 + "-");

            //Console.WriteLine("Trim: -" + s3 + "-");

            //Console.WriteLine("IndexOf('bc'): " + n1);

            //Console.WriteLine("LastIndexOf('bc'): " + n2);

            //Console.WriteLine("Substring(3): -" + s4 + "-");

            //Console.WriteLine("Substring(3, 5): -" + s5 + "-");

            //Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");

            //Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");

            //Console.WriteLine("IsNullOrEmpty: " + b1);

            //Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            //Console.WriteLine("-----------------------------");
            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            //DateTime d3 = DateTime.Parse("15/08/2000");
            //DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            //Demo - Now, UtcNow, Today-----------------------------------------------

            //DateTime d1 = DateTime.Now;

            //DateTime d2 = DateTime.UtcNow;

            //DateTime d3 = DateTime.Today;

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);


            //----Demo - ParseExact-----------------------------------------------------

            //DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            //Console.WriteLine("---------------------");

            // ----TimeSpan ----------------------------------------------------------------


            //TimeSpan teste = new TimeSpan(0, 1, 30);
            //Console.WriteLine(teste);
            //Console.WriteLine(teste.Ticks); //Duvida------------------

            //Console.WriteLine("------------------");

            //TimeSpan t1 = new TimeSpan();

            //TimeSpan t2 = new TimeSpan(900000000L);

            //TimeSpan t3 = new TimeSpan(2, 11, 21);

            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);


            //Console.WriteLine(t1);
            //Console.WriteLine("----");
            //Console.WriteLine(t2);
            //Console.WriteLine("----");
            //Console.WriteLine(t3);
            //Console.WriteLine("----");
            //Console.WriteLine(t4);
            //Console.WriteLine("----");
            //Console.WriteLine(t5);

            //---Demo - métodos From-------------------------------------------------

            //TimeSpan t1 = TimeSpan.FromDays(1.5);

            //TimeSpan t2 = TimeSpan.FromHours(1.5);

            //TimeSpan t3 = TimeSpan.FromMinutes(1.5);

            //TimeSpan t4 = TimeSpan.FromSeconds(1.5);

            //TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);

            //TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            //Console.WriteLine("FromDays: "+t1);
            //Console.WriteLine("FromHours: " + t2);
            //Console.WriteLine("FromMinutes: " + t3);
            //Console.WriteLine("FromSeconds: " + t4);
            //Console.WriteLine("FromMilliseconds: " + t5);
            //Console.WriteLine("FromTicks: " + t6);


            //---Propriedades e Operações com DateTime--------------------------------------

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);


            //-----Formatação(DateTime-> string) -------------------------

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            //string s1 = d.ToLongDateString();

            //string s2 = d.ToLongTimeString();

            //string s3 = d.ToShortDateString();

            //string s4 = d.ToShortTimeString();

            //string s5 = d.ToString();

            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");

            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine("ToLongDateString:"+s1);
            //Console.WriteLine("ToLongDateString:" + s2);
            //Console.WriteLine("ToLongDateString:" + s3);
            //Console.WriteLine("ToShortDateString:" + s4);
            //Console.WriteLine("ToString:"+s5);
            //Console.WriteLine("ToString(yyyy - MM - dd HH: mm:ss):" + s6);
            //Console.WriteLine("ToString(yyyy - MM - dd HH: mm:ss.fff):" + s7);


            //Opreações timeSpan -----------

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);
            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2.0);
            //TimeSpan div = t2.Divide(2.0);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine("add: "+sum);
            //Console.WriteLine("Subtract: " + dif);
            //Console.WriteLine("Multiply" + mult);
            //Console.WriteLine("Divide: " + div);

            //DateTimeKind------------------------

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


            Console.WriteLine("d1: " + d1);

            Console.WriteLine("d1 Kind: " + d1.Kind);

            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());

            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

            Console.WriteLine(); Console.WriteLine("d2: " + d2);

            Console.WriteLine("d2 Kind: " + d2.Kind);

            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());

            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());

            Console.WriteLine(); Console.WriteLine("d3: " + d3);

            Console.WriteLine("d3 Kind: " + d3.Kind);

            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());

            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
        }
    }
}

