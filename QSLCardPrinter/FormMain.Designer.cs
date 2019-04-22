namespace QSLCardPrinter
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAdifItems = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutQSLCardPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureShortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAdifConversion = new System.Windows.Forms.GroupBox();
            this.buttonReadClipboard = new System.Windows.Forms.Button();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.panelDesigner = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdifItems)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxAdifConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAdifItems
            // 
            this.dataGridViewAdifItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdifItems.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewAdifItems.Name = "dataGridViewAdifItems";
            this.dataGridViewAdifItems.Size = new System.Drawing.Size(280, 357);
            this.dataGridViewAdifItems.TabIndex = 0;
            this.dataGridViewAdifItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAdifItems_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTemplateToolStripMenuItem,
            this.saveTemplateToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTemplateToolStripMenuItem
            // 
            this.openTemplateToolStripMenuItem.Name = "openTemplateToolStripMenuItem";
            this.openTemplateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openTemplateToolStripMenuItem.Text = "Open Template";
            // 
            // saveTemplateToolStripMenuItem
            // 
            this.saveTemplateToolStripMenuItem.Name = "saveTemplateToolStripMenuItem";
            this.saveTemplateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveTemplateToolStripMenuItem.Text = "Save Template";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBackgroundImageToolStripMenuItem,
            this.clearBackgroundImageToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // loadBackgroundImageToolStripMenuItem
            // 
            this.loadBackgroundImageToolStripMenuItem.Name = "loadBackgroundImageToolStripMenuItem";
            this.loadBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.loadBackgroundImageToolStripMenuItem.Text = "Load background image";
            // 
            // clearBackgroundImageToolStripMenuItem
            // 
            this.clearBackgroundImageToolStripMenuItem.Name = "clearBackgroundImageToolStripMenuItem";
            this.clearBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clearBackgroundImageToolStripMenuItem.Text = "Clear background image";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutQSLCardPrinterToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutQSLCardPrinterToolStripMenuItem
            // 
            this.aboutQSLCardPrinterToolStripMenuItem.Name = "aboutQSLCardPrinterToolStripMenuItem";
            this.aboutQSLCardPrinterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aboutQSLCardPrinterToolStripMenuItem.Text = "About QSL Card Printer";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureShortcutsToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // configureShortcutsToolStripMenuItem
            // 
            this.configureShortcutsToolStripMenuItem.Name = "configureShortcutsToolStripMenuItem";
            this.configureShortcutsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configureShortcutsToolStripMenuItem.Text = "Configure shortcuts";
            // 
            // groupBoxAdifConversion
            // 
            this.groupBoxAdifConversion.Controls.Add(this.buttonReadFromFile);
            this.groupBoxAdifConversion.Controls.Add(this.buttonReadClipboard);
            this.groupBoxAdifConversion.Controls.Add(this.dataGridViewAdifItems);
            this.groupBoxAdifConversion.Location = new System.Drawing.Point(718, 27);
            this.groupBoxAdifConversion.Name = "groupBoxAdifConversion";
            this.groupBoxAdifConversion.Size = new System.Drawing.Size(292, 411);
            this.groupBoxAdifConversion.TabIndex = 3;
            this.groupBoxAdifConversion.TabStop = false;
            this.groupBoxAdifConversion.Text = "Info of ADIF";
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
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Location = new System.Drawing.Point(6, 19);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(115, 23);
            this.buttonReadFromFile.TabIndex = 1;
            this.buttonReadFromFile.Text = "Read from file";
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            // 
            // panelDesigner
            // 
            this.panelDesigner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesigner.Location = new System.Drawing.Point(12, 27);
            this.panelDesigner.Name = "panelDesigner";
            this.panelDesigner.Size = new System.Drawing.Size(700, 450);
            this.panelDesigner.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 486);
            this.Controls.Add(this.panelDesigner);
            this.Controls.Add(this.groupBoxAdifConversion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "QSLCardPrinter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdifItems)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxAdifConversion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdifItems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBackgroundImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearBackgroundImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureShortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutQSLCardPrinterToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxAdifConversion;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.Button buttonReadClipboard;
        private System.Windows.Forms.Panel panelDesigner;
    }
}

