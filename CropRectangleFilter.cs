using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public class CropRectangleFilter : FilterDecorator
    {
        public CropRectangleFilter(ComponentImage image)
        {
            this.image = image;
        }

        public override string GetDescription()
        {
            return image.GetDescription() + " + Прямокутник";
        }

        public override int GetPixelCount()
        {
            return (int)(image.GetPixelCount() * 0.80);
        }

        public override double GetSize()
        {
            return image.GetSize() * 0.80;
        }

        public override bool HasFilter(string filterName)
        {
            if (filterName == "Обрізка прямокутником") return true;
            return base.HasFilter(filterName);
        }

        public override string GetLastShape()
        {
            return "Rectangle";
        }
    }
}
