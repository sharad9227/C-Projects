using ClientApplication.ServiceReference3;
using RetailApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           

            ServiceReference3.Service1Client action1 = new ServiceReference3.Service1Client();
            ServiceReference4.Service1Client action2 = new ServiceReference4.Service1Client();
            String username,password,type;
            // Parameters for adding 
           

            int choice;
            //Menu for displaying
            void Login()
            {
                int id; string bookTitle; string bookAuthor; string publication; int year; string code; string bookKeyword;
                Console.WriteLine("*****************************************Login into Library Application**********************************************");
                Console.WriteLine("Please enter username");
                username = Console.ReadLine();
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
                Console.WriteLine("Enter the user type");
                type = Console.ReadLine();
                if (ValidatingRequest())
                {
                    if (type.Equals("Student") || type.Equals("Teacher"))
                    {

                        Console.WriteLine("Hello" + type);
                        Console.WriteLine("You can either borrow book or return book");
                        Console.WriteLine("Enter 1  to borrow book \n Enter 2 to return book");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            action2.BorrowBook(username);
                            Console.WriteLine("Book borrowed successfuly");
                        }
                        else if (choice == 2)
                        {
                            action2.ReturnBook(username);
                            Console.WriteLine("Book returned successfuly");
                        }
                        else
                            Console.WriteLine("Wrong choice entered . Please enter correct option");
                    }

                    else if (type.Equals("Librarian"))
                    {
                        Console.WriteLine("Enter 1  to add book \n Enter 2 to delete book \n Enter 3 to send email to users");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("enter userid : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter book title : ");
                             bookTitle = Console.ReadLine();
                            Console.WriteLine("enter bookauthor : ");
                            bookAuthor = Console.ReadLine();
                            Console.WriteLine("enter publication : ");
                            publication = Console.ReadLine();
                            Console.WriteLine("enter year : ");
                            year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter classification code : ");
                            code= (Console.ReadLine());
                            Console.WriteLine("enter keyword: ");
                            bookKeyword = (Console.ReadLine());
                            action2.AddBook(id, bookTitle, bookAuthor, publication, year, code, bookKeyword);
                            Console.WriteLine("Book added successfuly");
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("enter userid : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            action2.DeleteBook(id);
                            Console.WriteLine("Book deleted successfuly");
                        }
                        else if (choice == 3)
                        {
                            string id1;
                            bool flag;
                            Console.WriteLine("enter usermame of the user to send mail : ");
                            id1 = Console.ReadLine();
                            flag= action2.SendEmail(id1);
                            if (flag)
                            {
                                Console.WriteLine("Email sent successfully");
                            }
                            else
                            {
                                Console.WriteLine("Email not need to be sent");

                            }
                        }
                    }
                    Console.ReadKey();
                }

            }
            Login();

            bool ValidatingRequest()
            {
                bool flag;
                flag = action2.GetLoginStatus(username, password, type);
                if (flag)
                {
                    Console.WriteLine("Login Succesful");
                     Console.WriteLine("Welcome " + type);
                }
                else
                    Console.WriteLine("Login Failed.Credentials not valid");
                return flag;

            }





              
            }
          
    }
}
