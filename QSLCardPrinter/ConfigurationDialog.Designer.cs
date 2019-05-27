namespace QSLCardPrinter
{
    partial class ConfigurationDialog
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
            this.checkBoxLoadLastTemplate = new System.Windows.Forms.CheckBox();
            this.textBoxLastActiveTemplateFileName = new System.Windows.Forms.TextBox();
            this.groupBoxLastActiveTemplate = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxLoadLastActiveBackgroundImage = new System.Windows.Forms.CheckBox();
            this.groupBoxBackgroundImage = new System.Windows.Forms.GroupBox();
            this.textBoxLastActiveBackgroundImageFileName = new System.Windows.Forms.TextBox();
            this.groupBoxQSLFormat = new System.Windows.Forms.GroupBox();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.groupBoxLastActiveTemplate.SuspendLayout();
            this.groupBoxBackgroundImage.SuspendLayout();
            this.groupBoxQSLFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxLoadLastTemplate
            // 
            this.checkBoxLoadLastTemplate.AutoSize = true;
            this.checkBoxLoadLastTemplate.Location = new System.Drawing.Point(6, 19);
            this.checkBoxLoadLastTemplate.Name = "checkBoxLoadLastTemplate";
            this.checkBoxLoadLastTemplate.Size = new System.Drawing.Size(359, 17);
            this.checkBoxLoadLastTemplate.TabIndex = 0;
            this.checkBoxLoadLastTemplate.Text = "Load last active template on startup? Currently, this is the last template:";
            this.checkBoxLoadLastTemplate.UseVisualStyleBackColor = true;
            // 
            // textBoxLastActiveTemplateFileName
            // 
            this.textBoxLastActiveTemplateFileName.Location = new System.Drawing.Point(6, 42);
            this.textBoxLastActiveTemplateFileName.Name = "textBoxLastActiveTemplateFileName";
            this.textBoxLastActiveTemplateFileName.ReadOnly = true;
            this.textBoxLastActiveTemplateFileName.Size = new System.Drawing.Size(583, 20);
            this.textBoxLastActiveTemplateFileName.TabIndex = 1;
            // 
            // groupBoxLastActiveTemplate
            // 
            this.groupBoxLastActiveTemplate.Controls.Add(this.checkBoxLoadLastTemplate);
            this.groupBoxLastActiveTemplate.Controls.Add(this.textBoxLastActiveTemplateFileName);
            this.groupBoxLastActiveTemplate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLastActiveTemplate.Name = "groupBoxLastActiveTemplate";
            this.groupBoxLastActiveTemplate.Size = new System.Drawing.Size(595, 72);
            this.groupBoxLastActiveTemplate.TabIndex = 2;
            this.groupBoxLastActiveTemplate.TabStop = false;
            this.groupBoxLastActiveTemplate.Text = "Default template";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(449, 235);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(530, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // checkBoxLoadLastActiveBackgroundImage
            // 
            this.checkBoxLoadLastActiveBackgroundImage.AutoSize = true;
            this.checkBoxLoadLastActiveBackgroundImage.Location = new System.Drawing.Point(6, 19);
            this.checkBoxLoadLastActiveBackgroundImage.Name = "checkBoxLoadLastActiveBackgroundImage";
            this.checkBoxLoadLastActiveBackgroundImage.Size = new System.Drawing.Size(501, 17);
            this.checkBoxLoadLastActiveBackgroundImage.TabIndex = 5;
            this.checkBoxLoadLastActiveBackgroundImage.Text = "Load last active background image? Currently, the last background image loaded ca" +
    "n be found here:";
            this.checkBoxLoadLastActiveBackgroundImage.UseVisualStyleBackColor = true;
            // 
            // groupBoxBackgroundImage
            // 
            this.groupBoxBackgroundImage.Controls.Add(this.checkBoxLoadLastActiveBackgroundImage);
            this.groupBoxBackgroundImage.Controls.Add(this.textBoxLastActiveBackgroundImageFileName);
            this.groupBoxBackgroundImage.Location = new System.Drawing.Point(12, 90);
            this.groupBoxBackgroundImage.Name = "groupBoxBackgroundImage";
            this.groupBoxBackgroundImage.Size = new System.Drawing.Size(595, 72);
            this.groupBoxBackgroundImage.TabIndex = 6;
            this.groupBoxBackgroundImage.TabStop = false;
            this.groupBoxBackgroundImage.Text = "Background image";
            // 
            // textBoxLastActiveBackgroundImageFileName
            // 
            this.textBoxLastActiveBackgroundImageFileName.Location = new System.Drawing.Point(6, 42);
            this.textBoxLastActiveBackgroundImageFileName.Name = "textBoxLastActiveBackgroundImageFileName";
            this.textBoxLastActiveBackgroundImageFileName.ReadOnly = true;
            this.textBoxLastActiveBackgroundImageFileName.Size = new System.Drawing.Size(583, 20);
            this.textBoxLastActiveBackgroundImageFileName.TabIndex = 1;
            // 
            // groupBoxQSLFormat
            // 
            this.groupBoxQSLFormat.Controls.Add(this.labelHeight);
            this.groupBoxQSLFormat.Controls.Add(this.labelWidth);
            this.groupBoxQSLFormat.Controls.Add(this.numericUpDownHeight);
            this.groupBoxQSLFormat.Controls.Add(this.numericUpDownWidth);
            this.groupBoxQSLFormat.Location = new System.Drawing.Point(12, 168);
            this.groupBoxQSLFormat.Name = "groupBoxQSLFormat";
            this.groupBoxQSLFormat.Size = new System.Drawing.Size(172, 88);
            this.groupBoxQSLFormat.TabIndex = 7;
            this.groupBoxQSLFormat.TabStop = false;
            this.groupBoxQSLFormat.Text = "QSL card format";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(87, 30);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownWidth.TabIndex = 0;
            this.numericUpDownWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(87, 56);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownHeight.TabIndex = 0;
            this.numericUpDownHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 32);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(63, 13);
            this.labelWidth.TabIndex = 1;
            this.labelWidth.Text = "Width [mm]:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 58);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(66, 13);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height [mm]:";
            // 
            // ConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 270);
            this.Controls.Add(this.groupBoxQSLFormat);
            this.Controls.Add(this.groupBoxBackgroundImage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxLastActiveTemplate);
            this.Name = "ConfigurationDialog";
            this.Text = "Configure QSLCardPrinter";
            this.groupBoxLastActiveTemplate.ResumeLayout(false);
            this.groupBoxLastActiveTemplate.PerformLayout();
            this.groupBoxBackgroundImage.ResumeLayout(false);
            this.groupBoxBackgroundImage.PerformLayout();
            this.groupBoxQSLFormat.ResumeLayout(false);
            this.groupBoxQSLFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxLoadLastTemplate;
        private System.Windows.Forms.TextBox textBoxLastActiveTemplateFileName;
        private System.Windows.Forms.GroupBox groupBoxLastActiveTemplate;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxLoadLastActiveBackgroundImage;
        private System.Windows.Forms.GroupBox groupBoxBackgroundImage;
        private System.Windows.Forms.TextBox textBoxLastActiveBackgroundImageFileName;
        private System.Windows.Forms.GroupBox groupBoxQSLFormat;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
    }
}