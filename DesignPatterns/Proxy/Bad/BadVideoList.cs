using Proxy.Bad.ThirdPartyVideoLib;

namespace Proxy.Bad;

public class BadVideoList
{
    private Dictionary<string, IBadVideo> _videoList = new Dictionary<string, IBadVideo>();

    public void Add(IBadVideo video)
    {
        _videoList.Add(video.GetVideoId(), video);
    }

    public void Watch(string videoId)
    {
        var video = _videoList[videoId];
        video.Render();
    }
}
