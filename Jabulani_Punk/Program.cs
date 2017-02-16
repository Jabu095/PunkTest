using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Jabulani_Punk
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "DebitOrders.xml");
                var _debitorders = XmlToObject<debitorders>.GetXmlObject(xmlDoc.GetString(), typeof(debitorders));

                OutputAllBanksSummary(_debitorders);
                OutPutBank(_debitorders);
                Console.WriteLine("Check the files on this url "+ AppDomain.CurrentDomain.BaseDirectory);

                var readCons = Console.ReadLine();
            }
            catch (Exception ex)
            {
                new ExceptionService(ex);
            }
          

        }

        static void OutputAllBanksSummary(debitorders _debitorders)
        {
            /*Grouping the same banks*/
            var Banks = debitordersDeductions(_debitorders).GroupBy(x => x.bankname);

            /*writing the results to a text file*/
            foreach (var subBank in Banks)
            {
                using (StreamWriter sr = new StreamWriter("BankSheet.txt", true))
                {
                    sr.WriteLine(subBank.Key);
                    foreach (var bank in subBank)
                    {
                        sr.WriteLine(string.Format("{0}         {1}", bank.accountholder, bank.accountnumber));
                    }
                    sr.WriteLine("");
                }

            }
        }
        /// <summary>
        /// Method to return a collection of all the debitors
        /// </summary>
        /// <param name="_debitorders"></param>
        /// <returns></returns>
        static List<debitordersDeduction> debitordersDeductions(debitorders _debitorders)
        {
            var Banks = _debitorders.deduction.ToList();

            return Banks;
        }

        /// <summary>
        /// creating a method to out file for each bank
        /// </summary>
        /// <param name="_debitorders"></param>
        static void OutPutBank(debitorders _debitorders)
        {
            var Banks = debitordersDeductions(_debitorders).GroupBy(x => x.bankname);

            foreach (var subBank in Banks)
            {
                using (StreamWriter sr = new StreamWriter(subBank.Key+".txt"))
                {
                    var TotalAmount = subBank.Sum(x => x.amount);
                    sr.WriteLine(subBank.Key+"  "+TotalAmount);
                    foreach (var bank in subBank)
                    {
                        sr.WriteLine(string.Format("{0}    {1}  {2}   {3}   {4}", bank.accountholder, bank.accountnumber, bank.amount, bank.date, bank.accounttype));
                    }
                    sr.WriteLine("");
                }

            }
        }


    }
}
