//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2019-08-09 15:16:08
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Harbour CTS
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dapper.Contrib.Extensions;

namespace NBCZ.Model
{	
   
   [Table("V_PubDept_Parent")]
    public partial class V_PubDept_Parent
    {

	   /// <summary>
     	/// 
     	/// </summary>
		public string DeptCode { get; set; }

		/// <summary>
     	/// 
     	/// </summary>
		public string DeptName { get; set; }

		/// <summary>
     	/// 
     	/// </summary>
		public string Remark { get; set; }

		/// <summary>
     	/// 
     	/// </summary>
		public string ParentCode { get; set; }

		/// <summary>
     	/// 
     	/// </summary>
		public int DeptLevel { get; set; }

		/// <summary>
     	/// 
     	/// </summary>
		public string Lmid { get; set; }

		/// <summary>
     	/// 
     	/// </summary>
		public DateTime? Lmdt { get; set; }

		/// <summary>
     	/// 
     	/// </summary>
		public bool? StopFlag { get; set; }

		/// <summary>
     	/// 
     	/// </summary>
		public string ParentName { get; set; }

		   
    }
}
