using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic.ApplicationServices;
using System.Web;
using System.Diagnostics.CodeAnalysis;

namespace Crud
{
    public class Tools
    {
        DBConnection Laconnexion = new DBConnection();
        Utilisateur ArrivageUtilisateur = new Utilisateur();
        Log monLog = new Log();


        // -> Pour le formLogin ->
        // Méthode pour vérifier les informations de connexion
        public bool VerifierInformationsConnexion(string login, string MDPSaler)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            Laconnexion.IsConnect();
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM user WHERE login=@login AND MDP=@password";
                    MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", MDPSaler);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);
                    return false;
                }

            }
        }

        // FormLogin - Recup les infos de l'user pour l'envoyer dans le Form1. 
        public Utilisateur recupUser(string login, string mdp)
        {
            Utilisateur user = new Utilisateur();
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            Laconnexion.IsConnect();
            try
            {
                string query = "SELECT ID_User, prenom, login, Niveau FROM user WHERE login=@login AND MDP=@password";
                MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", mdp);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user.UtilisateurID = reader.GetInt32("ID_User");
                    user.UtilisateurLogin = reader.GetString("Login");
                    user.UtilisateurPrenom = reader.GetString("Prenom");
                    user.UtilisateurNiveau = reader.GetString("Niveau");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);
            }
            return user;
        }

        // FormLogin - verif si l'user est archivé ou non. 
        public bool VerifArchive(string login, string MDPSaler)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            // Ouvrez la connexion
            Laconnexion.IsConnect();
            {
                try
                {           // faire un select de archive et un if archive is true on bloque la connexion
                    string query = "SELECT archive FROM user WHERE login=@login AND MDP=@password";
                    MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", MDPSaler);
                    bool archive = Convert.ToBoolean(command.ExecuteScalar());
                    return archive;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);
                    return false;
                }

            }
        }

        // Form Login - Se déclenche quand l'user se connect, met a jour DateTimeConnexion pour l'user qui se co.
        public void MAJDateTimeLogin(DBConnection Laconnexion, Utilisateur Userco)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            Laconnexion.IsConnect();
            int ID = Userco.UtilisateurID;
            {
                try
                {
                    string query = "UPDATE user SET DateHeureConnexion = NOW() WHERE ID_User=@ID";
                    MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                    command.Parameters.AddWithValue("@ID", ID);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);

                }

            }
        }

        // Form Création - Création d'un nouvel utilisateur.
        public void EnregistrerUnUtilisateur(Utilisateur ArrivageUtilisateur)
        {
            if (!string.IsNullOrEmpty(ArrivageUtilisateur.UtilisateurNom) && !string.IsNullOrEmpty(ArrivageUtilisateur.UtilisateurPrenom) &&
                !string.IsNullOrEmpty(ArrivageUtilisateur.UtilisateurLogin) && !string.IsNullOrEmpty(ArrivageUtilisateur.UtilisateurMDP) &&
                !string.IsNullOrEmpty(ArrivageUtilisateur.UtilisateurNiveau))
            {
                Laconnexion.Server = "localhost";
                Laconnexion.DatabaseName = "belletable";
                Laconnexion.UserName = "root";
                Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
                Laconnexion.IsConnect();
                string query = "INSERT INTO user (Nom, Prenom, Login, Mdp, Niveau, Archive, DateHeureConnexion, DateHeureDeconnexion, NbMauvaisMdp) VALUES (@nom, @prenom, @login, @mdp, @niveau, @archive,@DTConnexion,@DTDeconnexion, @NbMauvaisMDP )";
                using (MySqlCommand commande = new MySqlCommand(query, Laconnexion.Connection))
                {
                    commande.Parameters.AddWithValue("@nom", ArrivageUtilisateur.UtilisateurNom);
                    commande.Parameters.AddWithValue("@prenom", ArrivageUtilisateur.UtilisateurPrenom);
                    commande.Parameters.AddWithValue("@login", ArrivageUtilisateur.UtilisateurLogin);
                    commande.Parameters.AddWithValue("@mdp", ArrivageUtilisateur.UtilisateurMDP);
                    commande.Parameters.AddWithValue("@niveau", ArrivageUtilisateur.UtilisateurNiveau);
                    commande.Parameters.AddWithValue("@archive", ArrivageUtilisateur.UtilisateurArchive);
                    commande.Parameters.AddWithValue("@DTConnexion", ArrivageUtilisateur.UtilisateurDerniereConnexion);
                    commande.Parameters.AddWithValue("@DTDeconnexion", ArrivageUtilisateur.UtilisateurDerniereDeconnexion);
                    commande.Parameters.AddWithValue("@NbMauvaisMDP", ArrivageUtilisateur.UtilisateurNbMauvaisMDP);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    if (lignesAffectees > 0)
                    {
                        MessageBox.Show("Les données ont été insérées avec succès dans la base de données.");

                    }
                    else
                    {
                        MessageBox.Show("Aucune donnée n'a été insérée dans la base de données.");

                    }
                }
            }
        }

        // Pour Form Creation, Pour retourner L'ID de l'user qui vient d'etre créer et l'ajouter dans la list User
        // ( utile pour le supprimer direct apres dans la DGV ou faire des modifs) ( sans ça impossible car l'user ajouté n'a pas d'id)
        public Utilisateur getID(Utilisateur NouvelUser)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            Laconnexion.IsConnect();
            try
            {
                string query = "SELECT ID_User FROM user WHERE login=@login";
                MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                command.Parameters.AddWithValue("@login", NouvelUser.UtilisateurLogin);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NouvelUser.UtilisateurID = reader.GetInt32("ID_User");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);
            }
            return NouvelUser;
        }
        // Form Modifier, Pour supp l'user.
        public void SupprimerUtilisateur(DBConnection laNewconnexion, Utilisateur utilisateurAModifier)
        {
            if (laNewconnexion.IsConnect())
            {
                string query = "DELETE FROM user WHERE ID_User = @userID;";

                using (MySqlCommand cmd = new MySqlCommand(query, laNewconnexion.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", utilisateurAModifier.UtilisateurID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("L'utilisateur a été supprimé avec succès !");

                        }
                        else
                        {
                            MessageBox.Show("Aucun utilisateur n'a été supprimé.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'utilisateur : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie.");
            }
        }

        // Form Modifier, modifier les données du user, quand le mdp a été touché.
        public void sauvegarderUtilisateurModifier(Utilisateur utilisateurAModifier, DBConnection laNewconnexion)
        {
            if (laNewconnexion.IsConnect())
            {
                string query = "UPDATE user SET Nom = @nom, Prenom = @prenom, Login = @login, Niveau=@niveau, Archive=@archive, MDP = @mdp WHERE ID_User = @userID;";

                using (MySqlCommand cmd = new MySqlCommand(query, laNewconnexion.Connection))
                {
                    cmd.Parameters.AddWithValue("@nom", utilisateurAModifier.UtilisateurNom);
                    cmd.Parameters.AddWithValue("@prenom", utilisateurAModifier.UtilisateurPrenom);
                    cmd.Parameters.AddWithValue("@login", utilisateurAModifier.UtilisateurLogin);
                    cmd.Parameters.AddWithValue("@mdp", utilisateurAModifier.UtilisateurMDP);
                    cmd.Parameters.AddWithValue("@userID", utilisateurAModifier.UtilisateurID);
                    cmd.Parameters.AddWithValue("@niveau", utilisateurAModifier.UtilisateurNiveau);
                    cmd.Parameters.AddWithValue("@archive", utilisateurAModifier.UtilisateurArchive);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Les informations ont été sauvegardées avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Aucune modification n'a été effectuée.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la sauvegarde des données : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie.");
            }
        }

        // Form Modifier, modifier les données du user, quand le mdp n'a pas été touché. Donc le MDP n'est pas touché.
        public void sauvegarderUtilisateurModifierSansMDP(Utilisateur utilisateurAModifier, DBConnection laNewconnexion)
        {
            if (laNewconnexion.IsConnect())
            {
                string query = "UPDATE user SET Nom = @nom, Prenom = @prenom, Login = @login, Niveau=@niveau, Archive=@archive WHERE ID_User = @userID;";

                using (MySqlCommand cmd = new MySqlCommand(query, laNewconnexion.Connection))
                {
                    cmd.Parameters.AddWithValue("@nom", utilisateurAModifier.UtilisateurNom);
                    cmd.Parameters.AddWithValue("@prenom", utilisateurAModifier.UtilisateurPrenom);
                    cmd.Parameters.AddWithValue("@login", utilisateurAModifier.UtilisateurLogin);
                    cmd.Parameters.AddWithValue("@userID", utilisateurAModifier.UtilisateurID);
                    cmd.Parameters.AddWithValue("@niveau", utilisateurAModifier.UtilisateurNiveau);
                    cmd.Parameters.AddWithValue("@archive", utilisateurAModifier.UtilisateurArchive);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Les informations ont été sauvegardées avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Aucune modification n'a été effectuée.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la sauvegarde des données : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("La connexion à la base de données n'est pas établie.");
            }
        }

        // Form1 Quand l'utilisateur se déco. 
        public void MAJDateTimeDeco(DBConnection Laconnexion, Utilisateur Userco)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            Laconnexion.IsConnect();
            int ID = Userco.UtilisateurID;

            {
                try
                {
                    string query = "UPDATE user SET DateHeureDeconnexion = NOW() WHERE ID_User=@ID";
                    MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                    command.Parameters.AddWithValue("@ID", ID);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);

                }

            }
        }

        // Form Creation - Quand user se connecte, créer un nouveau LOG
        // DateTime Deco au minimum car user toujours connecté. 
        public Log logNouvelleConnexion(DBConnection Laconnexion, Utilisateur userEntrant, Log nouveauLog)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            Laconnexion.IsConnect();
            int ID = userEntrant.UtilisateurID;
            string Login_arrivant = userEntrant.UtilisateurLogin;
            DateTime CO = DateTime.Now;
            DateTime Deco = DateTime.MinValue;
            {
                try
                {
                    string query = "INSERT INTO log(ID_User,Login, logDateTimeConnexion, logDateTimeDeconnexion) VALUES (@ID, @Login_user, @dateTimeCo, @dateTimeDeco); SELECT LAST_INSERT_ID();";
                    MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@Login_user", Login_arrivant);
                    command.Parameters.AddWithValue("@dateTimeCo", CO);
                    command.Parameters.AddWithValue("@dateTimeDeco", Deco);
                    // là je récup grace a LAST_INSERT_ID l'ID de mon log créé, et je le met dans mon log ID.
                    int idLogInserted = Convert.ToInt32(command.ExecuteScalar());
                    nouveauLog.Log_ID = idLogInserted;
                    nouveauLog.Log_Id_User = ID;
                    nouveauLog.Log_DateTimeConnexion = CO;
                    nouveauLog.Log_DateTimeDeconnexion = Deco;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion à la base de données pour logNouvelleConnexion : " + ex.Message);
                }
            }
            return nouveauLog;
        }

        // Form1 - Quand on déco, MAJ de la LogDateTimeDeconnexion. 
        public void logDeconnexionMAJ(DBConnection Laconnexion, Utilisateur Userco, Log LogPourDeco)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            Laconnexion.IsConnect();

            {
                try
                {
                    string query = "UPDATE log SET logDateTimeDeconnexion = NOW() WHERE ID_Log=@ID";
                    MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                    command.Parameters.AddWithValue("@ID", LogPourDeco.Log_ID);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la connexion à la base de données pour logDeconnexionMAJ: " + ex.Message);

                }

            }
        }

        // Form Création + Form Modif.  Avant de créer ou modifier un user,
        // Verif si le login est déjà use pour éviter les doublons 
        public bool VerifDoublonLogin(Utilisateur ArrivageUser)
        {
            bool estDupliqué = false;
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");

            try
            {
                Laconnexion.IsConnect();
                string query = "SELECT COUNT(*) FROM user WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                command.Parameters.AddWithValue("@login", ArrivageUser.UtilisateurLogin);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    estDupliqué = true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur MySQL VerifDoublonLogin : " + ex.Message);
            }
            return estDupliqué;
        }

        // Form Login - Quand mauvais MDP, on récup le nb de mauvaismdp en base, on ajoute 1
        // et on UPDATE avec le nouveau nombre. 
        public void MauvaisMDP(string login)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");

            try
            {
                Laconnexion.IsConnect();
                string query = "SELECT NbMauvaisMDP FROM user WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, Laconnexion.Connection);
                command.Parameters.AddWithValue("@login", login);

                int NbEchecAncienMDP = Convert.ToInt32(command.ExecuteScalar());
                int nbMDP = NbEchecAncienMDP + 1;

                string query2 = "Update user set NbMauvaisMDP = @nbMDP where login = @login";
                MySqlCommand command2 = new MySqlCommand(query2, Laconnexion.Connection);
                command2.Parameters.AddWithValue("@nbMDP", nbMDP);
                command2.Parameters.AddWithValue("@login", login);
                int rowsAffected = command2.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur MySQL Mauvais MDP : " + ex.Message);
            }
        }
        // Form Ouvrage - Lorsque l'opérateur séléctionne un ouvrage et l'inventorie.
        public void NouveauInventaire(Inventaire ArrivageInventaire)
        {
            Laconnexion.Server = "localhost";
            Laconnexion.DatabaseName = "belletable";
            Laconnexion.UserName = "root";
            Laconnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            Laconnexion.IsConnect();

            string query = "INSERT INTO inventaire (ID_Livre, etat, Date, Commentaire) VALUES (@id_livre, @etat, @Date, @Commentaire)";
            using (MySqlCommand commande = new MySqlCommand(query, Laconnexion.Connection))
            {
                commande.Parameters.AddWithValue("@id_livre", ArrivageInventaire.id_Livre_inventaire);
                commande.Parameters.AddWithValue("@etat", ArrivageInventaire.etat_inventaire);
                commande.Parameters.AddWithValue("@Date", DateTime.Now);
                commande.Parameters.AddWithValue("@Commentaire", ArrivageInventaire.commentaire_inventaire);

                int lignesAffectees = commande.ExecuteNonQuery();
                if (lignesAffectees > 0)
                {
                    MessageBox.Show("Les données ont été insérées avec succès dans la base de données.");

                }
                else
                {
                    MessageBox.Show("Aucune donnée n'a été insérée dans la base de données.");

                }
            }

        }
    }
}