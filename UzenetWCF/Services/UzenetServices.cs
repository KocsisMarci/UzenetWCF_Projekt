using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UzenetWCF.Models;
using UzenetWCF.Interfaces;
using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
namespace UzenetWCF.Services
{
    public class UzenetServices : ICRUD
    {

        public static MySqlConnection conn = new MySqlConnection();
        public static MySqlCommand cmd = new MySqlCommand();
        public UzenetServices() {
            conn.ConnectionString = "SERVER = localhost;" +
                                    "DATABASE = uzenetkuldo;" +
                                    "UID = root;" +
                                    "PASSWORD =;";

            cmd.Connection = conn;
         }
        public string Delete(int id)
        {
            cmd.Parameters.Clear();
            conn.Open();

            cmd.CommandText = "DELETE FROM  uzenet  WHERE Id=@m1;";

            cmd.Parameters.AddWithValue("@m1", id);
          
            int sorok = cmd.ExecuteNonQuery();
            conn.Close();
            if (sorok > 0) return "Sikeres üzenet törlés";

            else return "Sikertelen üzenet törlés";
        }

        public string Insert(Uzenet uzenet)
        {
            cmd.Parameters.Clear();
            conn.Open();

            cmd.CommandText = "INSERT INTO uzenet(Szoveg, KüldesiIdo, UzenetTipus, Telefon, Email) VALUES(@m1, @m2, @m3, @m4, @m5)";

            cmd.Parameters.AddWithValue("@m1", uzenet.Szoveg);
            cmd.Parameters.AddWithValue("@m2", uzenet.KuldesiIdo);
            cmd.Parameters.AddWithValue("@m3", uzenet.UzenetTipus);
            cmd.Parameters.AddWithValue("@m4", uzenet.Telefon);
            cmd.Parameters.AddWithValue("@m5", uzenet.Email);

            int sorok = cmd.ExecuteNonQuery();
            conn.Close();
            if (sorok > 0) return "Sikeres üzenet rögzités";

            else return "Sikertelen üzenet rögzités";
         }

        public List<Uzenet> Read()
        {
            conn.Open();
            cmd.CommandText = "SELECT * FROM uzenet";

            List<Uzenet> uzenetek = new List<Uzenet> { };

            MySqlDataReader olvaso = cmd.ExecuteReader();


            while (olvaso.Read()) {
                Uzenet uzenet = new Uzenet(olvaso.GetInt32("Id"), olvaso.GetString("Szoveg"), olvaso.GetDateTime("KüldesiIdo"), olvaso.GetString("UzenetTipus"), olvaso.GetString("Telefon"), olvaso.GetString("Email"));
                uzenetek.Add(uzenet);
            }

            conn.Close();

            return uzenetek; 
            //Itt egy throw new NotImplementedException() bent maradt, ezt utólag vettem észre egyébként a program működését nem gátolta.
        }

        public string Update(Uzenet uzenet)
        {
            cmd.Parameters.Clear();
            conn.Open();

            cmd.CommandText = "UPDATE  uzenet SET Szoveg=@m1, KüldesiIdo=@m2, UzenetTipus=@m3, Telefon=@m4, Email=@m5 WHERE Id=@m6;";

            cmd.Parameters.AddWithValue("@m1", uzenet.Szoveg);
            cmd.Parameters.AddWithValue("@m2", uzenet.KuldesiIdo);
            cmd.Parameters.AddWithValue("@m3", uzenet.UzenetTipus);
            cmd.Parameters.AddWithValue("@m4", uzenet.Telefon);
            cmd.Parameters.AddWithValue("@m5", uzenet.Email);
            cmd.Parameters.AddWithValue("@m6", uzenet.Id);
            int sorok = cmd.ExecuteNonQuery();
            conn.Close();
            if (sorok > 0) return "Sikeres üzenet szerkesztés";

            else return "Sikertelen üzenet szerkesztés";

        }
    }
}
