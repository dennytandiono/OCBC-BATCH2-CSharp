using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Kantor_WebAPI.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> AddEmployee(EmployeeItem data)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO employee(nama, jenis_kelamin, alamat) VALUES(@nama, @jenisKelamin, @alamat)", conn);
                
                    cmd.Parameters.AddWithValue("@nama", data.nama);
                    cmd.Parameters.AddWithValue("@jenisKelamin", data.jenisKelamin);
                    cmd.Parameters.AddWithValue("@alamat", data.alamat);

                    cmd.ExecuteNonQuery();
                    var Id = cmd.LastInsertedId;
                    conn.Close();
                    return GetEmployee(Id.ToString());
            } 
        }


        public List<EmployeeItem> UpdateEmployee(string id,EmployeeItem data)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE employee SET nama='{data.nama}', " +
                                                        $"jenis_kelamin='{data.jenisKelamin}', " +
                                                        $"alamat='{data.alamat}' " +
                                                        $"WHERE id='{id}'", conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                return GetEmployee(id);
            }
        }

        public List<EmployeeItem> DeleteEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM employee WHERE id= @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }
            return list;
        }


        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat"),
                        });
                    }
                }
            }
            return list;
        }

        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat"),
                        });
                    }
                }
            }
            return list;
        }
    }
}