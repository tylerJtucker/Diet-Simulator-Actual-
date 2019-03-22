namespace Diet_Simulator
{
    partial class ScoreboardScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.outputLabel = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.fdBorder = new System.Windows.Forms.Label();
            this.sdBorder = new System.Windows.Forms.Label();
            this.tdBorder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(103, 40);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(411, 582);
            this.outputLabel.TabIndex = 0;
            // 
            // nameLabel1
            // 
            this.nameLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(129, 273);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(104, 97);
            this.nameLabel1.TabIndex = 1;
            this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel2
            // 
            this.nameLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(255, 273);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(104, 97);
            this.nameLabel2.TabIndex = 2;
            this.nameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel3
            // 
            this.nameLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel3.Location = new System.Drawing.Point(381, 273);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(104, 97);
            this.nameLabel3.TabIndex = 3;
            this.nameLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreTimer
            // 
            this.scoreTimer.Enabled = true;
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimer_Tick);
            // 
            // fdBorder
            // 
            this.fdBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fdBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdBorder.Location = new System.Drawing.Point(115, 255);
            this.fdBorder.Name = "fdBorder";
            this.fdBorder.Size = new System.Drawing.Size(134, 132);
            this.fdBorder.TabIndex = 4;
            this.fdBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sdBorder
            // 
            this.sdBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sdBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdBorder.Location = new System.Drawing.Point(239, 255);
            this.sdBorder.Name = "sdBorder";
            this.sdBorder.Size = new System.Drawing.Size(134, 132);
            this.sdBorder.TabIndex = 5;
            this.sdBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tdBorder
            // 
            this.tdBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tdBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdBorder.Location = new System.Drawing.Point(365, 255);
            this.tdBorder.Name = "tdBorder";
            this.tdBorder.Size = new System.Drawing.Size(134, 132);
            this.tdBorder.TabIndex = 6;
            this.tdBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.tdBorder);
            this.Controls.Add(this.sdBorder);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.fdBorder);
            this.Controls.Add(this.outputLabel);
            this.Name = "ScoreboardScreen";
            this.Size = new System.Drawing.Size(627, 669);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScoreboardScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScoreboardScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Label fdBorder;
        private System.Windows.Forms.Label sdBorder;
        private System.Windows.Forms.Label tdBorder;
    }
}
