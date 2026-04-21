namespace proiect_arhitectura_sistemelor_de_calcul
{
    public partial class CPUViewerForm : Form
    {
        public CPUViewerForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                //put parse logic here
            }
        }
    }
}
