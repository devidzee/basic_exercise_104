using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic_exe_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int number_1;

            Console.WriteLine("input first number: ");

            number_1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number_1, i, number_1 * i);

                        }*/



            /*
                        int num_1 = 0;
                        int num_2 = 0;
                        int num_3 = 0;
                        int num_4 = 0;


                        for (int i = 0; i < 4; i++)
                        {

                            Console.WriteLine("enter {0} st number", i+1);


                            if (i == 0)
                            {
                                num_1 = int.Parse(Console.ReadLine());
                            }
                            else if (i == 1)
                            {
                                num_2 = int.Parse(Console.ReadLine());
                            }
                            else if (i == 2)
                            {
                                num_3 = int.Parse(Console.ReadLine());
                            }
                            else if (i == 3)
                            {
                                num_4 = int.Parse(Console.ReadLine());
                            }

                        }

                        int average = (num_1 + num_2 + num_3 + num_4) / 4;

                        Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", num_1, num_2, num_3, num_4, average);
            */


            /*            
                        int num_x = 0;
                        int num_y = 0;
                        int num_z = 0;

                        Console.WriteLine("enter first number: ");
                        num_x = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter second number: ");
                        num_y = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter third number: ");
                        num_z = int.Parse(Console.ReadLine());

                        int result_1, result_2;

                        result_1 = (num_x + num_y) * num_z;
                        result_2 = (num_x * num_y) + (num_y * num_z);


                        Console.WriteLine("result of specified numbers {0}, {1}, {2}, (x + y) * z is {3} and (x * y) + (y * z) is {4}", num_x, num_y, num_z, result_1, result_2);
            */

            /*
                        Console.WriteLine("enter your age: ");
                        int age = 0;
                        age = int.Parse(Console.ReadLine());

                        if (age < 25)
                        {
                            Console.WriteLine("you look older than " + age);

                        }
                        else if (age == 25)
                        {
                            Console.WriteLine("you look exactly " + age);

                        }
                        else if (age > 25)
                        {
                            Console.WriteLine("you look younger than " + age);
                        }

            */



            /* int number_1;
             Console.WriteLine("enter number: ");
             number_1 = int.Parse(Console.ReadLine());


             for (int i = 0; i < 2; i++)
             {
                 Console.WriteLine("{0} {0} {0} {0}", number_1);
                 Console.WriteLine("{0}{0}{0}{0}", number_1);

             }*/

            /*
                        int celsius = 0;
                        int kelvin = 0;
                        double farhenheit = 0;

                        Console.WriteLine("enter amount of celsius: ");
                        celsius = int.Parse(Console.ReadLine());


                        kelvin = celsius + 273;
                        farhenheit = celsius * 1.8 + 32;

                        Console.WriteLine("kelvin = {0}", kelvin);
                        Console.WriteLine("farhenhait = {0}", farhenheit);

            */

            // Strings

            /*            string my_str = "ereklenika";

                        Console.WriteLine("string length = " + my_str.Length);

                        Console.WriteLine(my_str.ToUpper());
                        Console.WriteLine(my_str.ToLower());*/


            /*
                        string name = "erekle ";
                        string surname = "deviodze";

                        string fullname = string.Concat(name, surname);

                        Console.WriteLine(fullname);
            */



            /* string str_1 = "nika";
               string str_2 = "gelashvils";

               string fullname = $"his full name is {str_1} {str_2}";



               Console.WriteLine(fullname);

   */
            /*
                        string str_1 = "nika";
                        string str_2 = "gelashvils";

                        Console.WriteLine(str_2[4]);

            */

            /*   string str_1 = "ereklenika";

               Console.WriteLine(str_1.IndexOf("e"));

   */

            /*

                        string str_1 = "nika3erekle";


                        string str_out = str_1.Remove(4, 0);

                        Console.WriteLine(str_out);


            */



            /*      string str_1 = Console.ReadLine();
                  string str_2 = "";

                  char first_char = str_1[0];

                  str_2 = first_char + str_1 + first_char;

                  Console.WriteLine(str_2);


      */
            /*
                        while (true) {

                            string str_1 = Console.ReadLine();

                            string str_2 = str_1.Substring(3);

                            Console.WriteLine(str_2);
                        }

            */


            /*   int int_1 = int.Parse(Console.ReadLine());
               int int_2 = int.Parse(Console.ReadLine());


               bool result;

               result = Method_1(int_1, int_2);

               Console.WriteLine(result);


   */


            /*
                        int number_1 = int.Parse(Console.ReadLine());
                        int number_2 = int.Parse(Console.ReadLine());


                        Console.WriteLine(Method_2(number_1, number_2));

            */









            /*
                        int number_1 = int.Parse(Console.ReadLine());
                        int number_1_distance = 0;
                        int number_2 = int.Parse(Console.ReadLine());
                        int number_2_distance = 0;

                        int distance_1 = 0;
                        int distance_2 = 0;
                        int distance_3 = 0;


                        if (number_1 < 0 && number_2 > 0)
                        {
                            distance_1 = number_2 - number_1;
                            Console.WriteLine(distance_1);
                        }
                        else if (number_1 > 0 && number_2 < 0)
                        {
                            distance_1 = number_1 - number_2;
                            Console.WriteLine(distance_1);
                        }
                        else if (number_1 > 0 && number_2 > 0)
                        {
                            Console.WriteLine(Distance_positives(number_1, number_2));
                        }
                        else if (number_1 < 0 && number_2 < 0)
                        {
                            Console.WriteLine(Distance_negatives(number_1, number_2));
                        }
                        else if (number_1 == 0 && (number_2 < 0 || number_2 > 0))
                        {
                            Console.WriteLine(Distance_num_1_0(number_1, number_2));
                        }
                        else if (number_2 == 0 && (number_1 < 0 || number_1 > 0))
                        {
                            Console.WriteLine(Distance_num_2_0(number_1, number_2));
                        }
                        else if (number_1 == number_2)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(0);
                        }
            */


            /*
                        string str_1 = "EREKLE";
                        string str_2 = "erekle";

                        Console.WriteLine(str_1.ToLower());
                        Console.WriteLine(str_2.ToUpper());
            */





            /*
                        string string_1 = "qaris sastveni var sulshi mefatureba sheni tvalebi rhameshi menatureba";

                        char space_1 = ' ';
                        string[] words = string_1.Split(space_1);

                        foreach (string i in words)
                        {
                            Console.WriteLine(i);
                        }


                        Console.WriteLine("___________________________________");


                        int length_1 = 0;
                        int index_1 = 0;

                        for (int i = 0; i < words.Length; i++)
                        {
                            if (words[i].Length > length_1)
                            {
                                length_1 = words[i].Length;
                                index_1 = i;
                            }
                        }

                        Console.WriteLine(length_1);
                        Console.WriteLine(words[index_1]);

            */

            /*

                        for (int i = 1; i <= 99; i+= 2)
                        {
                            Console.WriteLine(i);
                        }
            */

            /*
                        int number = 5;
                        int sum = 0;
                        int count = 0;
                        int temp_num = 0;


                        while (count < 10)
                        {

                            temp_num = number - 1;

                            while (temp_num > 1)
                            {

                                if (number % temp_num == 0)
                                {

                                    break;
                                }

                                temp_num--;


                            }

                            sum += number;
                            count += 1;



                        }

                        Console.WriteLine(sum);
                        Console.WriteLine(count);

            */


            /*

                        int number_1 = 0;
                        int temp_1 = 0;
                        int sum_1 = 0;

                        number_1 = int.Parse(Console.ReadLine());


                        // Console.WriteLine(number_1 % 10);
                        // Console.WriteLine(number_1 / 10);


                        while (true)
                        {

                            if (number_1 == 0)
                            {
                                break;
                            }
                            else
                            {

                                temp_1 = number_1 % 10;
                                sum_1 += temp_1;
                                number_1 = number_1 / 10;


                            }

                        }

                        Console.WriteLine(sum_1);

                        */

            /*

                        N 28


                        string[] temp_words = { };
                        char space_1 = ' ';
                        string str_1;
                        str_1 = Console.ReadLine();


                        temp_words = str_1.Split(space_1);



                        int array_len = 0;
                        array_len = temp_words.Length;


                        string[] reverse_words = new string[array_len];


                        for (int i = 0; i < temp_words.Length; i++)
                        {

                            string elemet = temp_words[i];

                            reverse_words[array_len - 1] = elemet;

                            array_len -= 1;


                        }


                        string result_string = "";

                        foreach (string i in reverse_words)
                        {
                            result_string = result_string + i + " ";
                        }


                        Console.WriteLine(result_string);

            */





            Console.WriteLine("input array length: ");
            int array_len = int.Parse(Console.ReadLine());
            


            int[] array_1 = new int[array_len];
            int[] array_2 = new int[array_len];


            int element = 0;

            

            for (int i = 0; i< array_1.Length; i++)
            {

                Console.WriteLine("input {0} element for array 1: ", i+1);
                element = int.Parse(Console.ReadLine());

                array_1[i] = element;
            }


            for (int i = 0; i < array_2.Length; i++)
            {

                Console.WriteLine("input {0} element for array 2: ", i+1);
                element = int.Parse(Console.ReadLine());

                array_2[i] = element;
            }


            int mul = 0;
            int[] result_array = new int[array_len];

            for (int i = 0; i < result_array.Length; i++)
            {

                mul = array_1[i] * array_2[i];
                result_array[i] = mul;

            }

            foreach (int i in result_array)
            {
                Console.WriteLine(i);

            }























        }


        static bool Method_1(int num_1, int num_2)
        {

            if (num_1 < 0 && num_2 > 0)
            {
                return true;
            }
            else if (num_1 > 0 && num_2 < 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        static int Method_2(int num_1, int num_2)
        {

            if (num_1 == num_2)
            {
                return (num_1 + num_2) * 3;
            }
            else
            {
                return num_1 + num_2;

            }

        }


        static int Distance_positives(int num_1, int num_2)
        {

            if (num_1 == num_2)
            {
                return 0;
            }
            else if (num_1 > num_2)
            {
                return num_1 - num_2;
            }
            else
            {
                return num_2 - num_1;
            }


        }

        static int Distance_negatives(int num_1, int num_2)
        {

            if (num_1 == num_2)
            {
                return 0;
            }
            else if (num_1 > num_2)
            {
                return num_1 - num_2;
            }
            else
            {
                return num_2 - num_1;
            }


        }


        static int Distance_num_1_0(int int_1, int int_2)
        {

            if (int_2 > 0)
            {
                int_2 = 0 - int_2;

                return int_1 - int_2;
                
            }
            else
            {
                return int_1 - int_2;
            }

        }

        static int Distance_num_2_0(int int_1, int int_2)
        {
            if (int_1 > 0)
            {
                int_1 = 0 - int_1;

                return int_2 - int_1;
            }
            else
            {
                return int_2 - int_1;
            }

        }












    }
}
