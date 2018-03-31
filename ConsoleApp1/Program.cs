using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockholm_resa
{
    class Program
    {
        static void Main(string[] args)

        {


            Console.WriteLine("Vill du; \n 1. Kalkylera distansen \n 2. Kalkylera medelhastigeheten \n 3. Beräkna Tiden");
            string InputString = Console.ReadLine();

            int InputInt = Convert.ToInt32(InputString);

            if (InputInt == 1)
            {
                CalDis();
            }
            if (InputInt == 2)
            {
                CalSpeed();
            }
            if (InputInt == 3)
            {
                CalTime();
            }

            void CalDis()
            {

                Console.WriteLine("Hur många minuter är det kvar?");

                string Time = Console.ReadLine();
                float TimeFloat = Convert.ToSingle(Time);

                Console.WriteLine("Hur många km/h åker du?");

                string Speed = Console.ReadLine();
                float SpeedFloat = Convert.ToSingle(Speed);

                TimeFloat = TimeFloat * 60f;
                SpeedFloat = SpeedFloat / 3.6f;

                float DisFloat = SpeedFloat * TimeFloat;
                DisFloat = DisFloat / 1000f;

                float foo = DisFloat;
                decimal bar = Convert.ToDecimal(foo);
                bar = Math.Round(bar, 2);

                Console.WriteLine("Det är " + "Inte Avrundat: {0}\nAvrundat {1}", foo, bar + " km kvar");
                return;
            }

            void CalSpeed()
            {
                Console.WriteLine("Hur Många minuter är det kvar?");

                string Time = Console.ReadLine();
                float TimeFloat = Convert.ToSingle(Time);

                Console.WriteLine("Hur många kilometer är det kvar?");

                string Dis = Console.ReadLine();
                float DisFloat = Convert.ToSingle(Dis);

                DisFloat = DisFloat * 1000f;
                TimeFloat = TimeFloat * 60f;

                float SpeedFloat = DisFloat / TimeFloat;
                SpeedFloat = SpeedFloat * 3.6f;

                float foo = SpeedFloat;
                decimal bar = Convert.ToDecimal(foo);
                bar = Math.Round(bar, 2);

                Console.WriteLine("Din medelhastighet är " + "Inte Avrundat: {0}\nAvrundat {1}", foo, bar + "Km/h");
                return;
            }

            void CalTime()
            {
                Console.WriteLine("Hur många kilometer är det kvar?");

                string Dis = Console.ReadLine();
                float DisFloat = Convert.ToSingle(Dis);

                Console.WriteLine("Hur många Km/h åker du?");

                string Speed = Console.ReadLine();
                float SpeedFloat = Convert.ToSingle(Speed);

                DisFloat = DisFloat * 1000f;
                SpeedFloat = SpeedFloat / 3.6f;

                float TimeFloat = DisFloat / SpeedFloat;
                TimeFloat = TimeFloat / 60f;

                float foo = TimeFloat;
                decimal bar = Convert.ToDecimal(foo);
                bar = Math.Round(bar, 2);

                Console.WriteLine("Du har " + "Inte Avrundat: {0}\nAvrundat {1}", foo, bar + " minuter kvar");
                return;
            }
            Console.WriteLine("Slå på vilken knapp du vill för att stoppa  programmet");
            Console.ReadKey();
        }

    }
}
