namespace QSLCardPrinter
{
    partial class LabelWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAdifConversion = new System.Windows.Forms.GroupBox();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.buttonReadClipboard = new System.Windows.Forms.Button();
            this.dataGridViewAdifItems = new System.Windows.Forms.DataGridView();
            this.ColumnAdifName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdifValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxLabelItems = new System.Windows.Forms.ListBox();
            this.buttonToLabelItemList = new System.Windows.Forms.Button();
            this.groupBoxCurrentLabelItems = new System.Windows.Forms.GroupBox();
            this.buttonDeleteLabel = new System.Windows.Forms.Button();
            this.buttonAddFreeText = new System.Windows.Forms.Button();
            this.groupBoxLabelSettings = new System.Windows.Forms.GroupBox();
            this.textBoxDefaultValue = new System.Windows.Forms.TextBox();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.numericUpDownPositionLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPositionTop = new System.Windows.Forms.NumericUpDown();
            this.labelPositionTop = new System.Windows.Forms.Label();
            this.labelDefaultValue = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelPositionLeft = new System.Windows.Forms.Label();
            this.groupBoxAdifConversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdifItems)).BeginInit();
            this.groupBoxCurrentLabelItems.SuspendLayout();
            this.groupBoxLabelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionTop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdifConversion
            // 
            this.groupBoxAdifConversion.Controls.Add(this.buttonReadFromFile);
            this.groupBoxAdifConversion.Controls.Add(this.buttonReadClipboard);
            this.groupBoxAdifConversion.Controls.Add(this.dataGridViewAdifItems);
            this.groupBoxAdifConversion.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAdifConversion.Name = "groupBoxAdifConversion";
            this.groupBoxAdifConversion.Size = new System.Drawing.Size(445, 426);
            this.groupBoxAdifConversion.TabIndex = 4;
            this.groupBoxAdifConversion.TabStop = false;
            this.groupBoxAdifConversion.Text = "Info of ADIF";
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Location = new System.Drawing.Point(6, 19);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(115, 23);
            this.buttonReadFromFile.TabIndex = 1;
            this.buttonReadFromFile.Text = "Read from file";
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            this.buttonReadFromFile.Click += new System.EventHandler(this.ButtonReadFromFileClick);
            // 
            // buttonReadClipboard
            // 
            this.buttonReadClipboard.Location = new System.Drawing.Point(127, 19);
            this.buttonReadClipboard.Name = "buttonReadClipboard";
            this.buttonReadClipboard.Size = new System.Drawing.Size(115, 23);
            this.buttonReadClipboard.TabIndex = 1;
            this.buttonReadClipboard.Text = "Read from clipboard";
            this.buttonReadClipboard.UseVisualStyleBackColor = true;
            this.buttonReadClipboard.Click += new System.EventHandler(this.ButtonReadClipboardClick);
            // 
            // dataGridViewAdifItems
            // 
            this.dataGridViewAdifItems.AllowUserToAddRows = false;
            this.dataGridViewAdifItems.AllowUserToDeleteRows = false;
            this.dataGridViewAdifItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdifItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdifItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAdifName,
            this.ColumnAdifValue});
            this.dataGridViewAdifItems.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewAdifItems.MultiSelect = false;
            this.dataGridViewAdifItems.Name = "dataGridViewAdifItems";
            this.dataGridViewAdifItems.ReadOnly = true;
            this.dataGridViewAdifItems.RowHeadersVisible = false;
            this.dataGridViewAdifItems.Size = new System.Drawing.Size(433, 372);
            this.dataGridViewAdifItems.TabIndex = 0;
            // 
            // ColumnAdifName
            // 
            this.ColumnAdifName.HeaderText = "AdifName";
            this.ColumnAdifName.Name = "ColumnAdifName";
            this.ColumnAdifName.ReadOnly = true;
            this.ColumnAdifName.Width = 200;
            // 
            // ColumnAdifValue
            // 
            this.ColumnAdifValue.HeaderText = "AdifValue";
            this.ColumnAdifValue.Name = "ColumnAdifValue";
            this.ColumnAdifValue.ReadOnly = true;
            this.ColumnAdifValue.Width = 200;
            // 
            // listBoxLabelItems
            // 
            this.listBoxLabelItems.FormattingEnabled = true;
            this.listBoxLabelItems.Location = new System.Drawing.Point(6, 19);
            this.listBoxLabelItems.Name = "listBoxLabelItems";
            this.listBoxLabelItems.Size = new System.Drawing.Size(156, 355);
            this.listBoxLabelItems.TabIndex = 5;
            this.listBoxLabelItems.SelectedIndexChanged += new System.EventHandler(this.ListBoxLabelItemsSelectedIndexChanged);
            // 
            // buttonToLabelItemList
            // 
            this.buttonToLabelItemList.Location = new System.Drawing.Point(463, 167);
            this.buttonToLabelItemList.Name = "buttonToLabelItemList";
            this.buttonToLabelItemList.Size = new System.Drawing.Size(28, 91);
            this.buttonToLabelItemList.TabIndex = 6;
            this.buttonToLabelItemList.Text = ">";
            this.buttonToLabelItemList.UseVisualStyleBackColor = true;
            this.buttonToLabelItemList.Click += new System.EventHandler(this.ButtonToLabelItemListClick);
            // 
            // groupBoxCurrentLabelItems
            // 
            this.groupBoxCurrentLabelItems.Controls.Add(this.buttonDeleteLabel);
            this.groupBoxCurrentLabelItems.Controls.Add(this.buttonAddFreeText);
            this.groupBoxCurrentLabelItems.Controls.Add(this.groupBoxLabelSettings);
            this.groupBoxCurrentLabelItems.Controls.Add(this.listBoxLabelItems);
            this.groupBoxCurrentLabelItems.Location = new System.Drawing.Point(497, 12);
            this.groupBoxCurrentLabelItems.Name = "groupBoxCurrentLabelItems";
            this.groupBoxCurrentLabelItems.Size = new System.Drawing.Size(452, 426);
            this.groupBoxCurrentLabelItems.TabIndex = 7;
            this.groupBoxCurrentLabelItems.TabStop = false;
            this.groupBoxCurrentLabelItems.Text = "Current label items";
            // 
            // buttonDeleteLabel
            // 
            this.buttonDeleteLabel.Location = new System.Drawing.Point(168, 191);
            this.buttonDeleteLabel.Name = "buttonDeleteLabel";
            this.buttonDeleteLabel.Size = new System.Drawing.Size(278, 23);
            this.buttonDeleteLabel.TabIndex = 8;
            this.buttonDeleteLabel.Text = "Delete label";
            this.buttonDeleteLabel.UseVisualStyleBackColor = true;
            this.buttonDeleteLabel.Click += new System.EventHandler(this.ButtonDeleteLabelClick);
            // 
            // buttonAddFreeText
            // 
            this.buttonAddFreeText.Location = new System.Drawing.Point(6, 380);
            this.buttonAddFreeText.Name = "buttonAddFreeText";
            this.buttonAddFreeText.Size = new System.Drawing.Size(156, 23);
            this.buttonAddFreeText.TabIndex = 8;
            this.buttonAddFreeText.Text = "Add free text";
            this.buttonAddFreeText.UseVisualStyleBackColor = true;
            this.buttonAddFreeText.Click += new System.EventHandler(this.ButtonAddFreeTextClick);
            // 
            // groupBoxLabelSettings
            // 
            this.groupBoxLabelSettings.Controls.Add(this.textBoxDefaultValue);
            this.groupBoxLabelSettings.Controls.Add(this.buttonSelectFont);
            this.groupBoxLabelSettings.Controls.Add(this.numericUpDownPositionLeft);
            this.groupBoxLabelSettings.Controls.Add(this.numericUpDownPositionTop);
            this.groupBoxLabelSettings.Controls.Add(this.labelPositionTop);
            this.groupBoxLabelSettings.Controls.Add(this.labelDefaultValue);
            this.groupBoxLabelSettings.Controls.Add(this.labelFont);
            this.groupBoxLabelSettings.Controls.Add(this.labelPositionLeft);
            this.groupBoxLabelSettings.Location = new System.Drawing.Point(168, 19);
            this.groupBoxLabelSettings.Name = "groupBoxLabelSettings";
            this.groupBoxLabelSettings.Size = new System.Drawing.Size(278, 166);
            this.groupBoxLabelSettings.TabIndex = 7;
            this.groupBoxLabelSettings.TabStop = false;
            this.groupBoxLabelSettings.Text = "Settings for label";
            // 
            // textBoxDefaultValue
            // 
            this.textBoxDefaultValue.Location = new System.Drawing.Point(136, 106);
            this.textBoxDefaultValue.Name = "textBoxDefaultValue";
            this.textBoxDefaultValue.Size = new System.Drawing.Size(136, 20);
            this.textBoxDefaultValue.TabIndex = 9;
            this.textBoxDefaultValue.TextChanged += new System.EventHandler(this.TextBoxDefaultValueTextChanged);
            // 
            // buttonSelectFont
            // 
            this.buttonSelectFont.Location = new System.Drawing.Point(198, 77);
            this.buttonSelectFont.Name = "buttonSelectFont";
            this.buttonSelectFont.Size = new System.Drawing.Size(74, 23);
            this.buttonSelectFont.TabIndex = 8;
            this.buttonSelectFont.Text = "select";
            this.buttonSelectFont.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPositionLeft
            // 
            this.numericUpDownPositionLeft.Location = new System.Drawing.Point(198, 51);
            this.numericUpDownPositionLeft.Name = "numericUpDownPositionLeft";
            this.numericUpDownPositionLeft.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownPositionLeft.TabIndex = 7;
            this.numericUpDownPositionLeft.ValueChanged += new System.EventHandler(this.NumericUpDownPositionLeftValueChanged);
            // 
            // numericUpDownPositionTop
            // 
            this.numericUpDownPositionTop.Location = new System.Drawing.Point(198, 25);
            this.numericUpDownPositionTop.Name = "numericUpDownPositionTop";
            this.numericUpDownPositionTop.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownPositionTop.TabIndex = 7;
            this.numericUpDownPositionTop.ValueChanged += new System.EventHandler(this.NumericUpDownPositionTopValueChanged);
            // 
            // labelPositionTop
            // 
            this.labelPositionTop.AutoSize = true;
            this.labelPositionTop.Location = new System.Drawing.Point(6, 29);
            this.labelPositionTop.Name = "labelPositionTop";
            this.labelPositionTop.Size = new System.Drawing.Size(110, 13);
            this.labelPositionTop.TabIndex = 6;
            this.labelPositionTop.Text = "Position from top [mm]";
            // 
            // labelDefaultValue
            // 
            this.labelDefaultValue.AutoSize = true;
            this.labelDefaultValue.Location = new System.Drawing.Point(6, 110);
            this.labelDefaultValue.Name = "labelDefaultValue";
            this.labelDefaultValue.Size = new System.Drawing.Size(90, 13);
            this.labelDefaultValue.TabIndex = 6;
            this.labelDefaultValue.Text = "Default / free text";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(6, 82);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(28, 13);
            this.labelFont.TabIndex = 6;
            this.labelFont.Text = "Font";
            // 
            // labelPositionLeft
            // 
            this.labelPositionLeft.AutoSize = true;
            this.labelPositionLeft.Location = new System.Drawing.Point(6, 55);
            this.labelPositionLeft.Name = "labelPositionLeft";
            this.labelPositionLeft.Size = new System.Drawing.Size(109, 13);
            this.labelPositionLeft.TabIndex = 6;
            this.labelPositionLeft.Text = "Position from left [mm]";
            // 
            // LabelWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.groupBoxCurrentLabelItems);
            this.Controls.Add(this.buttonToLabelItemList);
            this.Controls.Add(this.groupBoxAdifConversion);
            this.Name = "LabelWizard";
            this.Text = "LabelWizard";
            this.groupBoxAdifConversion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdifItems)).EndInit();
            this.groupBoxCurrentLabelItems.ResumeLayout(false);
            this.groupBoxLabelSettings.ResumeLayout(false);
            this.groupBoxLabelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdifConversion;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.Button buttonReadClipboard;
        private System.Windows.Forms.DataGridView dataGridViewAdifItems;
        private System.Windows.Forms.ListBox listBoxLabelItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdifName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdifValue;
        private System.Windows.Forms.Button buttonToLabelItemList;
        private System.Windows.Forms.GroupBox groupBoxCurrentLabelItems;
        private System.Windows.Forms.Button buttonDeleteLabel;
        private System.Windows.Forms.Button buttonAddFreeText;
        private System.Windows.Forms.GroupBox groupBoxLabelSettings;
        private System.Windows.Forms.TextBox textBoxDefaultValue;
        private System.Windows.Forms.Button buttonSelectFont;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionTop;
        private System.Windows.Forms.Label labelPositionTop;
        private System.Windows.Forms.Label labelDefaultValue;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Label labelPositionLeft;
    }
}