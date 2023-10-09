using Algorithms_Visualization.Models;

namespace Algorithms_Visualization.Models.Search
{
    public  class LinearSearch:BaseHelper
    {
        public static bool isExist(int key){
            foreach (var number in _numbers)
            {
                if(number==key){return true;}
            }
            return false;
        }
    }
}