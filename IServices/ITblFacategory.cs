using FixedAssetApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixedAssetApi.IServices
{
	public interface ITblFacategory
	{
		IEnumerable<TblFacategory> GetTblFacategory();
		TblFacategory GetTblFacategoryById(int id);

		TblFacategory AddTblFacategory(TblFacategory tblFacategory);

		TblFacategory UpdateTblFacategory(TblFacategory tblFacategory);

		TblFacategory DeleteTblFacategory(int id);
	}
}
