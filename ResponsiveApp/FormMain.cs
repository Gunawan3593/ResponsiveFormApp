namespace ResponsiveApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form test = new FormTest();
            test.MdiParent = this;
            test.Show();
        }
    }
}
