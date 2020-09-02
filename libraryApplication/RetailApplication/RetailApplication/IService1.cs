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
        String GetCommodityByTypeNo(int value);
        [OperationContract]
        String GetCommodityByTypeFeature(int Type, String features);
        [OperationContract]
        bool AddCommodity(Commodity commodity);
        [OperationContract]
        List<Laptop> getAllLaptops();
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
    /*Created parent class Commodity */
    [DataContract]
    public class Commodity
    {
        [DataMember]
        private int idNum;
        [DataMember]
        private String typeReference;
        [DataMember]
        private String name;
        [DataMember]
        private String type;
        [DataMember]
        private int price;
        [DataMember]
        private String brand;
        [DataMember]
        private int size;
        [DataMember]
        private int stock;
        //Encapsulaton using getters and setters
        public int IdNum { get => idNum; set => idNum = value; }
        public string TypeReference { get => typeReference; set => typeReference = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Size { get => size; set => size = value; }
        public int Stock { get => stock; set => stock = value; }

       
        //constructor
        public Commodity()
        {
        }
        //set method for setting commodity attributes
        public void setBasicInformation(int id, string name, string type, int price, string brand, int size, int stock)
        {
            this.IdNum = id;
            this.Name = name;
            this.Type = type;
            this.Price = price;
            this.Brand = brand;
            this.Size = size;
            this.Stock = stock;

        }
        // this method is for generating string and inserting the same into database
        public String AddCommodityInformation()
        {
             return  IdNum +" " +Name+" "+ Type + " "  +Price + " " +  Brand + " "+Size +" "+ Stock;
        }

        //getter method for getting basic information mentioned 
        public virtual String getBasicInformation()
        {
            return "ID:" + IdNum + "\tName:" + Name + "\tType" + Type + "\tPrice" + Price + "\tBrand" + Brand + "\tSize" + Size + "\tStock" + Stock;
        }

        //overriding tostring method
        public override string ToString()
        {
            return "ID:" + IdNum + "\tName:" + Name + "\tType" + Type + "\tPrice" + Price + "\tBrand" + Brand + "\tSize" + Size + "\tStock" + Stock;
        }
    }




    // Derived class laptop extending commodity class
    [DataContract]
    public class Laptop : Commodity
    {
        //additional feature CPU added for Laptop class
        [DataMember]
        private String CPU;
        
        
        //Encapsulation implemented for additional feature

        public string CPU1 { get => CPU; set => CPU = value; }
        //Default constructor
        public Laptop()
        {
        }
        //Setting laptop information 
        public void setLaptopInformation(int id, string name, string type, int price, string brand, int size, int stock, string CPU)
        {
            this.CPU1 = CPU;
        }
        //overiding basicinformation implementing polymorphism OOPS concept
        public override String getBasicInformation()
        {
          return base.getBasicInformation() + " " + CPU1.ToString();
        }
        //overiding tostring implementing polymorphism OOPS concept
        public override string ToString()
        {
           return base.ToString() + " " + CPU1.ToString();
        }
    }

    [DataContract]
    public class Wine : Commodity
    {
        //additional feature alcohol_content added for Wine class
        [DataMember]
        private String alcohol_content;

        //Setting wine information
        public void setWineInformation(String alcohol_content)
        {
            this.alcohol_content = alcohol_content;
        }
        //overiding basicinformation implementing polymorphism OOPS concept
        public override String getBasicInformation()
        {
            return base.getBasicInformation() + "" + alcohol_content.ToString();
        }
        //overiding tostring implementing polymorphism OOPS concept
        public override string ToString()
        {
            return base.ToString() + " " + alcohol_content.ToString();
        }
    }

}





