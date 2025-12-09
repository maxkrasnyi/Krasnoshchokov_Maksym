using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public abstract class FilterDecorator : ComponentImage
    {
        protected ComponentImage image;

        public override abstract string GetDescription();

        public override int GetPixelCount()
        {
            return image.GetPixelCount();
        }

        public override double GetSize()
        {
            return image.GetSize();
        }

        public override bool HasFilter(string filterName)
        {
            return image.HasFilter(filterName);
        }

        public override string GetLastShape()
        {
            return image.GetLastShape();
        }
    }
}
