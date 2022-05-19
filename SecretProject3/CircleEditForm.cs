using SecretProject3.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretProject3
{
    public partial class CircleEditForm : Form
    {
        private Circle _circle;
        public Circle Circle
        {
            get
            {
                return _circle;
            }
            set
            {
                _circle = value;
                textBoxRadius.Text = _circle.Radius.ToString();
                buttonColor.BackColor = _circle.Color;
            }
        }
        public CircleEditForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Circle.Radius = int.Parse(textBoxRadius.Text);
                Circle.Color = buttonColor.BackColor; //TO TEST...

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
