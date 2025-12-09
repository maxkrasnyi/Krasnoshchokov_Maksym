using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public class SaturationFilter : FilterDecorator
    {
        public SaturationFilter(ComponentImage image) { this.image = image; }

        public override string GetDescription() { return image.GetDescription() + " + Насиченість"; }

        public override double GetSize() { return base.GetSize() + 0.1; }

        public override bool HasFilter(string filterName)
        {
            if (filterName == "Насиченість") return true;
            return base.HasFilter(filterName);
        }
    }
}
