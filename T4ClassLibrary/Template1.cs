 
// This is the output code from your template
// you only get syntax-highlighting here - not intellisense
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EFWCF.DTO
{
	public class ModuleDTO:BaseDTO
	{
		public Int32 ID{get;set;}
		public Int32 PID{get;set;}
		public String ModuleCNName{get;set;}
		public String ShortCNName{get;set;}
		public String ModuleENName{get;set;}
		public String ShortENName{get;set;}
		public String ModuleDescribe{get;set;}
		public String ModuleImage{get;set;}
		public String ModuleType{get;set;}
		public Boolean IsLarge{get;set;}
		public String ControlTypeName{get;set;}
		public String Remarks{get;set;}
		public Int32 ViewOrder{get;set;}
	}
}
