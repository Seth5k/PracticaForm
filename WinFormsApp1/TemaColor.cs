using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class TemaColor
    {
        /// <summary>
        /// https://color.adobe.com/es/create/color-wheel
        /// </summary>
        public static Color Barra;

        private static readonly Color BarraA = Color.FromArgb(75,178,221);

        public static void Tema()
        {
            Barra = BarraA;
        }
    }
}
