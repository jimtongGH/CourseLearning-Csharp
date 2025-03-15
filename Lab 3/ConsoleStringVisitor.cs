using System.Text;

namespace Lab_3;

public class ConsoleStringVisitor : IVisitor
{
    private StringBuilder sb = new StringBuilder();

    public void Visit(Product product) { }

    public void Visit(InvoiceLine line)
    {
        sb.AppendLine($" {line.Quantity}      {line.Product.Name}             {line.Product.UnitPrice}$            {line.GetTotal()}$");
    }

    public void Visit(Invoice invoice)
    {
        sb.AppendLine($"Invoice                                   Date: {invoice.Date.ToShortDateString()}");
        sb.AppendLine($"\nCustomer number: {invoice.CustomerNumber}");
        sb.AppendLine($"Invoice number: {invoice.InvoiceNumber}");
        sb.AppendLine($"Payment by: {invoice.PaymentBy.ToShortDateString()}");
        sb.AppendLine("\nQty     Product                       Unit Price     Total");

        foreach (var line in invoice.Lines)
        {
            line.Accept(this);
        }

        sb.AppendLine($"                                        Pre-tax total: {invoice.GetPreTaxTotal()}$");
        sb.AppendLine($"                                        Tax(10%): {invoice.GetTax()}$");
        sb.AppendLine($"                                        Total: {invoice.GetTotal()}$");
    }

    public override string ToString() => sb.ToString();
}