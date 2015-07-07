using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacilityManagement.App_Domain
{
    public class Faculty
    {

        private int id;
        private string name;
        public Faculty() { 
        
        }
        public Faculty(string name)
        {
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}