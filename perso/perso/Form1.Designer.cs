namespace perso
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
            pictureBox1 = new PictureBox();
            especelab = new Label();
            especetxt = new TextBox();
            sexelab = new Label();
            sexecb = new ComboBox();
            surnomlab = new Label();
            surnomtxt = new TextBox();
            natlab = new Label();
            natcb = new ComboBox();
            methodelab = new Label();
            methodetxt = new TextBox();
            nblab = new Label();
            nbtxt = new TextBox();
            nbhlab = new Label();
            nbhtxt = new TextBox();
            jeuxtxt = new TextBox();
            jeuxlab = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.test;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(929, 495);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // especelab
            // 
            especelab.AutoSize = true;
            especelab.Location = new Point(935, 9);
            especelab.Name = "especelab";
            especelab.Size = new Size(114, 15);
            especelab.TabIndex = 1;
            especelab.Text = "Espèce du pokemon";
            // 
            // especetxt
            // 
            especetxt.Location = new Point(1055, 6);
            especetxt.Name = "especetxt";
            especetxt.Size = new Size(100, 23);
            especetxt.TabIndex = 2;
            // 
            // sexelab
            // 
            sexelab.AutoSize = true;
            sexelab.Location = new Point(1229, 9);
            sexelab.Name = "sexelab";
            sexelab.Size = new Size(101, 15);
            sexelab.TabIndex = 3;
            sexelab.Text = "Sexe du pokemon";
            // 
            // sexecb
            // 
            sexecb.FormattingEnabled = true;
            sexecb.Location = new Point(1360, 6);
            sexecb.Name = "sexecb";
            sexecb.Size = new Size(121, 23);
            sexecb.TabIndex = 4;
            sexecb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // surnomlab
            // 
            surnomlab.AutoSize = true;
            surnomlab.Location = new Point(935, 76);
            surnomlab.Name = "surnomlab";
            surnomlab.Size = new Size(120, 15);
            surnomlab.TabIndex = 5;
            surnomlab.Text = "Surnom du pokemon";
            // 
            // surnomtxt
            // 
            surnomtxt.Location = new Point(1061, 76);
            surnomtxt.Name = "surnomtxt";
            surnomtxt.Size = new Size(100, 23);
            surnomtxt.TabIndex = 6;
            // 
            // natlab
            // 
            natlab.AutoSize = true;
            natlab.Location = new Point(1229, 79);
            natlab.Name = "natlab";
            natlab.Size = new Size(114, 15);
            natlab.TabIndex = 7;
            natlab.Text = "Nature du pokemon";
            // 
            // natcb
            // 
            natcb.FormattingEnabled = true;
            natcb.Location = new Point(1360, 76);
            natcb.Name = "natcb";
            natcb.Size = new Size(121, 23);
            natcb.TabIndex = 8;
            // 
            // methodelab
            // 
            methodelab.AutoSize = true;
            methodelab.Location = new Point(935, 161);
            methodelab.Name = "methodelab";
            methodelab.Size = new Size(55, 15);
            methodelab.TabIndex = 9;
            methodelab.Text = "Méthode";
            // 
            // methodetxt
            // 
            methodetxt.Location = new Point(1018, 158);
            methodetxt.Name = "methodetxt";
            methodetxt.Size = new Size(100, 23);
            methodetxt.TabIndex = 10;
            // 
            // nblab
            // 
            nblab.AutoSize = true;
            nblab.Location = new Point(1229, 161);
            nblab.Name = "nblab";
            nblab.Size = new Size(121, 15);
            nblab.TabIndex = 11;
            nblab.Text = "Nombre de rencontre";
            // 
            // nbtxt
            // 
            nbtxt.Location = new Point(1360, 158);
            nbtxt.Name = "nbtxt";
            nbtxt.Size = new Size(100, 23);
            nbtxt.TabIndex = 12;
            // 
            // nbhlab
            // 
            nbhlab.AutoSize = true;
            nbhlab.Location = new Point(935, 233);
            nbhlab.Name = "nbhlab";
            nbhlab.Size = new Size(99, 15);
            nbhlab.TabIndex = 13;
            nbhlab.Text = "Nombre d'heures";
            // 
            // nbhtxt
            // 
            nbhtxt.Location = new Point(1055, 225);
            nbhtxt.Name = "nbhtxt";
            nbhtxt.Size = new Size(100, 23);
            nbhtxt.TabIndex = 14;
            // 
            // jeuxtxt
            // 
            jeuxtxt.Location = new Point(1280, 225);
            jeuxtxt.Name = "jeuxtxt";
            jeuxtxt.Size = new Size(100, 23);
            jeuxtxt.TabIndex = 15;
            // 
            // jeuxlab
            // 
            jeuxlab.AutoSize = true;
            jeuxlab.Location = new Point(1229, 233);
            jeuxlab.Name = "jeuxlab";
            jeuxlab.Size = new Size(29, 15);
            jeuxlab.TabIndex = 16;
            jeuxlab.Text = "Jeux";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(935, 294);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 17;
            label1.Text = "Ball utilisé";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1815, 1012);
            Controls.Add(label1);
            Controls.Add(jeuxlab);
            Controls.Add(jeuxtxt);
            Controls.Add(nbhtxt);
            Controls.Add(nbhlab);
            Controls.Add(nbtxt);
            Controls.Add(nblab);
            Controls.Add(methodetxt);
            Controls.Add(methodelab);
            Controls.Add(natcb);
            Controls.Add(natlab);
            Controls.Add(surnomtxt);
            Controls.Add(surnomlab);
            Controls.Add(sexecb);
            Controls.Add(sexelab);
            Controls.Add(especetxt);
            Controls.Add(especelab);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label especelab;
        private TextBox especetxt;
        private Label sexelab;
        private ComboBox sexecb;
        private Label surnomlab;
        private TextBox surnomtxt;
        private Label natlab;
        private ComboBox natcb;
        private Label methodelab;
        private TextBox methodetxt;
        private Label nblab;
        private TextBox nbtxt;
        private Label nbhlab;
        private TextBox nbhtxt;
        private TextBox jeuxtxt;
        private Label jeuxlab;
        private Label label1;
    }
}
