namespace Bridge.Bad;

public class Sony_Low_Basic_Remote : BadRemoteControl
{
    private string _brand = "Sony";
    private string _powerCategory = "Low";
    private int _power= 89;
    private string _functionalities = "Basic";

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
