using System;
using System.Collections.Generic;
namespace MY.Model
{	
	/// <summary>
	/// 实体-MES_ProductionPlan 
	/// </summary>
	public partial class MES_ProductionPlan    
	{	
		/// <summary>
		/// ID 
		/// </summary> 
				public Int32 ID { get; set; }
		/// <summary>
		/// Code 
		/// </summary> 
				public String Code { get; set; }
		/// <summary>
		/// PlanDate 
		/// </summary> 
				public DateTime? PlanDate { get; set; }
		/// <summary>
		/// PlanMan 
		/// </summary> 
				public String PlanMan { get; set; }
		/// <summary>
		/// OrderFactoryID 
		/// </summary> 
				public Int32? OrderFactoryID { get; set; }
		/// <summary>
		/// WorkShopID 
		/// </summary> 
				public Int32? WorkShopID { get; set; }
		/// <summary>
		/// WorkSectionID 
		/// </summary> 
				public Int32? WorkSectionID { get; set; }
		/// <summary>
		/// MadeIn 
		/// </summary> 
				public String MadeIn { get; set; }
		/// <summary>
		/// IsSubmit 
		/// </summary> 
				public Boolean? IsSubmit { get; set; }
		/// <summary>
		/// SubmitDate 
		/// </summary> 
				public DateTime? SubmitDate { get; set; }
		/// <summary>
		/// CheckState 
		/// </summary> 
				public Int32? CheckState { get; set; }
		/// <summary>
		/// IsBreakDown 
		/// </summary> 
				public Boolean? IsBreakDown { get; set; }
		/// <summary>
		/// BreakDownDate 
		/// </summary> 
				public DateTime? BreakDownDate { get; set; }
		/// <summary>
		/// CreateDate 
		/// </summary> 
				public DateTime CreateDate { get; set; }
		/// <summary>
		/// CreateUserID 
		/// </summary> 
				public Int32 CreateUserID { get; set; }
		/// <summary>
		/// LastModifiedDate 
		/// </summary> 
				public DateTime? LastModifiedDate { get; set; }
		/// <summary>
		/// LastModifiedUserID 
		/// </summary> 
				public Int32? LastModifiedUserID { get; set; }
		/// <summary>
		/// LastModifiedMemo 
		/// </summary> 
				public String LastModifiedMemo { get; set; }
		/// <summary>
		/// Remark 
		/// </summary> 
				public String Remark { get; set; }
	}
}
	
