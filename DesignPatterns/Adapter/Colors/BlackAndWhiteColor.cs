namespace Adapter.Colors;

public class BlackAndWhiteColor : Color
{
    public void Apply(Video video)
    {
        Console.WriteLine("Applying black and white color to video");
    }
}
