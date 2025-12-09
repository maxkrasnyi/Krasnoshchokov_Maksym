using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_OOAP
{
    public class ImageSystemFacade
    {
        private List<ComponentImage> imageList;

        public ImageSystemFacade()
        {
            this.imageList = new List<ComponentImage>();
        }

        public void AddImage(string name, bool isColor, int width, int height)
        {
            Picture newPic = new Picture(name, isColor, width, height);
            this.imageList.Add(newPic);
        }

        public void ApplyFilter(int index, string filterType)
        {
            if (index < 0 || index >= imageList.Count) return;

            ComponentImage currentImage = this.imageList[index];
            string lastShape = currentImage.GetLastShape();

            if (filterType == "Обрізка колом")
            {
                if (lastShape == "Circle")
                {
                    MessageBox.Show("Вже обрізано колом. Спробуйте прямокутник.");
                    return;
                }
            }
            else if (filterType == "Обрізка прямокутником")
            {
                if (lastShape == "None")
                {
                    MessageBox.Show("Спочатку треба вирізати коло!");
                    return;
                }
                if (lastShape == "Rectangle")
                {
                    MessageBox.Show("Вже обрізано прямокутником.");
                    return;
                }
            }

            switch (filterType)
            {
                case "Розмиття":
                    this.imageList[index] = new BlurFilter(currentImage);
                    break;
                case "Шум":
                    this.imageList[index] = new NoiseFilter(currentImage);
                    break;
                case "Обрізка колом":
                    this.imageList[index] = new CropCircleFilter(currentImage);
                    break;
                case "Обрізка прямокутником":
                    this.imageList[index] = new CropRectangleFilter(currentImage);
                    break;
                case "Насиченість":
                    this.imageList[index] = new SaturationFilter(currentImage);
                    break;
            }
        }

        public List<string> GetReportLines(bool sortBySize, string filterCriteria)
        {
            List<ComponentImage> tempList = new List<ComponentImage>();

            foreach (ComponentImage img in this.imageList)
            {
                bool shouldAdd = false;
                if (filterCriteria == "Всі")
                {
                    shouldAdd = true;
                }
                else
                {
                    if (img.HasFilter(filterCriteria)) shouldAdd = true;
                }

                if (shouldAdd) tempList.Add(img);
            }

            if (sortBySize)
            {
                tempList.Sort(delegate (ComponentImage x, ComponentImage y)
                {
                    return x.GetSize().CompareTo(y.GetSize());
                });
            }

            List<string> report = new List<string>();
            foreach (ComponentImage img in tempList)
            {
                string info = string.Format("{0} | {1} px | {2:F3} MB",
                    img.GetDescription(),
                    img.GetPixelCount(),
                    img.GetSize());

                report.Add(info);
            }

            return report;
        }
    }
}
