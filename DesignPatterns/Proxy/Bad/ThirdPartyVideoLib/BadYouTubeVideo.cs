namespace Proxy.Bad.ThirdPartyVideoLib;

public class BadYouTubeVideo : IBadVideo
{
    private string _videoId;

    public BadYouTubeVideo(string videoId)
    {
        _videoId = videoId;
        Download();
    }

    private void Download()
    {
        System.Console.WriteLine("Downloading video with id " + _videoId + " from YouTube API");
    }

    public void Render()
    {
        System.Console.WriteLine("Rendering video " + _videoId);
    }

    public string GetVideoId()
    {
        return _videoId;
    }
}
