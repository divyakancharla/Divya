using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AdoIntro
{
    class Program
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=PracticeDB;User ID=sa;Password=pass@word1");
        SqlCommand cmd = null;

        public  void Add()
        {
            try
            {
                cmd = new SqlCommand("Insert into project values(@id,@name,@sdate)", conn);
                cmd.Parameters.AddWithValue("@id", "P007");
                cmd.Parameters.AddWithValue("@name", "Camila");
                cmd.Parameters.AddWithValue("@sdate","USA");
                conn.Open();

                cmd.ExecuteNonQuery();//Execute Dml Queries
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void GetProjectById( string pid)
        {
            cmd = new SqlCommand("Select * from project where Projectno=@pid", conn);
            cmd.Parameters.AddWithValue("@pid", pid);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();//Execute select statement
            if (dr.HasRows)
            {
                dr.Read();
                Console.WriteLine("ID:{0} Name{1} Loccation{2}", dr["Projectno"], dr["Projectname"], dr["Location"]); 
            }
            else
            {
                Console.WriteLine("Invalid Project ID");
            }

        }
        public void GetAllRows()
        {
            try
            {
                cmd = new SqlCommand("select * from project", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0} Name{1} Loccation{2}", dr["Projectno"], dr["Projectname"], dr["Location"]);

                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            // obj.Add();
            //obj.GetProjectById("P006");
            obj.GetAllRows();
        }
    }
}
