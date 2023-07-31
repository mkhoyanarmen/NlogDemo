using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    internal class Program
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 16;
                int c = b / a;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
