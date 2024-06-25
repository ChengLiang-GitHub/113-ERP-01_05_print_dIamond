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
                if (j > 0 && shapeSelectCB.SelectedIndex == 0)
                {
                    continue;
                }
                else if (j < 0 && shapeSelectCB.SelectedIndex == 1)
                {
                    continue;
                }
                for (int n = 0; n < Math.Abs(j) + k; n++)
                    showLB.Text += n < Math.Abs(j) ? "   " : (n - Math.Abs(j)) % 2 == 1 ? "   " : "★";
                // for (int n = 0; n < k; n++)
                //    showLB.Text += n % 2 == 0 ? "   " : "★";
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

        private void avgSummerTemperature(ref double[,] sourceTmp, out Double[] hiAvgTmp, out Double[] lwAvgTmp)
        {
            hiAvgTmp = new Double[sourceTmp.GetLength(0)];
            lwAvgTmp = new Double[sourceTmp.GetLength(0)];
            for (int i = 0; i < sourceTmp.GetLength(0); i++)
            {
                hiAvgTmp[i] = Math.Ceiling(Math.Max(Math.Abs(sourceTmp[i, 0]), Math.Abs(sourceTmp[i, 1])));
                lwAvgTmp[i] = Math.Floor(Math.Min(Math.Abs(sourceTmp[i, 0]), Math.Abs(sourceTmp[i, 1])));
            }
        }

        private void avgBTN_Click(object sender, EventArgs e)
        {
            double[,] avgTempInWeek = { { 28.5, 20.1 }, { -21.3, 29.3 }, { 30.2, 22.2 }, { 21.7, 23.7 }, { 32.6, -24.9 }, { 23.4, 25.2 }, { 34.1, -26.4 } };
            double avgHighTpInWeek = 0;
            double avgLowTpInWeek = 0;
            //MessageBox.Show(Math.Ceiling(avgTempInWeek[0, 0]).ToString() + "\t" + Math.Floor(avgTempInWeek[0, 1]).ToString());
            MessageBox.Show(avgTempInWeek.Rank.ToString() + " " + avgTempInWeek.GetLength(0).ToString());

            for (int i = 0; i < avgTempInWeek.GetLength(0); i++)
            {

                avgHighTpInWeek += Math.Ceiling(Math.Max(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])));
                avgLowTpInWeek += Math.Floor(Math.Min(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])));
                char sign1 = (avgTempInWeek[i, 0] < 0) ? '-' : ' ';
                char sign2 = (avgTempInWeek[i, 1] < 0) ? '-' : ' ';
                temperatureRTB.Text += "Max is " + sign1 + $"{Math.Max(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1]))} ({Math.Ceiling(Math.Max(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])))})" +
                                                            " Min is " + sign2 + $"{Math.Min(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1]))} ({Math.Floor(Math.Min(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])))})" + "\n" +
                                                            $"高溫平均 : {avgHighTpInWeek / (i + 1)}" + $" 低溫平均 : {avgLowTpInWeek / (i + 1)}" + "\n";

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
                ltRTB.Text += a[i] + ", ";	//排序前
            }
            Array.Sort(a);
            ltRTB.Text += "\nAfter sorting\n";
            for (int i = 0; i < a.Length; i++)
            {
                ltRTB.Text += a[i] + ", ";	//排序後
            }

        }

        private void shapeSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void callAvgFunBtn_Click(object sender, EventArgs e)
        {
            double[,] avgTempInWeek = { { 28.5, 20.1 }, { -21.3, 29.3 }, { 30.2, 22.2 }, { 21.7, 23.7 }, { 32.6, -24.9 }, { 23.4, 25.2 }, { 34.1, -26.4 } };
            Double[] hiAvgTmp;
            Double[] lwAvgTmp;
            avgSummerTemperature(ref avgTempInWeek, out hiAvgTmp, out lwAvgTmp);
            for (int i = 0; i < avgTempInWeek.GetLength(0); i++)

            {
                char sign1 = (avgTempInWeek[i, 0] < 0) ? '-' : ' ';
                char sign2 = (avgTempInWeek[i, 1] < 0) ? '-' : ' ';
                temperatureRTB.Text += "Max is " + sign1 + $"{Math.Max(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1]))} ({Math.Ceiling(Math.Max(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])))})" +
                                                            " Min is " + sign2 + $"{Math.Min(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1]))} ({Math.Floor(Math.Min(Math.Abs(avgTempInWeek[i, 0]), Math.Abs(avgTempInWeek[i, 1])))})" + "\n";
            }
            temperatureRTB.Text += "H : " + (hiAvgTmp.Sum() / avgTempInWeek.GetLength(0)).ToString("00") + "\n"
                                                          + "L : " + Math.Round((lwAvgTmp.Sum() / avgTempInWeek.GetLength(0)), 0, MidpointRounding.AwayFromZero) + "\n";

        }
        Dictionary<double, double[]> mJP2UsUkEru = new Dictionary<double, double[]>();
        Dictionary<double, double[]> fmJP2UsUkEru = new Dictionary<double, double[]>();
        private void Form1_Load(object sender, EventArgs e)
        {
            mJP2UsUkEru.Add(24, new double[] { 6, 5, 38.5 });
            mJP2UsUkEru.Add(24.5, new double[] { 6.5, 5.5, 39 });
            mJP2UsUkEru.Add(25, new double[] { 7, 6, 40 });
            mJP2UsUkEru.Add(25.5, new double[] { 7.5, 6.5, 40.5 });
            mJP2UsUkEru.Add(26, new double[] { 8, 7, 41 });
            mJP2UsUkEru.Add(26.5, new double[] { 8.5, 7.5, 42 });
            mJP2UsUkEru.Add(27, new double[] { 9, 8, 42.5 });
            mJP2UsUkEru.Add(27.5, new double[] { 9.5, 8.5, 43 });
            mJP2UsUkEru.Add(28, new double[] { 10, 9, 44 });
            mJP2UsUkEru.Add(29, new double[] { 10.5, 9.5, 44.5 });
            mJP2UsUkEru.Add(30, new double[] { 12, 11, 46 });
            mJP2UsUkEru.Add(30.5, new double[] { 12.5, 11.5, 47 });


            fmJP2UsUkEru.Add(21.5, new double[] { 4, 1.5, 34 });
            fmJP2UsUkEru.Add(22, new double[] { 4.5, 2, 35 });
            fmJP2UsUkEru.Add(22.5, new double[] { 5.5, 3, 36 });
            fmJP2UsUkEru.Add(23, new double[] { 6, 3.5, 37 });
            fmJP2UsUkEru.Add(23.5, new double[] { 6.5, 4, 37.5 });
            fmJP2UsUkEru.Add(24, new double[] { 7, 4.5, 38 });
            fmJP2UsUkEru.Add(24.5, new double[] { 7.5, 5, 38.5 });
            fmJP2UsUkEru.Add(25, new double[] { 8, 5.5, 39 });
            fmJP2UsUkEru.Add(25.5, new double[] { 8.5, 6, 40 });
            fmJP2UsUkEru.Add(26, new double[] { 9, 6.5, 40.5 });
            fmJP2UsUkEru.Add(26.5, new double[] { 9.5, 7, 41 });
            fmJP2UsUkEru.Add(27, new double[] { 10, 7.5, 42 });
            fmJP2UsUkEru.Add(27.5, new double[] { 10.5, 8, 42.5 });
            fmJP2UsUkEru.Add(28, new double[] { 11, 8.5, 43 });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            szOfShoesCB.Items.Clear();
            switch (genderCB.SelectedIndex)
            {
                case 0:
                    szOfShoesCB.Items.AddRange(new object[] { 24, 24.5, 25, 25.5, 26, 26.5, 27, 27.5, 28, 29, 30, 30.5 });
                    break;
                case 1:
                    szOfShoesCB.Items.AddRange(new object[] { 21.5, 22, 22.5, 23, 23.5, 24, 24.5, 25, 25.5, 26, 26.5, 27, 27.5, 28 });
                    break;
            }

        }

        private void szOfShoesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string[] str= { "US","UK","EUR",""};
            switch (genderCB.SelectedIndex)
            {
                case 0:
                    foreach(var c in szOfShoesCB.Text)
                    {
                        szOfShoesRTB.Text += c+"\n";
                    }
                   
                    //MessageBox.Show(mJP2UsUkEru[(double)szOfShoesCB.SelectedItem].GetType().ToString());

                   dataGridView1.DataSource = mJP2UsUkEru[Convert.ToDouble(szOfShoesCB.SelectedItem)].Select((p,i) => new { _ = str[i], 日碼轉US_UK_EUR= p }).ToList();

                    str[3] = $"US {mJP2UsUkEru[Convert.ToDouble(szOfShoesCB.SelectedItem)][0]} UK {mJP2UsUkEru[Convert.ToDouble(szOfShoesCB.SelectedItem)][1]} EUR {mJP2UsUkEru[Convert.ToDouble(szOfShoesCB.SelectedItem)][2]}";

                    MessageBox.Show(str[3]);
                    break;
                case 1:
                    dataGridView1.DataSource = fmJP2UsUkEru[(Double)szOfShoesCB.SelectedItem].Select((p, i) => new { _ = str[i], 日碼轉US_UK_EUR = p }).ToList();
                    str[3] = $"US {fmJP2UsUkEru[Convert.ToDouble(szOfShoesCB.SelectedItem)][0]} UK {fmJP2UsUkEru[Convert.ToDouble(szOfShoesCB.SelectedItem)][1]} EUR {fmJP2UsUkEru[Convert.ToDouble(szOfShoesCB.SelectedItem)][2]}";

                    MessageBox.Show(str[3]);
                    break;
            }

        }

    }
}

