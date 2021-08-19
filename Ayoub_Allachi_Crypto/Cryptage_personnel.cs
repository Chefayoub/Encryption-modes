using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AA_Crypto
{
    class Cryptage_personnel
    {
        //Variables
        private string text;
        private string textCrypter;
        private int cle;

        //Constructeur
        public Cryptage_personnel(string thetext, int thekey)
        {
            this.text = thetext;
            this.cle = thekey;

        }

        //Méthode de cryptage
        public string Crypter()
        {
            //Boucle qui prend en compte la longueur du texte
            //Celle-ci prend des entiers pour la valeur de la clé
            for (int i = 0; i < text.Length; i++)
            {

                textCrypter += (char)(text[i] + cle);//Permet d'appliquer la clé au texte pour
                                                     //Le modifier 
                                                     //le + permet d'avancer
            }
            return textCrypter;
        }

        //Boucle qui prend en compte la longueur du texte
        //Celle-ci prend des entiers pour la valeur de la clé
        public string Decrypter()
        {
            for (int i = 0; i < text.Length; i++)
            {

                textCrypter += (char)(text[i] - cle);//Fait le contraire 
                                                    //Le - Permet de retourner sur ses pas

            }
            return textCrypter;
            
        }
    }
}
