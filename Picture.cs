using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public class Picture : ComponentImage
    {
        private int width;
        private int height;
        private bool isColor;

        public Picture(string name, bool isColor, int width, int height)
        {
            this.description = name;
            this.isColor = isColor;
            this.width = width;
            this.height = height;
        }

        public override int GetPixelCount()
        {
            return width * height;
        }

        public override double GetSize()
        {
            double bytesPerPixel = 1.0;
            if (isColor)
            {
                bytesPerPixel = 3.0;
            }

            double totalBytes = (double)GetPixelCount() * bytesPerPixel;
            return totalBytes / 1048576.0;
        }

        public override string GetDescription()
        {
            string colorType = "Чорно-біле";
            if (this.isColor)
            {
                colorType = "Кольорове";
            }

            return string.Format("{0} ({1})", description, colorType);
        }

        public override bool HasFilter(string filterName)
        {
            return false;
        }

        public override string GetLastShape()
        {
            return "None";
        }
    }
}
