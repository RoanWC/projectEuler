using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SquareOfSums(10));
            problem7();
            Console.Read();
        }

        public static void problem2()
        {
            /*
             * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
             * find the sum of the even-valued terms.
             */
            int term1 = 1;
            int term2 = 2;
            int sum = 2;
            for (int i = term1 + term2; i < 4000000; i= term1 + term2)
            {
                
                term1 = term2;
                term2 = i;
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("the sum is" + sum);

        }
        public static void problem3()
        {
            long biggestPrimeFactor = 1;
            long num = 6857;
            
            for (long i = 1; i < num; i++)
            {
                if (isPrime(i))
                {
                    if(num % i == 0)
                    {
                        biggestPrimeFactor = i;
                        Console.WriteLine("biggest one so far:" + biggestPrimeFactor);
                    }
                }
            }
            Console.WriteLine(biggestPrimeFactor);
        }
        public static bool isPrime(long num)
        {
            if (num == 2)
            {
                return true;
            }
            if (num == 3)
            {
                return true;
            }
            if (num == 1)
            {
                return false;
            }
            
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static void problem4()
        {
            List<object> numList = new List<object>();

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    if (!numList.Contains(i*j))
                    {
                        if (isPalindrome(i * j))
                        {
                            numList.Add(i * j);
                            Console.WriteLine(i * j);
                        }
                    }
                }
            } 
        }
        public static void problem5()
        {
            int i = 1;
            Console.WriteLine("alert");
            while(true)
            {
                if(i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        if (i % 4 == 0)
                        {
                            if (i % 5 == 0)
                            {
                                if (i % 6 == 0)
                                {
                                    if (i % 6 == 0)
                                    {
                                        if (i % 7 == 0)
                                        {
                                            if (i % 8 == 0)
                                            {
                                                if (i % 9 == 0)
                                                {
                                                    if (i % 10 == 0)
                                                    {
                                                        if (i % 11 == 0)
                                                        {
                                                            if (i % 12 == 0)
                                                            {
                                                                if (i % 13 == 0)
                                                                {
                                                                    if (i % 14 == 0)
                                                                    {
                                                                        if (i % 15 == 0)
                                                                        {
                                                                            if (i % 16 == 0)
                                                                            {
                                                                                if (i % 17 == 0)
                                                                                {
                                                                                    if (i % 18 == 0)
                                                                                    {
                                                                                        if (i % 19 == 0)
                                                                                        {
                                                                                            if (i % 20 == 0)
                                                                                            {
                                                                                                Console.WriteLine(i);
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                i++;
            }

        }

        public static void problem6()
        {
            int num = 100;
            int result = SquareOfSums(num) - sumOfSquares(num);
            Console.WriteLine(result);
        }


        public static int sumOfSquares(int num)
        {
            int result = 0;
            for (int i = 0; i < num + 1; i++)
            {
                result += i * i;
            }
            return result;
        }

        public static void problem7()
        {
            int number = 3;
            int answer = 0;
            int count = 1;
            while(count < 10001)
            {
                if (isPrime(number))
                {
                    count++;
                    answer = number;
                }
                number++;
            }
            Console.WriteLine(answer);
        }
        public static int SquareOfSums(int num)
        {
            int result = 0;
            for(int i = 0; i < num + 1; i++)
            {
                result += i;
            }
            result *= result;
            return result;
        }

        public static int reverseNum(int number)
        {
            int num = number;
            int result = 0;
            while(num > 0)
            {
                int dig = num % 10;
                result = result * 10 + dig;
                num = num / 10;
            }
            return result;
        }
        public static bool isPalindrome(int num)
        {
            if(num == reverseNum(num))
            {
                return true;
            }
            return false;
        }

    }
}
