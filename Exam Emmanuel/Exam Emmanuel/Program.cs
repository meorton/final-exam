using System;

namespace Exam_Emmanuel
{
    class Program
    {
        static void Main(string[] args)
        {



            //display name and date ------------ question 1
            GetMyInfo();


            //character lenght  ------------ question 2
            GetCharacter();

           


            //even or odd number ------------ question 3
            GetevenOdd();

            //count to 10 ------------ question 4
            Getcount();


            //mutiply, add  ------------ question 5
            GetMath();

            //gets day of week from date (hard coded value) ------------ question 6
            Getdayofweek();


            //gets positive and negative number ------------ question 7
            Getpositivenegative();


            //convert all user input to uppercase  ------------ question 8
            Getuppercase();

            //combine arrays ------------ question 9
            Getcombinearr();

 
            // gets factoria of user input  ------------ question 10
            GetFactoria();

            Console.WriteLine("\n");
            Console.WriteLine("Program completed press any key to exit");
            Console.ReadKey();

        }




        private static void GetMyInfo()

        {

            try

            {
              
               Console.Write("name and date output" + "\n");
                String name;
                Console.WriteLine("Enter Name:");

                name = Console.ReadLine();



                DateTime now = DateTime.Now;
                Console.WriteLine(name + " \t" + now.ToString("MM/dd/yyyy HH:mm"));

                //Console.WriteLine("Your name date and time is: ", name);


            }


            catch (Exception e) {


                Console.WriteLine("execption is", e);


            }

        }






        private static void GetCharacter()

        {

            try

            {


                string str;
                int i, len, a, b;
                Console.Write("To check the lenght of character and space input from user :\n");
                Console.Write("Enter strings or words :\n");
                Console.Write("----------------------------------------------\n");

                str = Console.ReadLine();

                a = 0;
                b = 0;
                len = str.Length;


                for (i = 0; i < len; i++)
                {
                    if ((str[i] >= ' ' && str[i] <= ' ') || (str[i] >= ' ' && str[i] <= ' '))
                    {
                        a++;
                    }

                    else
                        b++;
                }

                int total;

                total =a + b;

                Console.Write("\nThe total number of  string and spaces are : {0}\n", total);
              

            }


            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }





        private static void GetevenOdd()

        {

            try

            {



                int e;

                Console.Write("\n ");
                Console.Write("\n ");
                Console.Write("Check even or odd number" + "\n");
                Console.Write("Enter Value : ");
                e = int.Parse(Console.ReadLine());
                if (e % 2 == 0)
                {
                    Console.WriteLine("this number is an:" + "\t" + "Even Number");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("this number is an :" + "\t" + "Odd Number");
                    Console.Read();
                }



            }


            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }





        private static void Getcount()

        {

            try

            {
                Console.Write( "\n");
                Console.Write("Counting to 10 output"+"\n");

                int i = 1;

                while (i < 11)
                {

                  
                    Console.Write(i.ToString() + " ");

                    i++;
                }



            }


            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }





        private static void GetMath()

        {

            try

            {

                

                int Num1, Num2, output;
                char option;
                Console.Write("\n");

                Console.WriteLine("math calculation");
                Console.Write("Enter the First Number : ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Second Number : ");
                Num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose action to perform");
                Console.WriteLine("1. ADD;");
                Console.WriteLine("2. MULTIPLY");
                Console.Write("Enter the option from the above list to perform the task: ");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        output = Num1 + Num2;
                        Console.WriteLine("The result of Addition is : {0}", output);
                        break;
                    case '2':
                        output = Num1 * Num2;
                        Console.WriteLine("The result of Subtraction is : {0}", output);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.ReadLine();
           

            }


            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }





        private static void Getdayofweek()

        {

            try

            {


                //int val1;

                //Console.WriteLine("enter date in this format (yyyy mm dd");
                //val1 = Convert.ToChar(Console.ReadLine());
                //DateTime dt = new DateTime(val1);


                //Console.WriteLine("\n");

                
                DateTime dt = new DateTime(2019, 06, 07);
                
                Console.WriteLine("\n");
                Console.WriteLine("Day of the week with hard coded value");
                Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);


            }


            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }




        private static void Getpositivenegative()

        {

            try

            {


                int num;
                Console.Write("\n\n");
                Console.Write("Check whether a number is positive or negative:\n");
                Console.Write("----------------------------------------------");
                Console.Write("\n\n");
                Console.Write("Input an integer : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)

                    Console.WriteLine("{0} is a positive number.\n", num);
                else
                    Console.WriteLine("{0} is a negative number. \n", num);
            


            }


            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }



        private static void Getuppercase()

        {

            try

            {


                String val;
                Console.Write("\n\n");
                Console.Write("convert all user input to uppercase :\n");
                Console.Write("----------------------------------------------");
                Console.Write("\n\n");
                Console.Write("Enter character: ");
                val = (Console.ReadLine());

                

                string upperstr1 = val.ToUpper();

                Console.WriteLine(upperstr1);

                //Console.WriteLine(num.ToUpperInvariant);


            }

            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }




        private static void Getcombinearr()

        {

            try

            {


               
                int[] arr1 = new int[80];
                int[] arr2 = new int[80];
                int[] arr3 = new int[200];
                int val1, val2, sol;
                int i, j, k, val;

              
                Console.Write("\n\n");
                Console.Write("Combine array of user input:\n");
                Console.Write("----------------------------------------------");
                Console.Write("\n\n");

                Console.Write("Enter how many values would be stored in array 1:");
                val1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("You Input {0} elements to be stored in array 1 :\n", val1);
                for (i = 0; i < val1; i++)
                {
                    Console.Write("enter array value - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }


                Console.Write("Enter how many values would be stored in array 2:");
                val2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("You Input {0} elements to be stored in array 2 :\n", val2);
                for (i = 0; i < val2; i++)
                {
                    Console.Write("enter array value  - {0} : ", i);
                    arr2[i] = Convert.ToInt32(Console.ReadLine());
                }

              
                sol = val1 + val2;

               
                for (i = 0; i < val1; i++)
                {
                    arr3[i] = arr1[i];
                }
                for (j = 0; j < val2; j++)
                {
                    arr3[i] = arr2[j];
                    i++;
                }
             
                for (i = 0; i < sol; i++)
                {
                    for (k = 0; k < sol - 1; k++)
                    {

                        if (arr3[k] >= arr3[k + 1])
                        {
                            j = arr3[k + 1];
                            arr3[k + 1] = arr3[k];
                            arr3[k] = j;
                        }
                    }
                }
                
                Console.Write("\narray sorted and merge output :\n");
                for (i = 0; i < sol; i++)
                {
                    Console.Write("{0} ", arr3[i]);
                }
                Console.Write("\n\n");
            


            }

            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }



        private static void GetFactoria()

        {

            try

            {


                Console.Write("\n\n");
                Console.Write("Calculates factoria of user input :\n");
                Console.Write("----------------------------------------------");
                Console.Write("\n\n");


                int x, cal = 1, number;
                Console.Write("Enter Integer Number: ");
                number = int.Parse(Console.ReadLine());
                for (x = 1; x <= number; x++)
                {
                    cal = cal * x;
                }
                Console.Write("Factorial of " + number + " is: " + cal);



            }

            catch (Exception e)
            {


                Console.WriteLine("execption is", e);


            }

        }










    }
}






