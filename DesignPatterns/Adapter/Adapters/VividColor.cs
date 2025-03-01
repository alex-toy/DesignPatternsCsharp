using Adapter.Colors;
using Adapter.ThirdPartyColors;

namespace Adapter.Adapters;

public class VividColor : Color
{
    private Vivid _color;

    public VividColor()
    {
        _color = new Vivid();
    }
    public void Apply(Video video)
    {
        _color.Init();
        _color.Edit(video);
    }
}
