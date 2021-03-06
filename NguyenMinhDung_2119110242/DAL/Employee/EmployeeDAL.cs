using NguyenMinhDung_2119110242.DTO.EmployeeDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenMinhDung_2119110242.DAL.Department;
namespace NguyenMinhDung_2119110242.DAL.EmployeeDAL
{
    public class EmployeeDAL : DBConnection
    {
        public List<EmployeeDTO> ReadEmployee()
        {
            SqlConnection connect = CreateConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("getEmployees", connect);
            SqlDataReader reader = cmd.ExecuteReader();
            List<EmployeeDTO> lstEmp = new List<EmployeeDTO>();
            DepartmentDAL departDAL = new DepartmentDAL();
            while (reader.Read())
            {
                EmployeeDTO emp = new EmployeeDTO();
                emp.idEmployee = reader["idEmployee"].ToString();
                emp.Name = reader["Name"].ToString();
                emp.DateBirth = (DateTime)reader["DateBirth"];
                emp.Gender = (Boolean)reader["Gender"];
                emp.PlaceBirth = reader["PlaceBirth"].ToString();
                emp.Depart = departDAL.readDepart(reader["idDepartment"].ToString());

                lstEmp.Add(emp);
            }
            connect.Close();
            return lstEmp;
        }
        public void AddEmployee(EmployeeDTO emp)
        {
            SqlConnection connect = CreateConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("addEmp @idEmployee,@Name,@DateBirth,@Gender,@PlaceBirth,@idDepartment", connect);
            cmd.Parameters.Add(new SqlParameter("@idEmployee", emp.idEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", emp.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", emp.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", emp.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", emp.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("@idDepartment", emp.Depart.idDepartment));

            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void DeleteEmployee(EmployeeDTO emp) 
        {
            SqlConnection connect = CreateConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("deleteEmp @idEmployee", connect);
            cmd.Parameters.Add(new SqlParameter("@idEmployee", emp.idEmployee));
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void EditEmployee(EmployeeDTO emp)
        {
            SqlConnection connect = CreateConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("editEmp @idEmployee,@Name,@DateBirth,@Gender,@PlaceBirth,@idDepartment", connect);
            cmd.Parameters.Add(new SqlParameter("@idEmployee", emp.idEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", emp.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", emp.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", emp.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", emp.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("@idDepartment", emp.idDepartment));
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
