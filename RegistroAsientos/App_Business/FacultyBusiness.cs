using FacilityManagement.App_Domain;
using RegistroAsientos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAsientos.App_Business
{
    public class FacultyBusiness
    {
        FacultyData facultyData;
        public FacultyBusiness(){
            facultyData = new FacultyData();
        }
        public void Insert(Faculty faculty)
        {

            facultyData.Insert(faculty);
        }
        public IEnumerable<Faculty> Select()
        {

            return facultyData.Select();
        }
        public void Delete(int Id) {
            facultyData.Delete(Id);
        }
        public void Update(Faculty faculty)
        {
            facultyData.Update(faculty);
        }
            
    }
}