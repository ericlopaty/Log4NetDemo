using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4NetDemo
{
    class Program
    {
        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Log.Info("Application Starting");
            try
            {
                Log.Debug("Start of Try block");
                // do some work
                Log.Debug("End of Try block");
            }
            catch (Exception ex)
            {
                Log.Error("Error caught", ex);
            }
            Pause("Done");
            Log.Info("Application Ending");
        }

        public static void Pause(string message)
        {
            Console.Write(message);
            Console.ReadLine();
        }
    }
}
