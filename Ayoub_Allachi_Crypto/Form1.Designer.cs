namespace AA_Crypto
{
    partial class Cryptage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cryptage));
            this.label_clé = new System.Windows.Forms.Label();
            this.label_affich_txt_crypte = new System.Windows.Forms.Label();
            this.label_affich_txt_decrypte = new System.Windows.Forms.Label();
            this.text_a_crypter = new System.Windows.Forms.TextBox();
            this.label_txtCrypter = new System.Windows.Forms.Label();
            this.crypter_cle = new System.Windows.Forms.TextBox();
            this.affichage_crypt_perso = new System.Windows.Forms.TextBox();
            this.affichage_decrypt_perso = new System.Windows.Forms.TextBox();
            this.btn_Cryptage_personnel = new System.Windows.Forms.Button();
            this.btn_Cryptage_Net = new System.Windows.Forms.Button();
            this.btn_Decryptage_personnel = new System.Windows.Forms.Button();
            this.btn_Decryptage_Net = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.text_a_decrypter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decrypter_cle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.affichage_crypt_net = new System.Windows.Forms.TextBox();
            this.affichage_decrypt_net = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_clé
            // 
            this.label_clé.AutoSize = true;
            this.label_clé.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_clé.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clé.Location = new System.Drawing.Point(203, 186);
            this.label_clé.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_clé.Name = "label_clé";
            this.label_clé.Size = new System.Drawing.Size(47, 26);
            this.label_clé.TabIndex = 1;
            this.label_clé.Text = "Clé";
            // 
            // label_affich_txt_crypte
            // 
            this.label_affich_txt_crypte.AutoSize = true;
            this.label_affich_txt_crypte.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_affich_txt_crypte.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_affich_txt_crypte.Location = new System.Drawing.Point(95, 312);
            this.label_affich_txt_crypte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_affich_txt_crypte.Name = "label_affich_txt_crypte";
            this.label_affich_txt_crypte.Size = new System.Drawing.Size(150, 26);
            this.label_affich_txt_crypte.TabIndex = 2;
            this.label_affich_txt_crypte.Text = "Texte crypté";
            // 
            // label_affich_txt_decrypte
            // 
            this.label_affich_txt_decrypte.AutoSize = true;
            this.label_affich_txt_decrypte.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_affich_txt_decrypte.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_affich_txt_decrypte.Location = new System.Drawing.Point(74, 575);
            this.label_affich_txt_decrypte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_affich_txt_decrypte.Name = "label_affich_txt_decrypte";
            this.label_affich_txt_decrypte.Size = new System.Drawing.Size(176, 26);
            this.label_affich_txt_decrypte.TabIndex = 3;
            this.label_affich_txt_decrypte.Text = "Texte décrypté";
            // 
            // text_a_crypter
            // 
            this.text_a_crypter.BackColor = System.Drawing.SystemColors.Info;
            this.text_a_crypter.Location = new System.Drawing.Point(269, 148);
            this.text_a_crypter.Margin = new System.Windows.Forms.Padding(4);
            this.text_a_crypter.Name = "text_a_crypter";
            this.text_a_crypter.Size = new System.Drawing.Size(436, 28);
            this.text_a_crypter.TabIndex = 4;
            // 
            // label_txtCrypter
            // 
            this.label_txtCrypter.AutoSize = true;
            this.label_txtCrypter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_txtCrypter.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_txtCrypter.Location = new System.Drawing.Point(64, 146);
            this.label_txtCrypter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_txtCrypter.Name = "label_txtCrypter";
            this.label_txtCrypter.Size = new System.Drawing.Size(181, 26);
            this.label_txtCrypter.TabIndex = 5;
            this.label_txtCrypter.Text = "Texte à crypter";
            // 
            // crypter_cle
            // 
            this.crypter_cle.BackColor = System.Drawing.SystemColors.Info;
            this.crypter_cle.Location = new System.Drawing.Point(487, 187);
            this.crypter_cle.Margin = new System.Windows.Forms.Padding(4);
            this.crypter_cle.Name = "crypter_cle";
            this.crypter_cle.Size = new System.Drawing.Size(215, 28);
            this.crypter_cle.TabIndex = 6;
            // 
            // affichage_crypt_perso
            // 
            this.affichage_crypt_perso.BackColor = System.Drawing.SystemColors.Info;
            this.affichage_crypt_perso.Location = new System.Drawing.Point(266, 315);
            this.affichage_crypt_perso.Margin = new System.Windows.Forms.Padding(4);
            this.affichage_crypt_perso.Name = "affichage_crypt_perso";
            this.affichage_crypt_perso.Size = new System.Drawing.Size(215, 28);
            this.affichage_crypt_perso.TabIndex = 7;
            this.affichage_crypt_perso.TextChanged += new System.EventHandler(this.affichage_crypt_perso_TextChanged);
            // 
            // affichage_decrypt_perso
            // 
            this.affichage_decrypt_perso.BackColor = System.Drawing.SystemColors.Info;
            this.affichage_decrypt_perso.Location = new System.Drawing.Point(269, 575);
            this.affichage_decrypt_perso.Margin = new System.Windows.Forms.Padding(4);
            this.affichage_decrypt_perso.Name = "affichage_decrypt_perso";
            this.affichage_decrypt_perso.Size = new System.Drawing.Size(214, 28);
            this.affichage_decrypt_perso.TabIndex = 8;
            // 
            // btn_Cryptage_personnel
            // 
            this.btn_Cryptage_personnel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cryptage_personnel.Location = new System.Drawing.Point(266, 223);
            this.btn_Cryptage_personnel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cryptage_personnel.Name = "btn_Cryptage_personnel";
            this.btn_Cryptage_personnel.Size = new System.Drawing.Size(216, 85);
            this.btn_Cryptage_personnel.TabIndex = 9;
            this.btn_Cryptage_personnel.Text = "Cryptage personnel";
            this.btn_Cryptage_personnel.UseVisualStyleBackColor = false;
            this.btn_Cryptage_personnel.Click += new System.EventHandler(this.btn_Cryptage_personnel_Click);
            // 
            // btn_Cryptage_Net
            // 
            this.btn_Cryptage_Net.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cryptage_Net.Location = new System.Drawing.Point(487, 223);
            this.btn_Cryptage_Net.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cryptage_Net.Name = "btn_Cryptage_Net";
            this.btn_Cryptage_Net.Size = new System.Drawing.Size(216, 85);
            this.btn_Cryptage_Net.TabIndex = 10;
            this.btn_Cryptage_Net.Text = "Cryptage .Net";
            this.btn_Cryptage_Net.UseVisualStyleBackColor = false;
            this.btn_Cryptage_Net.Click += new System.EventHandler(this.btn_Cryptage_Net_Click);
            // 
            // btn_Decryptage_personnel
            // 
            this.btn_Decryptage_personnel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Decryptage_personnel.Location = new System.Drawing.Point(266, 483);
            this.btn_Decryptage_personnel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Decryptage_personnel.Name = "btn_Decryptage_personnel";
            this.btn_Decryptage_personnel.Size = new System.Drawing.Size(216, 85);
            this.btn_Decryptage_personnel.TabIndex = 11;
            this.btn_Decryptage_personnel.Text = "Decryptage personnel";
            this.btn_Decryptage_personnel.UseVisualStyleBackColor = false;
            this.btn_Decryptage_personnel.Click += new System.EventHandler(this.btn_Decryptage_personnel_Click);
            // 
            // btn_Decryptage_Net
            // 
            this.btn_Decryptage_Net.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Decryptage_Net.Location = new System.Drawing.Point(490, 483);
            this.btn_Decryptage_Net.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Decryptage_Net.Name = "btn_Decryptage_Net";
            this.btn_Decryptage_Net.Size = new System.Drawing.Size(216, 85);
            this.btn_Decryptage_Net.TabIndex = 12;
            this.btn_Decryptage_Net.Text = "Décryptage .Net";
            this.btn_Decryptage_Net.UseVisualStyleBackColor = false;
            this.btn_Decryptage_Net.Click += new System.EventHandler(this.btn_Decryptage_Net_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Titre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Titre.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(182, 9);
            this.Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(396, 69);
            this.Titre.TabIndex = 14;
            this.Titre.Text = "Cryptage de Ayoub";
            // 
            // text_a_decrypter
            // 
            this.text_a_decrypter.BackColor = System.Drawing.SystemColors.Info;
            this.text_a_decrypter.Location = new System.Drawing.Point(266, 410);
            this.text_a_decrypter.Margin = new System.Windows.Forms.Padding(4);
            this.text_a_decrypter.Name = "text_a_decrypter";
            this.text_a_decrypter.Size = new System.Drawing.Size(436, 28);
            this.text_a_decrypter.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Texte à décrypter";
            // 
            // decrypter_cle
            // 
            this.decrypter_cle.BackColor = System.Drawing.SystemColors.Info;
            this.decrypter_cle.Location = new System.Drawing.Point(491, 445);
            this.decrypter_cle.Margin = new System.Windows.Forms.Padding(4);
            this.decrypter_cle.Name = "decrypter_cle";
            this.decrypter_cle.Size = new System.Drawing.Size(215, 28);
            this.decrypter_cle.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Clé";
            // 
            // affichage_crypt_net
            // 
            this.affichage_crypt_net.BackColor = System.Drawing.SystemColors.Info;
            this.affichage_crypt_net.Location = new System.Drawing.Point(490, 314);
            this.affichage_crypt_net.Margin = new System.Windows.Forms.Padding(4);
            this.affichage_crypt_net.Name = "affichage_crypt_net";
            this.affichage_crypt_net.Size = new System.Drawing.Size(215, 28);
            this.affichage_crypt_net.TabIndex = 21;
            // 
            // affichage_decrypt_net
            // 
            this.affichage_decrypt_net.BackColor = System.Drawing.SystemColors.Info;
            this.affichage_decrypt_net.Location = new System.Drawing.Point(490, 575);
            this.affichage_decrypt_net.Margin = new System.Windows.Forms.Padding(4);
            this.affichage_decrypt_net.Name = "affichage_decrypt_net";
            this.affichage_decrypt_net.Size = new System.Drawing.Size(214, 28);
            this.affichage_decrypt_net.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(269, 186);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown1.TabIndex = 23;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(269, 450);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown2.TabIndex = 24;
            // 
            // Cryptage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 622);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.affichage_decrypt_net);
            this.Controls.Add(this.affichage_crypt_net);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decrypter_cle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_a_decrypter);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.btn_Decryptage_Net);
            this.Controls.Add(this.btn_Decryptage_personnel);
            this.Controls.Add(this.btn_Cryptage_Net);
            this.Controls.Add(this.btn_Cryptage_personnel);
            this.Controls.Add(this.affichage_decrypt_perso);
            this.Controls.Add(this.affichage_crypt_perso);
            this.Controls.Add(this.crypter_cle);
            this.Controls.Add(this.label_txtCrypter);
            this.Controls.Add(this.text_a_crypter);
            this.Controls.Add(this.label_affich_txt_decrypte);
            this.Controls.Add(this.label_affich_txt_crypte);
            this.Controls.Add(this.label_clé);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cryptage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "CRYPTAGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_clé;
        private System.Windows.Forms.Label label_affich_txt_crypte;
        private System.Windows.Forms.Label label_affich_txt_decrypte;
        private System.Windows.Forms.TextBox text_a_crypter;
        private System.Windows.Forms.Label label_txtCrypter;
        private System.Windows.Forms.TextBox crypter_cle;
        private System.Windows.Forms.TextBox affichage_crypt_perso;
        private System.Windows.Forms.TextBox affichage_decrypt_perso;
        private System.Windows.Forms.Button btn_Cryptage_personnel;
        private System.Windows.Forms.Button btn_Cryptage_Net;
        private System.Windows.Forms.Button btn_Decryptage_personnel;
        private System.Windows.Forms.Button btn_Decryptage_Net;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.TextBox text_a_decrypter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox decrypter_cle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox affichage_crypt_net;
        private System.Windows.Forms.TextBox affichage_decrypt_net;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

