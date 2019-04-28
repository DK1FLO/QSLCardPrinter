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
            this.groupBoxLastActiveTemplate.SuspendLayout();
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
            this.buttonOk.Location = new System.Drawing.Point(451, 90);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(532, 90);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // ConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 121);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxLastActiveTemplate);
            this.Name = "ConfigurationDialog";
            this.Text = "Configure QSLCardPrinter";
            this.groupBoxLastActiveTemplate.ResumeLayout(false);
            this.groupBoxLastActiveTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxLoadLastTemplate;
        private System.Windows.Forms.TextBox textBoxLastActiveTemplateFileName;
        private System.Windows.Forms.GroupBox groupBoxLastActiveTemplate;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}