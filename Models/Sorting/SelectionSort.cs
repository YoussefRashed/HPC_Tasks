namespace Algorithms_Visualization.Models.Sorting
{
    public class SelectionSort:BaseHelper
    {
        public static void Sort(){
            try
            {
                if(_numbers!=null){
                    printNumbers(false,"Selection Sort");
                        for (int i = 0; i < _numbers.Count ; i++)
                        {
                            int min=i;
                            for (int j = i; j < _numbers.Count ; j++){
                                if(_numbers[j]<_numbers[min]){
                                    min=j;
                                }
                            }
                            Swapp(min,i);
                            
                        }
                        printNumbers(true,"Selection Sort");
                }else{
                    ThrowNullException();
                }
            }
            catch (System.Exception ex)
            {
                
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine(ex.Message);
                Console.ForegroundColor=ConsoleColor.White;            }
        }
    }
}