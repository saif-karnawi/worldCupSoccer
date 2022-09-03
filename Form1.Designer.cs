namespace worldCupPenalties
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
            this.topleft = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.topright = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // topleft
            // 
            this.topleft.BackColor = System.Drawing.Color.Yellow;
            this.topleft.BackgroundImage = global::worldCupPenalties.Properties.Resources.target;
            this.topleft.Location = new System.Drawing.Point(120, 184);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(39, 37);
            this.topleft.TabIndex = 0;
            this.topleft.TabStop = false;
            this.topleft.Tag = "topLeft";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Yellow;
            this.top.BackgroundImage = global::worldCupPenalties.Properties.Resources.target;
            this.top.Location = new System.Drawing.Point(434, 184);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(39, 37);
            this.top.TabIndex = 1;
            this.top.TabStop = false;
            this.top.Tag = "top";
            // 
            // topright
            // 
            this.topright.BackColor = System.Drawing.Color.Yellow;
            this.topright.BackgroundImage = global::worldCupPenalties.Properties.Resources.target;
            this.topright.Location = new System.Drawing.Point(757, 184);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(39, 37);
            this.topright.TabIndex = 2;
            this.topright.TabStop = false;
            this.topright.Tag = "topRight";
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Yellow;
            this.left.BackgroundImage = global::worldCupPenalties.Properties.Resources.target;
            this.left.Location = new System.Drawing.Point(120, 460);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(39, 37);
            this.left.TabIndex = 3;
            this.left.TabStop = false;
            this.left.Tag = "left";
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Yellow;
            this.right.BackgroundImage = global::worldCupPenalties.Properties.Resources.target;
            this.right.Location = new System.Drawing.Point(757, 460);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(39, 37);
            this.right.TabIndex = 4;
            this.right.TabStop = false;
            this.right.Tag = "right";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::worldCupPenalties.Properties.Resources.football;
            this.pictureBox1.Location = new System.Drawing.Point(434, 559);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::worldCupPenalties.Properties.Resources.stand_small;
            this.pictureBox2.Location = new System.Drawing.Point(387, 299);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 235);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Goals Scored: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time: 0:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::worldCupPenalties.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(893, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.topright);
            this.Controls.Add(this.top);
            this.Controls.Add(this.topleft);
            this.Name = "Form1";
            this.Text = "World Cup Penalties";
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox topleft;
        private PictureBox top;
        private PictureBox topright;
        private PictureBox left;
        private PictureBox right;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}