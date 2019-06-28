using System.Text.RegularExpressions;

namespace Shop.Infrastructure.Busines
{
    public static class SizeExtension
    {
        public static string SizeConventer(this string size)
        {
            if (Regex.IsMatch(size, "^[^x]+$"))
            {
                switch (size)
                {
                    case "XS":
                        size = "44";
                        break;
                    case "S":
                        size = "46";
                        break;
                    case "M":
                        size = "48";
                        break;
                    case "L":
                        size = "50";
                        break;
                    case "XL":
                        size = "52";
                        break;
                    case "XXL":
                        size = "54";
                        break;
                    case "XXXL":
                        size = "56";
                        break;
                    default:
                        break;
                }
            }
            return size;
        }
    }
}
