namespace Algorithms_Visualization.Models.Search
{
    public class BinarySearch : BaseHelper
    {
        private static void CheckIfSorted()
        {
            int ele = _numbers[0];
            for (int n = 1; n < _numbers.Count; n++)
            {
                if (ele > _numbers[n])
                {
                    ThrowExep("The List you entered is not sorted so we can not apply  Binary Search on it");
                }
                else
                {
                    ele = _numbers[n];
                }
            }
        }
        public static bool isExist(int key)
        {
            try
            {
                CheckIfSorted();
                int start = 0;
                int end = _numbers.Count;

                while (end >= start)
                {
                    int mid = (start + end) / 2;
                    if (_numbers[mid] == key) { return true; }
                    else if (_numbers[mid] < key)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine(ex.Message);
                Console.ForegroundColor=ConsoleColor.White;
            }
                return false;


        }
    }
}