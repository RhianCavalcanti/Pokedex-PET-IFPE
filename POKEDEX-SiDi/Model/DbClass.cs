using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Data.SQLite;
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

        //public static void Delete(int Id)
        //{
        //    try
        //    {
        //        using (var cmd = new SqliteCommand(ConnectionDb()))
        //        {
        //            cmd.CommandText = "DELETE FROM tb_pokemon Where id_pokemon=@Id";
        //            cmd.Parameters.AddWithValue("@Id", Id);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}






















//class DbClass
//{
//    public static SQLiteConnection conection;
//    //public static string DbFile = Path.Combine(ApplicationData.Current.LocalFolder.Path, "pokemon.db");

//    public async static void InitializeDB()
//    {
//        await ApplicationData.Current.LocalFolder.CreateFileAsync("DataBaseUWP.db", CreationCollisionOption.OpenIfExists);
//        string caminho = Path.Combine(ApplicationData.Current.LocalFolder.Path, "DataBaseUWP.db");

//        using (conection = new SqliteConnection($"Filename={caminho}"))
//        {
//            conection.Open();
//            string initCMD = "CREATE TABLE IF NOT EXISTS PokemonData(id int PRIMARY KEY, id_pokemon int, name Varchar(255), type Varchar(255), height int, weight int, image Varchar(255))";

//            SqliteCommand CMDcreateTable = new SqliteCommand(initCMD, conection);
//            CMDcreateTable.ExecuteReader();
//            conection.Close();
//        }
//    }

//    public static SQLiteConnection ConnectionDb()
//    {
//        //conection = new SQLiteConnection("Data Source=C:\\Users\\pokemon.db");
//        //conection = new SQLiteConnection("Data Source=C:\\\\Users\\Adan\\source\\repos\\TesteApiPokedex\\TesteApiPokedex\\dbfortest\\db_teste.db");
//        //conection = new SQLiteConnection("Data Source=C://Users//Adan//Desktop//pokedex//Pokedex-PET-IFPE//POKEDEX-SiDi//DataBase//db_teste.db", true);
//        //conection = new SQLiteConnection("Data Source=C:\\Users\\Adan\\Desktop\\pokedex\\Pokedex-PET-IFPE\\POKEDEX-SiDi\\bin\\db_teste.db");
//        conection = new SQLiteConnection("Data Source=Assets\\pokemon.db");
//        conection.Open();
//        return conection;

//        //conection.CreateCommand().CommandTimeout = 400;
//        //using (var conection = new SQLiteConnection("Data Source=C:\\Users\\Adan\\Desktop\\pokemon.db", true))
//        //{
//        //conection.Open();
//        //return conection;
//        //}

//    }

//    public static DataTable GetPokemon(int number)
//    {
//        SQLiteDataAdapter da = null;
//        DataTable dt = new DataTable();
//        try
//        {
//            using (var cmd = ConnectionDb().CreateCommand())
//            {
//                cmd.CommandText = "SELECT * FROM tb_pokemon LIMIT 10 OFFSET " + number;
//                da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDb());
//                da.Fill(dt);
//                ConnectionDb().Close();
//                return dt;
//            }
//        }
//        catch (Exception ex)
//        {
//            ConnectionDb().Close();
//            throw ex;
//        }
//    }

//    public static DataTable consulta(string sql)
//    {
//        SQLiteDataAdapter da = null;
//        DataTable dt = new DataTable();
//        try
//        {
//            using (var cmd = ConnectionDb().CreateCommand())
//            {
//                cmd.CommandText = "SELECT * FROM tb_pokemon WHERE NAME='" + sql + "'";
//                da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDb());
//                da.Fill(dt);
//                ConnectionDb().Close();
//                return dt;
//            }
//        }
//        catch (Exception ex)
//        {
//            ConnectionDb().Close();
//            throw ex;
//        }

//    }

