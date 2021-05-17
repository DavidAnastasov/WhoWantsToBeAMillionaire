
namespace WhoWantsToBeAMillionaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswerA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerA.ForeColor = System.Drawing.Color.White;
            this.btnAnswerA.Location = new System.Drawing.Point(12, 277);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(277, 81);
            this.btnAnswerA.TabIndex = 0;
            this.btnAnswerA.Text = "A";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswerC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerC.ForeColor = System.Drawing.Color.White;
            this.btnAnswerC.Location = new System.Drawing.Point(12, 364);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(277, 81);
            this.btnAnswerC.TabIndex = 2;
            this.btnAnswerC.Text = "C";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswerB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerB.ForeColor = System.Drawing.Color.White;
            this.btnAnswerB.Location = new System.Drawing.Point(295, 277);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(277, 81);
            this.btnAnswerB.TabIndex = 1;
            this.btnAnswerB.Text = "B";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswerD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerD.ForeColor = System.Drawing.Color.White;
            this.btnAnswerD.Location = new System.Drawing.Point(295, 364);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(277, 81);
            this.btnAnswerD.TabIndex = 3;
            this.btnAnswerD.Text = "D";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::WhoWantsToBeAMillionaire.Properties.Resources.scoreboard;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(578, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 433);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(12, 76);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(3);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(560, 195);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoints
            // 
            this.lblPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(12, 12);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(3);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(560, 32);
            this.lblPoints.TabIndex = 9;
            this.lblPoints.Text = "Points: 0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(893, 455);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Who wants to be a millionaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblPoints;
    }
}

