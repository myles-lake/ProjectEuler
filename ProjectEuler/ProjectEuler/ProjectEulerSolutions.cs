﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ProjectEulerSolutions
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public void MultiplesOf3And5()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("1 : Multiples of 3 and 5");
            Console.WriteLine(sum);
        }
        /// <summary>
        /// Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:
        /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        /// </summary>
        public void EvenFibinacciNumbers()
        {
            int sum = 0;
            int fib1 = 1;
            int fib2 = 2;
            int fibTemp = 0;
            while (fib1 <= 4000000 && fib2 <= 4000000)
            {
                if (fib2 % 2 == 0)
                {
                    sum += fib2;
                }
                fibTemp = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibTemp;
            }
            Console.WriteLine("2 : Even Fibinacci Numbers");
            Console.WriteLine(sum);
        }
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public void LargestPrimeFactor()
        {
            long number = 600851475143;
            long numberTemp = number;
            long largestFactor = 0;
            int counter = 3;
            while (counter * counter <= numberTemp)
            {
                if (numberTemp % counter == 0)
                {
                    numberTemp = numberTemp / counter;
                    largestFactor = counter;
                }
                else
                {
                    counter += 2;
                }
            }
            if (numberTemp > largestFactor)
            {
                largestFactor = numberTemp;
            }
            Console.WriteLine("3 : Largest Prime Factor");
            Console.WriteLine(largestFactor);
        }
        /// <summary>
        /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public void LargestPalindromeProduct()
        {
            int product = 0;
            string productString;
            int largestPalindrome = 0;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    product = i * j;
                    productString = product.ToString();
                    char[] palindromeArray = productString.ToCharArray();
                    int counter = palindromeArray.Length - 1;
                    bool flag = true;
                    for (int k = 0; k < palindromeArray.Length; k++)
                    {
                        if (!palindromeArray[k].Equals(palindromeArray[counter]))
                        {
                            flag = false;
                            break;
                        }
                        counter--;
                    }
                    if (flag)
                    {
                        if (product > largestPalindrome)
                        {
                            largestPalindrome = product;
                        }
                    }
                }
            }
            Console.WriteLine("4 : Largest Palindrome Product");
            Console.WriteLine(largestPalindrome);
        }
        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public void SmallestMultiple()
        {
            int number = 20;
            while (true)
            {
                bool flag = true;
                for (int i = 1; i < 21; i++)
                {
                    if (number % i != 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
                number += 20;
            }
            Console.WriteLine("5 : Smallest Multiple");
            Console.WriteLine(number);
        }
        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        /// 1^2 + 2^2 + ... + 10^2 = 385
        /// The square of the sum of the first ten natural numbers is,
        /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        public void SumSquareDifference()
        {
            int sumOFSquares = 0;
            int squareOfSums = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOFSquares += i * i;
                squareOfSums += i;
            }
            squareOfSums *= squareOfSums;
            int difference = squareOfSums - sumOFSquares;
            Console.WriteLine("6 : Sum Square Difference");
            Console.WriteLine(difference);
        }
        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// What is the 10001st prime number?
        /// </summary>
        public void _10001stPrime()
        {
            int currentNumber = 1;
            int primeCounter = 0;
            int _10001stPrimeNumber;
            while (true)
            {
                bool flag = true;
                for (int i = 3; i * i <= currentNumber; i += 2)
                {
                    if (currentNumber % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    primeCounter++;
                    if (primeCounter == 10001)
                    {
                        _10001stPrimeNumber = currentNumber;
                        break;
                    }
                }
                currentNumber += 2;
            }
            Console.WriteLine("7 : 10001st Prime");
            Console.WriteLine(_10001stPrimeNumber);
        }
        /// <summary>
        /// The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
        /// 73167176531330624919225119674426574742355349194934
        /// 96983520312774506326239578318016984801869478851843
        /// 85861560789112949495459501737958331952853208805511
        /// 12540698747158523863050715693290963295227443043557
        /// 66896648950445244523161731856403098711121722383113
        /// 62229893423380308135336276614282806444486645238749
        /// 30358907296290491560440772390713810515859307960866
        /// 70172427121883998797908792274921901699720888093776
        /// 65727333001053367881220235421809751254540594752243
        /// 52584907711670556013604839586446706324415722155397
        /// 53697817977846174064955149290862569321978468622482
        /// 83972241375657056057490261407972968652414535100474
        /// 82166370484403199890008895243450658541227588666881
        /// 16427171479924442928230863465674813919123162824586
        /// 17866458359124566529476545682848912883142607690042
        /// 24219022671055626321111109370544217506941658960408
        /// 07198403850962455444362981230987879927244284909188
        /// 84580156166097919133875499200524063689912560717606
        /// 05886116467109405077541002256983155200055935729725
        /// 71636269561882670428252483600823257530420752963450
        /// Find the thirteen adjacent digits in the 1000-digit number that have the greatest product.What is the value of this product?
        /// </summary>
        public void LargestProductInASeries()
        {
            string series = "73167176531330624919225119674426574742355349194934" +
                            "96983520312774506326239578318016984801869478851843" +
                            "85861560789112949495459501737958331952853208805511" +
                            "12540698747158523863050715693290963295227443043557" +
                            "66896648950445244523161731856403098711121722383113" +
                            "62229893423380308135336276614282806444486645238749" +
                            "30358907296290491560440772390713810515859307960866" +
                            "70172427121883998797908792274921901699720888093776" +
                            "65727333001053367881220235421809751254540594752243" +
                            "52584907711670556013604839586446706324415722155397" +
                            "53697817977846174064955149290862569321978468622482" +
                            "83972241375657056057490261407972968652414535100474" +
                            "82166370484403199890008895243450658541227588666881" +
                            "16427171479924442928230863465674813919123162824586" +
                            "17866458359124566529476545682848912883142607690042" +
                            "24219022671055626321111109370544217506941658960408" +
                            "07198403850962455444362981230987879927244284909188" +
                            "84580156166097919133875499200524063689912560717606" +
                            "05886116467109405077541002256983155200055935729725" +
                            "71636269561882670428252483600823257530420752963450";
            char[] seriesChar = series.ToCharArray();
            int[] seriesInt = seriesChar.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            long largestProd = 0;
            for (int i = 0; i < seriesInt.Length - 13; i++)
            {
                long prod = 1;
                for (int j = i; j < i + 13; j++)
                {
                    prod *= seriesInt[j];
                }
                if (prod >= largestProd)
                {
                    largestProd = prod;
                }
            }
            Console.WriteLine("8 : Largest Product In A Series");
            Console.WriteLine(largestProd);
        }
        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a < b < c for which
        /// a^2 + b^2 = c^2
        /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// </summary>
        public void SpecialPythagoreanTriplet()
        {
            bool flag = false;
            long prod = 0;
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    for (int c = 0; c < 1000; c++)
                    {
                        if (a * a + b * b == c * c && a + b + c == 1000)
                        {
                            flag = true;
                            prod = a * b * c;
                            break;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            Console.WriteLine("9 : Special Pythagorean Triplet");
            Console.WriteLine(prod);
        }
    }
}
