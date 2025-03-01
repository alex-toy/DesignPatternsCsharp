using Adapter.Colors;

namespace Adapter;

public class VideoEditor
{
    private Video _video;

    public VideoEditor(Video video)
    {
        _video = video;
    }

    public void ApplyColor(Color color)
    {
        color.Apply(_video);
    }
}
