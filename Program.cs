using System;
using System.Text;
using System.Web;

namespace UrlEncode.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var accumulator = new StringBuilder();
            var read = System.Console.Read();
            while (read != -1)
            {
                accumulator.Append(Convert.ToChar(read));
                read = System.Console.Read();
            }
            var output = HttpUtility.UrlEncode(accumulator.ToString().Trim());
            System.Console.Write(output);
        }
    }
}