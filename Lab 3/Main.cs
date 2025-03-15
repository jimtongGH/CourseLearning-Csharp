using Lab_3;

class main
{
    static void Main()
    {
        // Create Products
        Product book = new Product("Mythical Man-Month", 45m);
        Product paper = new Product("Ream of paper (500)", 5m);
        Product laptop = new Product("Standart Fruit Laptop", 2000m);

        // Create Invoice
        Invoice invoice = new Invoice(5678, 1234, new DateTime(2023, 1, 5), new DateTime(2023, 2, 5));
        invoice.AddLine(new InvoiceLine(book, 1));
        invoice.AddLine(new InvoiceLine(paper, 4));
        invoice.AddLine(new InvoiceLine(laptop, 1));

        // Console output
        Console.WriteLine("Console output:");
        ConsoleStringVisitor consoleVisitor = new ConsoleStringVisitor();
        invoice.Accept(consoleVisitor);
        Console.WriteLine(consoleVisitor.ToString());

        // XML output
        Console.WriteLine("\nXML output:");
        XMLExportVisitor xmlVisitor = new XMLExportVisitor();
        invoice.Accept(xmlVisitor);
        Console.WriteLine(xmlVisitor.ToString());
    }
}