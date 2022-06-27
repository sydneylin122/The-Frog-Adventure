namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.nextBottom = new System.Windows.Forms.Button();
            this.frog = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.txtScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(798, 31);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(115, 41);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // nextBottom
            // 
            this.nextBottom.BackColor = System.Drawing.Color.Silver;
            this.nextBottom.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBottom.ForeColor = System.Drawing.Color.Goldenrod;
            this.nextBottom.Location = new System.Drawing.Point(380, 300);
            this.nextBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextBottom.Name = "nextBottom";
            this.nextBottom.Size = new System.Drawing.Size(216, 67);
            this.nextBottom.TabIndex = 9;
            this.nextBottom.Text = "Next";
            this.nextBottom.UseVisualStyleBackColor = false;
            this.nextBottom.Visible = false;
            this.nextBottom.Click += new System.EventHandler(this.next_Click);
            // 
            // frog
            // 
            this.frog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.frog.Image = global::WindowsFormsApp1.Properties.Resources.frog;
            this.frog.Location = new System.Drawing.Point(71, 375);
            this.frog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frog.Name = "frog";
            this.frog.Size = new System.Drawing.Size(112, 96);
            this.frog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.frog.TabIndex = 10;
            this.frog.TabStop = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.ghost.Image = global::WindowsFormsApp1.Properties.Resources.dead1;
            this.ghost.Location = new System.Drawing.Point(71, 203);
            this.ghost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(126, 136);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost.TabIndex = 7;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.stone;
            this.pictureBox4.Location = new System.Drawing.Point(1030, 426);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.rocks;
            this.pictureBox3.Location = new System.Drawing.Point(1148, 457);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1638, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(899, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 41);
            this.label1.TabIndex = 11;
            // 
            // txtDead
            // 
            this.txtDead.AutoSize = true;
            this.txtDead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.txtDead.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDead.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtDead.Location = new System.Drawing.Point(294, 222);
            this.txtDead.Name = "txtDead";
            this.txtDead.Size = new System.Drawing.Size(386, 41);
            this.txtDead.TabIndex = 12;
            this.txtDead.Text = "You are dead! Tab Next.";
            this.txtDead.Visible = false;
            this.txtDead.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 690);
            this.Controls.Add(this.txtDead);
            this.Controls.Add(this.nextBottom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frog);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "遊戲挑戰";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.frog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextBottom;
        private System.Windows.Forms.PictureBox frog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDead;
    }
}

