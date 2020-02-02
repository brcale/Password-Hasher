namespace Csharp_passwordhash
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.enteredPasswordTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.hashedMessage2 = new System.Windows.Forms.Label();
            this.numberOfTimes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(66, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter password: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enteredPasswordTB
            // 
            this.enteredPasswordTB.Location = new System.Drawing.Point(192, 81);
            this.enteredPasswordTB.Name = "enteredPasswordTB";
            this.enteredPasswordTB.Size = new System.Drawing.Size(193, 20);
            this.enteredPasswordTB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hash/Insert to base";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox1.Location = new System.Drawing.Point(192, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show password?";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // hashedMessage2
            // 
            this.hashedMessage2.AutoSize = true;
            this.hashedMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.hashedMessage2.ForeColor = System.Drawing.SystemColors.Info;
            this.hashedMessage2.Location = new System.Drawing.Point(191, 192);
            this.hashedMessage2.Name = "hashedMessage2";
            this.hashedMessage2.Size = new System.Drawing.Size(58, 22);
            this.hashedMessage2.TabIndex = 4;
            this.hashedMessage2.Text = "label2";
            this.hashedMessage2.Click += new System.EventHandler(this.hashedMessage2_Click);
            // 
            // numberOfTimes
            // 
            this.numberOfTimes.AutoSize = true;
            this.numberOfTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberOfTimes.ForeColor = System.Drawing.SystemColors.Info;
            this.numberOfTimes.Location = new System.Drawing.Point(192, 257);
            this.numberOfTimes.Name = "numberOfTimes";
            this.numberOfTimes.Size = new System.Drawing.Size(51, 20);
            this.numberOfTimes.TabIndex = 5;
            this.numberOfTimes.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(721, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfTimes);
            this.Controls.Add(this.hashedMessage2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enteredPasswordTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enteredPasswordTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label hashedMessage2;
        private System.Windows.Forms.Label numberOfTimes;
        private System.Windows.Forms.Label label2;
    }
}

