using System;

class Assignment1
{
    public static void Main()
    {
        string repeat = "N", menuInput = "";


        do
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Assignment 1\n");
            Console.WriteLine("Nama : Denny Tandiono");
            Console.WriteLine("Nomor Peserta : FSDO002ONL019");
            Console.WriteLine("Domisili : Jakarta");

            Console.WriteLine("===Daftar Soal===");
            Console.WriteLine("");
            Console.WriteLine(" 1. Segitiga Alphabet \n 2. Segitiga Angka \n 3. Faktorial \n 4. Balik Angka \n 5. Converter Angka \n 6. Palindrom Check");

            Console.WriteLine("");
            Console.Write("Masukan angka menu pilihan : ");
            menuInput = Console.ReadLine();

            switch (menuInput)
            {
                case "1":
                    {
                        int input = 0;

                        Console.Write("Input Range : ");
                        input = int.Parse(Console.ReadLine());

                        char huruf = 'A';
                        int i, j, k, m;
                        for (i = 1; i <= input; i++)
                        {
                            for (j = 1; j <= input - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (k = 1; k <= i; k++)
                            {
                                Console.Write(huruf++);
                            }
                            huruf--;
                            for (m = 1; m < i; m++)
                            {
                                Console.Write(--huruf);
                            }
                            Console.Write("\n");
                            huruf = 'A';
                        }
                        break;
                    }

                case "2":
                    {
                        int i, j, k, l, n;
                        Console.Write("Enter the Range=");
                        n = int.Parse(Console.ReadLine());
                        for (i = 1; i <= n; i++)
                        {
                            for (j = 1; j <= n - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (k = 1; k <= i; k++)
                            {
                                Console.Write(k);
                            }
                            for (l = i - 1; l >= 1; l--)
                            {
                                Console.Write(l);
                            }
                            Console.Write("\n");
                        }

                        break;
                    }

                case "3":
                    {
                        int i, fact = 1, number;
                        Console.Write("Enter any Number: ");
                        number = int.Parse(Console.ReadLine());
                        for (i = 1; i <= number; i++)
                        {
                            fact *= i;
                        }
                        Console.WriteLine("Factorial of " + number + " is: " + fact);
                        break;
                    }

                case "4":
                    {
                        int n, reverse = 0, remainder;

                        Console.Write("Enter a number: ");
                        n = int.Parse(Console.ReadLine());

                        while (n > 0)
                        {
                            remainder = n % 10;
                            reverse = reverse * 10 + remainder;
                            n /= 10;
                        }
                        Console.WriteLine("Reversed Number: " + reverse);
                        break;
                    }

                case "5":
                    {
                        int n, temp = 0, rem;
                        Console.Write("Enter the Number= ");
                        n = int.Parse(Console.ReadLine());
                        while (n > 0)
                        {
                            rem = n % 10;
                            temp = temp * 10 + rem;
                            n = n / 10;
                        }
                        n = temp;
                        while (n > 0)
                        {
                            rem = n % 10;
                            switch (rem)
                            {
                                case 1:
                                    Console.Write("one ");
                                    break;
                                case 2:
                                    Console.Write("two ");
                                    break;
                                case 3:
                                    Console.Write("three ");
                                    break;
                                case 4:
                                    Console.Write("four ");
                                    break;
                                case 5:
                                    Console.Write("five ");
                                    break;
                                case 6:
                                    Console.Write("six ");
                                    break;
                                case 7:
                                    Console.Write("seven ");
                                    break;
                                case 8:
                                    Console.Write("eight ");
                                    break;
                                case 9:
                                    Console.Write("nine ");
                                    break;
                                case 0:
                                    Console.Write("zero ");
                                    break;
                                default:
                                    Console.Write("=====");
                                    break;
                            }
                            n = n / 10;
                        }
                        Console.WriteLine();
                        break;
                    }

                case "6":
                    {
                        string kata, reverse;

                        Console.Write("Input Kata yang akan dicek : ");
                        kata = Console.ReadLine();

                        char [] character = kata.ToCharArray();
                        Array.Reverse(character);
                        reverse = new string(character);

                        bool check = kata.Equals(reverse, StringComparison.OrdinalIgnoreCase);
                        if(check == true)
                        {
                            Console.WriteLine("" + kata + " is a Palindrome");
                        }
                        else
                        {
                            Console.WriteLine("" + kata + " is not a Palindrome");
                        }
                        break;
                    }
                
                default : 
                {
                    Console.WriteLine("Pilih Salah satu Menu!");
                    break;
                }
            }

            Console.Write("Kembali ke menu awal? (Y/N) : ");
            repeat = Console.ReadLine();
            repeat = repeat.ToUpper();
        } while (repeat == "Y");
    }
}