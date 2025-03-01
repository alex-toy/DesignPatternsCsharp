using Adapter.Colors;
using Adapter.ThirdPartyColors;

namespace Adapter.Adapters;

public class RainbowColor : Color
{
    private Rainbow _rainbow; 

    public RainbowColor()
    {
        _rainbow = new Rainbow();
    }

    public void Apply(Video video)
    {
        _rainbow.Setup();
        _rainbow.Update(video);
    }
}
