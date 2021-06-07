using System;
using System.Data;
using System.Data.SqlClient;
using Security;

namespace SQL
{
    public class Queries
    {
        public static bool LogInQuery(string username, string password)
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                                SELECT * FROM DBMSusers
                                WHERE Username='" + username + "' AND Passwd='" + password + "'";

            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                Current_User.exception = true;
                return false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            Current_User.exception = false;
            conn.Close();
            if (dtbl.Rows.Count == 1)
            {
                foreach(DataRow row in dtbl.Rows)
                {
                    Current_User.SetUser(row["Username"].ToString(), row["FirstName"].ToString(), row["LastName"].ToString(), row["Privilege"].ToString()); ;
                }

                return true;
            }
            else
            {
                return false;
            }

        }

        public static void TableSales()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT stor_id AS 'Store ID', ord_num AS 'Order Number', ord_date as 'Order Date', qty as 'Quantity', payterms as 'Pay Terms', title_id AS 'Title ID' FROM sales;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "sales";

        }

        public static void TableAuthors()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT au_id AS 'Author ID', au_lname AS 'Last Name', au_fname as 'First Name', phone as 'Phone Number', address as 'Address', city AS 'City', state AS 'State', zip AS 'Zip Code', contract AS 'Contracted' FROM authors;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "authors";
        }

        public static void TableDiscounts()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT discounttype AS 'Discount Type', stor_id AS 'Store ID', lowqty as 'Low Quantity', highqty as 'High Quantity', discount as 'Discount' FROM discounts;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "discounts";
        }

        public static void TableEmployee()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT emp_id AS 'Employee ID', fname AS 'First Name', lname AS 'Last Name', job_id AS 'Job ID', job_lvl AS 'Job Level', pub_id AS 'Publisher ID', hire_date AS 'Hire Date' FROM employee;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "employee";

        }

        public static void TableJobs()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT job_id AS 'Job ID', job_desc AS 'Job Description', min_lvl AS 'Minimum Level', max_lvl AS 'Maximum Level' FROM jobs;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "jobs";
        }

        public static void TablePublishers()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT pub_id AS 'Publisher ID', pub_name AS 'Publisher Name', city as 'City', state as 'State', country as 'Country' FROM publishers;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "publishers";
        }

        public static void TableRoyalties()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT title_id AS 'Title ID', lorange AS 'Lower Range', hirange AS 'Higher Range', royalty AS 'Royalty' FROM roysched;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "royalties";
        }

        public static void TableStores()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT stor_id AS 'Store ID', stor_name AS 'Store Name', stor_address AS 'Store Address', city AS 'City', state as 'State', zip AS 'State Zip Code' FROM stores;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);

            CurrentTable.tableKind = "stores";

        }

        public static void TableTitleAuthors()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT au_id AS 'Author ID', title_id AS 'Title ID', au_ord AS 'Author Orders', royaltyper AS 'Royalty Per Title' FROM titleauthor;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "titleAuthors";
        }

        public static void TableTitles()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT title_id AS 'Title ID', title AS 'Title', type AS 'Type', pub_id AS 'Publisher ID', price AS 'Price', advance AS 'Advance', royalty AS 'Royalty', ytd_sales AS 'To Date Sales', notes AS 'Notes', pubdate AS 'Publishing Date' FROM titles;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(CurrentTable.dtb);
            sda.Fill(CurrentTable.reserve);

            CurrentTable.tableKind = "titles";
        }

    }
}
