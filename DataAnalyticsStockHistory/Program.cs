/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * https://datahub.io/core/s-and-p-500-companies-financials
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace DataAnalyticsStockHistory
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Process() + " records processed.");
        }
        public static int Process() {
            Dictionary<String, CompanyFinancials> company = new Dictionary<string, CompanyFinancials>();
            int totalProcessed = 0;
            String[] data = File.ReadAllLines("..\\..\\data\\constituents-financials_csv.csv");
            // Each element of data is a line in the CSV file. The first element is the column headers, not data.
            int count = 0;
            foreach (String s in data) {
                if (count > 0) {
                    //Console.WriteLine(s);
                    String[] tmp = null;
                    try {
                        // ToDo: The split on comma doesn't work so well because there are commas in company names. 
                        // Those company names are enclosed in quotes so additional processing is needed. For now, there's a try/catch that
                        //  allows processing to continue and simply discards the companies that cannot be processed.
                       tmp = s.Split(',');
                        CompanyFinancials cf = new CompanyFinancials(tmp[0], tmp[1], tmp[2], Convert.ToDouble(tmp[3]), Convert.ToDouble(tmp[4]));
                        company.Add(cf.symbol, cf);
                        totalProcessed++;
                    } catch (Exception ex) {
                        try { Console.WriteLine("Could not add " + tmp[0]); } catch (Exception ex1){ }
                    }
                }
                count++;
            }
            return totalProcessed;
        }
    }
}
