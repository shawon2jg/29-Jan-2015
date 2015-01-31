using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class CenterDBGateway:CommonDBGateway
    {
        public List<Center> GetSelectedCenters(int thanaId)
        {
            List<Center> centerList = new List<Center>();
            string query = "SELECT * FROM tbl_thana WHERE thana_id='" + thanaId + "'";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();
            Center aCenter;

            while (ASqlDataReader.Read())
            {
                aCenter = new Center();
                aCenter.Id = (int)ASqlDataReader["id"];
                aCenter.Name = ASqlDataReader["name"].ToString();
                aCenter.DistrictId = (int)ASqlDataReader["district_id"];
                aCenter.ThanaId = (int)ASqlDataReader["thana_Id"];

                centerList.Add(aCenter);
            }

            ASqlDataReader.Close();
            ASqlCommand.Dispose();
            ASqlConnection.Close();

            return centerList;
        }
        public Center GetCenter(int id)
        {
            ASqlConnection.Open();
            string query = "SELECT * FROM tbl_center where id = '" + id + "'";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();

            if (ASqlDataReader.HasRows)
            {
                Center aCenter = new Center();
                ASqlDataReader.Read();
                aCenter.Id = Convert.ToInt32(ASqlDataReader["id"]);
                aCenter.Name = ASqlDataReader["name"].ToString();
                aCenter.DistrictId = Convert.ToInt32(ASqlDataReader["district_id"]);
                aCenter.ThanaId = Convert.ToInt32(ASqlDataReader["thana_id"]);
                ASqlDataReader.Close();
                ASqlConnection.Close();
                return aCenter;
            }
            else
            {
                ASqlConnection.Close();
                return null;
            }
        }
        public List<ViewMedicineStockInCenter> GetMedicineStockInCenters(int centerId)
        {
            List<ViewMedicineStockInCenter> stockMedicineList = new List<ViewMedicineStockInCenter>();
            string query = "SELECT * FROM v_medicine_stock_report WHERE center_id='" + centerId + "'";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();
            

            while (ASqlDataReader.Read())
            {
                ViewMedicineStockInCenter aStockInCenter = new ViewMedicineStockInCenter();
                aStockInCenter.CenterId = (int)ASqlDataReader["center_id"];
                aStockInCenter.Name = ASqlDataReader["name"].ToString();
                aStockInCenter.Quantity = (int)ASqlDataReader["quantity"];


                stockMedicineList.Add(aStockInCenter);
            }

            ASqlDataReader.Close();
            ASqlCommand.Dispose();
            ASqlConnection.Close();

            return stockMedicineList;
        }
        public void Save(Doctor aDoctor)
        {
            ASqlConnection.Open();
            string query = "INSERT INTO tbl_doctor VALUES('" + aDoctor.Name + "','" + aDoctor.Degree + "','" + aDoctor.Specialization + "','" + aDoctor.CenterId + "') ";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlCommand.ExecuteNonQuery();
            ASqlConnection.Close();
        }
        public MedicineStockInCenter FindInCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            string query = "SELECT * FROM tbl_medicine_stock_center WHERE medicine_id = '" + aMedicineStockInCenter.MedicineId + "' AND center_id='" + aMedicineStockInCenter.CenterId + "'";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();

            MedicineStockInCenter medicineStockInCenter;

            if (ASqlDataReader.HasRows)
            {
                medicineStockInCenter = new MedicineStockInCenter();
                medicineStockInCenter.Id = (int)ASqlDataReader["id"];
                medicineStockInCenter.CenterId = (int)ASqlDataReader["center_id"];
                medicineStockInCenter.MedicineId = (int)ASqlDataReader["medicine_id"];
                medicineStockInCenter.Quantity = (int)ASqlDataReader["quantity"];

                ASqlDataReader.Close();
                ASqlCommand.Dispose();
                ASqlConnection.Close();
                return medicineStockInCenter;
            }
            else
            {
                ASqlDataReader.Close();
                ASqlCommand.Dispose();
                ASqlConnection.Close();
                return null;
            }
        }

        public Center CheckCodePassword(Center aCenterLogin)
        {
            string query = "SELECT * FROM tbl_center_login WHERE center_code = '" + aCenterLogin.Code + "' AND password='" + aCenterLogin.Password + "'";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();



            if (ASqlDataReader.HasRows)
            {
                Center bCenter = new Center();
                ASqlDataReader.Read();
                bCenter.Id = (int)ASqlDataReader["id"];
                bCenter.CenterId = (int)ASqlDataReader["center_id"];
                bCenter.Code = ASqlDataReader["center_code"].ToString();
                bCenter.Password = ASqlDataReader["password"].ToString();


                ASqlDataReader.Close();
                ASqlConnection.Close();
                return bCenter;
            }
            else
            {
                ASqlDataReader.Close();
                ASqlConnection.Close();
                return null;
            }
        }
    }
}
