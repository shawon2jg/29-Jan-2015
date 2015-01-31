using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class CenterManager
    {
        CenterDBGateway aCenterDBGateway = new CenterDBGateway();

        public List<Center> GetSelectedCenters(int thanaId)
        {
            return aCenterDBGateway.GetSelectedCenters(thanaId);
        }
        public Center GetCenter(int id)
        {
            return aCenterDBGateway.GetCenter(id);
        }
        public string Save(Doctor aDoctor)
        {
            aCenterDBGateway.Save(aDoctor);
            return "Doctor Saved Successfully";
        }
        public List<ViewMedicineStockInCenter> GetMedicineStockInCenters(int centerId)
        {
            return aCenterDBGateway.GetMedicineStockInCenters(centerId);
        }
        public Center CheckCodePassword(Center aCenter)
        {
            return aCenterDBGateway.CheckCodePassword(aCenter);
        }
    }
}
