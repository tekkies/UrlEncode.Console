using System;
using System.Text;
using System.Web;

namespace UrlEncode.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder();
            var next = System.Console.Read();
            while (next != -1)
            {
                var ch = Convert.ToChar(next);
                stringBuilder.Append(ch);
                next = System.Console.Read();
            }
            var output = HttpUtility.UrlEncode(stringBuilder.ToString());
            System.Console.Write(output);
        }
    }
}