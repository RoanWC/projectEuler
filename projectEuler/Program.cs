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
            //Console.WriteLine(isPrime(9));
            problem10();
            
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
        public static void problem8()
        {
            int[] nums = {
                            7,3,1,6,7,1,7,6,5,3,1,3,3,0,6,2,4,9,1,9,2,2,5,1,1,9,6,7,4,4,2,6,5,7,4,7,4,2,3,5,5,3,4,9,1,9,4,9,3,4,
                            9,6,9,8,3,5,2,0,3,1,2,7,7,4,5,0,6,3,2,6,2,3,9,5,7,8,3,1,8,0,1,6,9,8,4,8,0,1,8,6,9,4,7,8,8,5,1,8,4,3,
                            8,5,8,6,1,5,6,0,7,8,9,1,1,2,9,4,9,4,9,5,4,5,9,5,0,1,7,3,7,9,5,8,3,3,1,9,5,2,8,5,3,2,0,8,8,0,5,5,1,1,
                            1,2,5,4,0,6,9,8,7,4,7,1,5,8,5,2,3,8,6,3,0,5,0,7,1,5,6,9,3,2,9,0,9,6,3,2,9,5,2,2,7,4,4,3,0,4,3,5,5,7,
                            6,6,8,9,6,6,4,8,9,5,0,4,4,5,2,4,4,5,2,3,1,6,1,7,3,1,8,5,6,4,0,3,0,9,8,7,1,1,1,2,1,7,2,2,3,8,3,1,1,3,
                            6,2,2,2,9,8,9,3,4,2,3,3,8,0,3,0,8,1,3,5,3,3,6,2,7,6,6,1,4,2,8,2,8,0,6,4,4,4,4,8,6,6,4,5,2,3,8,7,4,9,
                            3,0,3,5,8,9,0,7,2,9,6,2,9,0,4,9,1,5,6,0,4,4,0,7,7,2,3,9,0,7,1,3,8,1,0,5,1,5,8,5,9,3,0,7,9,6,0,8,6,6,
                            7,0,1,7,2,4,2,7,1,2,1,8,8,3,9,9,8,7,9,7,9,0,8,7,9,2,2,7,4,9,2,1,9,0,1,6,9,9,7,2,0,8,8,8,0,9,3,7,7,6,
                            6,5,7,2,7,3,3,3,0,0,1,0,5,3,3,6,7,8,8,1,2,2,0,2,3,5,4,2,1,8,0,9,7,5,1,2,5,4,5,4,0,5,9,4,7,5,2,2,4,3,
                            5,2,5,8,4,9,0,7,7,1,1,6,7,0,5,5,6,0,1,3,6,0,4,8,3,9,5,8,6,4,4,6,7,0,6,3,2,4,4,1,5,7,2,2,1,5,5,3,9,7,
                            5,3,6,9,7,8,1,7,9,7,7,8,4,6,1,7,4,0,6,4,9,5,5,1,4,9,2,9,0,8,6,2,5,6,9,3,2,1,9,7,8,4,6,8,6,2,2,4,8,2,
                            8,3,9,7,2,2,4,1,3,7,5,6,5,7,0,5,6,0,5,7,4,9,0,2,6,1,4,0,7,9,7,2,9,6,8,6,5,2,4,1,4,5,3,5,1,0,0,4,7,4,
                            8,2,1,6,6,3,7,0,4,8,4,4,0,3,1,9,9,8,9,0,0,0,8,8,9,5,2,4,3,4,5,0,6,5,8,5,4,1,2,2,7,5,8,8,6,6,6,8,8,1,
                            1,6,4,2,7,1,7,1,4,7,9,9,2,4,4,4,2,9,2,8,2,3,0,8,6,3,4,6,5,6,7,4,8,1,3,9,1,9,1,2,3,1,6,2,8,2,4,5,8,6,
                            1,7,8,6,6,4,5,8,3,5,9,1,2,4,5,6,6,5,2,9,4,7,6,5,4,5,6,8,2,8,4,8,9,1,2,8,8,3,1,4,2,6,0,7,6,9,0,0,4,2,
                            2,4,2,1,9,0,2,2,6,7,1,0,5,5,6,2,6,3,2,1,1,1,1,1,0,9,3,7,0,5,4,4,2,1,7,5,0,6,9,4,1,6,5,8,9,6,0,4,0,8,
                            0,7,1,9,8,4,0,3,8,5,0,9,6,2,4,5,5,4,4,4,3,6,2,9,8,1,2,3,0,9,8,7,8,7,9,9,2,7,2,4,4,2,8,4,9,0,9,1,8,8,
                            8,4,5,8,0,1,5,6,1,6,6,0,9,7,9,1,9,1,3,3,8,7,5,4,9,9,2,0,0,5,2,4,0,6,3,6,8,9,9,1,2,5,6,0,7,1,7,6,0,6,
                            0,5,8,8,6,1,1,6,4,6,7,1,0,9,4,0,5,0,7,7,5,4,1,0,0,2,2,5,6,9,8,3,1,5,5,2,0,0,0,5,5,9,3,5,7,2,9,7,2,5,
                            7,1,6,3,6,2,6,9,5,6,1,8,8,2,6,7,0,4,2,8,2,5,2,4,8,3,6,0,0,8,2,3,2,5,7,5,3,0,4,2,0,7,5,2,9,6,3,4,5,0
            };
            long highestProduct = 1;
           
            for(int i = 0; i < nums.Length - 12; i++)
            {
                long currentProduct = 1;
                for (int j = 0; j < 13; j++)
                {             
                    currentProduct *= nums[i + j];                    
                }
                if(currentProduct > highestProduct)
                {
                    highestProduct = currentProduct;
                }
            }
            Console.WriteLine("highest product is: " + highestProduct);
        }
        public static void problem9()
        {
            for(int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for(int c = b + 1; c < 1000; c++)
                    {
                        if(a + b + c == 1000)
                        {
                            if(a * a + b * b == c * c)
                            {
                                Console.WriteLine("A: " + a + " B: " + b + " C: " + c);
                            }
                        }
                    }
                }
            }
        }
        public static void problem10()
        {
            List<int> primes = new List<int>();
            long sum = 0;
            for(int i = 0; i < 2000000; i++)
            {
                if (isPrime(i))
                {
                    primes.Add(i);
                    sum += i;
                    Console.WriteLine("i: " + i);
                    Console.WriteLine("Sum: " + sum);
                }
            }
            Console.WriteLine(sum);
        }


        //utility methods
        public static bool isPalindrome(int num)
        {
            if (num == reverseNum(num))
            {
                return true;
            }
            return false;
        }

        public static int reverseNum(int number)
        {
            int num = number;
            int result = 0;
            while (num > 0)
            {
                int dig = num % 10;
                result = result * 10 + dig;
                num = num / 10;
            }
            return result;
        }
        public static int SquareOfSums(int num)
        {
            int result = 0;
            for (int i = 0; i < num + 1; i++)
            {
                result += i;
            }
            result *= result;
            return result;
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

            for (int i = 2; i < Math.Sqrt(num) + 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    
}
