namespace Lab5_OOAP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxImages = new ListBox();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBoxColor = new CheckBox();
            buttonAdd = new Button();
            buttonApply = new Button();
            checkSort = new CheckBox();
            buttonShow = new Button();
            label3 = new Label();
            label4 = new Label();
            comboFilterView = new ComboBox();
            comboFilters = new ComboBox();
            numWidth = new NumericUpDown();
            numHeight = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            SuspendLayout();
            // 
            // listBoxImages
            // 
            listBoxImages.FormattingEnabled = true;
            listBoxImages.Location = new Point(12, 12);
            listBoxImages.Name = "listBoxImages";
            listBoxImages.Size = new Size(881, 204);
            listBoxImages.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(69, 227);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(174, 27);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 230);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 263);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 4;
            label2.Text = "Ширина в пікселях";
            // 
            // checkBoxColor
            // 
            checkBoxColor.AutoSize = true;
            checkBoxColor.Location = new Point(15, 331);
            checkBoxColor.Name = "checkBoxColor";
            checkBoxColor.Size = new Size(108, 24);
            checkBoxColor.TabIndex = 5;
            checkBoxColor.Text = "Кольорове";
            checkBoxColor.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(78, 363);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(358, 461);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(158, 29);
            buttonApply.TabIndex = 8;
            buttonApply.Text = "Застосувати фільтр";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // checkSort
            // 
            checkSort.AutoSize = true;
            checkSort.Location = new Point(478, 259);
            checkSort.Name = "checkSort";
            checkSort.Size = new Size(194, 24);
            checkSort.TabIndex = 9;
            checkSort.Text = "Сортувати за розміром";
            checkSort.UseVisualStyleBackColor = true;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(605, 289);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(147, 29);
            buttonShow.TabIndex = 11;
            buttonShow.Text = "Показати/оновити";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // label3
            // 
            label3.Location = new Point(474, 231);
            label3.Name = "label3";
            label3.Size = new Size(240, 25);
            label3.TabIndex = 12;
            label3.Text = "Відображення за видом фільтру";
            // 
            // label4
            // 
            label4.Location = new Point(316, 399);
            label4.Name = "label4";
            label4.Size = new Size(245, 25);
            label4.TabIndex = 13;
            label4.Text = "Виберіть фільтр для зображення";
            // 
            // comboFilterView
            // 
            comboFilterView.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilterView.FormattingEnabled = true;
            comboFilterView.Items.AddRange(new object[] { "Всі", "Розмиття", "Шум", "Насиченість", "Обрізка колом", "Обрізка прямокутником" });
            comboFilterView.Location = new Point(712, 227);
            comboFilterView.Name = "comboFilterView";
            comboFilterView.Size = new Size(181, 28);
            comboFilterView.TabIndex = 10;
            // 
            // comboFilters
            // 
            comboFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilters.FormattingEnabled = true;
            comboFilters.Items.AddRange(new object[] { "Розмиття", "Шум", "Насиченість", "Обрізка колом", "Обрізка прямокутником" });
            comboFilters.Location = new Point(347, 427);
            comboFilters.Name = "comboFilters";
            comboFilters.Size = new Size(181, 28);
            comboFilters.TabIndex = 7;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(159, 261);
            numWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(84, 27);
            numWidth.TabIndex = 14;
            // 
            // numHeight
            // 
            numHeight.Location = new Point(159, 296);
            numHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(84, 27);
            numHeight.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 298);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 16;
            label5.Text = "Висота в пікселях";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 520);
            Controls.Add(label5);
            Controls.Add(numHeight);
            Controls.Add(numWidth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonShow);
            Controls.Add(comboFilterView);
            Controls.Add(checkSort);
            Controls.Add(buttonApply);
            Controls.Add(comboFilters);
            Controls.Add(buttonAdd);
            Controls.Add(checkBoxColor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(listBoxImages);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxImages;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private CheckBox checkBoxColor;
        private Button buttonAdd;
        private Button buttonApply;
        private CheckBox checkSort;
        private Button buttonShow;
        private Label label3;
        private Label label4;
        private ComboBox comboFilterView;
        private ComboBox comboFilters;
        private NumericUpDown numWidth;
        private NumericUpDown numHeight;
        private Label label5;
    }
}
