using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenMinhDung_2119110242.DTO.DepartmentDTO
{
    public class DepartmentDTO
    {
        public string idDepartment { get; set; }
        public string Name { get; set; }
        public List<EmployeeDTO.EmployeeDTO> Employees { get; set; }
    }
}
