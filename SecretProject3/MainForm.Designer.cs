namespace SecretProject3
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
            this.rectangleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.deleteSelectedShapesButton = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
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
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(135, 103);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(106, 23);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.Text = "RECTANGLE";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(425, 103);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(106, 23);
            this.triangleButton.TabIndex = 4;
            this.triangleButton.Text = "TRIANGLE";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(280, 103);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(106, 23);
            this.circleButton.TabIndex = 5;
            this.circleButton.Text = "CIRCLE";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(12, 103);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(94, 23);
            this.squareButton.TabIndex = 7;
            this.squareButton.Text = "SQUARE";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(690, 397);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(98, 41);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // deleteSelectedShapesButton
            // 
            this.deleteSelectedShapesButton.Location = new System.Drawing.Point(567, 369);
            this.deleteSelectedShapesButton.Name = "deleteSelectedShapesButton";
            this.deleteSelectedShapesButton.Size = new System.Drawing.Size(98, 69);
            this.deleteSelectedShapesButton.TabIndex = 9;
            this.deleteSelectedShapesButton.Text = "DELETE SELECTED SHAPES";
            this.deleteSelectedShapesButton.UseVisualStyleBackColor = true;
            this.deleteSelectedShapesButton.Click += new System.EventHandler(this.deleteSelectedShapesButton_Click);
            // 
            // brushButton
            // 
            this.brushButton.Location = new System.Drawing.Point(559, 103);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(106, 23);
            this.brushButton.TabIndex = 10;
            this.brushButton.Text = "BRUSH";
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.Location = new System.Drawing.Point(690, 103);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(106, 23);
            this.eraserButton.TabIndex = 11;
            this.eraserButton.Text = "ERASER";
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eraserButton);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.deleteSelectedShapesButton);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.rectangleButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button deleteSelectedShapesButton;
        private System.Windows.Forms.Button brushButton;
        private System.Windows.Forms.Button eraserButton;
    }
}

