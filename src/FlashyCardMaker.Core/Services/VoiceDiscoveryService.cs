namespace FlashyCardMaker.Core.Services;

using FlashyCardMaker.Core.Models;

public sealed class VoiceDiscoveryService
{
    public IReadOnlyList<VoiceCatalogItem> Discover(string languageCode)
    {
        return
        [
            new VoiceCatalogItem("voice-default", "Default Voice", languageCode)
        ];
    }
}
