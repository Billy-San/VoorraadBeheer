namespace VoorraadBeheer
{
    partial class inloggen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.inloggenbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(215, 171);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(150, 31);
            this.usernametb.TabIndex = 2;
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(215, 277);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(150, 31);
            this.passwordtb.TabIndex = 3;
            // 
            // inloggenbtn
            // 
            this.inloggenbtn.Location = new System.Drawing.Point(215, 363);
            this.inloggenbtn.Name = "inloggenbtn";
            this.inloggenbtn.Size = new System.Drawing.Size(150, 34);
            this.inloggenbtn.TabIndex = 4;
            this.inloggenbtn.Text = "Inloggen";
            this.inloggenbtn.UseVisualStyleBackColor = true;
            this.inloggenbtn.Click += new System.EventHandler(this.inloggenbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "MeubleMalin Login";
            // 
            // inloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inloggenbtn);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inloggen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernametb;
        private TextBox passwordtb;
        private Button inloggenbtn;
        private Label label3;
    }
}