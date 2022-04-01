using System.IO;

namespace SML.Models
{
    internal static class TextManager
    {
        public static string[] GetTextFromFile(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}