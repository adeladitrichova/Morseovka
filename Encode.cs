public string Encode(string text)
{
    text = SanitizeText(text);
    var morseCode = new StringBuilder();
    foreach (var c in text)
    {
        morseCode.Append(_encodeDict[c] + " ");
    }
    return morseCode.ToString().TrimEnd();
}