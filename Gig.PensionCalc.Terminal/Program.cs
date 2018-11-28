using Gig.PensionCalc.Business;
using Gig.PensionCalc.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gig.PensionCalc.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isman = true;
            int  birth = 1984;
            int finish;
            string name;
            int age = 0;
            bool isw = false;
            switch (args.Length)
            {
                case 3:
                    name = args[0];
                    age = int.Parse(args[1]);
                    isw = bool.Parse(args[2]);
                    break;
                case 2:
                    birth = int.Parse(args[0]);
                    isman = bool.Parse(args[1]);
                    break;
                case 1:
                    isman = bool.Parse(args[1]);
                    birth = 1984;
                    break;
                case 0:
                    Console.WriteLine("Мужского рода? Да - 1");
                    isman = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Укажите год рождения");
                    birth = int.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }

            if (isman)
            {
                switch (birth)
                {
                    case 1959:
                        finish = 2020;
                        break;
                    case 1960:
                        finish = 2022;
                        break;
                    case 1961:
                        finish = 2024;
                        break;
                    case 1962:
                        finish = 2026;
                        break;
                    default:
                        if (birth > 1962) finish = birth + 65;
                        if (birth < 1959) finish = birth + 60;
                        break;
                }
            }
            else
            {
                switch (birth)
                {
                    case 1964:
                        finish = 2020;
                        break;
                    case 1965:
                        finish = 2022;
                        break;
                    case 1966:
                        finish = 2024;
                        break;
                    case 1967:
                        finish = 2026;
                        break;
                    case 1968:
                        finish = 2028;
                        break;
                    case 1969:
                        finish = 2030;
                        break;
                    case 1970:
                        finish = 2032;
                        break;
                    case 1971:
                        finish = 2034;
                        break;
                    default:
                        if (birth > 1970) finish = birth + 63;
                        if (birth < 1964) finish = birth + 55;
                        break;
                }
            }

            var man = new UserInfo();
            man.Name = "nomatter";
            man.Sex = isman ? Sex.Man : Sex.Woman;
            man.BirthDay = DateTime.Today.AddYears(-age);

            var calc = new Calculator();
            var pensionInfo = calc.Calc(man);
            var resu = $"{birth} erfedkl";
            var result = string.Format("{0}, тебе работать ещё {1}", 
                isman,
                (birth)
                );
            Console.WriteLine(resu);
            Console.ReadKey();
        }
    }
}
