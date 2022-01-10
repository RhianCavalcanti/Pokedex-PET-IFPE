using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;


namespace POKEDEX_SiDi.Model
{
    class DbClass
    {
        public static SQLiteConnection conection;

        public static SQLiteConnection ConnectionDb()
        {
            conection = new SQLiteConnection("Data Source=C:\\Users\\Adan\\source\\repos\\TesteApiPokedex\\TesteApiPokedex\\dbfortest\\db_teste.db", true );
            //conection = new SQLiteConnection("Data Source=C:\\Users\\Adan\\Desktop\\pokedex\\Pokedex-PET-IFPE\\POKEDEX-SiDi\\DataBase\\pokemon.db");
            conection.Open();
            return conection;
        }

        public static DataTable GetPokemon(int number)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_pokemon LIMIT 10 OFFSET "+number;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDb());
                    da.Fill(dt);
                    ConnectionDb().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConnectionDb().Close();
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_pokemon WHERE NAME='" + sql + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDb());
                    da.Fill(dt);
                    ConnectionDb().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConnectionDb().Close();
                throw ex;
            }

        }

        //public static void Add(PokemonDb pokemon)
        //{
        //    try
        //    {
        //        using (var cmd = ConnectionDb().CreateCommand())
        //        {
        //            cmd.CommandText = "INSERT INTO tb_pokemon(id_pokemon, name, type, hp, attack, defense, special_attack, special_defense, speed, height, weight, image) values (@id_pokemon, @name, @type, @hp, @attack, @defense, @special_attack, @special_defense, @speed, @height, @weight, @image)";
        //            cmd.Parameters.AddWithValue("@id_pokemon", pokemon.Id);
        //            cmd.Parameters.AddWithValue("@name", pokemon.Name);
        //            cmd.Parameters.AddWithValue("@type", pokemon.Types);
        //            cmd.Parameters.AddWithValue("@hp", pokemon.Hp);
        //            cmd.Parameters.AddWithValue("@attack", pokemon.Attack);
        //            cmd.Parameters.AddWithValue("@defense", pokemon.Defense);
        //            cmd.Parameters.AddWithValue("@special_attack", pokemon.SpecialAttack);
        //            cmd.Parameters.AddWithValue("@special_defense", pokemon.SpecialDefense);
        //            cmd.Parameters.AddWithValue("@speed", pokemon.Speed);
        //            cmd.Parameters.AddWithValue("@height", pokemon.Height);
        //            cmd.Parameters.AddWithValue("@weight", pokemon.Weight);
        //            cmd.Parameters.AddWithValue("@image", pokemon.Image);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public static void Add(PokemonDb pokemon)
        {
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO pokemon(id_pokemon, name, type, height, weight, image) values (@id_pokemon, @name, @type, @height, @weight, @image)";
                    cmd.Parameters.AddWithValue("@id_pokemon", pokemon.Id);
                    cmd.Parameters.AddWithValue("@name", pokemon.Name);
                    cmd.Parameters.AddWithValue("@type", pokemon.Types);
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

        public static void Update(PokemonDb pokemon)
        {
            try
            {
                using (var cmd = new SQLiteCommand(ConnectionDb()))
                {
                    if (pokemon.Id != null)
                    {
                        cmd.CommandText = "UPDATE tb_pokemon SET name=@name, type=@type, height=@height, weight=@weight, image=@image  WHERE id_pokemon=@id_pokemon"; 
                        cmd.Parameters.AddWithValue("@id_pokemon", pokemon.Id);
                        cmd.Parameters.AddWithValue("@name", pokemon.Name);
                        cmd.Parameters.AddWithValue("@type", pokemon.Types);
                        cmd.Parameters.AddWithValue("@height", pokemon.Height);
                        cmd.Parameters.AddWithValue("@weight", pokemon.Weight);
                        cmd.Parameters.AddWithValue("@image", pokemon.Image);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(ConnectionDb()))
                {
                    cmd.CommandText = "DELETE FROM tb_pokemon Where id_pokemon=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
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


    
        //private static SQLiteConnection conexao;
        //public static string caminho = System.Environment.CurrentDirectory;

        //public static string nomeBanco = "bancotestepoke.db;";
        //public static string caminhoBanco = caminho + @"\BD\";
        //private static SQLiteConnection ConexaoBanco()
        //{
        //    Console.WriteLine(caminho);
        //    conexao = new SQLiteConnection("Data Source=" + caminhoBanco + nomeBanco);
        //    conexao.Open();
        //    return conexao;
        //}

        ////*public static DataTable ObterTodosPoke()
        ////{
        ////    SQLiteDataAdapter da = null;
        ////    DataTable dt = new DataTable();
        ////    try
        ////     {
        ////        using (var cmd = ConexaoBanco().CreateCommand())
        ////        {
        ////            cmd.CommandText = "SELECT * FROM teste";
        ////           da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
        ////            da.Fill(dt);
        ////            return dt;
        ////        }
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        throw ex;
        ////    }
        ////}

        //public static void NovoPokemon(string nomepoke)
        //{
        //    try
        //    {
        //        var cmd = ConexaoBanco().CreateCommand();
        //        cmd.CommandText = "INSERT INTO teste (NOMEPOKE) VALUES (@nome)";
        //        cmd.Parameters.AddWithValue("@nome", nomepoke);
        //        cmd.ExecuteNonQuery();
        //        ConexaoBanco().Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        ConexaoBanco().Close();
        //    }
        //}
    

