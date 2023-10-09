namespace Algorithms_Visualization.Models.Sorting
{
    public class BubbleSort : BaseHelper
    {
        public static void Sort()
        {
            try
            {
                if (_numbers.Any())
                {
                    printNumbers(false, "Bubble Sort");

                    for (int i = 0; i < _numbers.Count; i++)
                    {
                        for (int j = 0; j < _numbers.Count - 1; j++)
                        {
                            if (_numbers[j] > _numbers[j + 1])
                            {
                                Swapp(j, j + 1);
                            }
                        }
                    }
                    printNumbers(true, "Bubble Sort");
                }
                else
                {
                    ThrowNullException();
                }
            }
            catch (System.Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}