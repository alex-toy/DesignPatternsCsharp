using Visitor.Generic.Clients;

namespace Visitor.Generic.Visitors;

public class PDFExportVisitor : BaseVisitor
{
    public void Visit(Law law)
    {
        Console.WriteLine("Exporting law client as PDF.");
    }

    public void Visit(Restaurant restaurant)
    {
        Console.WriteLine("Exporting restaurant client as PDF.");
    }

    public void Visit(Retail retail)
    {
        Console.WriteLine("Exporting retail client as PDF.");
    }
}
