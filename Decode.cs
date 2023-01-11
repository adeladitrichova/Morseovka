using System;

public class Decode
{
    public string Decode(string code)
    {
        var text = new StringBuilder();
        var symbols = code.Split(" ");
        foreach (var s in symbols)
        {
            text.Append(_decodeDict[s]);
        }
        return text.ToString();
    }
}
