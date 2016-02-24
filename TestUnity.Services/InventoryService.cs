using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWCF.Models;
using EFWCF.DTO;
using EFWCF.IServices;
using EFWCF.BLL;
namespace EFWCF.Services
{
    public class MaterialBaseInfoService : ServiceBase<DTO.MaterialBaseInfoDTO, Models.MaterialBaseInfo>, IMaterialBaseInfoService
    {
        public MaterialBaseInfoService()
        {
            base.BaseBLL = new MaterialBaseInfoBLL();
        }
    }
}
