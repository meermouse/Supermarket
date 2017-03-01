using System;

namespace Supermarket.Console
{
    public static class ErrorHandling
    {
        public static void ProcessException(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
