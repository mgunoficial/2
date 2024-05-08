using System;
using System.Security.Cryptography;

namespace ArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Arraydeki ededleri print etmek

            int[] arr = { 500, 0235, 4306, 4340,433535,-34,434,23 };


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            };

            //Arraydeki ededlerin cemini tapmaq


            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }


            Console.WriteLine(sum);


            //Arrayi tersine prin etmek


            for (int i = arr.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(arr[i]);
            }
            //Arrayi tersine cevirmek

            int[] newArr = new int[arr.Length];

            int j = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newArr[j] = arr[i];
                j++;
            };

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }



            //Arraydeki en boyuk elementi tapmaq

            var max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);


            //Arraydeki ededlerin sayini tapmaq

            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                count++;
            }

            Console.WriteLine(count);


            //Arrayi sort etmek

            var min = arr[0];
            var maximum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int a = 0; a < arr.Length; a++)
                {
                    if (min > arr[a])
                    {
                        min = arr[a];
                    }
                }


                for (int e = 0; e < arr.Length; e++)
                {
                    if (maximum < arr[e])
                    {
                        maximum = arr[e];
                    }
                }

                Console.WriteLine(min);

                for (int z = 0; z < arr.Length; z++)
                {
                    if (arr[z] == min)
                    {
                        arr[z] = maximum+1;
                    }
                }


                min = maximum;
            }





            //Arrayde 0 ededinden nece defe islendiyini tapmaq

            var counter = 0;
            string newStr;

            for (int i = 0; i < arr.Length; i++)
            {
                newStr = arr[i].ToString();

                for (int d = 0; d < newStr.Length; d++)
                {
                    if (newStr[d] == '0')
                        counter++;
                }
            }

            Console.WriteLine($"Count: {counter}");



            //Arrayde menfi ededlerin sayini tapmaq


            int[] array = { 345, 543, -234, -5, 32, -35, 23, -45, -52, 5 - 23, 532, 532, -23, 532 };


            var countNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    countNum++;
            }

            Console.WriteLine(countNum);


            //Arrayde musbet ededlerin cemini tapmaq


            var summer = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    summer += array[i];
            }

            Console.WriteLine(summer);



            //Arraydeki ededleri ozlerinin kvadtratina cevirmek


            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
                Console.WriteLine(array[i]);
            }


            //Arrayi coxdan aza sort etmek

            var max2 = 0;
            var hasNum = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int a = 0; a < arr.Length; a++)
                {
                    if (max2 < arr[a])
                    {
                        max2 = arr[a];
                    }
                }


                for (int z = 0; z < arr.Length; z++)
                {
                    if (arr[z] == max2)
                    {
                        arr[z] = 0;
                        hasNum = true;
                    }
                }

                if (hasNum)
                    Console.WriteLine(max2);

                max2 = 0;
            }
        }
    }
}
