using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jabulani_Punk
{
    public class ExceptionService
    {
        public string ActionName { get; set; }
        public string Message { get; set; }
        public string Stacktrace { get; set; }
        public string ExceptionHelp { get; set; }

        public ExceptionService(Exception ex)
        {
            this.Message = ex.Message;
            this.ActionName = ex.TargetSite.Name;
            this.Stacktrace = ex.StackTrace.ToString().Substring(0, 20);
            this.ExceptionHelp = ex.HelpLink;
            writeOnfile();
        }

        /// <summary>
        /// writing the details of the exception to a log file
        /// </summary>
        private void writeOnfile()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "logErrors.txt"))
            {
                using (StreamWriter writer = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "logErrors.txt"))
                {
                    writer.WriteLine(string.Format("********Method name:{0}  Message:{1}  Stacktrace:{2}  ExceptionHelplink:{3} timestamp: {4}******", ActionName, Message, Stacktrace, ExceptionHelp, DateTime.Now));
                }
            }
            else
            {
                var filename = AppDomain.CurrentDomain.BaseDirectory + "logErrors.txt";
                using (StreamWriter writer = new StreamWriter(filename, true))
                {
                    writer.WriteLine(string.Format("********Method name:{0}  Message:{1}  Stacktrace:{2}  ExceptionHelplink:{3} timestamp: {4}******", ActionName, Message, Stacktrace, ExceptionHelp, DateTime.Now));
                }
            }

        }

        private void EmailException()
        {

        }
    }
}
