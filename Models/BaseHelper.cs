namespace Algorithms_Visualization.Models
{
    public  class BaseHelper
    {
        protected  static List<int> _numbers;

        public static void SetNumbers(List<int> numbers){
            _numbers=numbers;
        }
        protected static void printNumbers(bool AfterSort,string Title){
            System.Console.WriteLine($"\n\n======================={((AfterSort)?"After":"Before")} {Title}=======================");
            foreach (var num in _numbers)
            {
                System.Console.Write(num+ "\t");
            }
            System.Console.WriteLine($"\n============================================================");

        }
        
        public static void  ThrowExep(string message){
        throw new InvalidCastException(message);

        }
        public static void ThrowNullException(){
            throw new Exception("Array should not be null Must be initilaized firstly");
        }

        protected static void Swapp(int ndx1,int ndx2){
            var temp=_numbers[ndx1];
            _numbers[ndx1]=_numbers[ndx2];
            _numbers[ndx2]=temp;
        }
        
    }
}