namespace Gwent
{
    partial class GwentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GwentForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.flpOpponentsHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayerHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flpBlack = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRed = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblOP = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblMyPoints = new System.Windows.Forms.Label();
            this.lblOPoints = new System.Windows.Forms.Label();
            this.fplOpLives = new System.Windows.Forms.FlowLayoutPanel();
            this.fplMyLives = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPass = new System.Windows.Forms.Button();
            this.lblOL = new System.Windows.Forms.Label();
            this.lblYP = new System.Windows.Forms.Label();
            this.pcbSound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(1118, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(208, 64);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Play Gwent";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // flpOpponentsHand
            // 
            this.flpOpponentsHand.BackColor = System.Drawing.Color.Gainsboro;
            this.flpOpponentsHand.Location = new System.Drawing.Point(12, 12);
            this.flpOpponentsHand.Name = "flpOpponentsHand";
            this.flpOpponentsHand.Size = new System.Drawing.Size(1092, 255);
            this.flpOpponentsHand.TabIndex = 17;
            // 
            // flpPlayerHand
            // 
            this.flpPlayerHand.BackColor = System.Drawing.Color.Gainsboro;
            this.flpPlayerHand.Location = new System.Drawing.Point(12, 606);
            this.flpPlayerHand.Name = "flpPlayerHand";
            this.flpPlayerHand.Size = new System.Drawing.Size(1092, 255);
            this.flpPlayerHand.TabIndex = 18;
            // 
            // flpBlack
            // 
            this.flpBlack.BackColor = System.Drawing.Color.Gainsboro;
            this.flpBlack.Location = new System.Drawing.Point(75, 310);
            this.flpBlack.Name = "flpBlack";
            this.flpBlack.Size = new System.Drawing.Size(474, 255);
            this.flpBlack.TabIndex = 19;
            this.flpBlack.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpMyHand_DragDrop);
            this.flpBlack.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpRed_DragEnter);
            // 
            // flpRed
            // 
            this.flpRed.BackColor = System.Drawing.Color.Gainsboro;
            this.flpRed.Location = new System.Drawing.Point(555, 310);
            this.flpRed.Name = "flpRed";
            this.flpRed.Size = new System.Drawing.Size(488, 255);
            this.flpRed.TabIndex = 20;
            this.flpRed.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpMyHand_DragDrop);
            this.flpRed.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpRed_DragEnter);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(1128, 104);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(286, 95);
            this.lblDisplay.TabIndex = 23;
            // 
            // lblOP
            // 
            this.lblOP.BackColor = System.Drawing.Color.Transparent;
            this.lblOP.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.ForeColor = System.Drawing.Color.White;
            this.lblOP.Location = new System.Drawing.Point(1149, 348);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(112, 56);
            this.lblOP.TabIndex = 24;
            this.lblOP.Text = "OpPoints:";
            this.lblOP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblOP.Visible = false;
            // 
            // lblMP
            // 
            this.lblMP.BackColor = System.Drawing.Color.Transparent;
            this.lblMP.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.ForeColor = System.Drawing.Color.White;
            this.lblMP.Location = new System.Drawing.Point(1113, 483);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(148, 56);
            this.lblMP.TabIndex = 25;
            this.lblMP.Text = "Your Points:";
            this.lblMP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMP.Visible = false;
            // 
            // lblMyPoints
            // 
            this.lblMyPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblMyPoints.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyPoints.ForeColor = System.Drawing.Color.White;
            this.lblMyPoints.Location = new System.Drawing.Point(1264, 475);
            this.lblMyPoints.Name = "lblMyPoints";
            this.lblMyPoints.Size = new System.Drawing.Size(57, 56);
            this.lblMyPoints.TabIndex = 26;
            this.lblMyPoints.Text = "0";
            this.lblMyPoints.Visible = false;
            // 
            // lblOPoints
            // 
            this.lblOPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblOPoints.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPoints.ForeColor = System.Drawing.Color.White;
            this.lblOPoints.Location = new System.Drawing.Point(1264, 340);
            this.lblOPoints.Name = "lblOPoints";
            this.lblOPoints.Size = new System.Drawing.Size(57, 56);
            this.lblOPoints.TabIndex = 27;
            this.lblOPoints.Text = "0";
            this.lblOPoints.Visible = false;
            // 
            // fplOpLives
            // 
            this.fplOpLives.BackColor = System.Drawing.Color.Transparent;
            this.fplOpLives.Location = new System.Drawing.Point(1326, 294);
            this.fplOpLives.Name = "fplOpLives";
            this.fplOpLives.Size = new System.Drawing.Size(91, 47);
            this.fplOpLives.TabIndex = 29;
            // 
            // fplMyLives
            // 
            this.fplMyLives.BackColor = System.Drawing.Color.Transparent;
            this.fplMyLives.Location = new System.Drawing.Point(1326, 428);
            this.fplMyLives.Name = "fplMyLives";
            this.fplMyLives.Size = new System.Drawing.Size(91, 47);
            this.fplMyLives.TabIndex = 30;
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.btnPass.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPass.Location = new System.Drawing.Point(1118, 797);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(208, 64);
            this.btnPass.TabIndex = 21;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // lblOL
            // 
            this.lblOL.BackColor = System.Drawing.Color.Transparent;
            this.lblOL.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOL.ForeColor = System.Drawing.Color.White;
            this.lblOL.Location = new System.Drawing.Point(1128, 294);
            this.lblOL.Name = "lblOL";
            this.lblOL.Size = new System.Drawing.Size(178, 47);
            this.lblOL.TabIndex = 31;
            this.lblOL.Text = "Opponent Lives:";
            this.lblOL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblOL.Visible = false;
            // 
            // lblYP
            // 
            this.lblYP.BackColor = System.Drawing.Color.Transparent;
            this.lblYP.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYP.ForeColor = System.Drawing.Color.White;
            this.lblYP.Location = new System.Drawing.Point(1157, 428);
            this.lblYP.Name = "lblYP";
            this.lblYP.Size = new System.Drawing.Size(149, 47);
            this.lblYP.TabIndex = 32;
            this.lblYP.Text = "Your Lives:";
            this.lblYP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblYP.Visible = false;
            // 
            // pcbSound
            // 
            this.pcbSound.Image = ((System.Drawing.Image)(resources.GetObject("pcbSound.Image")));
            this.pcbSound.Location = new System.Drawing.Point(1347, 16);
            this.pcbSound.Name = "pcbSound";
            this.pcbSound.Size = new System.Drawing.Size(67, 64);
            this.pcbSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSound.TabIndex = 33;
            this.pcbSound.TabStop = false;
            this.pcbSound.Click += new System.EventHandler(this.pcbSound_Click);
            // 
            // GwentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1425, 872);
            this.Controls.Add(this.pcbSound);
            this.Controls.Add(this.lblYP);
            this.Controls.Add(this.lblOL);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblOPoints);
            this.Controls.Add(this.lblMyPoints);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.flpRed);
            this.Controls.Add(this.flpBlack);
            this.Controls.Add(this.flpPlayerHand);
            this.Controls.Add(this.flpOpponentsHand);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.fplOpLives);
            this.Controls.Add(this.fplMyLives);
            this.Name = "GwentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gwent";
            this.Load += new System.EventHandler(this.GwentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FlowLayoutPanel flpOpponentsHand;
        private System.Windows.Forms.FlowLayoutPanel flpPlayerHand;
        private System.Windows.Forms.FlowLayoutPanel flpBlack;
        private System.Windows.Forms.FlowLayoutPanel flpRed;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblMyPoints;
        private System.Windows.Forms.Label lblOPoints;
        private System.Windows.Forms.FlowLayoutPanel fplOpLives;
        private System.Windows.Forms.FlowLayoutPanel fplMyLives;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Label lblOL;
        private System.Windows.Forms.Label lblYP;
        private System.Windows.Forms.PictureBox pcbSound;
    }
}

