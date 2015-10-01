namespace chmv_3
{
    partial class Pricelist
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.targetName = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.chooseCategory = new System.Windows.Forms.ComboBox();
            this.from = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеПерсоналомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.categoryNameText = new System.Windows.Forms.TextBox();
            this.addCategoryLabel = new System.Windows.Forms.Label();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.produstNameText = new System.Windows.Forms.TextBox();
            this.productCostText = new System.Windows.Forms.TextBox();
            this.productCategoryCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetName
            // 
            this.targetName.Location = new System.Drawing.Point(12, 39);
            this.targetName.Name = "targetName";
            this.targetName.Size = new System.Drawing.Size(329, 20);
            this.targetName.TabIndex = 0;
            this.targetName.Text = "Введите название товара";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(258, 90);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(83, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseCategory
            // 
            this.chooseCategory.FormattingEnabled = true;
            this.chooseCategory.Location = new System.Drawing.Point(394, 38);
            this.chooseCategory.Name = "chooseCategory";
            this.chooseCategory.Size = new System.Drawing.Size(126, 21);
            this.chooseCategory.TabIndex = 2;
            this.chooseCategory.Text = "Выберите категорию";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(394, 92);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(46, 20);
            this.from.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Name,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(13, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 275);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Category.Width = 200;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название";
            this.Name.Name = "Name";
            this.Name.Width = 300;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(474, 93);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(46, 20);
            this.to.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ценовой диапазон";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(582, 38);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 8;
            this.enter.Text = "Вход";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеПерсоналомToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // управлениеПерсоналомToolStripMenuItem
            // 
            this.управлениеПерсоналомToolStripMenuItem.Name = "управлениеПерсоналомToolStripMenuItem";
            this.управлениеПерсоналомToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.управлениеПерсоналомToolStripMenuItem.Text = "Управление персоналом";
            this.управлениеПерсоналомToolStripMenuItem.Click += new System.EventHandler(this.управлениеПерсоналомToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "От";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "До";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Редактирование";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // categoryNameText
            // 
            this.categoryNameText.Location = new System.Drawing.Point(715, 174);
            this.categoryNameText.Name = "categoryNameText";
            this.categoryNameText.Size = new System.Drawing.Size(130, 20);
            this.categoryNameText.TabIndex = 13;
            this.categoryNameText.Text = "Название категории";
            this.categoryNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoryNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addCategoryLabel
            // 
            this.addCategoryLabel.AutoSize = true;
            this.addCategoryLabel.Location = new System.Drawing.Point(721, 149);
            this.addCategoryLabel.Name = "addCategoryLabel";
            this.addCategoryLabel.Size = new System.Drawing.Size(114, 13);
            this.addCategoryLabel.TabIndex = 14;
            this.addCategoryLabel.Text = "Добавить категорию";
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(735, 210);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(75, 22);
            this.addCategoryButton.TabIndex = 15;
            this.addCategoryButton.Text = "Добавить";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Location = new System.Drawing.Point(732, 258);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(89, 13);
            this.addProductLabel.TabIndex = 14;
            this.addProductLabel.Text = "Добавить товар";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(735, 363);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 22);
            this.addProductButton.TabIndex = 15;
            this.addProductButton.Text = "Добавить";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // produstNameText
            // 
            this.produstNameText.Location = new System.Drawing.Point(715, 284);
            this.produstNameText.Name = "produstNameText";
            this.produstNameText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.produstNameText.Size = new System.Drawing.Size(130, 20);
            this.produstNameText.TabIndex = 13;
            this.produstNameText.Text = "Название товара";
            this.produstNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.produstNameText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // productCostText
            // 
            this.productCostText.Location = new System.Drawing.Point(715, 310);
            this.productCostText.Name = "productCostText";
            this.productCostText.Size = new System.Drawing.Size(130, 20);
            this.productCostText.TabIndex = 13;
            this.productCostText.Text = "Цена товара";
            this.productCostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productCostText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // productCategoryCombo
            // 
            this.productCategoryCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productCategoryCombo.FormattingEnabled = true;
            this.productCategoryCombo.Location = new System.Drawing.Point(715, 336);
            this.productCategoryCombo.Name = "productCategoryCombo";
            this.productCategoryCombo.Size = new System.Drawing.Size(130, 21);
            this.productCategoryCombo.TabIndex = 16;
            this.productCategoryCombo.Text = "Категория";
            this.productCategoryCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pricelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 436);
            this.Controls.Add(this.productCategoryCombo);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.addProductLabel);
            this.Controls.Add(this.addCategoryLabel);
            this.Controls.Add(this.productCostText);
            this.Controls.Add(this.produstNameText);
            this.Controls.Add(this.categoryNameText);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.chooseCategory);
            this.Controls.Add(this.search);
            this.Controls.Add(this.targetName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Pricelist";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pricelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetName;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox chooseCategory;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеПерсоналомToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox categoryNameText;
        private System.Windows.Forms.Label addCategoryLabel;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox produstNameText;
        private System.Windows.Forms.TextBox productCostText;
        private System.Windows.Forms.ComboBox productCategoryCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