//    public static void Add(PokemonDb pokemon)
//    {
//        try
//        {
//            using (var cmd = ConnectionDb().CreateCommand())
//            {
//                cmd.CommandText = "INSERT INTO tb_pokemon(id_pokemon, name, type, hp, attack, defense, special_attack, special_defense, speed, height, weight, image) values (@id_pokemon, @name, @type, @hp, @attack, @defense, @special_attack, @special_defense, @speed, @height, @weight, @image)";
//                cmd.Parameters.AddWithValue("@id_pokemon", pokemon.Id);
//                cmd.Parameters.AddWithValue("@name", pokemon.Name);
//                cmd.Parameters.AddWithValue("@type", pokemon.Types);
//                cmd.Parameters.AddWithValue("@hp", pokemon.Hp);
//                cmd.Parameters.AddWithValue("@attack", pokemon.Attack);
//                cmd.Parameters.AddWithValue("@defense", pokemon.Defense);
//                cmd.Parameters.AddWithValue("@special_attack", pokemon.SpecialAttack);
//                cmd.Parameters.AddWithValue("@special_defense", pokemon.SpecialDefense);
//                cmd.Parameters.AddWithValue("@speed", pokemon.Speed);
//                cmd.Parameters.AddWithValue("@height", pokemon.Height);
//                cmd.Parameters.AddWithValue("@weight", pokemon.Weight);
//                cmd.Parameters.AddWithValue("@image", pokemon.Image);
//                cmd.ExecuteNonQuery();
//            }
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
//    }
//    //public static void Add(PokemonDb pokemon)
//    //{
//    //    try
//    //    {
//    //        using (var cmd = ConnectionDb().CreateCommand())
//    //        {
//    //            cmd.CommandText = "INSERT INTO pokemon(id_pokemon, name, type, height, weight, image) values (@id_pokemon, @name, @type, @height, @weight, @image)";
//    //            cmd.Parameters.AddWithValue("@id_pokemon", pokemon.Id);
//    //            cmd.Parameters.AddWithValue("@name", pokemon.Name);
//    //            cmd.Parameters.AddWithValue("@type", pokemon.Types);
//    //            cmd.Parameters.AddWithValue("@height", pokemon.Height);
//    //            cmd.Parameters.AddWithValue("@weight", pokemon.Weight);
//    //            cmd.Parameters.AddWithValue("@image", pokemon.Image);
//    //            cmd.ExecuteNonQuery();
//    //        }
//    //    }
//    //    catch (Exception ex)
//    //    {
//    //        throw ex;
//    //    }
//    //}

//    //public static void Update(PokemonDb pokemon)
//    //{
//    //    try
//    //    {
//    //        using (var cmd = new SQLiteCommand(ConnectionDb()))
//    //        {
//    //            if (pokemon.Id != null)
//    //            {
//    //                cmd.CommandText = "UPDATE tb_pokemon SET name=@name, type=@type, height=@height, weight=@weight, image=@image  WHERE id_pokemon=@id_pokemon"; 
//    //                cmd.Parameters.AddWithValue("@id_pokemon", pokemon.Id);
//    //                cmd.Parameters.AddWithValue("@name", pokemon.Name);
//    //                cmd.Parameters.AddWithValue("@type", pokemon.Types);
//    //                cmd.Parameters.AddWithValue("@height", pokemon.Height);
//    //                cmd.Parameters.AddWithValue("@weight", pokemon.Weight);
//    //                cmd.Parameters.AddWithValue("@image", pokemon.Image);
//    //                cmd.ExecuteNonQuery();
//    //            }
//    //        };
//    //    }
//    //    catch (Exception ex)
//    //    {
//    //        throw ex;
//    //    }
//    //}

//    public static void Delete(int Id)
//    {
//        try
//        {
//            using (var cmd = new SQLiteCommand(ConnectionDb()))
//            {
//                cmd.CommandText = "DELETE FROM tb_pokemon Where id_pokemon=@Id";
//                cmd.Parameters.AddWithValue("@Id", Id);
//                cmd.ExecuteNonQuery();
//            }
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
//    }
//}
//}



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
