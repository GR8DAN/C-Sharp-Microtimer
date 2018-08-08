namespace TickerDemo
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
            this.components = new System.ComponentModel.Container();
            this.ButReset = new System.Windows.Forms.Button();
            this.ButStop = new System.Windows.Forms.Button();
            this.ButStart = new System.Windows.Forms.Button();
            this.LblSixCount = new System.Windows.Forms.Label();
            this.LblSix = new System.Windows.Forms.Label();
            this.LblFiveCount = new System.Windows.Forms.Label();
            this.LblFive = new System.Windows.Forms.Label();
            this.LblFourCount = new System.Windows.Forms.Label();
            this.LblFour = new System.Windows.Forms.Label();
            this.LblThreeCount = new System.Windows.Forms.Label();
            this.LblThree = new System.Windows.Forms.Label();
            this.LblTwoCount = new System.Windows.Forms.Label();
            this.LblTwo = new System.Windows.Forms.Label();
            this.LblOneCount = new System.Windows.Forms.Label();
            this.LblOne = new System.Windows.Forms.Label();
            this.LblStats = new System.Windows.Forms.Label();
            this.TmrScreenUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ButReset
            // 
            this.ButReset.Location = new System.Drawing.Point(134, 11);
            this.ButReset.Margin = new System.Windows.Forms.Padding(2);
            this.ButReset.Name = "ButReset";
            this.ButReset.Size = new System.Drawing.Size(59, 21);
            this.ButReset.TabIndex = 20;
            this.ButReset.Text = "Reset";
            this.ButReset.UseVisualStyleBackColor = true;
            this.ButReset.Click += new System.EventHandler(this.ButReset_Click);
            // 
            // ButStop
            // 
            this.ButStop.Location = new System.Drawing.Point(71, 11);
            this.ButStop.Margin = new System.Windows.Forms.Padding(2);
            this.ButStop.Name = "ButStop";
            this.ButStop.Size = new System.Drawing.Size(59, 21);
            this.ButStop.TabIndex = 19;
            this.ButStop.Text = "Stop";
            this.ButStop.UseVisualStyleBackColor = true;
            this.ButStop.Click += new System.EventHandler(this.ButStop_Click);
            // 
            // ButStart
            // 
            this.ButStart.Location = new System.Drawing.Point(11, 11);
            this.ButStart.Margin = new System.Windows.Forms.Padding(2);
            this.ButStart.Name = "ButStart";
            this.ButStart.Size = new System.Drawing.Size(56, 21);
            this.ButStart.TabIndex = 18;
            this.ButStart.Text = "Start";
            this.ButStart.UseVisualStyleBackColor = true;
            this.ButStart.Click += new System.EventHandler(this.ButStart_Click);
            // 
            // LblSixCount
            // 
            this.LblSixCount.AutoSize = true;
            this.LblSixCount.Location = new System.Drawing.Point(31, 150);
            this.LblSixCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSixCount.Name = "LblSixCount";
            this.LblSixCount.Size = new System.Drawing.Size(13, 13);
            this.LblSixCount.TabIndex = 32;
            this.LblSixCount.Text = "0";
            // 
            // LblSix
            // 
            this.LblSix.AutoSize = true;
            this.LblSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSix.Location = new System.Drawing.Point(11, 147);
            this.LblSix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSix.Name = "LblSix";
            this.LblSix.Size = new System.Drawing.Size(17, 17);
            this.LblSix.TabIndex = 31;
            this.LblSix.Text = "6";
            // 
            // LblFiveCount
            // 
            this.LblFiveCount.AutoSize = true;
            this.LblFiveCount.Location = new System.Drawing.Point(31, 127);
            this.LblFiveCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFiveCount.Name = "LblFiveCount";
            this.LblFiveCount.Size = new System.Drawing.Size(13, 13);
            this.LblFiveCount.TabIndex = 30;
            this.LblFiveCount.Text = "0";
            // 
            // LblFive
            // 
            this.LblFive.AutoSize = true;
            this.LblFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFive.Location = new System.Drawing.Point(11, 125);
            this.LblFive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFive.Name = "LblFive";
            this.LblFive.Size = new System.Drawing.Size(17, 17);
            this.LblFive.TabIndex = 29;
            this.LblFive.Text = "5";
            // 
            // LblFourCount
            // 
            this.LblFourCount.AutoSize = true;
            this.LblFourCount.Location = new System.Drawing.Point(31, 105);
            this.LblFourCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFourCount.Name = "LblFourCount";
            this.LblFourCount.Size = new System.Drawing.Size(13, 13);
            this.LblFourCount.TabIndex = 28;
            this.LblFourCount.Text = "0";
            // 
            // LblFour
            // 
            this.LblFour.AutoSize = true;
            this.LblFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFour.Location = new System.Drawing.Point(11, 102);
            this.LblFour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFour.Name = "LblFour";
            this.LblFour.Size = new System.Drawing.Size(17, 17);
            this.LblFour.TabIndex = 27;
            this.LblFour.Text = "4";
            // 
            // LblThreeCount
            // 
            this.LblThreeCount.AutoSize = true;
            this.LblThreeCount.Location = new System.Drawing.Point(31, 83);
            this.LblThreeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblThreeCount.Name = "LblThreeCount";
            this.LblThreeCount.Size = new System.Drawing.Size(13, 13);
            this.LblThreeCount.TabIndex = 26;
            this.LblThreeCount.Text = "0";
            // 
            // LblThree
            // 
            this.LblThree.AutoSize = true;
            this.LblThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThree.Location = new System.Drawing.Point(11, 80);
            this.LblThree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblThree.Name = "LblThree";
            this.LblThree.Size = new System.Drawing.Size(17, 17);
            this.LblThree.TabIndex = 25;
            this.LblThree.Text = "3";
            // 
            // LblTwoCount
            // 
            this.LblTwoCount.AutoSize = true;
            this.LblTwoCount.Location = new System.Drawing.Point(31, 59);
            this.LblTwoCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTwoCount.Name = "LblTwoCount";
            this.LblTwoCount.Size = new System.Drawing.Size(13, 13);
            this.LblTwoCount.TabIndex = 24;
            this.LblTwoCount.Text = "0";
            // 
            // LblTwo
            // 
            this.LblTwo.AutoSize = true;
            this.LblTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTwo.Location = new System.Drawing.Point(11, 57);
            this.LblTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTwo.Name = "LblTwo";
            this.LblTwo.Size = new System.Drawing.Size(17, 17);
            this.LblTwo.TabIndex = 23;
            this.LblTwo.Text = "2";
            // 
            // LblOneCount
            // 
            this.LblOneCount.AutoSize = true;
            this.LblOneCount.Location = new System.Drawing.Point(31, 36);
            this.LblOneCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOneCount.Name = "LblOneCount";
            this.LblOneCount.Size = new System.Drawing.Size(13, 13);
            this.LblOneCount.TabIndex = 22;
            this.LblOneCount.Text = "0";
            // 
            // LblOne
            // 
            this.LblOne.AutoSize = true;
            this.LblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOne.Location = new System.Drawing.Point(11, 34);
            this.LblOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOne.Name = "LblOne";
            this.LblOne.Size = new System.Drawing.Size(17, 17);
            this.LblOne.TabIndex = 21;
            this.LblOne.Text = "1";
            // 
            // LblStats
            // 
            this.LblStats.AutoSize = true;
            this.LblStats.Location = new System.Drawing.Point(11, 168);
            this.LblStats.Name = "LblStats";
            this.LblStats.Size = new System.Drawing.Size(49, 13);
            this.LblStats.TabIndex = 33;
            this.LblStats.Text = "Statistics";
            // 
            // TmrScreenUpdate
            // 
            this.TmrScreenUpdate.Tick += new System.EventHandler(this.TmrScreenUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 211);
            this.Controls.Add(this.LblStats);
            this.Controls.Add(this.LblSixCount);
            this.Controls.Add(this.LblSix);
            this.Controls.Add(this.LblFiveCount);
            this.Controls.Add(this.LblFive);
            this.Controls.Add(this.LblFourCount);
            this.Controls.Add(this.LblFour);
            this.Controls.Add(this.LblThreeCount);
            this.Controls.Add(this.LblThree);
            this.Controls.Add(this.LblTwoCount);
            this.Controls.Add(this.LblTwo);
            this.Controls.Add(this.LblOneCount);
            this.Controls.Add(this.LblOne);
            this.Controls.Add(this.ButReset);
            this.Controls.Add(this.ButStop);
            this.Controls.Add(this.ButStart);
            this.Name = "Form1";
            this.Text = "Dice Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButReset;
        private System.Windows.Forms.Button ButStop;
        private System.Windows.Forms.Button ButStart;
        private System.Windows.Forms.Label LblSixCount;
        private System.Windows.Forms.Label LblSix;
        private System.Windows.Forms.Label LblFiveCount;
        private System.Windows.Forms.Label LblFive;
        private System.Windows.Forms.Label LblFourCount;
        private System.Windows.Forms.Label LblFour;
        private System.Windows.Forms.Label LblThreeCount;
        private System.Windows.Forms.Label LblThree;
        private System.Windows.Forms.Label LblTwoCount;
        private System.Windows.Forms.Label LblTwo;
        private System.Windows.Forms.Label LblOneCount;
        private System.Windows.Forms.Label LblOne;
        private System.Windows.Forms.Label LblStats;
        private System.Windows.Forms.Timer TmrScreenUpdate;
    }
}

