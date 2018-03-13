namespace Kids_Game
{
    partial class frmLogin
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.pwdtxtbox = new System.Windows.Forms.TextBox();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.picUserAvatar3 = new System.Windows.Forms.PictureBox();
            this.picUserAvatar2 = new System.Windows.Forms.PictureBox();
            this.picUserAvatar1 = new System.Windows.Forms.PictureBox();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(152, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(234, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Player Selection ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(14, 138);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(183, 20);
            this.nametxtbox.TabIndex = 0;
            // 
            // pwdtxtbox
            // 
            this.pwdtxtbox.Location = new System.Drawing.Point(14, 291);
            this.pwdtxtbox.Name = "pwdtxtbox";
            this.pwdtxtbox.PasswordChar = '*';
            this.pwdtxtbox.Size = new System.Drawing.Size(183, 20);
            this.pwdtxtbox.TabIndex = 1;
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Location = new System.Drawing.Point(14, 323);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(105, 17);
            this.chkPassword.TabIndex = 12;
            this.chkPassword.Text = "Show Password ";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(454, 426);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // picUserAvatar3
            // 
            this.picUserAvatar3.Location = new System.Drawing.Point(421, 226);
            this.picUserAvatar3.Name = "picUserAvatar3";
            this.picUserAvatar3.Size = new System.Drawing.Size(116, 103);
            this.picUserAvatar3.TabIndex = 11;
            this.picUserAvatar3.TabStop = false;
            // 
            // picUserAvatar2
            // 
            this.picUserAvatar2.Image = global::Kids_Game.Properties.Resources.figure_2;
            this.picUserAvatar2.Location = new System.Drawing.Point(270, 226);
            this.picUserAvatar2.Name = "picUserAvatar2";
            this.picUserAvatar2.Size = new System.Drawing.Size(116, 103);
            this.picUserAvatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserAvatar2.TabIndex = 10;
            this.picUserAvatar2.TabStop = false;
            // 
            // picUserAvatar1
            // 
            this.picUserAvatar1.Image = global::Kids_Game.Properties.Resources._200px_Paul_Pogba_2017;
            this.picUserAvatar1.Location = new System.Drawing.Point(421, 90);
            this.picUserAvatar1.Name = "picUserAvatar1";
            this.picUserAvatar1.Size = new System.Drawing.Size(116, 103);
            this.picUserAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserAvatar1.TabIndex = 9;
            this.picUserAvatar1.TabStop = false;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Image = global::Kids_Game.Properties.Resources.player_image_ronaldo;
            this.picUserAvatar.Location = new System.Drawing.Point(270, 90);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(116, 103);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserAvatar.TabIndex = 8;
            this.picUserAvatar.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 463);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.chkPassword);
            this.Controls.Add(this.picUserAvatar3);
            this.Controls.Add(this.picUserAvatar2);
            this.Controls.Add(this.picUserAvatar1);
            this.Controls.Add(this.picUserAvatar);
            this.Controls.Add(this.pwdtxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox pwdtxtbox;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.PictureBox picUserAvatar1;
        private System.Windows.Forms.PictureBox picUserAvatar2;
        private System.Windows.Forms.PictureBox picUserAvatar3;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.Button buttonExit;
    }
}