using Timer = System.Windows.Forms.Timer;
namespace DZWF
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CounterClicks = new System.Windows.Forms.Label();
            this.MaxRecord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(342, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(240, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 200);
            this.button1.TabIndex = 1;
            this.button1.Text = "Нажми меня";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // CounterClicks
            // 
            this.CounterClicks.AutoSize = true;
            this.CounterClicks.Location = new System.Drawing.Point(382, 220);
            this.CounterClicks.Name = "CounterClicks";
            this.CounterClicks.Size = new System.Drawing.Size(13, 15);
            this.CounterClicks.TabIndex = 2;
            this.CounterClicks.Text = "0";
            // 
            // MaxRecord
            // 
            this.MaxRecord.AutoSize = true;
            this.MaxRecord.Location = new System.Drawing.Point(498, 220);
            this.MaxRecord.Name = "MaxRecord";
            this.MaxRecord.Size = new System.Drawing.Size(42, 15);
            this.MaxRecord.TabIndex = 3;
            this.MaxRecord.Text = "Max: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaxRecord);
            this.Controls.Add(this.CounterClicks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label CounterClicks;
        private Timer timer1;
        private Label MaxRecord;
    }
}