using System;
using System.Windows.Forms;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalc.Click += btnCalc_Click;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                Vector3 A = new Vector3(
                    float.Parse(txtAx.Text),
                    float.Parse(txtAy.Text),
                    float.Parse(txtAz.Text));

                Vector3 B = new Vector3(
                    float.Parse(txtBx.Text),
                    float.Parse(txtBy.Text),
                    float.Parse(txtBz.Text));

                Vector3 C = new Vector3(
                    float.Parse(txtCx.Text),
                    float.Parse(txtCy.Text),
                    float.Parse(txtCz.Text));

                Vector3 normal = ComputeUnitNormal(A, B, C);

                lblResult.Text =
                    $"Normala unitară:\n" +
                    $"Nx = {normal.X:F3}\n" +
                    $"Ny = {normal.Y:F3}\n" +
                    $"Nz = {normal.Z:F3}";
            }
            catch
            {
                MessageBox.Show("Date invalide!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Vector3 ComputeUnitNormal(Vector3 A, Vector3 B, Vector3 C)
        {
            Vector3 AB = B - A;
            Vector3 AC = C - A;

            Vector3 normal = Vector3.Cross(AB, AC);

            if (normal.Length() == 0)
                throw new Exception("Triunghi degenerat");

            return Vector3.Normalize(normal);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click_1(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
