using Algorithms_Visualization.Models;
using Algorithms_Visualization.Models.Search;
using Algorithms_Visualization.Models.Sorting;

namespace Algorithms_Visualization.Application
{
    public class AlgorithmsModule : BaseHelper
    {
        private List<int> UserNumbers = new();

        public  void StartApp(){
            System.Console.WriteLine("\n\n======================== Welcome ========================\n\n");

            System.Console.WriteLine("How many numbers You wish to add ?");

            var size = int.Parse(Console.ReadLine());

            try
            {
                if (size <= 0)
                {
                    ThrowExep("Sorry Size must be equal or more than 1");
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        System.Console.WriteLine($"Enter The {i + 1} number : ");
                        UserNumbers.Add(int.Parse(Console.ReadLine()));
                    }

                    System.Console.WriteLine("\nAll done, Your List now is ready to be used");
                    bool another_Operation = true;
                    while (another_Operation)
                    {
                        Operations();
                        System.Console.WriteLine("Another Operation on the same List ? [Default]=Y (Y/n)");
                        var answer = Console.ReadLine();
                        if (!answer.ToLower().StartsWith("y")&& !string.IsNullOrEmpty( answer))
                        {
                            another_Operation = false;
                        }

                        Console.Clear();



                    }

                }
            }
            catch (System.Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        private void Operations()
        {
            List<string> options = new(){
                    "1) Check Element Existance using Binary Search ?",
                    "2) Check Element Existance using Linear Search ?",
                    "3) Sorting List using Selection Sort?",
                    "4) Sorting List using Bubble Sort?",
                    "5) Sorting List using Insertion Sort?",
                };

            System.Console.WriteLine("What do you wish to do in this List");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in options)
            {
                System.Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ExecuteBinarySearch();
                    break;

                case 2:
                    ExecuteLinearSearch();
                    break;
                case 3:
                    ExecuteSelectionSort();
                    break;
                case 4:
                    ExecuteBubbleSort();
                    break;
                case 5:
                    ExecuteInsertionSort();
                    break;


                default:
                    System.Console.WriteLine("Invalid option");
                    break;
            }
        }

        private void ExecuteLinearSearch()
        {
            LinearSearch.SetNumbers(UserNumbers);

            System.Console.WriteLine("Enetr The Key You  want to check :");

            int key = int.Parse(Console.ReadLine());

            LinearSearch.isExist(key);
            if (LinearSearch.isExist(key))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Element is founded");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Element is not founded");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void ExecuteBinarySearch()
        {
            BinarySearch.SetNumbers(UserNumbers);
            System.Console.WriteLine("Enetr The Key You  want to check :");

            int key = int.Parse(Console.ReadLine());
            if (BinarySearch.isExist(key))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Element is founded");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Element is not founded");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }


        private void ExecuteSelectionSort()
        {
            SelectionSort.SetNumbers(UserNumbers);
            SelectionSort.Sort();
        }


        private void ExecuteBubbleSort()
        {
            BubbleSort.SetNumbers(UserNumbers);
            BubbleSort.Sort();
        }

        private void ExecuteInsertionSort()
        {
            InsertionSort.SetNumbers(UserNumbers);
            InsertionSort.Sort();
        }

    }
}