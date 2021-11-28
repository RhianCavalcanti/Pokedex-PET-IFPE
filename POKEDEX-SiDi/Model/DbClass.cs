using System;
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
            conection = new SQLiteConnection("Data Source=C:Caminho do banco de dados");
            conection.Open();
            return conection;
        }

        public static DataTable GetPokemon()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM pokemon";
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
                    cmd.CommandText = "SELECT * FROM pokemon WHERE NAME='" + sql + "'";
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

        //public static void Add(TableSearch tableSearch)
        public static void Add(long id, string name)
        {
            try
            {
                using (var cmd = ConnectionDb().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO pokemon(NAME, IDENTIFICATION) values (@name, @identification)";
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Identification", id);
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
    

