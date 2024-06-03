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
                if (j > 0 && shapeSelectCB.SelectedIndex==0)
                {
                    continue;
                }
                else if (j < 0 && shapeSelectCB.SelectedIndex == 1)
                {
                    continue;
                }
                for (int n = 0; n < Math.Abs(j) + k; n++)
                    showLB.Text += n < Math.Abs(j) ? "   " : (n - Math.Abs(j)) % 2 == 1 ? "   " : "��";
                // for (int n = 0; n < k; n++)
                //    showLB.Text += n % 2 == 0 ? "   " : "��";
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
            MessageBox.Show(avgTempInWeek.Rank.ToString());

            for (int i = 0; i < avgTempInWeek.GetLength(0); i++)
            {

                avgHighTpInWeek += Math.Ceiling(Math.Max(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])));
                avgLowTpInWeek += Math.Floor(Math.Min(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])));
                char sign1 = (avgTempInWeek[i, 0] < 0) ? '-' : ' ';
                char sign2 = (avgTempInWeek[i, 1] < 0) ? '-' : ' ';
                temperatureRTB.Text += "Max is " + sign1 + $"{Math.Max(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1]))} ({Math.Ceiling(Math.Max(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])))})" +
                                                            " Min is " + sign2 + $"{Math.Min(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1]))} ({Math.Floor(Math.Min(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])))})" + "\n" +
                                                            $"���ť��� : {avgHighTpInWeek / (i + 1)}" + $" �C�ť��� : {avgLowTpInWeek / (i + 1)}" + "\n";

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

        private void ltBTN_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            Random r = new Random();
            ltRTB.Text = "Before sorting \n";
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 50);
                ltRTB.Text += a[i] + ", ";	//�Ƨǫe
            }
            Array.Sort(a);
            ltRTB.Text += "\nAfter sorting\n";
            for (int i = 0; i < a.Length; i++)
            {
                ltRTB.Text += a[i] + ", ";	//�Ƨǫ�
            }

        }

        private void shapeSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

