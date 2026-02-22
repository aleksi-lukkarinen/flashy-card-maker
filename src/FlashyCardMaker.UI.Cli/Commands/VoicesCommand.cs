namespace FlashyCardMaker.UI.Cli.Commands;

using FlashyCardMaker.Core.Services;
using FlashyCardMaker.Core.Models;

public sealed class VoicesCommand(VoiceDiscoveryService discoveryService)
{
    public IReadOnlyList<VoiceCatalogItem> Execute(string languageCode) => discoveryService.Discover(languageCode);
}
