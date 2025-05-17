using System;
using System.IO;
namespace MathLibrary
{
    public class MathOperations
    {
        private static readonly string logFilePath = "log.txt";
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                LogError("Cannot divide by zero.");
                return double.NaN;
            }
            return (double)a / b;
        }
        private void LogError(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}