namespace VectorGraphicEditor
{
    partial class MainForm
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
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReset = new System.Windows.Forms.Button();
            this.deleteSelectedShapesButton = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCustomColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRectangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxSquare = new System.Windows.Forms.PictureBox();
            this.pictureBoxCircle = new System.Windows.Forms.PictureBox();
            this.pictureBoxEraser = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxTriangle = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).BeginInit();
            this.SuspendLayout();
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(512, 44);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(74, 33);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // deleteSelectedShapesButton
            // 
            this.deleteSelectedShapesButton.Location = new System.Drawing.Point(419, 21);
            this.deleteSelectedShapesButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteSelectedShapesButton.Name = "deleteSelectedShapesButton";
            this.deleteSelectedShapesButton.Size = new System.Drawing.Size(74, 56);
            this.deleteSelectedShapesButton.TabIndex = 9;
            this.deleteSelectedShapesButton.Text = "DELETE SELECTED SHAPES";
            this.deleteSelectedShapesButton.UseVisualStyleBackColor = true;
            this.deleteSelectedShapesButton.Click += new System.EventHandler(this.deleteSelectedShapesButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMenu.Controls.Add(this.buttonCustomColor);
            this.panelMenu.Controls.Add(this.deleteSelectedShapesButton);
            this.panelMenu.Controls.Add(this.buttonReset);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.pictureBoxRectangle);
            this.panelMenu.Controls.Add(this.pictureBoxSquare);
            this.panelMenu.Controls.Add(this.pictureBoxCircle);
            this.panelMenu.Controls.Add(this.pictureBoxEraser);
            this.panelMenu.Controls.Add(this.pictureBoxLine);
            this.panelMenu.Controls.Add(this.pictureBoxTriangle);
            this.panelMenu.Location = new System.Drawing.Point(-4, -4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1168, 98);
            this.panelMenu.TabIndex = 12;
            // 
            // buttonCustomColor
            // 
            this.buttonCustomColor.Location = new System.Drawing.Point(224, 37);
            this.buttonCustomColor.Name = "buttonCustomColor";
            this.buttonCustomColor.Size = new System.Drawing.Size(25, 25);
            this.buttonCustomColor.TabIndex = 19;
            this.buttonCustomColor.UseVisualStyleBackColor = true;
            this.buttonCustomColor.Click += new System.EventHandler(this.buttonCustomColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Background Color";
            // 
            // pictureBoxRectangle
            // 
            this.pictureBoxRectangle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRectangle.Image = global::SecretProject3.Properties.Resources.rectangle85;
            this.pictureBoxRectangle.Location = new System.Drawing.Point(601, 10);
            this.pictureBoxRectangle.Name = "pictureBoxRectangle";
            this.pictureBoxRectangle.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxRectangle.TabIndex = 16;
            this.pictureBoxRectangle.TabStop = false;
            this.pictureBoxRectangle.Click += new System.EventHandler(this.pictureBoxRectangle_Click);
            this.pictureBoxRectangle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxRectangle_Paint);
            // 
            // pictureBoxSquare
            // 
            this.pictureBoxSquare.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSquare.Image = global::SecretProject3.Properties.Resources.square85;
            this.pictureBoxSquare.Location = new System.Drawing.Point(692, 10);
            this.pictureBoxSquare.Name = "pictureBoxSquare";
            this.pictureBoxSquare.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxSquare.TabIndex = 15;
            this.pictureBoxSquare.TabStop = false;
            this.pictureBoxSquare.Click += new System.EventHandler(this.pictureBoxSquare_Click);
            this.pictureBoxSquare.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSquare_Paint);
            // 
            // pictureBoxCircle
            // 
            this.pictureBoxCircle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCircle.Image = global::SecretProject3.Properties.Resources.circle85;
            this.pictureBoxCircle.Location = new System.Drawing.Point(874, 10);
            this.pictureBoxCircle.Name = "pictureBoxCircle";
            this.pictureBoxCircle.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxCircle.TabIndex = 14;
            this.pictureBoxCircle.TabStop = false;
            this.pictureBoxCircle.Click += new System.EventHandler(this.pictureBoxCircle_Click);
            this.pictureBoxCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCircle_Paint);
            // 
            // pictureBoxEraser
            // 
            this.pictureBoxEraser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEraser.Image = global::SecretProject3.Properties.Resources.eraser85;
            this.pictureBoxEraser.Location = new System.Drawing.Point(965, 10);
            this.pictureBoxEraser.Name = "pictureBoxEraser";
            this.pictureBoxEraser.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxEraser.TabIndex = 13;
            this.pictureBoxEraser.TabStop = false;
            this.pictureBoxEraser.Click += new System.EventHandler(this.pictureBoxEraser_Click);
            this.pictureBoxEraser.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxEraser_Paint);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLine.Image = global::SecretProject3.Properties.Resources.line85;
            this.pictureBoxLine.Location = new System.Drawing.Point(1056, 10);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxLine.TabIndex = 12;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Click += new System.EventHandler(this.pictureBoxLine_Click);
            this.pictureBoxLine.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxLine_Paint);
            // 
            // pictureBoxTriangle
            // 
            this.pictureBoxTriangle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTriangle.Image = global::SecretProject3.Properties.Resources.triangle85;
            this.pictureBoxTriangle.Location = new System.Drawing.Point(783, 10);
            this.pictureBoxTriangle.Name = "pictureBoxTriangle";
            this.pictureBoxTriangle.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxTriangle.TabIndex = 11;
            this.pictureBoxTriangle.TabStop = false;
            this.pictureBoxTriangle.Click += new System.EventHandler(this.pictureBoxTriangle_Click);
            this.pictureBoxTriangle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTriangle_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 670);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button deleteSelectedShapesButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonCustomColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRectangle;
        private System.Windows.Forms.PictureBox pictureBoxSquare;
        private System.Windows.Forms.PictureBox pictureBoxCircle;
        private System.Windows.Forms.PictureBox pictureBoxEraser;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.PictureBox pictureBoxTriangle;
    }
}

