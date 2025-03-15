using System.Text;

namespace Lab_3;

public class XMLExportVisitor : IVisitor
{
    private StringBuilder sb = new StringBuilder();

    public void Visit(Product product) { }

    public void Visit(InvoiceLine line)
    {
        sb.AppendLine($"<line qty=\"{line.Quantity}\" productTitle=\"{line.Product.Name}\" unitPrice=\"{line.Product.UnitPrice}$\" total=\"{line.GetTotal()}$\"/>");
    }

    public void Visit(Invoice invoice)
    {
        sb.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        sb.AppendLine($"<invoice date=\"{invoice.Date.ToShortDateString()}\">");
        sb.AppendLine($"<customerNumber>{invoice.CustomerNumber}</customerNumber>");
        sb.AppendLine($"<invoiceNumber>{invoice.InvoiceNumber}</invoiceNumber>");
        sb.AppendLine($"<paymentBy>{invoice.PaymentBy.ToShortDateString()}</paymentBy>");
        sb.AppendLine("<lines>");

        foreach (var line in invoice.Lines)
        {
            line.Accept(this);
        }

        sb.AppendLine("</lines>");
        sb.AppendLine($"<total pre-tax=\"{invoice.GetPreTaxTotal()}$\" tax=\"{invoice.GetTax()}$\" total=\"{invoice.GetTotal()}$\"/>");
        sb.AppendLine("</invoice>");
    }

    public override string ToString() => sb.ToString();
}