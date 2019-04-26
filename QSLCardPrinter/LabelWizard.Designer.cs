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
            this.groupBoxAdifConversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdifItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdifConversion
            // 
            this.groupBoxAdifConversion.Controls.Add(this.buttonReadFromFile);
            this.groupBoxAdifConversion.Controls.Add(this.buttonReadClipboard);
            this.groupBoxAdifConversion.Controls.Add(this.dataGridViewAdifItems);
            this.groupBoxAdifConversion.Location = new System.Drawing.Point(504, 12);
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
            // 
            // dataGridViewAdifItems
            // 
            this.dataGridViewAdifItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdifItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdifItems.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewAdifItems.Name = "dataGridViewAdifItems";
            this.dataGridViewAdifItems.Size = new System.Drawing.Size(433, 372);
            this.dataGridViewAdifItems.TabIndex = 0;
            // 
            // LabelWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.groupBoxAdifConversion);
            this.Name = "LabelWizard";
            this.Text = "LabelWizard";
            this.groupBoxAdifConversion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdifItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdifConversion;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.Button buttonReadClipboard;
        private System.Windows.Forms.DataGridView dataGridViewAdifItems;
    }
}