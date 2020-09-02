using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RetailApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        static MySqlConnection GetConnection()
        {
            //this static method will return a connection constructed by connection string
            string myConnectionString = "Database=src31;DataSource = mysql.mcscw3.le.ac.uk; User Id = src31; Password =io6juThe";
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            return connection;
        }


        /*This method is getting book by title*/
        public List<Books> GetBookByTitle(String title)
        {
            List<Books> book = new List<Books>();
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                //Initially we are searching by feature and then filtering by type_no
                MySqlCommand mycm = new MySqlCommand("Select * from book where title=?title", connection);
                mycm.Parameters.AddWithValue("?title", title);
                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        Books b = new Books();
                        b.Book_id = msdr.GetInt32("book_id");
                        b.Title = msdr.GetString("title");
                        b.Author = msdr.GetString("author");
                        b.Press = msdr.GetString("press");
                        b.Pub_year = msdr.GetInt32("pub_year");
                        b.Classification_code = msdr.GetString("classification_code");
                        b.Keyword = msdr.GetString("keyword");

                        book.Add(b);
                    }

                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return book;
        }

        /*This method is getting book by author*/

        public List<Books> GetBookByAuthor(String Author)
        {
            List<Books> book = new List<Books>();
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                //Initially we are searching by feature and then filtering by type_no
                MySqlCommand mycm = new MySqlCommand("Select * from book where author=?Author", connection);
                mycm.Parameters.AddWithValue("?author", Author);
                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        Books b = new Books();
                        b.Book_id = msdr.GetInt32("book_id");
                        b.Title = msdr.GetString("title");
                        b.Author = msdr.GetString("author");
                        b.Press = msdr.GetString("press");
                        b.Pub_year = msdr.GetInt32("pub_year");
                        b.Classification_code = msdr.GetString("classification_code");
                        b.Keyword = msdr.GetString("keyword");

                        book.Add(b);
                    }

                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return book;
        }



        /*This method is getting book by keyword*/

        public List<Books> GetBookByKeyword(String keyword)
        {
            List<Books> book = new List<Books>();
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                //Initially we are searching by feature and then filtering by type_no
                MySqlCommand mycm = new MySqlCommand("Select * from book where author=?Author", connection);
                mycm.Parameters.AddWithValue("?keyword", keyword);
                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        Books b = new Books();
                        b.Book_id = msdr.GetInt32("book_id");
                        b.Title = msdr.GetString("title");
                        b.Author = msdr.GetString("author");
                        b.Press = msdr.GetString("press");
                        b.Pub_year = msdr.GetInt32("pub_year");
                        b.Classification_code = msdr.GetString("classification_code");
                        b.Keyword = msdr.GetString("keyword");

                        book.Add(b);
                    }

                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return book;
        }


        //add book

        public bool AddBook(int id, string bookTitle, string bookAuthor, string publication, int year, string code, string bookKeyword)
        {
            bool flag = false;
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                MySqlCommand mycm = new MySqlCommand("", connection);
                mycm.Prepare();
                mycm.CommandText = String.Format("insert into book (book_id, title, author, press, pub_year, classification_code, keyword) values (?id, ?bookTitle, ?bookAuthor, ?publication, ?year, ?code, ?bookKeyword)", connection);
                mycm.Parameters.AddWithValue("?id", id);
                mycm.Parameters.AddWithValue("?bookTitle", bookTitle);
                mycm.Parameters.AddWithValue("?bookAuthor", bookAuthor);
                mycm.Parameters.AddWithValue("?publication", publication);
                mycm.Parameters.AddWithValue("?year", year);
                mycm.Parameters.AddWithValue("?code", code);
                mycm.Parameters.AddWithValue("?bookKeyword", bookKeyword);
                mycm.ExecuteNonQuery();
                connection.Close();
                flag = true;
                return flag;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return flag;
            }
        }
        //delete books
        public bool DeleteBook(int id)
        {
            bool flag = false;
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                MySqlCommand mycm = new MySqlCommand("", connection);
                mycm.Prepare();
                mycm.CommandText = String.Format("delete from book where book_id=?id");
                mycm.Parameters.AddWithValue("?id", id);
                mycm.ExecuteNonQuery();
                connection.Close();
                flag = true;
                return flag;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return flag;
            }
        }

        //checking login functionality


        public bool GetLoginStatus(String username, String password, String userType)
        {
            bool flag = false;
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                //Initially we are searching by feature and then filtering by type_no
                MySqlCommand mycm = new MySqlCommand("Select * from Login where userid=?username && usertype=?userType", connection);
                mycm.Parameters.AddWithValue("?username", username);
                mycm.Parameters.AddWithValue("?userType", userType);
                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        Login l = new Login();
                        if (password.Equals(msdr.GetString("password")))
                            flag = true;
                        else
                            flag = false;
                    }

                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return flag;
        }


        //borrow books

        public bool BorrowBook(String username)
        {
            bool flag = false;
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                //Initially we are searching by feature and then filtering by type_no
                MySqlCommand mycm = new MySqlCommand("Select * from user where user_id=?username", connection);
                mycm.Parameters.AddWithValue("?username", username);

                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        Login l = new Login();
                        if (username.Equals(msdr.GetString("user_id")) && msdr.GetInt16("book_count") < 5 && msdr.GetString("user_type").Equals("Student"))
                        {

                            MySqlCommand mycm1 = new MySqlCommand("update user SET book_count=book_count+1 where user_id=?username", connection);
                            mycm1.Parameters.AddWithValue("?username", username);
                            flag = true;
                        }
                        else if (username.Equals(msdr.GetString("user_id")) && msdr.GetInt16("book_count") < 10 && msdr.GetString("user_type").Equals("Teacher"))

                        {

                            MySqlCommand mycm1 = new MySqlCommand("update user SET book_count=book_count+1 where user_id=?username", connection);
                            mycm1.Parameters.AddWithValue("?username", username);
                            flag = true;

                        }
                        else
                            flag = false;
                    }

                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return flag;
        }





        //return books
        public bool ReturnBook(String username)
        {
            bool flag = false;
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                //Initially we are searching by feature and then filtering by type_no
                MySqlCommand mycm = new MySqlCommand("Select * from user where userid=?username", connection);
                mycm.Parameters.AddWithValue("?username", username);

                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        Login l = new Login();
                        if (username.Equals(msdr.GetString("user_id")))
                        {

                            MySqlCommand mycm1 = new MySqlCommand("update user SET book_count=book_count-1 where userid=?username", connection);
                            flag = true;
                        }

                        else
                            flag = false;
                    }

                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return flag;
        }


        //assuming return date is 30 days from borrowed date for Teacher and 15 days for student 

        public bool SendEmail(String username)

        {
            bool flag = false;
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                //Initially we are searching by feature and then filtering by type_no
                MySqlCommand mycm = new MySqlCommand("Select * from user where user_id=?username", connection);
                mycm.Parameters.AddWithValue("?username", username);

                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        String usertype = msdr.GetString("user_type");
                        if (username.Equals(msdr.GetString("user_id")) && usertype.Equals("Student"))
                        {
                          
                            DateTime date1 = new DateTime();
                            DateTime returndate = new DateTime();
                            date1 = msdr.GetDateTime("borrowed_date").AddDays(6);
                            returndate = msdr.GetDateTime("borrowed_date").AddDays(15);
                            System.TimeSpan diffResult = returndate-date1;
                            if (diffResult.Days < 10)
                            {
                                Console.WriteLine("email is sent as deadline is near.");
                                flag = true;
                            }
                        }
                       else if (username.Equals(msdr.GetString("user_id")) && usertype.Equals("Teacher"))
                        {
  
                            DateTime date1 = new DateTime();
                            DateTime returndate = new DateTime();
                            date1 = msdr.GetDateTime("borrowed_date").AddDays(21);
                            returndate = msdr.GetDateTime("borrowed_date").AddDays(30);
                            System.TimeSpan diffResult = returndate - date1;
                            if (diffResult.Days < 10)
                            {
                                flag = true;
                                Console.WriteLine("email is sent as deadline is near.");
                            }   
                        }
                        else
                            flag = false;
                    }

                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return flag;

        }
    }



    }









    


    

