using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public class NoiseFilter : FilterDecorator
    {
        public NoiseFilter(ComponentImage image) { this.image = image; }

        public override string GetDescription() { return image.GetDescription() + " + Шум"; }

        public override double GetSize()
        {
            return base.GetSize() * 1.2;
        }

        public override bool HasFilter(string filterName)
        {
            if (filterName == "Шум") return true;
            return base.HasFilter(filterName);
        }
    }
}
