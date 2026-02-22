namespace FlashyCardMaker.Infrastructure.Providers;

using FlashyCardMaker.Core.Models;

public sealed class CsvExportWriter
{
    public async Task WriteAsync(string outputPath, IReadOnlyList<GenerationRecord> records, CancellationToken cancellationToken = default)
    {
        var lines = new List<string> { "recordId,sourceLanguage,sourceText" };
        lines.AddRange(records.Select(r => $"{Escape(r.RecordId)},{Escape(r.SourceLanguage)},{Escape(r.SourceText)}"));
        await File.WriteAllLinesAsync(outputPath, lines, cancellationToken);
    }

    private static string Escape(string value) => $"\"{value.Replace("\"", "\"\"")}\"";
}
