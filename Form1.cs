namespace proiect_arhitectura_sistemelor_de_calcul
{
    public partial class CPUViewerForm : Form
    {
        public CPUViewerForm()
        {
            InitializeComponent();

            instructionLoader.Load("InstructiuniProcesor.xlsx");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                parsedLines = ASMParser.Parse(openFileDialog.FileName);
                if (parsedLines.Count != 0)
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

                parsedTextBox.Lines = parsedLines.ToArray();
            }
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (parsedLines == null || parsedLines.Count == 0)
            {
                MessageBox.Show(
                         "Parsed content does not exist",
                         "Step status",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                return;
            }
        }
    }
}
