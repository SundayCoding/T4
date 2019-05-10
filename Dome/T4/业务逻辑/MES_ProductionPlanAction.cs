

using System;
using System.Collections.Generic;
using MY.Model;
using FluentData;
namespace MY.BLL
{	
	
	/// <summary>
    /// MES_ProductionPlan 操作类
    /// </summary>
	public partial class MES_ProductionPlanAction
	{
		

		public static MES_ProductionPlan Select(Int32 iD)
		{
			using(var context = db.Context())
            {
                return context.Sql(" SELECT * FROM MES_ProductionPlan WHERE ID = @id ")
					.Parameter("id", iD)
                    .QuerySingle<MES_ProductionPlan>();
            }
		}

		public static List<MES_ProductionPlan> SelectAll()
        {
            return SelectAll(string.Empty);
        }

        public static List<MES_ProductionPlan> SelectAll(string sortExpression)
        {
            return SelectAll(0, 0, sortExpression);
        }

        public static List<MES_ProductionPlan> SelectAll(int startRowIndex, int maximumRows, string sortExpression)
        {
            using (var context = db.Context())
            {
                var select = context.Select<MES_ProductionPlan>(" * ")
                    .From(" MES_ProductionPlan ");

                if (maximumRows > 0)
                {
                    if (startRowIndex == 0) 
                        startRowIndex = 1;

                    select.Paging(startRowIndex, maximumRows);
                }

                if (!string.IsNullOrEmpty(sortExpression))
                    select.OrderBy(sortExpression);

                return select.QueryMany();
            }
        }

		public static int CountAll()
        {
            using (var context = db.Context())
            {
                return context.Sql(" SELECT COUNT(*) FROM MES_ProductionPlan ")
                    .QuerySingle<int>();
            }
        }

		
		public static bool Insert(MES_ProductionPlan mES_ProductionPlan) 
        {
            using (var context = db.Context())
            {
                int id = context.Insert<MES_ProductionPlan>("MES_ProductionPlan", mES_ProductionPlan)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();

                mES_ProductionPlan.ID = id;
                return id > 0;
            }
        }
		public static bool Update(MES_ProductionPlan mES_ProductionPlan)
        {
            using (var context = db.Context())
            {
                return context.Update<MES_ProductionPlan>("MES_ProductionPlan", mES_ProductionPlan)
                    .AutoMap(x => x.ID)
										.Where("ID", mES_ProductionPlan.ID)
					                    .Execute() > 0;
            }
        }

		public static bool Delete(MES_ProductionPlan mES_ProductionPlan) 
        {
            return Delete(mES_ProductionPlan.ID);
        }

        public static bool Delete(Int32 iD)
        {
            using (var context = db.Context())
            {
                return context.Sql(" DELETE FROM Product WHERE ID = @id ")
                    .Parameter("id", iD)
                    .Execute() > 0;
            }
        }
	}
	
}
	
