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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startLabelWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutQSLCardPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDesigner = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonLoadFromClip = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(768, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTemplateToolStripMenuItem,
            this.saveTemplateToolStripMenuItem,
            this.toolStripSeparator1,
            this.startLabelWizardToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTemplateToolStripMenuItem
            // 
            this.openTemplateToolStripMenuItem.Name = "openTemplateToolStripMenuItem";
            this.openTemplateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openTemplateToolStripMenuItem.Text = "Open Template";
            this.openTemplateToolStripMenuItem.Click += new System.EventHandler(this.OpenTemplateToolStripMenuItemClick);
            // 
            // saveTemplateToolStripMenuItem
            // 
            this.saveTemplateToolStripMenuItem.Name = "saveTemplateToolStripMenuItem";
            this.saveTemplateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveTemplateToolStripMenuItem.Text = "Save Template";
            this.saveTemplateToolStripMenuItem.Click += new System.EventHandler(this.SaveTemplateToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // startLabelWizardToolStripMenuItem
            // 
            this.startLabelWizardToolStripMenuItem.Name = "startLabelWizardToolStripMenuItem";
            this.startLabelWizardToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.startLabelWizardToolStripMenuItem.Text = "Start label wizard";
            this.startLabelWizardToolStripMenuItem.Click += new System.EventHandler(this.StartLabelWizardToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
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
            this.loadBackgroundImageToolStripMenuItem.Click += new System.EventHandler(this.LoadBackgroundImageToolStripMenuItemClick);
            // 
            // clearBackgroundImageToolStripMenuItem
            // 
            this.clearBackgroundImageToolStripMenuItem.Name = "clearBackgroundImageToolStripMenuItem";
            this.clearBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.clearBackgroundImageToolStripMenuItem.Text = "Clear background image";
            this.clearBackgroundImageToolStripMenuItem.Click += new System.EventHandler(this.ClearBackgroundImageToolStripMenuItemClick);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.ConfigureToolStripMenuItemClick);
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
            // panelDesigner
            // 
            this.panelDesigner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesigner.Location = new System.Drawing.Point(12, 27);
            this.panelDesigner.Name = "panelDesigner";
            this.panelDesigner.Size = new System.Drawing.Size(700, 450);
            this.panelDesigner.TabIndex = 4;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(718, 73);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(40, 40);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // buttonLoadFromClip
            // 
            this.buttonLoadFromClip.Location = new System.Drawing.Point(718, 27);
            this.buttonLoadFromClip.Name = "buttonLoadFromClip";
            this.buttonLoadFromClip.Size = new System.Drawing.Size(40, 40);
            this.buttonLoadFromClip.TabIndex = 5;
            this.buttonLoadFromClip.UseVisualStyleBackColor = true;
            this.buttonLoadFromClip.Click += new System.EventHandler(this.ButtonLoadFromClip_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 486);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonLoadFromClip);
            this.Controls.Add(this.panelDesigner);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "QSLCardPrinter";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBackgroundImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearBackgroundImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutQSLCardPrinterToolStripMenuItem;
        private System.Windows.Forms.Panel panelDesigner;
        private System.Windows.Forms.ToolStripMenuItem startLabelWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonLoadFromClip;
        private System.Windows.Forms.Button buttonPrint;
    }
}

