﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Population
{
    class Program
    {
        public static string ReplaceIncorrectSeparators(string text)
        {
            char[] separators = new char[] { ' ', ':', ';', '-', ',', '\t' };
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return string.Join("\t", subs);
        }
        static void Main(string[] args)
        {
            string citiesPopulation = @"Страна Население Дата %
Китай: 1405023000; 24.08.2020; 17.99%
Индия: 1375100000 24.08.2020 17.6%
США: 329957441; 15.07.2020; 4.24%
Индонезия 266911900; 01.07.2019 3.42%
Пакистан - 218647040 24.08.2020; 2.8%
Бразилия 211950300; 24.08.2020; 2.71%
Нигерия 208426036; 24.08.2020; 2.67%
Бангладеш 171147762 24.08.2020; 2.19%
Россия: 146748590; 01.01.2020 1.88%
Мексика - 127792286, 01.07.2020, 1.64%
Япония 125950000; 01.03.2020, 1.61%
Эфиопия 112079000, 01.07.2019 1.43%
Филиппины 108968790, 24.08.2020; 1.39%
Египет 100812120, 24.08.2020 1.29%
Вьетнам 96208984; 01.04.2019; 1.23%
ДРК 86791000, 01.07.2019, 1.11%
Иран 84393386 24.08.2020 1.08%
Турция - 83154997 1.01.2020 1.06%
Германия - 83149300 1.10.2019 1.06%
Франция - 68859599; 01.01.2018, 0.88%";
           
            
            Console.WriteLine(ReplaceIncorrectSeparators(citiesPopulation));
            Console.ReadKey();
        }
    }
    
}
