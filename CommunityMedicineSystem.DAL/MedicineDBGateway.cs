using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class MedicineDBGateway:CommonDBGateway
    {
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicineList = new List<Medicine>();
            string query = "SELECT * FROM tbl_medicine";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();

            while (ASqlDataReader.Read())
            {
                Medicine aMedicine = new Medicine();
                aMedicine.Id = (int)ASqlDataReader["id"];
                aMedicine.Name = ASqlDataReader["name"].ToString();
                aMedicine.Power = (float)ASqlDataReader["power"];
                aMedicine.Type = ASqlDataReader["type"].ToString();

                medicineList.Add(aMedicine);
            }

            ASqlDataReader.Close();
            ASqlCommand.Dispose();
            ASqlConnection.Close();
            return medicineList;
        }

        public void InsertInCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            string query = "INSERT INTO tbl_medicine_stock_center VALUES('" + aMedicineStockInCenter.CenterId + "', '" + aMedicineStockInCenter.MedicineId + "', '" + aMedicineStockInCenter.Quantity + "')";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);

            ASqlCommand.ExecuteNonQuery();
            ASqlCommand.Dispose();
            ASqlConnection.Close();
        }

        public void UpdateInCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            string query = "UPDATE tbl_medicine_stock_center VALUES SET quantity+='" + aMedicineStockInCenter.Quantity + "' WHERE id='" + aMedicineStockInCenter.Id + "'";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);

            ASqlCommand.ExecuteNonQuery();
            ASqlCommand.Dispose();
            ASqlConnection.Close();
        }

        public void SaveMedicine(Medicine aMedicine)
        {
            ASqlConnection.Open();
            string query = "INSERT INTO tbl_medicine VALUES('" + aMedicine.Name + "','" + aMedicine.Power + "','" + aMedicine.Type + "')";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlCommand.ExecuteNonQuery();
            ASqlConnection.Close();
        }

        public Medicine FindMedicineName(string name)
        {
            ASqlConnection.Open();
            string query = "SELECT * FROM tbl_medicine WHERE name = '" + name + "' ";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();

            if (ASqlDataReader.HasRows)
            {
                Medicine aMedicine = new Medicine();
                ASqlDataReader.Read();
                aMedicine.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aMedicine.Power = Convert.ToInt32(ASqlDataReader["power"]);
                aMedicine.Type = ASqlDataReader["type"].ToString();
                ASqlDataReader.Close();
                ASqlConnection.Close();
                return aMedicine;
            }
            else
            {
                ASqlConnection.Close();
                return null;
            }
        }
    }
}
