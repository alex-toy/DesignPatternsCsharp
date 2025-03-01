using Bridge.Good.Dimensions;

namespace Bridge.Good;

public class RemoteControl
{
    public required Brand Brand { get; set; }
    public required Power Power { get; set; }
    public required Functionality Functionality { get; set; }

    public void TurnOff()
    {
        System.Console.WriteLine($"Brand : {Brand.Label} - Power : {Power.Value} ({Power.Category}) - Functionalities : {Functionality.Label} -> turn off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine($"Brand : {Brand.Label} - Power : {Power.Value} ({Power.Category}) - Functionalities : {Functionality.Label} -> turn on");
    }

    public void VolumeDown()
    {
        System.Console.WriteLine($"Brand : {Brand.Label} - Power : {Power.Value} ({Power.Category}) - Functionalities : {Functionality.Label} -> volume down");
    }

    public void VolumeUp()
    {
        System.Console.WriteLine($"Brand : {Brand.Label} - Power : {Power.Value} ({Power.Category}) - Functionalities : {Functionality.Label} -> volume up");
    }
}
