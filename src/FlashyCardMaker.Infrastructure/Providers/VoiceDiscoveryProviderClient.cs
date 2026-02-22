namespace FlashyCardMaker.Infrastructure.Providers;

using FlashyCardMaker.Core.Models;

public sealed class VoiceDiscoveryProviderClient
{
    public IReadOnlyList<VoiceCatalogItem> Fetch(string languageCode, IReadOnlyDictionary<string, string> headers)
    {
        if (!headers.ContainsKey("Authorization"))
        {
            return Array.Empty<VoiceCatalogItem>();
        }

        return [new VoiceCatalogItem("voice-default", "Default Voice", languageCode)];
    }
}
