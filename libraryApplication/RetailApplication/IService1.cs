using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RetailApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        //Added method declaration here for the methods defined in service class


        [OperationContract]
        List<Books> GetBookByTitle(String value);
        [OperationContract]
        List<Books> GetBookByAuthor(String value);
        [OperationContract]
        List<Books> GetBookByKeyword(String value);
        [OperationContract]
        bool AddBook(int id, string bookTitle, string bookAuthor, string publication, int year, string code, string bookKeyword);
        [OperationContract]
        bool DeleteBook(int id);
        [OperationContract]
        bool GetLoginStatus(String username, String password, String userType);
        [OperationContract]
         bool BorrowBook(String username);
        [OperationContract]
        bool ReturnBook(String username);
        [OperationContract]
        bool SendEmail(String username);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.


    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    /*Created  class Login  */
    [DataContract]
    public class Login
    {
        [DataMember]
        private String userId;
        [DataMember]
        private String password;
        [DataMember]
        private String userType;

        public string UserType { get => userType; set => userType = value; }
        public string Password { get => password; set => password = value; }
      
        public string UserId { get => userId; set => userId = value; }


        //constructor
        public Login()
        {
        }
        public override string ToString()
        {
            return "User Id:" + UserId + "User Type:" + UserType + "Password:" + Password;
        }

    }

    [DataContract]
    public class Books
    {
        [DataMember]
        private int book_id;
        [DataMember]
        private string title;
        [DataMember]
        private string author;
        [DataMember]
        private string press;
        [DataMember]
        private int pub_year;
        [DataMember]
        private string classification_code;
        [DataMember]
        private string keyword;

        public Books()
        {
        }

        public Books(int book_id, string title, string author, string press, int pub_year, string classification_code, string keyword)
        {
            this.Book_id = book_id;
            this.Title = title;
            this.Author = author;
            this.Press = press;
            this.Pub_year = pub_year;
            this.Classification_code = classification_code;
            this.Keyword = keyword;
        }

        public int Book_id { get => book_id; set => book_id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Press { get => press; set => press = value; }
        public int Pub_year { get => pub_year; set => pub_year = value; }
        public string Classification_code { get => classification_code; set => classification_code = value; }
        public string Keyword { get => keyword; set => keyword = value; }

        public override string ToString()
        {
            return "Book Id:" + book_id + "Title:" + title + "Author:" + author + "Publication:" + press + "Publication Year:" + pub_year + "Classification code" + classification_code + "Keyword:" + keyword;
        }
    }



    [DataContract]
    public class Library
    {
        [DataMember]
        private int lib_book_id;
        [DataMember]
        private string title;
        [DataMember]
        private int total_book_count;
        [DataMember]
        private int lib_user_id;
        [DataMember]
        private string lib_user_type;
        [DataMember]
        private int libuser_book_count;

        public Library()
        {
        }

        public Library(int lib_book_id, string title, int total_book_count, int lib_user_id, string lib_user_type, int libuser_book_count)
        {
            this.Lib_book_id = lib_book_id;
            this.Title = title;
            this.Total_book_count = total_book_count;
            this.Lib_user_id = lib_user_id;
            this.Lib_user_type = lib_user_type;
            this.Libuser_book_count = libuser_book_count;
        }

        public int Lib_book_id { get => lib_book_id; set => lib_book_id = value; }
        public string Title { get => title; set => title = value; }
        public int Total_book_count { get => total_book_count; set => total_book_count = value; }
        public int Lib_user_id { get => lib_user_id; set => lib_user_id = value; }
        public string Lib_user_type { get => lib_user_type; set => lib_user_type = value; }
        public int Libuser_book_count { get => libuser_book_count; set => libuser_book_count = value; }

        public override string ToString()
        {
            return "Id of Book kept in library" + lib_book_id + "Title of book" + title + "Total book count" + total_book_count + "User id" + lib_user_id + "Library user type" + Lib_user_type + "Library user book count" + libuser_book_count; ;
        }
    }
}