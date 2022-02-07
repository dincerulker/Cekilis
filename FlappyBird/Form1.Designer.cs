
namespace FlappyBird
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
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.pbPipe4 = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBird
            // 
            this.pbBird.BackgroundImage = global::FlappyBird.Properties.Resources.birdnew;
            this.pbBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBird.Location = new System.Drawing.Point(29, 154);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(50, 50);
            this.pbBird.TabIndex = 2;
            this.pbBird.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.BackgroundImage = global::FlappyBird.Properties.Resources.ground;
            this.pbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbGround.Location = new System.Drawing.Point(0, 400);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(800, 50);
            this.pbGround.TabIndex = 1;
            this.pbGround.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.BackgroundImage = global::FlappyBird.Properties.Resources.pipedown;
            this.pbPipe2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPipe2.Location = new System.Drawing.Point(428, 2);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(86, 121);
            this.pbPipe2.TabIndex = 3;
            this.pbPipe2.TabStop = false;
            // 
            // pbPipe1
            // 
            this.pbPipe1.BackgroundImage = global::FlappyBird.Properties.Resources.pipe;
            this.pbPipe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPipe1.Location = new System.Drawing.Point(310, 246);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(83, 158);
            this.pbPipe1.TabIndex = 4;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe3
            // 
            this.pbPipe3.BackgroundImage = global::FlappyBird.Properties.Resources.pipe;
            this.pbPipe3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPipe3.Location = new System.Drawing.Point(582, 292);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(86, 112);
            this.pbPipe3.TabIndex = 5;
            this.pbPipe3.TabStop = false;
            // 
            // pbPipe4
            // 
            this.pbPipe4.BackgroundImage = global::FlappyBird.Properties.Resources.pipedown;
            this.pbPipe4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPipe4.Location = new System.Drawing.Point(703, 2);
            this.pbPipe4.Name = "pbPipe4";
            this.pbPipe4.Size = new System.Drawing.Size(85, 166);
            this.pbPipe4.TabIndex = 6;
            this.pbPipe4.TabStop = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 50;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPipe4);
            this.Controls.Add(this.pbPipe3);
            this.Controls.Add(this.pbPipe1);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbGround);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.PictureBox pbPipe4;
        private System.Windows.Forms.Timer tmrGame;
    }
}

