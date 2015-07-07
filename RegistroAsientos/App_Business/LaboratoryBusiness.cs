using FacilityManagement.App_Domain;
using RegistroAsientos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroAsientos.App_Business
{
    public class LaboratoryBusiness
    {
        LaboratoryData laboratoryData;
        public LaboratoryBusiness(){
            laboratoryData = new LaboratoryData();
        }
        public void Insert(Laboratory laboratory)
        {

            laboratoryData.Insert(laboratory);
        }
        public IEnumerable<Laboratory> Select()
        {

            return laboratoryData.Select();
        }
        public void Delete(int Id) {
            laboratoryData.Delete(Id);
        }
        public void Update(Laboratory laboratory)
        {
            laboratoryData.Update(laboratory);
        }
    }
}