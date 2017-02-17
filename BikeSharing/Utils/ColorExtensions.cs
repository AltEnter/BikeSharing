using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BikeSharing.Utils
{
    public static class ColorExtensions
    {

        public static string ToHexString(this Color color) =>
            $"{ColorAsInt(color.A):x2}{ColorAsInt(color.R):x2}{ColorAsInt(color.G):x2}{ColorAsInt(color.B):x2}";

        private static int ColorAsInt(double color) => (int)(color * 255);
    }
}
