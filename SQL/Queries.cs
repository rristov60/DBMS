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

            cmd.CommandText = @"SELECT stor_id AS 'Store ID (stor_id)', ord_num AS 'Order Number (ord_num)', ord_date as 'Order Date (ord_date)', qty as 'Quantity (qty)', payterms as 'Pay Terms (payterms)', title_id AS 'Title ID (title_id)' FROM sales;";
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

            cmd.CommandText = @"SELECT au_id AS 'Author ID (au_id)', au_lname AS 'Last Name (au_lname)', au_fname as 'First Name (au_fname)', phone as 'Phone Number (phone)', address as 'Address (address)', city AS 'City (city)', state AS 'State (state)', zip AS 'Zip Code (zip)', contract AS 'Contracted (contract)' FROM authors;";
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

            cmd.CommandText = @"SELECT discounttype AS 'Discount Type (discounttype)', stor_id AS 'Store ID (stor_id)', lowqty as 'Low Quantity (lowqty)', highqty as 'High Quantity (highqty)', discount as 'Discount (discount)' FROM discounts;";
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

            cmd.CommandText = @"SELECT emp_id AS 'Employee ID (emp_id)', fname AS 'First Name (fname)', lname AS 'Last Name (lname)', job_id AS 'Job ID (job_id)', job_lvl AS 'Job Level (job_lvl)', pub_id AS 'Publisher ID (pub_id)', hire_date AS 'Hire Date (hire_date)' FROM employee;";
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

            cmd.CommandText = @"SELECT job_id AS 'Job ID (job_id)', job_desc AS 'Job Description (job_desc)', min_lvl AS 'Minimum Level (min_lvl)', max_lvl AS 'Maximum Level (max_lvl)' FROM jobs;";
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

            cmd.CommandText = @"SELECT pub_id AS 'Publisher ID (pub_id)', pub_name AS 'Publisher Name (pub_name)', city as 'City (city)', state as 'State (state)', country as 'Country (country)' FROM publishers;";
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

            cmd.CommandText = @"SELECT title_id AS 'Title ID (title_id)', lorange AS 'Lower Range (lorange)', hirange AS 'Higher Range (hirange)', royalty AS 'Royalty (royalty)' FROM roysched;";
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

            cmd.CommandText = @"SELECT stor_id AS 'Store ID (stor_id)', stor_name AS 'Store Name (stor_name)', stor_address AS 'Store Address (stor_address)', city AS 'City (city)', state as 'State (state)', zip AS 'State Zip Code (zip)' FROM stores;";
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

            cmd.CommandText = @"SELECT au_id AS 'Author ID (au_id)', title_id AS 'Title ID (title_id)', au_ord AS 'Author Orders (au_ord)', royaltyper AS 'Royalty Per Title (royaltyper)' FROM titleauthor;";
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

            cmd.CommandText = @"SELECT title_id AS 'Title ID (title_id)', title AS 'Title (title)', type AS 'Type (type)', pub_id AS 'Publisher ID (pub_id)', price AS 'Price (price)', advance AS 'Advance (advance)', royalty AS 'Royalty (royalty)', ytd_sales AS 'To Date Sales (ytd_sales)', notes AS 'Notes (notes)', pubdate AS 'Publishing Date (pubdate)' FROM titles;";
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

        public static void GetUsers(DataTable users)
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT * FROM DBMSusers;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                CurrentTable.Sucess = false;
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);

            sda.Fill(users);
        }

        public static bool DeleteUser(string username)
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM DBMSusers WHERE Username = '" + username.Trim() + "'";
                conn.Open();
                int i = (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }

        public static bool CreateUser(string firstName, string lastName, string username, string password, string privileges)
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"INSERT INTO DBMSusers
                                VALUES (@Username, @Passwd, @FirstName, @LastName, @Privilege)";

            cmd.Parameters.AddWithValue("@Username", username.Trim());
            cmd.Parameters.AddWithValue("@Passwd", Hashing.PasswordHashing(password.Trim()));
            cmd.Parameters.AddWithValue("@FirstName", firstName.Trim());
            cmd.Parameters.AddWithValue("@LastName", lastName.Trim());
            cmd.Parameters.AddWithValue("@Privilege", privileges.Trim());

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            int sucess = (int)cmd.ExecuteNonQuery();
       
            if (sucess != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SalesFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT stor_id AS 'Store ID (stor_id)', ord_num AS 'Order Number (ord_num)', ord_date as 'Order Date (ord_date)', qty as 'Quantity (qty)', payterms as 'Pay Terms (payterms)', title_id AS 'Title ID (title_id)' FROM sales WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }catch(Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredSales";

            }catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool AuthorsFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT au_id AS 'Author ID (au_id)', au_lname AS 'Last Name (au_lname)', au_fname as 'First Name (au_fname)', phone as 'Phone Number (phone)', address as 'Address (address)', city AS 'City (city)', state AS 'State (state)', zip AS 'Zip Code (zip)', contract AS 'Contracted (contract)' FROM authors WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredAuthors";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool DiscountsFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT discounttype AS 'Discount Type (discounttype)', stor_id AS 'Store ID (stor_id)', lowqty as 'Low Quantity (lowqty)', highqty as 'High Quantity (highqty)', discount as 'Discount (discount)' FROM discounts WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredDiscounts";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool EmployeeFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT emp_id AS 'Employee ID (emp_id)', fname AS 'First Name (fname)', lname AS 'Last Name (lname)', job_id AS 'Job ID (job_id)', job_lvl AS 'Job Level (job_lvl)', pub_id AS 'Publisher ID (pub_id)', hire_date AS 'Hire Date (hire_date)' FROM employee WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredEmployee";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool JobsFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT job_id AS 'Job ID (job_id)', job_desc AS 'Job Description (job_desc)', min_lvl AS 'Minimum Level (min_lvl)', max_lvl AS 'Maximum Level (max_lvl)' FROM jobs WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredJobs";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool PublishersFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT pub_id AS 'Publisher ID (pub_id)', pub_name AS 'Publisher Name (pub_name)', city as 'City (city)', state as 'State (state)', country as 'Country (country)' FROM publishers WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredPublishers";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool RoyaltiesFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT title_id AS 'Title ID (title_id)', lorange AS 'Lower Range (lorange)', hirange AS 'Higher Range (hirange)', royalty AS 'Royalty (royalty)' FROM roysched WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredRoyalties";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool StoresFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT stor_id AS 'Store ID (stor_id)', stor_name AS 'Store Name (stor_name)', stor_address AS 'Store Address (stor_address)', city AS 'City (city)', state as 'State (state)', zip AS 'State Zip Code (zip)' FROM stores WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredStores";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool TitleAuthorsFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT au_id AS 'Author ID (au_id)', title_id AS 'Title ID (title_id)', au_ord AS 'Author Orders (au_ord)', royaltyper AS 'Royalty Per Title (royaltyper)' FROM titleauthor WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredTitleAuthors";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool TitlesFilter(string filter, string andOr)
        {
            string[] filters = filter.Split('\n');
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            string theFilter = "SELECT title_id AS 'Title ID (title_id)', title AS 'Title (title)', type AS 'Type (type)', pub_id AS 'Publisher ID (pub_id)', price AS 'Price (price)', advance AS 'Advance (advance)', royalty AS 'Royalty (royalty)', ytd_sales AS 'To Date Sales (ytd_sales)', notes AS 'Notes (notes)', pubdate AS 'Publishing Date (pubdate)' FROM titles WHERE";
            int i = 0;
            try
            {
                foreach (string column in filters)
                {
                    string[] columns;
                    columns = column.Split('=');


                    if (filters.Length == 1 || i == 0)
                        theFilter += " " + columns[0] + "='" + columns[1].Trim() + "'";
                    else
                    {
                        theFilter += " " + andOr + " " + columns[0] + "='" + columns[1].Trim() + "'";
                    }

                    i++;
                }

                theFilter += ";";



            }
            catch (Exception ex)
            {
                return false;
            }


            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = theFilter;
                SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connectionString);
                CurrentTable.dtb = new DataTable();
                sda.Fill(CurrentTable.dtb);
                sda.Fill(CurrentTable.reserve);

                CurrentTable.tableKind = "FilteredTitles";

            }
            catch (Exception ex)
            {
                return false;
            }


            return true;

        }

        public static bool SaveChanges()
        {
            string connectionString = "Server=tcp:memorygame.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=riste;Password=Ristov123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);

            
            try
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM " + CurrentTable.tableKind;
                cmd.ExecuteNonQuery();
                SqlBulkCopy bulkInsert = new SqlBulkCopy(connectionString);
                bulkInsert.DestinationTableName = CurrentTable.tableKind;
                bulkInsert.WriteToServer(CurrentTable.dtb);
            }catch(Exception ex)
            {
                return false;
            }

            
            return true;

        }

    }
}
