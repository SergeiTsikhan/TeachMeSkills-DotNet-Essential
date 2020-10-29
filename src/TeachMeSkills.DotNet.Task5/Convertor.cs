//```
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
//и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к BYN – public Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из BYN в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в BYN.
//```

using System;

namespace TeachMeSkills.DotNet.Task5
{
    class Convertor
    {

        private double _sum { get; set; }
        private double _usd;
        private double _eur;
        private double _rub;
        private double _byn;
        public void Jobvisegold()
        {
            Console.WriteLine("1.usd\n2.eur\n3.rub\n4.byn ");
            Console.WriteLine("Input what valut you have...(1,2,3,4)");
            string userinput = Console.ReadLine();
            double chek = double.Parse(userinput);
            string value = ChekInput(chek).ToString();
            Console.WriteLine(ChekInput(chek));



            Console.WriteLine("Input what valut2 you need...(1,2,3,4)");
            string userinput2 = Console.ReadLine();
            double chek2 = double.Parse(userinput2);
            string value2 = ChekInput2(chek2).ToString();
            Console.WriteLine(ChekInput2(chek2));


            Console.WriteLine("Input you sum: ");
            double sum = double.Parse(Console.ReadLine());
            double yousum = GetSum(sum);

            Console.WriteLine($"You convert sum:{GetCOnvert(value, value2, yousum, 0)} ");
        }
        public Valut ChekInput(double chek)
        {
            return chek switch
            {
                1 => Valut.usd,
                2 => Valut.eur,
                3 => Valut.rub,
                4 => Valut.byn,
            };
        }
        public Valut ChekInput2(double chek2)
        {
            return chek2 switch
            {
                1 => Valut.usd,
                2 => Valut.eur,
                3 => Valut.rub,
                4 => Valut.byn
            };

        }

        public Convertor(double usd, double eur, double rub, double byn)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
            _byn = byn;
        }

        public double Convert(double _usd, double _eur, double _rub, double _bun)
        {
            return 1;
        }
        public double GetSum(double sum)
        {
            _sum = sum;
            return _sum;
        }

        public double GetCOnvert(string valut1, string valut2, double sum, double convertsum)
        {
            switch (valut1)
            {
                case "usd":
                    {
                        switch (valut2)
                        {
                            case "eur":
                                {
                                    return convertsum = sum * 0.84;
                                }
                            case "rub":
                                {
                                    return convertsum = sum * 76.47;
                                }
                            case "byn":
                                {
                                    return convertsum = sum * 2.54;
                                }
                        }
                    }
                    break;

                case "eur":
                    {
                        switch (valut2)
                        {
                            case "usd":
                                {
                                    return convertsum = sum * 1.19;
                                }
                            case "rub":
                                {
                                    return convertsum = sum * 90.41;
                                }
                            case "byn":
                                {
                                    return convertsum = sum * 3;
                                }
                        }

                    }
                    break;

                case "rub":
                    {
                        switch (valut2)
                        {
                            case "usd":
                                {
                                    return convertsum = sum * 0.013;
                                }
                            case "eur":
                                {
                                    return convertsum = sum * 0.011;
                                }
                            case "byn":
                                {
                                    return convertsum = sum * 0.033;
                                }
                        }
                    }
                    break;

                case "byn":
                    {
                        switch (valut2)
                        {
                            case "usd":
                                {
                                    return convertsum = sum * 0.39;
                                }
                            case "eur":
                                {
                                    return convertsum = sum * 0.33;
                                }
                            case "rub":
                                {
                                    return convertsum = sum * 30.11;
                                }
                        }
                    }
                    break;
            }
            return convertsum;
        }
    }
}
