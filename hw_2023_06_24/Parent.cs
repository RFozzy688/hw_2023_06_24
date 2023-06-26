namespace hw_2023_06_24
{
    public partial class Parent : Form
    {
        public Child ChildForm { get; set; }
        public TextBox TextBoxParent { get; set; }
        public Parent()
        {
            InitializeComponent();
            this.Show();

            ChildForm = new Child(this);
            ChildForm.Show();
            TextBoxParent = textBox1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChildForm.TextBoxChild.Text = textBox1.Text;
        }
    }
}