using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace SQLApp
{
    /// <summary>
    /// 数据访问辅助类。
    /// </summary>
    public class SQLHelper
    {
        public static String connectionString; //连接字符串
        static SQLHelper()
        {
            connectionString = "Data Source=192.168.1.100;Initial Catalog=DB_TEST;User Id=sa;Password=123456;";
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString,SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.Parameters.AddRange(parameters);
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>		
        public static bool ExecuteSqlTran(List<SqlCommand> ListSqlCommand)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction sqlTran = conn.BeginTransaction();
                //OracleTransaction tx=conn.BeginTransaction();	
                foreach (SqlCommand oc in ListSqlCommand)
                {
                    try
                    {
                        oc.Connection = conn;
                        oc.Transaction = sqlTran;
                        oc.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException E)
                    {
                        sqlTran.Rollback();
                        throw new Exception(E.Message);
                    }

                }
                sqlTran.Commit();
                return true;
            }
            return false;
        }

        public static bool ExecuteSqlTran(List<string> sqls, List<SqlParameter[]> parameters)
        {
            if (sqls == null || parameters == null || sqls.Count <= 0 || parameters.Count < 0 || sqls.Count != parameters.Count)
            {
                return false;
            }
            else
            {
                List<SqlCommand> listCommands = new List<SqlCommand>();
                for (int i = 0; i < sqls.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand(sqls[i]);
                    cmd.Parameters.AddRange(parameters[i]);
                    listCommands.Add(cmd);
                }
                return ExecuteSqlTran(listCommands);
            }
        }
    }
}
