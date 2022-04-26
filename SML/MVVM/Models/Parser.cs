using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SML.MVVM.Models
{
    internal static class Parser
    {
        public static bool ToTwoInts(object o, out int a, out int b)
        {
            a = 0;
            b = 0;
            try
            {
                var arr = o as string[];
                a = int.Parse(arr[0]);
                b = int.Parse(arr[1]);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool ToTwoInts(object first, object second, out int a, out int b)
        {
            a = 0;
            b = 0;
            try
            {
                a = int.Parse(first as string);
                b = int.Parse(second as string);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool CanParseToTwoInts(object first, object second)
        {
            try
            {
                var a = int.Parse(first as string);
                var b = int.Parse(second as string);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool ToInt(object o, out int a)
        {
            a = 0;
            try
            {
                a = int.Parse(o as string);
            }
            catch (Exception)
            {
                return false;

            }
            return true;
        }
        public static bool CanParseToInt(object o)
        {
            return int.TryParse(o as string, out var a);
        }
    }
}
