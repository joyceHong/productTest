using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace productTest
{
    public interface IProductCore
    {
        List<int> Sum<T>(List<T> numbers, string columnName, int maxCount);
    }

    public class ProductCore:IProductCore
    {

        public List<int> Sum<T>(List<T> numbers, string columnName, int maxCount)
        {
            List<int> result = new List<int>();
            var number = 0;
            var sum = 0;
            var counter = 0;
            numbers.ForEach(n =>
            {
                number =(int) n.GetType().GetProperty(columnName).GetValue(n, null);

                sum += number;
                ++counter;

                if (counter == maxCount)
                {
                    result.Add(sum);
                    counter = 0;
                    sum = 0;
                }
            });

            if (numbers.Count % maxCount != 0) {
                result.Add(sum);
            }
            
            return result;
        }
    }

    public class Product
    {
        public int id { get; set; }
        public int cost { get; set; }
        public int revenue { get; set; }
        public int sellPrice { get; set; }
     
    }
}
