using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Boolean wrongNum = false;
        private void button1_Click(object sender, EventArgs e)
        {
            int diamondSize;
            int lineNum;
            if (string.IsNullOrEmpty(diamondSizeTB.Text))
            {
                MessageBox.Show("Please keyin size");
                return;
            }
            if (wrongNum == true)
            {
                return;
            }
            diamondSize = Convert.ToInt32(diamondSizeTB.Text);
            lineNum = diamondSize * 2 - 1;
            showLB.Text = "";
            for (int i = 0, j = diamondSize - 1, k = 1; i < (lineNum); i++, j--, k = ((j >= 0) ? k + 2 : k - 2))
            {
                for (int n = 0; n < Math.Abs(j) + k; n++)
                    showLB.Text += n < Math.Abs(j) ? "   " : (n- Math.Abs(j)) % 2 == 1 ? "   " : "¡¹";
                showLB.Text += "\n";
                Console.WriteLine(k);
            }

        }

        private void diamondSizeTB_TextChanged(object sender, EventArgs e)
        {
            if (!((new Regex(@"^[0-9]+$")).IsMatch(diamondSizeTB.Text)))
            {
                MessageBox.Show("Please keyin positve number.");
                wrongNum = true;
                return;
            }
            wrongNum = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void avgBTN_Click(object sender, EventArgs e)
        {
            double[,] avgTempInWeek = { { 28.5, 20.1 }, { -21.3, 29.3 }, { 30.2, 22.2 }, { 21.7, 23.7 }, { 32.6, -24.9 }, { 23.4, 25.2 }, { 34.1, -26.4 } };
            double avgHighTpInWeek = 0;
            double avgLowTpInWeek = 0;
            //MessageBox.Show(Math.Ceiling(avgTempInWeek[0, 0]).ToString() + "\t" + Math.Floor(avgTempInWeek[0, 1]).ToString());
            // MessageBox.Show(avgTempInWeek.GetLength(0).ToString());

            for (int i = 0; i < avgTempInWeek.GetLength(0); i++)
            {
                if (Math.Abs(avgTempInWeek[i, 0]) > Math.Abs(avgTempInWeek[i, 1]))
                {
                    avgHighTpInWeek += Math.Ceiling(Math.Abs(avgTempInWeek[i, 0]));
                    avgLowTpInWeek += Math.Floor(Math.Abs(avgTempInWeek[i, 1]));
                }
                else
                {
                    avgHighTpInWeek += Math.Ceiling(Math.Abs(avgTempInWeek[i, 1]));
                    avgLowTpInWeek += Math.Floor(Math.Abs(avgTempInWeek[i, 0]));
                }

            }
            temperatureRTB.Text += "H : " + (avgHighTpInWeek / avgTempInWeek.GetLength(0)).ToString("00") + "\n"
                                                        + "L : " + Math.Round((avgLowTpInWeek / avgTempInWeek.GetLength(0)), 0, MidpointRounding.AwayFromZero) + "\n";
            //MessageBox.Show("H : " + (avgHighTpInWeek / avgTempInWeek.GetLength(0)).ToString("00.00"));
            //MessageBox.Show("L : " + (avgLowTpInWeek / avgTempInWeek.GetLength(0)).ToString("00.00"));
            //MessageBox.Show("H : " + Math.Round((avgHighTpInWeek / avgTempInWeek.GetLength(0)), 0, MidpointRounding.AwayFromZero));
            //MessageBox.Show("L : " + Math.Round((avgLowTpInWeek / avgTempInWeek.GetLength(0)), 0, MidpointRounding.AwayFromZero));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void hiddenBTN_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            temperatureRTB.Text = "";
        }
    }
}

