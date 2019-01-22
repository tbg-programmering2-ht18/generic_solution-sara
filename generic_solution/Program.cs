using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_solution
{
    public class DataSample<T>
    {
        private T theData;

        public DataSample(T theData)
            {
                this.theData = theData;
            }

        public T GetData()
        {
            return theData;
        }

        public String MyToString()
        {
            return theData.ToString();
        }

        public static T getMiddleElement(T[] arr)
        {
            T element = arr[arr.Length / 2];
            return element;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            DataSample<String> dss = new DataSample<string>("Forty-two");
            DataSample<int> dsi = new DataSample<int>(42);

            String s = dss.GetData();
            int i = dsi.GetData();

            String[] words = { "C++", "MacOS", "C#", "Android", "Python" };
            String middle = DataSample<String>.getMiddleElement(words);

            Console.WriteLine(String.Format("s={0}, i={1}  and middle={2}", s, i, middle));
            Console.ReadKey();
        }
    }
}
