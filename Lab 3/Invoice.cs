namespace Lab_3;

public class Invoice
{
    public int CustomerNumber { get; }
    public int InvoiceNumber { get; }
    public DateTime Date { get; }
    public DateTime PaymentBy { get; }
    public List<InvoiceLine> Lines { get; }

    public Invoice(int customerNumber, int invoiceNumber, DateTime date, DateTime paymentBy)
    {
        CustomerNumber = customerNumber;
        InvoiceNumber = invoiceNumber;
        Date = date;
        PaymentBy = paymentBy;
        Lines = new List<InvoiceLine>();
    }

    public void AddLine(InvoiceLine line)
    {
        Lines.Add(line);
    }

    public decimal GetPreTaxTotal()
    {
        decimal total = 0;
        foreach (var line in Lines)
        {
            total += line.GetTotal();
        }
        return total;
    }

    public decimal GetTax() => GetPreTaxTotal() * 0.1m;
    public decimal GetTotal() => GetPreTaxTotal() + GetTax();

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        foreach (var line in Lines)
        {
            line.Accept(visitor);
        }
    }
}