using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public class CropCircleFilter : FilterDecorator
    {
        public CropCircleFilter(ComponentImage image)
        {
            this.image = image;
        }

        public override string GetDescription()
        {
            return image.GetDescription() + " + Коло";
        }

        public override int GetPixelCount()
        {
            return (int)(image.GetPixelCount() * 0.785);
        }

        public override double GetSize()
        {
            return image.GetSize() * 0.785;
        }

        public override bool HasFilter(string filterName)
        {
            if (filterName == "Обрізка колом") return true;
            return base.HasFilter(filterName);
        }

        public override string GetLastShape()
        {
            return "Circle";
        }
    }
}
