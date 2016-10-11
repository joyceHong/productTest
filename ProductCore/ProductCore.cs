using System.Collections.Generic;

namespace productTest
{
    public class ProductCore
    {
        public List<int> Sum<T>(List<T> numbers, string columnName, int maxCount)
        {
            List<int> result = new List<int>();
            var number = 0;
            var sum = 0;
            var counter = 0;
            numbers.ForEach(n =>
            {
                number = (int)n.GetType().GetProperty(columnName).GetValue(n, null);

                sum += number;
                ++counter;

                if (counter == maxCount)
                {
                    result.Add(sum);
                    counter = 0;
                    sum = 0;
                }
            });

            if (numbers.Count % maxCount != 0)
            {
                result.Add(sum);
            }

            return result;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}