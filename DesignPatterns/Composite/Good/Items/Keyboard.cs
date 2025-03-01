using Composite.Good.Structure;

namespace Composite.Good.Items;

public class Keyboard : Item
{
    private float _price = 40.00f;

    public float GetPrice()
    {
        return _price;
    }
}
