using System.IO;

namespace SML.Models
{
    internal static class TextManager
    {
        public static string[] GetTextArrayFromFile(string path)
        {
            return File.ReadAllLines(path);
        }
        public static string GetTextFromFile(string path)
        {
            return StringHandler.StringArrayToString(GetTextArrayFromFile(path));
        }
    }
}