namespace flappy_bird
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.fallTimer = new System.Windows.Forms.Timer(this.components);
            this.runSpeed = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // fallTimer
            // 
            this.fallTimer.Interval = 150;
            this.fallTimer.Tick += new System.EventHandler(this.fallTimer_Tick);
            // 
            // runSpeed
            // 
            this.runSpeed.Interval = 15;
            this.runSpeed.Tick += new System.EventHandler(this.runSpeed_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(309, 29);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(32, 39);
            this.score.TabIndex = 2;
            this.score.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(221, 29);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(82, 39);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 38);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // character
            // 
            this.character.Image = ((System.Drawing.Image)(resources.GetObject("character.Image")));
            this.character.Location = new System.Drawing.Point(34, 127);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(70, 32);
            this.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.character.TabIndex = 5;
            this.character.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 383);
            this.Controls.Add(this.character);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Timer fallTimer;
        private System.Windows.Forms.Timer runSpeed;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox character;
    }
}

