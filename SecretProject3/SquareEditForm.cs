using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorGraphicEditor.Shapes;

namespace VectorGraphicEditor
{
    public partial class SquareEditForm : Form
    {
        private Square _square;
        public Square Square
        {
            get
            {
                return _square;
            }

            set
            {
                _square = value;
                textBoxWidth.Text = _square.Width.ToString();
                buttonColor.BackColor = _square.Color;
            }
        }
        public SquareEditForm()
        {
            InitializeComponent();
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Square.Width = int.Parse(textBoxWidth.Text);
                Square.Height = Square.Width;
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
