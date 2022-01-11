using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.Data;
using Windows.Storage;

namespace POKEDEX_SiDi.Model
{
    class DbClass
    {
        public static SqliteConnection conection;

        public async static void InitializeDB()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("pokemonDb.db", CreationCollisionOption.OpenIfExists);
            string caminho = Path.Combine(ApplicationData.Current.LocalFolder.Path, "pokemonDb.db");

            using (conection = new SqliteConnection($"Filename={caminho}"))
            {
                conection.Open();
                string initCMD = "CREATE TABLE IF NOT EXISTS tb_pokemon (id_pokemon int, name Varchar(500), type Varchar(500), hp int, attack int, defense int, special_attack int, special_defense int, speed int, height int, weight int, image Varchar(500))";

                SqliteCommand CMDcreateTable = new SqliteCommand(initCMD, conection);
                CMDcreateTable.ExecuteReader();
                conection.Close();
            }
        }

        public static SqliteConnection ConnectionDb()
        {
            string caminho = Path.Combine(ApplicationData.Current.LocalFolder.Path, "pokemonDb.db");

            conection = new SqliteConnection($"Filename={caminho}");
            conection.Open();
            return conection;

        }

        public static DataTable GetPokemon(int number)
        {
            DataTable dt = new DataTable();
            try
            {
                ConnectionDb();
                string selectCmd = "SELECT * FROM tb_pokemon LIMIT 10 OFFSET " + number;
                SqliteCommand cmd_getRec = new SqliteCommand(selectCmd, ConnectionDb());
                SqliteDataReader reader = cmd_getRec.ExecuteReader();
                ConnectionDb().Close();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                ConnectionDb().Close();
                throw ex;
            }
        }

        public static DataTable GetPokemonType(int number, string especie)
        {
            DataTable dt = new DataTable();
            try
            {
                ConnectionDb();
                string selectCmd = "SELECT * FROM tb_pokemon WHERE type LIKE '%" + especie + "%' LIMIT 10 OFFSET " +number;
                SqliteCommand cmd_getRec = new SqliteCommand(selectCmd, ConnectionDb());
                SqliteDataReader reader = cmd_getRec.ExecuteReader(); 
                ConnectionDb().Close();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                ConnectionDb().Close();
                throw ex;
            }
        }



        public static DataTable consulta(string sql)
        {
            
            DataTable dt = new DataTable();
            try
            {
                ConnectionDb();
                string selectCmd = "SELECT * FROM tb_pokemon WHERE NAME='" + sql + "'";
                SqliteCommand cmd_getRec = new SqliteCommand(selectCmd, ConnectionDb());
                SqliteDataReader reader = cmd_getRec.ExecuteReader();
                ConnectionDb().Close();
                dt.Load(reader);
                return dt;
                
            }
            catch (Exception ex)
            {
                ConnectionDb().Close();
                throw ex;
            }

        }

        public static DataTable consultaId(string sql)
        {

            DataTable dt = new DataTable();
            try
            {
                ConnectionDb();
                string selectCmd = "SELECT * FROM tb_pokemon WHERE id_pokemon='" + sql + "'";
                SqliteCommand cmd_getRec = new SqliteCommand(selectCmd, ConnectionDb());
                SqliteDataReader reader = cmd_getRec.ExecuteReader();
                ConnectionDb().Close();
                dt.Load(reader);
                return dt;

            }
            catch (Exception ex)
            {
                ConnectionDb().Close();
                throw ex;
            }

        }

        public static int Count()
        {
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM tb_pokemon WHERE name LIKE '%" + "User"+"%'";
                    cmd.ExecuteNonQuery();
                    ConnectionDb().Close();
                    int number = Convert.ToInt32(cmd.ExecuteScalar());
                    return number;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void Add(PokemonDb pokemon)
        {
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO tb_pokemon (id_pokemon, name, type, hp, attack, defense, special_attack, special_defense, speed, height, weight, image) values (@id_pokemon, @name, @type, @hp, @attack, @defense, @special_attack, @special_defense, @speed, @height, @weight, @image)";
                    cmd.Parameters.AddWithValue("@id_pokemon", pokemon.Id);
                    cmd.Parameters.AddWithValue("@name", pokemon.Name);
                    cmd.Parameters.AddWithValue("@type", pokemon.Types);
                    cmd.Parameters.AddWithValue("@hp", pokemon.Hp);
                    cmd.Parameters.AddWithValue("@attack", pokemon.Attack);
                    cmd.Parameters.AddWithValue("@defense", pokemon.Defense);
                    cmd.Parameters.AddWithValue("@special_attack", pokemon.SpecialAttack);
                    cmd.Parameters.AddWithValue("@special_defense", pokemon.SpecialDefense);
                    cmd.Parameters.AddWithValue("@speed", pokemon.Speed);
                    cmd.Parameters.AddWithValue("@height", pokemon.Height);
                    cmd.Parameters.AddWithValue("@weight", pokemon.Weight);
                    cmd.Parameters.AddWithValue("@image", pokemon.Image);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static void Update(PokemonDb pokemon)
        //{
        //    try
        //    {
        //        using (var cmd = new SQLiteCommand(ConnectionDb()))
        //        {
        //            if (pokemon.Id != null)
        //            {
        //                cmd.CommandText = "UPDATE tb_pokemon SET name=@name, type=@type, height=@height, weight=@weight, image=@image  WHERE id_pokemon=@id_pokemon"; 
        //                cmd.Parameters.AddWithValue("@id_pokemon", pokemon.Id);
        //                cmd.Parameters.AddWithValue("@name", pokemon.Name);
        //                cmd.Parameters.AddWithValue("@type", pokemon.Types);
        //                cmd.Parameters.AddWithValue("@height", pokemon.Height);
        //                cmd.Parameters.AddWithValue("@weight", pokemon.Weight);
        //                cmd.Parameters.AddWithValue("@image", pokemon.Image);
        //                cmd.ExecuteNonQuery();
        //            }
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static void Delete()
        {
            try
            {
                using(var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_pokemon";
                    //cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}