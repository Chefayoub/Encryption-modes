using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AA_Crypto
{
    public partial class Cryptage : Form
    {

        public Cryptage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //---------------------------------------------------------------------------------
        //Cryptage

        //Cryptage personnel
        private void btn_Cryptage_personnel_Click(object sender, EventArgs e)
        {
            int key = (int) numericUpDown1.Value;//Prend le numericdupDown comme reference pour la clé

            //Ici on créer 
            Cryptage_personnel crp;//utilise la classe
            crp = new Cryptage_personnel(text_a_crypter.Text, key);//instancier + recupere texte et la clé
            affichage_crypt_perso.Text = crp.Crypter();//Affiche le texte crypter grace a la méthode crypter
        }

        //Cryptage .Net avec MD5 ( Message Digest 5 )
        private void btn_Cryptage_Net_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(text_a_crypter.Text);//Recupere le texte a crypter
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())//Instentier
            {
                byte[] cle = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(crypter_cle.Text));//Utilise la clé
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                {
                    Key = cle,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    affichage_crypt_net.Text = Convert.ToBase64String(results, 0, results.Length);//Convertisseur et affichage
                }
            }
        }



        //---------------------------------------------------------------------------------
        //Decryptage

        //Cryptage personnel
        private void btn_Decryptage_personnel_Click(object sender, EventArgs e)
        {
            int key = (int)numericUpDown2.Value;//Prend le numericdupDown comme reference pour la clé

            Cryptage_personnel crp; ;//utilise la classe
            crp = new Cryptage_personnel(text_a_decrypter.Text, key);//instancier + recupere texte et la clé
            affichage_decrypt_perso.Text = crp.Decrypter();//Affiche le texte crypter grace a la méthode crypter
        }

        //Decryptage .Net avec MD5 ( Message Digest 5 )
        private void btn_Decryptage_Net_Click(object sender, EventArgs e)
        {
            byte[] data = Convert.FromBase64String(affichage_crypt_net.Text);//Recupere le texte crypter
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())//Instentier
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(decrypter_cle.Text));//Utilise la clé
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    affichage_decrypt_net.Text = UTF8Encoding.UTF8.GetString(results);//Afichage de fin
                }
            }
        }

        private void affichage_crypt_perso_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
