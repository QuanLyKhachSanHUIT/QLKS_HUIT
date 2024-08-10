using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongKe
    {
        public List<DoanhThu> LoadDanhThu(DateTime bd, DateTime kt)
        {

            List<DoanhThu> list = new List<DoanhThu>();

            try
            {
                using (SqlConnection connection = new SqlConnection(BLL_DAL.Properties.Settings.Default.QLKhachSanConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("EXEC dbo.ThongKeDoanhThu @StartDate, @EndDate", connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", bd);
                        command.Parameters.AddWithValue("@EndDate", kt);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DoanhThu statistics = new DoanhThu
                                {
                                    LoaiDoanhThu = Convert.ToString(reader["Phong"]),
                                    TongTien = Convert.ToInt32(reader["DoanhThu"]),
                                };

                                list.Add(statistics);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadDanhThu: {ex.Message}");
            }

            return list;
        }

        public int SoLuongPhong(DateTime bd, DateTime kt)
        {
            int count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(BLL_DAL.Properties.Settings.Default.QLKhachSanConnectionString))
                {
                    connection.Open();

                    string query = "EXEC dbo.SoLuongDatPhong @StartDate, @EndDate";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", bd);
                        command.Parameters.AddWithValue("@EndDate", kt);

                        object result = command.ExecuteScalar();
                        Console.WriteLine($"Raw Result: {result}");

                        if (result != null && result != DBNull.Value)
                        {
                            count = Convert.ToInt32(result);
                        }
                        else
                        {
                            Console.WriteLine("Result is null or DBNull.");
                            count = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                count = -1;
            }

            return count;
        }


        public (float DoanhThuPhong, float DoanhThuDichVu, float TongDoanhThu) ThongKeTongDoanhThu(DateTime bd, DateTime kt)
        {
            float doanhThuPhong = 0;
            float doanhThuDichVu = 0;
            float tongDoanhThu = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(BLL_DAL.Properties.Settings.Default.QLKhachSanConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("EXEC dbo.ThongKeDoanhThuTongHop @StartDate, @EndDate", connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", bd);
                        command.Parameters.AddWithValue("@EndDate", kt);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                doanhThuPhong = reader["DoanhThuPhong"] != DBNull.Value ? Convert.ToSingle(reader["DoanhThuPhong"]) : 0;
                                doanhThuDichVu = reader["DoanhThuDichVu"] != DBNull.Value ? Convert.ToSingle(reader["DoanhThuDichVu"]) : 0;
                                tongDoanhThu = reader["TongDoanhThu"] != DBNull.Value ? Convert.ToSingle(reader["TongDoanhThu"]) : 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return (doanhThuPhong, doanhThuDichVu, tongDoanhThu);
        }

        public ThongKe()
        {

        }
    }
}
