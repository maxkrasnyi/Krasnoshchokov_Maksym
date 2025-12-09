using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public abstract class ComponentImage
    {
        protected string description;

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double GetSize();
        public abstract int GetPixelCount();
        public abstract bool HasFilter(string filterName);
        public abstract string GetLastShape();
    }
}
