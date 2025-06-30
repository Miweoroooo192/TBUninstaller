using System.IO;
using System.Windows.Forms;
namespace TBUnistaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(Path.GetTempPath(), "Trollbox")))
            {
                label2.Visible = true;
                label1.Visible = false;
                button1.Visible = false;
                try {
                    Directory.Delete(Path.Combine(Path.GetTempPath(), "Trollbox"), true);
                }
                catch ( Exception err)
                {
                    MessageBox.Show(err.Message, "Error");
                }
                finally
                {
                    MessageBox.Show("Done!", "Done!", MessageBoxButtons.OK);
                    Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show($"{Path.Combine(Path.GetTempPath(), "Trollbox")} Doenst Exist", "Its not installed yet");
            }
        }
    }
}
