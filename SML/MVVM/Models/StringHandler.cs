using System.Text;

namespace SML.Models
{
    internal class StringHandler
    {
        public static string StringArrayToString(string[] arr)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var str in arr)
                sb.Append(str);
            return sb.ToString();
        }
    }
}
