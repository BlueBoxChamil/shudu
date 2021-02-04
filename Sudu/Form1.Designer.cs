using SuDu;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


       

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.but2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_1 = new System.Windows.Forms.Button();
            this.num_2 = new System.Windows.Forms.Button();
            this.num_3 = new System.Windows.Forms.Button();
            this.num_4 = new System.Windows.Forms.Button();
            this.num_5 = new System.Windows.Forms.Button();
            this.num_9 = new System.Windows.Forms.Button();
            this.num_8 = new System.Windows.Forms.Button();
            this.num_7 = new System.Windows.Forms.Button();
            this.num_6 = new System.Windows.Forms.Button();
            this.num_delete = new System.Windows.Forms.Button();
            this.button_tip = new System.Windows.Forms.Button();
            this.label_tip = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.min_button = new System.Windows.Forms.Button();
            this.progressBar_sudoku = new System.Windows.Forms.ProgressBar();
            //this.progressBar1 = new SuDu.MyProgressBar();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("庞门正道标题体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(610, 195);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(166, 47);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "生成数独";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("庞门正道标题体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "简单",
            "中等",
            "困难"});
            this.comboBox1.Location = new System.Drawing.Point(610, 95);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "简单";
            // 
            // but2
            // 
            this.but2.Font = new System.Drawing.Font("庞门正道标题体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but2.Location = new System.Drawing.Point(610, 294);
            this.but2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(166, 47);
            this.but2.TabIndex = 2;
            this.but2.Text = "提交";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("庞门正道标题体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(606, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "错误次数：0";
            // 
            // num_1
            // 
            this.num_1.Location = new System.Drawing.Point(43, 425);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(46, 45);
            this.num_1.TabIndex = 5;
            this.num_1.Text = "1";
            this.num_1.UseVisualStyleBackColor = true;
            this.num_1.Click += new System.EventHandler(this.num_Click);
            // 
            // num_2
            // 
            this.num_2.Location = new System.Drawing.Point(106, 425);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(46, 45);
            this.num_2.TabIndex = 6;
            this.num_2.Text = "2";
            this.num_2.UseVisualStyleBackColor = true;
            this.num_2.Click += new System.EventHandler(this.num_Click);
            // 
            // num_3
            // 
            this.num_3.Location = new System.Drawing.Point(170, 425);
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(46, 45);
            this.num_3.TabIndex = 7;
            this.num_3.Text = "3";
            this.num_3.UseVisualStyleBackColor = true;
            this.num_3.Click += new System.EventHandler(this.num_Click);
            // 
            // num_4
            // 
            this.num_4.Location = new System.Drawing.Point(233, 425);
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(46, 45);
            this.num_4.TabIndex = 8;
            this.num_4.Text = "4";
            this.num_4.UseVisualStyleBackColor = true;
            this.num_4.Click += new System.EventHandler(this.num_Click);
            // 
            // num_5
            // 
            this.num_5.Location = new System.Drawing.Point(299, 425);
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(46, 45);
            this.num_5.TabIndex = 9;
            this.num_5.Text = "5";
            this.num_5.UseVisualStyleBackColor = true;
            this.num_5.Click += new System.EventHandler(this.num_Click);
            // 
            // num_9
            // 
            this.num_9.Location = new System.Drawing.Point(233, 477);
            this.num_9.Name = "num_9";
            this.num_9.Size = new System.Drawing.Size(46, 45);
            this.num_9.TabIndex = 13;
            this.num_9.Text = "9";
            this.num_9.UseVisualStyleBackColor = true;
            // 
            // num_8
            // 
            this.num_8.Location = new System.Drawing.Point(170, 477);
            this.num_8.Name = "num_8";
            this.num_8.Size = new System.Drawing.Size(46, 45);
            this.num_8.TabIndex = 12;
            this.num_8.Text = "8";
            this.num_8.UseVisualStyleBackColor = true;
            this.num_8.Click += new System.EventHandler(this.num_Click);
            // 
            // num_7
            // 
            this.num_7.Location = new System.Drawing.Point(106, 477);
            this.num_7.Name = "num_7";
            this.num_7.Size = new System.Drawing.Size(46, 45);
            this.num_7.TabIndex = 11;
            this.num_7.Text = "7";
            this.num_7.UseVisualStyleBackColor = true;
            this.num_7.Click += new System.EventHandler(this.num_Click);
            // 
            // num_6
            // 
            this.num_6.Location = new System.Drawing.Point(43, 477);
            this.num_6.Name = "num_6";
            this.num_6.Size = new System.Drawing.Size(46, 45);
            this.num_6.TabIndex = 10;
            this.num_6.Text = "6";
            this.num_6.UseVisualStyleBackColor = true;
            this.num_6.Click += new System.EventHandler(this.num_Click);
            // 
            // num_delete
            // 
            this.num_delete.Location = new System.Drawing.Point(299, 477);
            this.num_delete.Name = "num_delete";
            this.num_delete.Size = new System.Drawing.Size(46, 45);
            this.num_delete.TabIndex = 14;
            this.num_delete.Text = "DE";
            this.num_delete.UseVisualStyleBackColor = true;
            this.num_delete.Click += new System.EventHandler(this.num_delete_Click);
            // 
            // button_tip
            // 
            this.button_tip.Location = new System.Drawing.Point(369, 425);
            this.button_tip.Name = "button_tip";
            this.button_tip.Size = new System.Drawing.Size(44, 97);
            this.button_tip.TabIndex = 15;
            this.button_tip.Text = "TIP";
            this.button_tip.UseVisualStyleBackColor = true;
            this.button_tip.Click += new System.EventHandler(this.button_tip_Click);
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("庞门正道标题体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tip.Location = new System.Drawing.Point(606, 463);
            this.label_tip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(108, 20);
            this.label_tip.TabIndex = 16;
            this.label_tip.Text = "提示次数：0";
            // 
            // close_button
            // 
            this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(803, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(10, 10);
            this.close_button.TabIndex = 17;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // min_button
            // 
            this.min_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min_button.BackgroundImage")));
            this.min_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.min_button.FlatAppearance.BorderSize = 0;
            this.min_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_button.Location = new System.Drawing.Point(763, 12);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(10, 10);
            this.min_button.TabIndex = 18;
            this.min_button.UseVisualStyleBackColor = true;
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // progressBar_sudoku
            // 
            this.progressBar_sudoku.BackColor = System.Drawing.Color.Lime;
            this.progressBar_sudoku.ForeColor = System.Drawing.Color.Green;
            this.progressBar_sudoku.Location = new System.Drawing.Point(610, 499);
            this.progressBar_sudoku.Name = "progressBar_sudoku";
            this.progressBar_sudoku.Size = new System.Drawing.Size(100, 23);
            this.progressBar_sudoku.TabIndex = 19;
            this.progressBar_sudoku.Click += new System.EventHandler(this.progressBar_sudoku_Click);
            // 
            // progressBar1
            // 
            //this.progressBar1.Location = new System.Drawing.Point(485, 514);
            //this.progressBar1.Name = "progressBar1";
            //this.progressBar1.Size = new System.Drawing.Size(300, 23);
            //this.progressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(140)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(830, 558);
            this.Controls.Add(this.progressBar_sudoku);
            this.Controls.Add(this.min_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label_tip);
            this.Controls.Add(this.button_tip);
            this.Controls.Add(this.num_delete);
            this.Controls.Add(this.num_9);
            this.Controls.Add(this.num_8);
            this.Controls.Add(this.num_7);
            this.Controls.Add(this.num_6);
            this.Controls.Add(this.num_5);
            this.Controls.Add(this.num_4);
            this.Controls.Add(this.num_3);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("庞门正道标题体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "数独";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private ComboBox comboBox1;
        private Button but2;
        private Timer timer1;
        private Label label1;
        private Label label2;
        private Button num_1;
        private Button num_2;
        private Button num_3;
        private Button num_4;
        private Button num_5;
        private Button num_9;
        private Button num_8;
        private Button num_7;
        private Button num_6;
        private Button num_delete;
        private Button button_tip;
        private Label label_tip;
        private Button close_button;
        private Button min_button;
        private ProgressBar progressBar_sudoku;
        private MyProgressBar progressBar1; //新添此句，添加新的控件MyProgressBar
    }
}

