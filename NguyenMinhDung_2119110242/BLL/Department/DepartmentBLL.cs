using NguyenMinhDung_2119110242.DAL.Department;
using NguyenMinhDung_2119110242.DTO.DepartmentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenMinhDung_2119110242.BLL.DepartmentBLL
{
    public class DepartmentBLL
    {
        DepartmentDAL departDAL = new DepartmentDAL();
        public List<DepartmentDTO> readDepartList()
        {
            List<DepartmentDTO> lstDepart = departDAL.ReadDepartList();
            return lstDepart;
        }
    }
}
