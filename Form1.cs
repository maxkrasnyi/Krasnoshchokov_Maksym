namespace Lab5_OOAP
{
    public partial class Form1 : Form
    {
        private ImageSystemFacade facade;
        public Form1()
        {
            InitializeComponent();
            this.facade = new ImageSystemFacade();

            if (comboFilters.Items.Count > 0) comboFilters.SelectedIndex = 0;
            if (comboFilterView.Items.Count > 0) comboFilterView.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            int w = (int)numWidth.Value;
            int h = (int)numHeight.Value;

            bool isColor = checkBoxColor.Checked;

            if (name == "")
            {
                MessageBox.Show("Введіть назву!");
                return;
            }

            if (w <= 0 || h <= 0)
            {
                MessageBox.Show("Розміри мають бути більше 0!");
                return;
            }

            facade.AddImage(name, isColor, w, h);
            RefreshList();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxImages.SelectedIndex;

            if (selectedIndex < 0)
            {
                MessageBox.Show("Виберіть зображення!");
                return;
            }

            if (checkSort.Checked)
            {
                MessageBox.Show("Вимкніть сортування!");
                return;
            }

            if (comboFilterView.SelectedItem.ToString() != "Всі")
            {
                MessageBox.Show("Оберіть режим 'Всі'!");
                return;
            }

            string filter = comboFilters.SelectedItem.ToString();
            facade.ApplyFilter(selectedIndex, filter);
            RefreshList();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxImages.Items.Clear();

            bool sort = checkSort.Checked;
            string viewFilter = "Всі";

            if (comboFilterView.SelectedItem != null)
            {
                viewFilter = comboFilterView.SelectedItem.ToString();
            }

            List<string> lines = facade.GetReportLines(sort, viewFilter);

            foreach (string line in lines)
            {
                listBoxImages.Items.Add(line);
            }
        }
    }
}
