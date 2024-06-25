namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            diamondSizeTB = new TextBox();
            printBTN = new Button();
            label2 = new Label();
            showLB = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            shapeSelectCB = new ComboBox();
            avgWeekTPg = new TabPage();
            callAvgFunBtn = new Button();
            hiddenBTN = new Button();
            panel1 = new Panel();
            temperatureRTB = new RichTextBox();
            showBTN = new Button();
            avgBTN = new Button();
            tabPage2 = new TabPage();
            ltRTB = new RichTextBox();
            ltBTN = new Button();
            tabPage3 = new TabPage();
            szOfShoesRTB = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            szOfShoesCB = new ComboBox();
            genderCB = new ComboBox();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            avgWeekTPg.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Size";
            label1.Click += label1_Click;
            // 
            // diamondSizeTB
            // 
            diamondSizeTB.Location = new Point(54, 17);
            diamondSizeTB.Name = "diamondSizeTB";
            diamondSizeTB.Size = new Size(100, 23);
            diamondSizeTB.TabIndex = 1;
            diamondSizeTB.TextChanged += diamondSizeTB_TextChanged;
            // 
            // printBTN
            // 
            printBTN.Location = new Point(6, 90);
            printBTN.Name = "printBTN";
            printBTN.Size = new Size(75, 23);
            printBTN.TabIndex = 2;
            printBTN.Text = "Print";
            printBTN.UseVisualStyleBackColor = true;
            printBTN.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 20);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Result";
            label2.Click += label2_Click;
            // 
            // showLB
            // 
            showLB.AutoSize = true;
            showLB.Font = new Font("Microsoft JhengHei UI", 12F);
            showLB.ForeColor = Color.Gold;
            showLB.Location = new Point(185, 45);
            showLB.Name = "showLB";
            showLB.Size = new Size(0, 20);
            showLB.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(avgWeekTPg);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(766, 426);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(shapeSelectCB);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(printBTN);
            tabPage1.Controls.Add(showLB);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(diamondSizeTB);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(758, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "print diamond";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 49);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Shape";
            // 
            // shapeSelectCB
            // 
            shapeSelectCB.FormattingEnabled = true;
            shapeSelectCB.Items.AddRange(new object[] { "▼", "▲", "Diamond" });
            shapeSelectCB.Location = new Point(55, 49);
            shapeSelectCB.Name = "shapeSelectCB";
            shapeSelectCB.Size = new Size(100, 23);
            shapeSelectCB.TabIndex = 5;
            shapeSelectCB.Text = "Diamond";
            shapeSelectCB.SelectedIndexChanged += shapeSelectCB_SelectedIndexChanged;
            // 
            // avgWeekTPg
            // 
            avgWeekTPg.Controls.Add(callAvgFunBtn);
            avgWeekTPg.Controls.Add(hiddenBTN);
            avgWeekTPg.Controls.Add(panel1);
            avgWeekTPg.Controls.Add(showBTN);
            avgWeekTPg.Controls.Add(avgBTN);
            avgWeekTPg.Location = new Point(4, 24);
            avgWeekTPg.Name = "avgWeekTPg";
            avgWeekTPg.Padding = new Padding(3);
            avgWeekTPg.Size = new Size(758, 398);
            avgWeekTPg.TabIndex = 1;
            avgWeekTPg.Text = "一周均溫";
            avgWeekTPg.UseVisualStyleBackColor = true;
            // 
            // callAvgFunBtn
            // 
            callAvgFunBtn.Location = new Point(26, 116);
            callAvgFunBtn.Name = "callAvgFunBtn";
            callAvgFunBtn.Size = new Size(94, 23);
            callAvgFunBtn.TabIndex = 4;
            callAvgFunBtn.Text = "call avgFun";
            callAvgFunBtn.UseVisualStyleBackColor = true;
            callAvgFunBtn.Click += callAvgFunBtn_Click;
            // 
            // hiddenBTN
            // 
            hiddenBTN.Location = new Point(25, 89);
            hiddenBTN.Name = "hiddenBTN";
            hiddenBTN.Size = new Size(75, 23);
            hiddenBTN.TabIndex = 3;
            hiddenBTN.Text = "hidden";
            hiddenBTN.UseVisualStyleBackColor = true;
            hiddenBTN.Click += hiddenBTN_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(temperatureRTB);
            panel1.Location = new Point(159, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 346);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // temperatureRTB
            // 
            temperatureRTB.Location = new Point(14, 12);
            temperatureRTB.Name = "temperatureRTB";
            temperatureRTB.Size = new Size(404, 312);
            temperatureRTB.TabIndex = 0;
            temperatureRTB.Text = "";
            // 
            // showBTN
            // 
            showBTN.Location = new Point(26, 60);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(75, 23);
            showBTN.TabIndex = 1;
            showBTN.Text = "show";
            showBTN.UseVisualStyleBackColor = true;
            showBTN.Click += button1_Click_1;
            // 
            // avgBTN
            // 
            avgBTN.Location = new Point(26, 31);
            avgBTN.Name = "avgBTN";
            avgBTN.Size = new Size(75, 23);
            avgBTN.TabIndex = 0;
            avgBTN.Text = "average";
            avgBTN.UseVisualStyleBackColor = true;
            avgBTN.Click += avgBTN_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ltRTB);
            tabPage2.Controls.Add(ltBTN);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(758, 398);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "樂透";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ltRTB
            // 
            ltRTB.Location = new Point(129, 18);
            ltRTB.Name = "ltRTB";
            ltRTB.Size = new Size(558, 348);
            ltRTB.TabIndex = 1;
            ltRTB.Text = "";
            // 
            // ltBTN
            // 
            ltBTN.Location = new Point(18, 15);
            ltBTN.Name = "ltBTN";
            ltBTN.Size = new Size(75, 23);
            ltBTN.TabIndex = 0;
            ltBTN.Text = "start";
            ltBTN.UseVisualStyleBackColor = true;
            ltBTN.Click += ltBTN_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(szOfShoesRTB);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(szOfShoesCB);
            tabPage3.Controls.Add(genderCB);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(758, 398);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "鞋碼轉換";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // szOfShoesRTB
            // 
            szOfShoesRTB.Location = new Point(384, 31);
            szOfShoesRTB.Name = "szOfShoesRTB";
            szOfShoesRTB.Size = new Size(350, 125);
            szOfShoesRTB.TabIndex = 4;
            szOfShoesRTB.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 51);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 3;
            label5.Text = "the size of shoes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 22);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 2;
            label4.Text = "gender";
            // 
            // szOfShoesCB
            // 
            szOfShoesCB.FormattingEnabled = true;
            szOfShoesCB.Location = new Point(120, 48);
            szOfShoesCB.Name = "szOfShoesCB";
            szOfShoesCB.Size = new Size(121, 23);
            szOfShoesCB.TabIndex = 1;
            szOfShoesCB.SelectedIndexChanged += szOfShoesCB_SelectedIndexChanged;
            // 
            // genderCB
            // 
            genderCB.FormattingEnabled = true;
            genderCB.Items.AddRange(new object[] { "Male", "Female" });
            genderCB.Location = new Point(120, 19);
            genderCB.Name = "genderCB";
            genderCB.Size = new Size(121, 23);
            genderCB.TabIndex = 0;
            genderCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(279, 248);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            avgWeekTPg.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox diamondSizeTB;
        private Button printBTN;
        private Label label2;
        private Label showLB;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage avgWeekTPg;
        private Button avgBTN;
        private Button showBTN;
        private Panel panel1;
        private RichTextBox temperatureRTB;
        private Button hiddenBTN;
        private TabPage tabPage2;
        private RichTextBox ltRTB;
        private Button ltBTN;
        private ComboBox shapeSelectCB;
        private Label label3;
        private Button callAvgFunBtn;
        private TabPage tabPage3;
        private ComboBox genderCB;
        private ComboBox szOfShoesCB;
        private Label label5;
        private Label label4;
        private RichTextBox szOfShoesRTB;
        private DataGridView dataGridView1;
    }
}
