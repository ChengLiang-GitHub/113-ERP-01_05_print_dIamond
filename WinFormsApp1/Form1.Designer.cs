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
            avgWeekTPg = new TabPage();
            hiddenBTN = new Button();
            panel1 = new Panel();
            temperatureRTB = new RichTextBox();
            showBTN = new Button();
            avgBTN = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            avgWeekTPg.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Size";
            label1.Click += label1_Click;
            // 
            // diamondSizeTB
            // 
            diamondSizeTB.Location = new Point(12, 27);
            diamondSizeTB.Name = "diamondSizeTB";
            diamondSizeTB.Size = new Size(100, 23);
            diamondSizeTB.TabIndex = 1;
            diamondSizeTB.TextChanged += diamondSizeTB_TextChanged;
            // 
            // printBTN
            // 
            printBTN.Location = new Point(12, 56);
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
            label2.Location = new Point(17, 12);
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
            showLB.Location = new Point(17, 42);
            showLB.Name = "showLB";
            showLB.Size = new Size(0, 20);
            showLB.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(avgWeekTPg);
            tabControl1.Location = new Point(135, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(643, 426);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(showLB);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(635, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "print diamond";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // avgWeekTPg
            // 
            avgWeekTPg.Controls.Add(hiddenBTN);
            avgWeekTPg.Controls.Add(panel1);
            avgWeekTPg.Controls.Add(showBTN);
            avgWeekTPg.Controls.Add(avgBTN);
            avgWeekTPg.Location = new Point(4, 24);
            avgWeekTPg.Name = "avgWeekTPg";
            avgWeekTPg.Padding = new Padding(3);
            avgWeekTPg.Size = new Size(635, 398);
            avgWeekTPg.TabIndex = 1;
            avgWeekTPg.Text = "一周均溫";
            avgWeekTPg.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(printBTN);
            Controls.Add(diamondSizeTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            avgWeekTPg.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}
