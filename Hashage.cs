using System;
using System.Text;
using System.Security.Cryptography;

namespace Crud
{
    public static class Hashage
    {
        public static string GenerateSHA256String(string inputString)//SHA256
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }
        public static string petitsha(string input) //Sha1
        {
            var data = Encoding.ASCII.GetBytes(input);
            var hashData = new SHA1Managed().ComputeHash(data);
            var hash = string.Empty;
            foreach (var b in hashData)
            {
                hash += b.ToString("X2");
            }
            return hash;
        }
        public static string GenerateSHA512String(string inputString)//Sha512
        {
            SHA512 sha512 = SHA512.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }
        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
        public static string MakeMD5Hash(string input)//MD5
        {
            // etape 1, calculer MD5 depuis la chaine
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // etape 2, concertir vers chaine Hexa
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public static string SalerLeMDP(string MDPHasher)
        {
            int index = MDPHasher.Length - 1;
            char premierNombre = '\0';
            char premiereLettre = '\0';

            do
            {
                char caractere = MDPHasher[index];

                if (char.IsDigit(caractere) && premierNombre == '\0')
                {
                    premierNombre = caractere;
                }
                if (char.IsLetter(caractere) && !char.IsDigit(caractere) && premiereLettre == '\0')
                {
                    premiereLettre = caractere;
                }

                index--;
            } while (index >= 0 && (premierNombre == '\0' || premiereLettre == '\0'));

                int nombre = int.Parse(premierNombre.ToString());// Conversion du char en int
                string debutMDP = MDPHasher.Substring(0, nombre);
                string finMDP = MDPHasher.Substring(nombre);
                string nouveauMDP = debutMDP + premiereLettre + finMDP;
                return nouveauMDP;
        }
    }
}