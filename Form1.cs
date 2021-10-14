using Der_KlassificatorML.Model;
using System;
using System.Windows.Forms;

namespace Der_Klassificator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.ShowDialog();
            if (img.FileName != null)

            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.ImageLocation = img.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add input data
            var input1 = new ModelInput();

            input1.ImageSource = pictureBox1.ImageLocation;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input1);

            label2.Text = result.Prediction.ToString();

        }


        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string caption = "InfoBox";
            MessageBox.Show("Das Modell ist trainiert, um Katzen, Löwen oder Schlangen zu erkennen", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
