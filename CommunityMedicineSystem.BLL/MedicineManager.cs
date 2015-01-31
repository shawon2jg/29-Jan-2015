using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class MedicineManager
    {
        MedicineDBGateway aMedicineDBGateway = new MedicineDBGateway();
        CenterDBGateway aCenterGateway = new CenterDBGateway();

        public List<Medicine> GetAllMedicines()
        {
            return aMedicineDBGateway.GetAllMedicines();
        }

        public void SendMedicineToCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            MedicineStockInCenter medicineStockInCenter = aCenterGateway.FindInCenter(aMedicineStockInCenter);

            if (medicineStockInCenter == null)
            {
                aMedicineDBGateway.InsertInCenter(aMedicineStockInCenter);
            }
            else
            {
                aMedicineDBGateway.UpdateInCenter(aMedicineStockInCenter);
            }
        }

        public string SaveMedicine(Medicine aMedicine)
        {
            Medicine medicineFound = aMedicineDBGateway.FindMedicineName(aMedicine.Name);
            if (medicineFound == null)
            {
                aMedicineDBGateway.SaveMedicine(aMedicine);
                return "Medicine Successfully Saved...!!!";
            }
            else
            {
                return "This medicine already exist";
            }
        }
    }
}
