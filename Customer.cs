using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GetSet
{
    internal class Customer
    {/*
        int id;
        string name;
        DateTime mEndDate;
        string comment;*/
        /*public Customer()
        {
            Console.WriteLine("Customer Constructor");
            id = -1;
            name = "not given";
            mEndDate = DateTime.Now;
        }
        public int Id{get{ return id; } set{ id = value;} }
        public string Name { get { return name; } set { name = value; } }
        public DateTime MEndDate { get { return mEndDate; } set { mEndDate = value; } }*/
        //public Customer(int id,string name,DateTime mEndDate)
        //{
        //    Console.WriteLine("Customer Constructor");
        //    this.id = id;
        //    this.name = name;
        //    this.mEndDate = mEndDate;
        //}
        //public int Id { get { return id; } }
        //public string Name { get { return name; } }
        //public DateTime MEndDate { get { return mEndDate; } }
        /*public Customer(int id, string name, DateTime mEndDate)
        {
            Console.WriteLine("Customer Constructor");
            this.id = id;
            this.name = name;
            this.mEndDate = mEndDate;
        }
        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public DateTime MEndDate { get { return mEndDate; } }
        public string Comment { set { comment = value; } }
        public void ReadComment(string passCode)
        {
            if(passCode=="admin@123")
                Console.WriteLine("Comment is : "+comment);
        }*//*
        private int id;
        public int Id
        {
            get { return id; }
            set { if (value >= 1) { id = value; } else { id = -1; } }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { if (value.Length >= 6) { name = value; } else { name = "Invalid"; } }
        }*//*
        private static double tax;
        public static double Tax { get { return tax; } set { tax = value; } }
        private int id;
        public int Id { get { return id; } set { if (value >= 1) { id = value; } else { id = -1; } } }

        private string name;
        public string Name { get { return name; } set { if (value.Length >= 6) { name = value; } else { name = "Invalid"; } } }*/
        int id;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get; set; }
        public string City { get; set; }
        public double ODLimit { get; set; }
    }
}
