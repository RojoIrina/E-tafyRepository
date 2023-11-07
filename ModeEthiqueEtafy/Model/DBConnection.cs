using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeEthiqueEtafy.Model
{
    internal class DBConnection
    {
        public static NpgsqlConnection connection = new NpgsqlConnection(
               "Server=localhost;" +
               "User Id=postgres;" +
               "Password=admin;" +
               "Database=mode_ethique;");

        public static string VendeurNextIndex()
        {
            string vendeurIndex = "VEN-";
            connection.Open();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(id_vendeur) FROM vendeurs", connection);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    vendeurIndex += $"{reader.GetInt64(0) + 1}";
                }
            }
            catch (NpgsqlException exception)
            {
                Console.Error.WriteLine($"Erreur sql : {exception.SqlState}");
            }
            connection.Close();
            return vendeurIndex;
        }
        public static string AcheteurNextIndex()
        {
            string acheteurIndex = "ACH-";
            connection.Open();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(id_acheteur) FROM acheteur", connection);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    acheteurIndex += $"{reader.GetInt64(0) + 1}";
                }
            }
            catch (NpgsqlException exception)
            {
                Console.Error.WriteLine($"Erreur sql : {exception.SqlState}");
            }
            connection.Close();
            return acheteurIndex;
        }

        public static void VendeurInsert(Vendeur vendeur)
        {
            connection.Open();
            string insertquerry = "INSERT INTO \"vendeurs\"(id_vendeur, nom_vendeur, niff_stat, login, mot_de_passe, adresse, contact, label) VALUES " +
                $"({vendeur.ToString()})";
            NpgsqlCommand insert = new NpgsqlCommand(insertquerry, connection);
            insert.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Un client a été ajouté!!! \n");
        }
        public static void InsertAcheteur(Acheteur acheteur)
        {
            connection.Open();
            var sql = $"INSERT INTO acheteur(id_acheteur, nom, prenom, contact, adresse, login, motdepasse)" +
                       $"VALUES('{acheteur.IdAcheteur}'," +
                       $"'{acheteur.Nom}','{acheteur.Prenom}'," +
                       $"'{acheteur.Contact}','{acheteur.Adresse}'," +
                        $"'{acheteur.LoginAcheteur}','{acheteur.MotDePasse}')";
            var cmdinsertacheteur = new NpgsqlCommand(sql, connection);
            cmdinsertacheteur.ExecuteNonQuery();
            connection.Close();
        }
        public static bool RecupererLoginAcheteur(string login)
        {
            bool loginOk = false;
            try
            {
                connection.Open();
                var sqllogin = $"SELECT login FROM acheteur WHERE login = '{login}'";
                var cmdrecupererlogin = new NpgsqlCommand(sqllogin, connection);
                NpgsqlDataReader reader = cmdrecupererlogin.ExecuteReader();
                if (reader.Read())
                {
                    loginOk = login.Equals(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception ici (par exemple, journalisation ou affichage d'un message d'erreur)
                Console.WriteLine($"Erreur lors de la récupération du login : {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return loginOk;
        }

        public static bool RecupererPasswordAcheteur(string motdepasse)
        {
            bool motdepasseOk = false;
            try
            {
                connection.Open();

                var sqlmotdepasse = $"SELECT mot_de_passe FROM acheteur WHERE mot_de_passe = '{motdepasse}'";
                var cmdrecuperermotdepasse = new NpgsqlCommand(sqlmotdepasse, connection);
                NpgsqlDataReader reader = cmdrecuperermotdepasse.ExecuteReader();
                if (reader.Read())
                {
                    motdepasseOk = true;
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception ici (par exemple, journalisation ou affichage d'un message d'erreur)
                Console.WriteLine($"Erreur lors de la récupération du mot de passe : {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return motdepasseOk;
        }




        public static bool RecupererLoginVendeur(string login)
        {
            bool loginOk = false;
            try
            {
                connection.Open();
                var sqllogin = $"SELECT login FROM vendeurs WHERE login = '{login}'";
                var cmdrecupererlogin = new NpgsqlCommand(sqllogin, connection);
                NpgsqlDataReader reader = cmdrecupererlogin.ExecuteReader();
                if (reader.Read())
                {
                    loginOk = login.Equals(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception ici (par exemple, journalisation ou affichage d'un message d'erreur)
                Console.WriteLine($"Erreur lors de la récupération du login du vendeur : {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return loginOk;


        
        }
        public static bool RecupererPasswordVendeur(string motdepasse)
        {
            bool motdepasseOk = false;
            try
            {
                connection.Open();

                var sqlmotdepasse = $"SELECT mot_de_passe FROM vendeurs WHERE mot_de_passe = '{motdepasse}'";
                var cmdrecuperermotdepasse = new NpgsqlCommand(sqlmotdepasse, connection);
                NpgsqlDataReader reader = cmdrecuperermotdepasse.ExecuteReader();
                if (reader.Read())
                {
                    motdepasseOk = true;
                }
            }
            catch (Exception ex)
            {
                // Gérer l'exception ici (par exemple, journalisation ou affichage d'un message d'erreur)
                Console.WriteLine($"Erreur lors de la récupération du mot de passe du vendeur : {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return motdepasseOk;
        }

        public static int NextIndex(string table)
        {
            int indice = 0;
            connection.Open();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT id_{table} FROM {table}", connection);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    indice = reader.GetInt32(0);
                }
            }
            catch (NpgsqlException exception)
            {
                Console.Error.WriteLine($"Erreur sql : {exception.SqlState}");
            }
            connection.Close();
            return indice + 1;
        }


    }





}
