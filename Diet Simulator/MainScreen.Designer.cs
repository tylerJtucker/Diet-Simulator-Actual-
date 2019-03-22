namespace Diet_Simulator
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.insButton = new System.Windows.Forms.Button();
            this.scorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Millenium BdEx BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diet Simulator";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(222, 196);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(182, 52);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // insButton
            // 
            this.insButton.BackColor = System.Drawing.Color.Transparent;
            this.insButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.insButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insButton.Location = new System.Drawing.Point(222, 348);
            this.insButton.Name = "insButton";
            this.insButton.Size = new System.Drawing.Size(182, 52);
            this.insButton.TabIndex = 4;
            this.insButton.Text = "INSTRUCTIONS";
            this.insButton.UseVisualStyleBackColor = false;
            this.insButton.Click += new System.EventHandler(this.insButton_Click);
            // 
            // scorButton
            // 
            this.scorButton.BackColor = System.Drawing.Color.Transparent;
            this.scorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.scorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorButton.Location = new System.Drawing.Point(222, 502);
            this.scorButton.Name = "scorButton";
            this.scorButton.Size = new System.Drawing.Size(182, 52);
            this.scorButton.TabIndex = 5;
            this.scorButton.Text = "SCOREBOARD";
            this.scorButton.UseVisualStyleBackColor = false;
            this.scorButton.Click += new System.EventHandler(this.scorButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.Controls.Add(this.scorButton);
            this.Controls.Add(this.insButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(627, 669);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button insButton;
        private System.Windows.Forms.Button scorButton;
    }
}
