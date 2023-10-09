namespace Algorithms_Visualization.Models.Sorting
{
    public class InsertionSort : BaseHelper
    {
        public static void Sort()
        {
            try
            {
                if (_numbers.Any())
                {
                    printNumbers(false, "Insertion Sort");
                    for (int i = 1; i < _numbers.Count; ++i)
                    {
                        int key = _numbers[i];
                        int j = i - 1;

                        while (j >= 0 && _numbers[j] > key)
                        {
                            _numbers[j + 1] = _numbers[j];
                            j = j - 1;
                        }
                        _numbers[j + 1] = key;
                    }
                    printNumbers(true, "Insertion Sort");
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