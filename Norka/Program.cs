//#define loggingEnabled
using System;
using System.Windows.Forms;
using Norka.SplashScreen;


namespace Norka
{
    internal static class Program
    {
        private static log4net.ILog log;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
          

            log4net.Config.XmlConfigurator.Configure();
            //log = log4net.LogManager.GetLogger("Program");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Func.Func.FStart = new Form_Start();

            Application.Run(Func.Func.FStart);

#if loggingEnabled
log.Info("Applikation gestartet");
#endif




#if loggingEnabled
  log.Info("Applikation beendet");
#endif

        }



    }
}