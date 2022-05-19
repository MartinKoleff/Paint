using SecretProject3.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretProject3
{
    public partial class RectangleEditForm : Form
    {
        private Rectangle _rectangle;
        public Rectangle Rectangle
        {
            get
            {
                return _rectangle;
            }

            set
            {
                _rectangle = value;
                textBoxWidth.Text = _rectangle.Width.ToString();
                textBoxHeight.Text = _rectangle.Height.ToString();
                buttonColor.BackColor = _rectangle.Color;
            }
        }
        public RectangleEditForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle.Width = int.Parse(textBoxWidth.Text);
                Rectangle.Height = int.Parse(textBoxHeight.Text);
                Rectangle.Color = buttonColor.BackColor; //TO TEST...

            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = cd.Color;
        }
    }
}
