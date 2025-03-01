namespace Bridge.Bad;

public class LG_Medium_Advanced_Remote : BadRemoteControl
{
    private string _brand = "LG";
    private string _powerCategory = "Medium";
    private int _power = 689;
    private string _functionalities = "Advanced";

    public override void TurnOff()
    {
        System.Console.WriteLine($"Brand : {_brand} - Power : {_power} ({_powerCategory}) - Functionalities : {_functionalities} -> turn off");
    }

    public override void TurnOn()
    {
        System.Console.WriteLine($"Brand : {_brand} - Power : {_power} ({_powerCategory}) - Functionalities : {_functionalities} -> turn on");
    }

    public override void VolumeDown()
    {
        System.Console.WriteLine($"Brand : {_brand} - Power : {_power} ({_powerCategory}) - Functionalities : {_functionalities} -> volume down");
    }

    public override void VolumeUp()
    {
        System.Console.WriteLine($"Brand : {_brand} - Power : {_power} ({_powerCategory}) - Functionalities : {_functionalities} -> volume up");
    }
}
