namespace FlashyCardMaker.Infrastructure.Providers;

using FlashyCardMaker.Core.Models;

public sealed class OutputFormatDispatcher
{
    public IReadOnlyList<string> Dispatch(IReadOnlyList<GenerationRecord> records, IReadOnlyList<string> formatKeys)
    {
        return formatKeys.Select(format => $"{format}:{records.Count}").ToList();
    }
}
