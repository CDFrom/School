using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    abstract class Case //Base class
    {
        public abstract void test();
    } //end of Case

    class Case1 : Case //Showing OutOfMemoryException
    {
        public override void test()
        {
            List<int> test = new List<int>();
            Random r = new Random();
            
            Console.WriteLine("Please hold...");

            while (true)
            {
                test.Add(r.Next());
            }
        }
    } //End of Case1

    class Case2 : Case //Showing IndexOutOfRangeException
    {
        public override void test()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr[5]);
        }
    } //End of Case2

    class Case3 : Case //Showing FileNotFoundException
    {
        public override void test()
        {
            StreamReader sr = new StreamReader("test.txt");
        }
    } //End of Case3

    class Case4 : Case //Showing KeyNotFoundException
    {
        public override void test()
        {
            Dictionary<string, int> test = new Dictionary<string, int>();
            test.Add("Mouse", 1);
            test.Add("Dog", 2);
            test.Add("Cat", 3);
            test.Add("Hippo", 4);

            Console.WriteLine(test["Hippopotamus"]);
        }

    } //End of Case4

    class Case5 : Case //Showing InvalidOperationException
    {
        public override void test()
        {
            List<int> test = new List<int>();
            test.Add(1);
            int oldNum = 1;
            foreach (var num in test)
            {
                int newNum = num + oldNum;
                oldNum = num;
                test.Add(newNum);
            }
        }
    } //End of Case5

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Case test;
            Exception error = null; //Storing the error for more info upon request

            while ((input = Console.ReadLine()) != "exit") //To store input and exit application
            {
                if (int.TryParse(input, out int testCase)) //Checking input is an integer
                {
                    bool leaveFinal = false; //For the finally block, if 1-5 is not picked we set to true

                    try
                    {
                        switch (testCase)
                        {
                            case 1:
                                test = new Case1();
                                test.test();
                                break;
                            case 2:
                                test = new Case2();
                                test.test();
                                break;
                            case 3:
                                test = new Case3();
                                test.test();
                                break;
                            case 4:
                                test = new Case4();
                                test.test();
                                break;
                            case 5:
                                test = new Case5();
                                test.test();
                                break;
                            default:
                                Console.WriteLine("Please enter a value between 1 and 5");
                                leaveFinal = true; //Do nothing in the finally block
                                break;
                        }
                    }//End of try block
                    catch(OutOfMemoryException outOfMemory)
                    {
                        Console.WriteLine(outOfMemory.Message);
                        error = outOfMemory; //Pass the error to give more detail
                    }
                    catch(IndexOutOfRangeException outOfRange)
                    {
                        Console.WriteLine(outOfRange.Message);
                        error = outOfRange; //Pass the error to give more detail
                    }
                    catch(FileNotFoundException fileNotFound)
                    {
                        Console.WriteLine(fileNotFound.Message);
                        error = fileNotFound; //Pass the error to give more detail
                    }
                    catch(KeyNotFoundException keyNotFound)
                    {
                        Console.WriteLine(keyNotFound.Message);
                        error = keyNotFound; //Pass the error to give more detail
                    }
                    catch(InvalidOperationException invalidOperation)
                    {
                        Console.WriteLine(invalidOperation.Message);
                        error = invalidOperation; //Pass the error to give more detail
                    }
                    catch(IOException inputOutputE)
                    {
                        Console.WriteLine(inputOutputE.Message);
                        error = inputOutputE; //Pass the error to give more detail
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        error = e; //Pass the error to give more detail
                    }
                    finally
                    {
                        string errorInput;

                        while(!leaveFinal)
                        {
                            Console.WriteLine("Would you like more detail? (y/n)");
                            errorInput = Console.ReadLine();

                            if (errorInput == "y")
                            {
                                Console.WriteLine(error);
                                break;
                            }
                            else if (errorInput == "n")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter y/n...");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 5...");
                }
            }
        }
    }
}
