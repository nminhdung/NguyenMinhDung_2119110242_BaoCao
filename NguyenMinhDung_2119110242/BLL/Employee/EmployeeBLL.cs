using NguyenMinhDung_2119110242.DAL.EmployeeDAL;
using NguyenMinhDung_2119110242.DTO.EmployeeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenMinhDung_2119110242.BLL.EmployeeBLL
{
    public class EmployeeBLL
    {
        EmployeeDAL dal = new EmployeeDAL();
        public List<EmployeeDTO> ReadEmployee()
        {
            List<EmployeeDTO> lstEmp = dal.ReadEmployee();
            return lstEmp;
        }
        public void AddEmployee(EmployeeDTO emp)
        {
            dal.AddEmployee(emp);
        }
        public void DeleteEmployee(EmployeeDTO emp)
        {
            dal.DeleteEmployee(emp);
        }
    }
}
