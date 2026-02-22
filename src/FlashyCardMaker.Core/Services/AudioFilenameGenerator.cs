namespace FlashyCardMaker.Core.Services;

using System.Security.Cryptography;
using System.Text;

public sealed class AudioFilenameGenerator
{
    public string Generate(string languageCode, string sourceText, string extension)
    {
        var normalizedLanguage = string.IsNullOrWhiteSpace(languageCode) ? "und" : languageCode.ToLowerInvariant();
        var words = string.Join("_", sourceText.Split([' ', '\t', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries)).ToLowerInvariant();
        var slug = new string(words.Where(ch => char.IsLetterOrDigit(ch) || ch == '_').ToArray());
        slug = slug.Length > 50 ? slug[..50] : slug;

        var hashInput = Encoding.UTF8.GetBytes($"{normalizedLanguage}:{sourceText}");
        var hash = Convert.ToHexString(SHA256.HashData(hashInput)).ToLowerInvariant()[..12];

        return $"{normalizedLanguage}_{slug}_{hash}.{extension.TrimStart('.')}";
    }
}
