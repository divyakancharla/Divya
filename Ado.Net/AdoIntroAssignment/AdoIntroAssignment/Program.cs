using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AdoIntroAssignment
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A63MUHA\SQLEXPRESS;Initial Catalog=PracticeDB;User ID=sa;Password=pass@word1");
        SqlCommand cmd = null;
        public void Add(int id,string name,int price,int stock)
        {
            try
            {
                cmd = new SqlCommand("insert into product values(@id,@name,@price,@stock)", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void Get(int id)
        {
            try
            {
                cmd = new SqlCommand("select * from product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    Console.WriteLine("id:{0} \t Name:{1} \t Price:{2} \t Stock:{3}",
                        dr["id"], dr["name"], dr["price"], dr["stock"]);
                }
                else
                {
                    Console.WriteLine("No Rows To Show");
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
        public void Getall()
        {
            try
            {
                cmd = new SqlCommand("Select * from product", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        Console.WriteLine("id:{0} \t Name:{1} \t Price:{2} \t Stock:{3}",
                            dr["id"], dr["name"], dr["price"], dr["stock"]);
                    }
                }
                else
                {
                    Console.WriteLine("No Rows To Show");
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
        public void update(int id, string name, int price, int stock)
        {
            try
            {
                cmd = new SqlCommand("update product set name=@name,price=@price,stock=@stock where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
}
        public void Delete(int id)
        {
            try
            {
                cmd = new SqlCommand("delete  from product where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
                {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int id;
            Console.WriteLine("Enter id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter stock:");
            int stock = int.Parse(Console.ReadLine());
            //p.Add(id, name, price, stock);
            //Console.WriteLine("Enter Element to Get");
            //int idd = int.Parse(Console.ReadLine());
            //p.Get(idd);
            //p.Getall();
            //int iddel = int.Parse(Console.ReadLine());
            //p.Delete(iddel);
            p.update(id, name, price, stock);
        }
    }
}
