namespace Diet_Simulator
{
    partial class InstructionsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsScreen));
            this.InsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.joystickPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.joystickPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // InsLabel
            // 
            this.InsLabel.Font = new System.Drawing.Font("Millenium BdEx BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InsLabel.Location = new System.Drawing.Point(40, 9);
            this.InsLabel.Name = "InsLabel";
            this.InsLabel.Size = new System.Drawing.Size(559, 168);
            this.InsLabel.TabIndex = 2;
            this.InsLabel.Text = "Sally is on a diet, its simple.....Don\'t let her eat, unless its a salad";
            this.InsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(320, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "<---- USE THIS TO MOVE HER MOUTH";
            // 
            // joystickPicture
            // 
            this.joystickPicture.Image = ((System.Drawing.Image)(resources.GetObject("joystickPicture.Image")));
            this.joystickPicture.Location = new System.Drawing.Point(108, 224);
            this.joystickPicture.Name = "joystickPicture";
            this.joystickPicture.Size = new System.Drawing.Size(206, 209);
            this.joystickPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.joystickPicture.TabIndex = 3;
            this.joystickPicture.TabStop = false;
            // 
            // InstructionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.joystickPicture);
            this.Controls.Add(this.InsLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "InstructionsScreen";
            this.Size = new System.Drawing.Size(627, 669);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.InstructionsScreen_PreviewKeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.joystickPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsLabel;
        private System.Windows.Forms.PictureBox joystickPicture;
        private System.Windows.Forms.Label label1;
    }
}
