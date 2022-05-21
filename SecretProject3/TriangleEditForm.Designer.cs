namespace VectorGraphicEditor
{
    partial class TriangleEditForm
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
            this.colorLabel = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.customPointsButton = new System.Windows.Forms.Button();
            this.customPointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(12, 123);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(39, 16);
            this.colorLabel.TabIndex = 15;
            this.colorLabel.Text = "Color";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 142);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(343, 23);
            this.buttonColor.TabIndex = 14;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(12, 31);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(343, 22);
            this.textBoxWidth.TabIndex = 13;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(199, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 12);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(41, 16);
            this.widthLabel.TabIndex = 11;
            this.widthLabel.Text = "Width";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(12, 91);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(343, 22);
            this.textBoxHeight.TabIndex = 10;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(280, 278);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 72);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(46, 16);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Height";
            // 
            // customPointsButton
            // 
            this.customPointsButton.Location = new System.Drawing.Point(12, 198);
            this.customPointsButton.Name = "customPointsButton";
            this.customPointsButton.Size = new System.Drawing.Size(343, 64);
            this.customPointsButton.TabIndex = 16;
            this.customPointsButton.Text = "Click for custom points triangle";
            this.customPointsButton.UseVisualStyleBackColor = true;
            this.customPointsButton.Click += new System.EventHandler(this.customPointsButton_Click);
            // 
            // customPointsLabel
            // 
            this.customPointsLabel.AutoSize = true;
            this.customPointsLabel.Location = new System.Drawing.Point(12, 179);
            this.customPointsLabel.Name = "customPointsLabel";
            this.customPointsLabel.Size = new System.Drawing.Size(92, 16);
            this.customPointsLabel.TabIndex = 17;
            this.customPointsLabel.Text = "Custom Points";
            // 
            // TriangleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.customPointsLabel);
            this.Controls.Add(this.customPointsButton);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.heightLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriangleEditForm";
            this.ShowIcon = false;
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button customPointsButton;
        private System.Windows.Forms.Label customPointsLabel;
    }
}