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

        /* Call from getcommodityfromtypefeature : */
        public String GetCommodityByTypeNo(int id)
        {
            //creating commodity object
            Commodity commodity = new Commodity();

            try
            {
                //Open connection
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                MySqlCommand mycm = new MySqlCommand("Select type_name from Types where TYPE_NO=?type_no", connection);
                mycm.Parameters.AddWithValue("?type_no", id);
                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        //read type name corresponding to typeref  and assign value to corresponding property of commodity table
                        commodity.Name = msdr.GetString("type_name");
                    
                    }
                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return commodity.Name;
        }
        /*This method is getting commodity by type and feature */
        public String GetCommodityByTypeFeature(int Type, String features)
        {
            Commodity commodity = new Commodity();
        try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                //Initially we are searching by feature and then filtering by type_no
                MySqlCommand mycm = new MySqlCommand("Select TYPE_NO from Feature where FEATURE_NO=?feature_no", connection);
                mycm.Parameters.AddWithValue("?feature_no", features);
                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        int type;

                        type = msdr.GetInt32("TYPE_NO");
                        if (type == Type)
                        {
                            commodity.TypeReference = GetCommodityByTypeNo(type);

                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            return commodity.TypeReference;
        }


        //This method is for adding commodity as per input by user .
        public bool AddCommodity(Commodity commodity)
        {

           
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand mycm = new MySqlCommand("", connection);
            mycm.Prepare();
            //insert query 
            mycm.CommandText = String.Format("insert into Commodities(type_no,information) values (?type_no,?information)");


            mycm.Parameters.AddWithValue("?type_no", commodity.Type);
            //setting values for testing by WCF client with String commodity information and basic information 
            commodity.setBasicInformation(commodity.IdNum,commodity.Name,commodity.Type,commodity.Price,commodity.Brand,commodity.Size,commodity.Stock);

           
            mycm.Parameters.AddWithValue("?information", commodity.AddCommodityInformation());

            mycm.ExecuteNonQuery(); 
            connection.Close();
            return true;
        }

        public List<Laptop> getAllLaptops()
        {
            //a list of employees
            List<Laptop> laptops = new List<Laptop>();
            try
            {
                //Open connection
                MySqlConnection connection = GetConnection();
                connection.Open();
                // SQL query assignment
                MySqlCommand mycm = new MySqlCommand("select * from Commodities", connection);
                //execute query
                MySqlDataReader msdr = mycm.ExecuteReader();

                while (msdr.Read())
                {
                    if (msdr.HasRows)
                    {
                        Laptop lap = new Laptop();
                        String lap_info;
                       // fetching type no and checking if it is equal to laptop type no in type table
                        lap.IdNum = msdr.GetInt32("TYPE_NO");
                        if (lap.IdNum == 100001)
                        {
                        // Getting the laptop information string 
                            lap_info = msdr.GetString("INFORMATION");
                            string[] values = lap_info.Split(' ');
                           //Iterating the values, splitting them in respective laptop attributes and adding them to laptop list
                            foreach (String word in values)
                            {

                                Console.WriteLine("Feature is " + word);

                                Console.WriteLine(word.Substring(0, 3));
                                
                                if (word.Substring(0,3).Equals("c02"))
                                {
                                    lap.Name = word;
                                    Console.WriteLine(word);
                                    Console.WriteLine(lap.Name);

                                }
                                if (word.Substring(0,3).Equals("c05"))
                                {
                                    lap.Brand = word;
                                    Console.WriteLine(lap.Brand);
                                }
                                if (word.Substring(0,3).Equals("c03"))
                                {
                                    lap.CPU1 = word;
                                    Console.WriteLine(lap.Brand);
                                }


                            }

                        }

                        else
                        {
                            continue;
                        }
                        //add the laptops to the list of laptops

                        laptops.Add(lap);

                    }
                }
                msdr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //return laptops list
            return laptops;
        }
    }

   
}









    


    

