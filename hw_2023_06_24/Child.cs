using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_2023_06_24
{
    public partial class Child : Form
    {
        public Parent ParentForm { get; set; }
        public TextBox TextBoxChild { get; set; }
        public Child()
        {
            InitializeComponent();
        }
        public Child(Parent parent)
        {
            InitializeComponent();

            ParentForm = parent;
            Location = new Point(ParentForm.Location.X, ParentForm.Location.Y + ParentForm.Height + 10);

            TextBoxChild = textBox1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ParentForm.TextBoxParent.Text = TextBoxChild.Text;
        }
    }
}
