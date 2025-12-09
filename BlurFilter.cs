using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public class BlurFilter : FilterDecorator
    {
        public BlurFilter(ComponentImage image) { this.image = image; }

        public override string GetDescription() { return image.GetDescription() + " + Розмиття"; }

        public override double GetSize()
        {
            return base.GetSize() + 0.5;
        }

        public override bool HasFilter(string filterName)
        {
            if (filterName == "Розмиття") return true;
            return base.HasFilter(filterName);
        }
    }
}
