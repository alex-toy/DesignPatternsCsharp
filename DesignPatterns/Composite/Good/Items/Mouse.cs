using Composite.Good.Structure;

namespace Composite.Good.Items;

public class Mouse : Item
{
    private float _price = 18.00f;

    public float GetPrice()
    {
        return _price;
    }
}
