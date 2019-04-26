namespace QSLCardPrinter
{
    partial class FormConfigLabel
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
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.numericUpDownPositionX = new System.Windows.Forms.NumericUpDown();
            this.labelPositionTop = new System.Windows.Forms.Label();
            this.numericUpDownPositionY = new System.Windows.Forms.NumericUpDown();
            this.labelPositionLeft = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.groupBoxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.Controls.Add(this.numericUpDownPositionX);
            this.groupBoxPosition.Controls.Add(this.labelPositionTop);
            this.groupBoxPosition.Controls.Add(this.numericUpDownPositionY);
            this.groupBoxPosition.Controls.Add(this.labelPositionLeft);
            this.groupBoxPosition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Size = new System.Drawing.Size(118, 81);
            this.groupBoxPosition.TabIndex = 8;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Position";
            // 
            // numericUpDownPositionX
            // 
            this.numericUpDownPositionX.Location = new System.Drawing.Point(38, 25);
            this.numericUpDownPositionX.Name = "numericUpDownPositionX";
            this.numericUpDownPositionX.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownPositionX.TabIndex = 3;
            this.numericUpDownPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPositionX.ValueChanged += new System.EventHandler(this.NumericUpDownPositionXValueChanged);
            // 
            // labelPositionTop
            // 
            this.labelPositionTop.AutoSize = true;
            this.labelPositionTop.Location = new System.Drawing.Point(6, 51);
            this.labelPositionTop.Name = "labelPositionTop";
            this.labelPositionTop.Size = new System.Drawing.Size(26, 13);
            this.labelPositionTop.TabIndex = 4;
            this.labelPositionTop.Text = "Top";
            // 
            // numericUpDownPositionY
            // 
            this.numericUpDownPositionY.Location = new System.Drawing.Point(38, 49);
            this.numericUpDownPositionY.Name = "numericUpDownPositionY";
            this.numericUpDownPositionY.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownPositionY.TabIndex = 3;
            this.numericUpDownPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPositionY.ValueChanged += new System.EventHandler(this.NumericUpDownPositionYValueChanged);
            // 
            // labelPositionLeft
            // 
            this.labelPositionLeft.AutoSize = true;
            this.labelPositionLeft.Location = new System.Drawing.Point(6, 27);
            this.labelPositionLeft.Name = "labelPositionLeft";
            this.labelPositionLeft.Size = new System.Drawing.Size(25, 13);
            this.labelPositionLeft.TabIndex = 4;
            this.labelPositionLeft.Text = "Left";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(15, 128);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(115, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
            // 
            // buttonSelectFont
            // 
            this.buttonSelectFont.Location = new System.Drawing.Point(15, 99);
            this.buttonSelectFont.Name = "buttonSelectFont";
            this.buttonSelectFont.Size = new System.Drawing.Size(115, 23);
            this.buttonSelectFont.TabIndex = 9;
            this.buttonSelectFont.Text = "Select Font";
            this.buttonSelectFont.UseVisualStyleBackColor = true;
            this.buttonSelectFont.Click += new System.EventHandler(this.ButtonSelectFontClick);
            // 
            // FormConfigLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 163);
            this.Controls.Add(this.groupBoxPosition);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSelectFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormConfigLabel";
            this.Text = "Config label";
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionX;
        private System.Windows.Forms.Label labelPositionTop;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionY;
        private System.Windows.Forms.Label labelPositionLeft;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSelectFont;
    }
}