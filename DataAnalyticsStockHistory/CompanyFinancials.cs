/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * https://datahub.io/core/s-and-p-500-companies-financials
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAnalyticsStockHistory
{
    class CompanyFinancials
    {
        public CompanyFinancials(String symbol, String name, String sector, double price, double priceEarnings) {
            this.symbol = symbol;
            this.name = name;
            this.price = price;
            this.priceEarnings = priceEarnings;
        }

        public CompanyFinancials(String symbol, String name, String sector, double price, double priceEarnings, 
                                 double dividendYield, double earningsPerShare, 
                                 double fiftyTwoWeekLow, double fiftyTwoWeekHigh, double marketCap,
                                 double EBITDA, double priceSales,double priceBook, String secFiling) {
            this.symbol = symbol;
            this.name = name;
            this.sector = sector;
            this.price = price;
            this.priceEarnings = priceEarnings;
            this.dividendYield = dividendYield;
            this.earningsPerShare = earningsPerShare;
            this.fiftyTwoWeekHigh = fiftyTwoWeekHigh;
            this.fiftyTwoWeekLow = fiftyTwoWeekLow;
            this.marketCap = marketCap;
            this.EBIDTA = EBIDTA;
            this.priceSales = priceSales;
            this.priceBook = priceBook;
            this.secFiling = secFiling;
        }
        // Symbol,Name,Sector,Price,Price/Earnings,Dividend Yield,Earnings/Share,
        //52 Week Low,52 Week High,Market Cap,EBITDA,Price/Sales,Price/Book,SEC Filings
        public String symbol { get; set; }
        public String name { get; set; }
        public String sector { get; set; }
        public double price { get; set; }
        public double priceEarnings { get; set; }
        public double dividendYield { get; set; }
        public double earningsPerShare { get; set; }
        public double fiftyTwoWeekLow { get; set; }
        public double fiftyTwoWeekHigh { get; set; }
        public double marketCap { get; set; }
        public double EBIDTA { get; set; }
        public double priceSales { get; set; }
        public double priceBook { get; set; }
        public String secFiling { get; set; }

        public override String ToString() { return symbol + ": " + name; }
    }
}
