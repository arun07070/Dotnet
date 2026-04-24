using System;

namespace SalesProgram
{
    class SalesBase
    {
        protected int salesNo;
        protected int productNo;
        protected double price;
        protected int qty;
        protected string dateOfSale;

        public SalesBase(int salesNo, int productNo, double price, int qty, string dateOfSale)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;
        }
    }
    class SaleDetails : SalesBase
    {
        double totalAmount;

        public SaleDetails(int salesNo, int productNo, double price, int qty, string dateOfSale)
            : base(salesNo, productNo, price, qty, dateOfSale) { }

        public void Sales()
        {
            totalAmount = qty * price;
        }

        public void ShowData()
        {
            Console.WriteLine("\n--- Sales Details ---");
            Console.WriteLine($"Sales No: {salesNo}");
            Console.WriteLine($"Product No: {productNo}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Qty: {qty}");
            Console.WriteLine($"Date: {dateOfSale}");
            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }
    class Program
    {
        static void Main()
        {
            SaleDetails sale = new SaleDetails(1, 1001, 500, 3, "02-04-2026");
            sale.Sales();
            sale.ShowData();
        }
    }
}