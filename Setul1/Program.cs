
namespace Setul1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema1();
            //Problema2();
            //Problema3();
            //Problema4();
            //Problema5();
            //Problema6();
            //Problema7();
            //Problema8();
            //Problema9();
            //Problema10();
            //Problema11();
            //Problema12();
            //Problema13();
            //Problema14();
            //Problema15();
            //Problema16();
            //Problema17();
            //Problema18();
            //Problema19();
            //Problema20();
            //Problema21();

        }


        private static void Problema1()
        {
            Console.Write("Introduceti coeficientul a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Introduceti coeficientul b: ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Ecuatia are o infinitate de solutii.");
                else
                    Console.WriteLine("Ecuatia nu are solutii.");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Solutia este: x = {x}");
            }

        }

        private static void Problema2()
        {
            Console.Write("Introduceti coeficientul a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Introduceti coeficientul b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Introduceti coeficientul c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Ecuatia are o infinitate de solutii.");
                    else
                        Console.WriteLine("Ecuatia nu are solutii.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Ecuatia este de gradul 1, solutia este: x = {x}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                    Console.WriteLine("Ecuatia nu are solutii reale.");
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Ecuatia are o solutie dubla: x = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Solutiile sunt: x1 = {x1}, x2 = {x2}");
                }
            }

        }
        static void Problema3()
        {
            Console.Write("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti k: ");
            int k = int.Parse(Console.ReadLine());

            if (k == 0)
                Console.WriteLine("Nu se poate imparti la 0.");
            else if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}.");
            else
                Console.WriteLine($"{n} nu se divide cu {k}.");

        }

        private static void Problema4()
        {
            Console.Write("Introduceti anul y: ");
            int y = int.Parse(Console.ReadLine());

            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                Console.WriteLine($"{y} este an bisect.");
            else
                Console.WriteLine($"{y} nu este an bisect.");

        }

        private static void Problema5()
        {
            Console.Write("Introduceti un numar: ");
            string inputNumar = Console.ReadLine();

            Console.Write("Introduceti pozitia k: ");
            string inputPozitie = Console.ReadLine();

            if (int.TryParse(inputNumar, out int numar) && int.TryParse(inputPozitie, out int k))
            {

                numar = Math.Abs(numar);

                string numarStr = numar.ToString();


                if (k > 0 && k <= numarStr.Length)
                {
                    char cifra = numarStr[numarStr.Length - k];
                    Console.WriteLine($"Cifra a {k}-a de la sfarsitul numarului este: {cifra}");
                }
                else
                {
                    Console.WriteLine("Pozitia k este invalida!");
                }
            }
            else
            {
                Console.WriteLine("Input invalid! Introduceti numere intregi.");
            }

        }

        private static void Problema6()
        {
            Console.Write("Introduceti latura a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti latura b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Introduceti latura c: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Numerele pot fi laturile unui triunghi.");
            else
                Console.WriteLine("Numerele NU pot fi laturile unui triunghi.");

        }

        private static void Problema7()
        {
            Console.Write("Introduceti valoarea lui a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea lui b: ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Dupa swap: a = {a}, b = {b}");

        }

        private static void Problema8()
        {
            Console.Write("Introduceti valoarea lui a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea lui b: ");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Dupa swap: a = {a}, b = {b}");

        }

        private static void Problema9()
        {
            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            Console.WriteLine($"Divizorii lui {n} sunt:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }

        }

        private static void Problema10()
        {
            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine($"{n} nu este prim.");
                return;
            }

            bool estePrim = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    estePrim = false;
                    break;
                }
            }

            if (estePrim)
                Console.WriteLine($"{n} este prim.");
            else
                Console.WriteLine($"{n} nu este prim.");

        }

        private static void Problema11()
        {
            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);

            Console.Write("Cifrele in ordine inversa sunt: ");
            while (n > 0)
            {
                int cifra = n % 10;
                Console.Write(cifra);
                n /= 10;
            }

            Console.WriteLine();

        }

        private static void Problema12() 
        {
            Console.Write("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti limita inferioara a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti limita superioara b: ");
            int b = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    count++;
            }

            Console.WriteLine($"In intervalul [{a}, {b}] sunt {count} numere divizibile cu {n}.");

        }

        private static void Problema13()
        {
            Console.Write("Introduceti anul de inceput y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti anul de sfarsit y2: ");
            int y2 = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = y1; i <= y2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    count++;
            }

            Console.WriteLine($"Intre anii {y1} și {y2} sunt {count} ani bisecti.");

        }

        private static void Problema14() 
        {
            Console.WriteLine("Dati un numar intreg");
            int numar = int.Parse(Console.ReadLine());
            int oglindit = 0;
            int n = numar;

            while (n != 0)
            {
                int ultimaCifra = n % 10;
                oglindit = oglindit * 10 + ultimaCifra;
                n = n / 10;
            }

            if (numar == oglindit)
            {
                Console.WriteLine($"Numarul {numar} este un palindrom");
            }
            else
            {
                Console.WriteLine($"Numarul {numar} nu este un palindrom");
            }
        }

        private static void Problema15()
        {
            Console.Write("Introduceti primul numar: ");
            int numar1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int numar2 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            int numar3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numerele in ordine crescatoare sunt:");
            if (numar1 <= numar2 && numar1 <= numar3)
            {

                if (numar2 <= numar3)
                    Console.WriteLine($"{numar1}, {numar2}, {numar3}");
                else
                    Console.WriteLine($"{numar1}, {numar3}, {numar2}");
            }
            else if (numar2 <= numar1 && numar2 <= numar3)
            {

                if (numar1 <= numar3)
                    Console.WriteLine($"{numar2}, {numar1}, {numar3}");
                else
                    Console.WriteLine($"{numar2}, {numar3}, {numar1}");
            }
            else
            {
                if (numar1 <= numar2)
                    Console.WriteLine($"{numar3}, {numar1}, {numar2}");
                else
                    Console.WriteLine($"{numar3}, {numar2}, {numar1}");
            }

        }

        private static void Problema16()
        {
            Console.WriteLine("Introduceti cinci numere:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            
            if (a > b) (a, b) = (b, a);
            if (a > c) (a, c) = (c, a);
            if (a > d) (a, d) = (d, a);
            if (a > e) (a, e) = (e, a);

            if (b > c) (b, c) = (c, b);
            if (b > d) (b, d) = (d, b);
            if (b > e) (b, e) = (e, b);

            if (c > d) (c, d) = (d, c);
            if (c > e) (c, e) = (e, c);

            if (d > e) (d, e) = (e, d);

            Console.WriteLine($"Numerele în ordine crescătoare: {a}, {b}, {c}, {d}, {e}");

        }

        private static void Problema17()
        {
            Console.Write("Introduceți primul număr: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceți al doilea număr: ");
            int b = int.Parse(Console.ReadLine());

            int originalA = a, originalB = b;

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            int gcd = a;
            int lcm = (originalA * originalB) / gcd;

            Console.WriteLine($"CMMDC este: {gcd}");
            Console.WriteLine($"CMMMC este: {lcm}");

        }

        private static void Problema18()
        {
            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Descompunerea in factori primi pentru {n} este: ");

            for (int i = 2; i * i <= n; i++)
            {
                int exponent = 0;
                while (n % i == 0)
                {
                    n /= i;
                    exponent++;
                }
                if (exponent > 0)
                    Console.Write($"{i}^{exponent} ");
            }
            if (n > 1)
                Console.Write($"{n}^1");

            Console.WriteLine();

        }

        private static void Problema19()
        {
            Console.Write("Introduceti un numar: ");
            string numar = Console.ReadLine();

            char primaCifra = numar[0];
            char aDouaCifra = '\0';

            bool esteValid = true;

            foreach (char cifra in numar)
            {
                if (cifra != primaCifra)
                {
                    if (aDouaCifra == '\0')
                    {
                        aDouaCifra = cifra;
                    }
                    else if (cifra != aDouaCifra)
                    {
                        esteValid = false;
                        break;
                    }
                }
            }
            if (esteValid)
            {
                Console.WriteLine($"{numar} este format doar din două cifre care se pot repeta.");
            }
            else
            {
                Console.WriteLine($"{numar} NU este format doar din două cifre care se pot repeta.");
            }

        }

        private static void Problema20()
        {
            Console.Write("Introduceti numaratorul (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Introduceti numitorul (n): ");
            int n = int.Parse(Console.ReadLine());


            if (n == 0)
            {
                Console.WriteLine("Numitorul nu poate fi zero.");
                return;
            }

            int parteIntreaga = m / n; 
            int rest = m % n; 

            Console.Write($"Rezultatul este: {parteIntreaga}");

            if (rest == 0)
            {
                Console.WriteLine(".0");
                return;
            }

            Console.Write(".");

            string parteZecimala = "";
            int[] pozitiiResturi = new int[10000];
            int pozitie = 0;

            while (rest != 0)
            {
                if (pozitiiResturi[rest] != 0)
                {
                    int startPerioada = pozitiiResturi[rest] - 1;
                    string neperiodic = parteZecimala.Substring(0, startPerioada);
                    string periodic = parteZecimala.Substring(startPerioada);

                    Console.WriteLine($"{neperiodic}({periodic})");
                    return;
                }

                pozitiiResturi[rest] = pozitie + 1;

                rest *= 10;
                int cifra = rest / n;
                parteZecimala += cifra.ToString();
                rest %= n;
                pozitie++;
            }
            Console.WriteLine(parteZecimala);

        }

        private static void Problema21()
        {
            Console.WriteLine("Ganditi-va la un numar intre 1 si 1024.");
            Console.WriteLine("Voi incerca sa ghicesc numarul vostru folosind intrebari.");

            int stanga = 1;
            int dreapta = 1024;

            while (stanga < dreapta)
            {
                int mijloc = (stanga + dreapta) / 2;

                Console.Write($"Numarul este mai mare sau egal decat {mijloc}? (da/nu): ");
                string raspuns = Console.ReadLine().Trim().ToLower();

                if (raspuns == "da")
                {
                    stanga = mijloc; 
                }
                else if (raspuns == "nu")
                {
                    dreapta = mijloc - 1; 
                }
                else
                {
                    Console.WriteLine("Va rog sa raspundeți doar cu 'da' sau 'nu'.");
                }
            }

            Console.WriteLine($"Numarul gandit este: {stanga}");

        }
    }
}


