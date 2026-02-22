namespace FlashyCardMaker.Infrastructure.Providers;

public sealed class AudioOutputPathResolver
{
    public string Resolve(string baseDirectory, string languageCode, string fileName)
    {
        var languageDirectory = Path.Combine(baseDirectory, languageCode);
        Directory.CreateDirectory(languageDirectory);
        return Path.Combine(languageDirectory, fileName);
    }
}
