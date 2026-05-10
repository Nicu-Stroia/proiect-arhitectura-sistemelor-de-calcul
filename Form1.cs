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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var parsed = ASMParser.Parse(openFileDialog.FileName);
                if (parsed.Count != 0)
                    MessageBox.Show(
                        "Parsed successfully",
                        "Parse status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                else
                    MessageBox.Show(
                        "Parsed failed",
                        "Parse status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                parsedTextBox.Lines = parsed.ToArray();
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if the file is loaded and update the registers
        }
    }
}
