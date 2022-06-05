namespace CabInvoice
{
    internal class InvoiceSummary
    {
        private int length;
        private double totalFare;

        public InvoiceSummary(int length, double totalFare)
        {
            this.length = length;
            this.totalFare = totalFare;
        }
    }

}