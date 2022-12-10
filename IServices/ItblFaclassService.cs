using FixedAssetApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixedAssetApi.IServices
{
	public interface ItblFaclassService
	{
		 IEnumerable<TblFaclass> GetTblFaclasses();
		TblFaclass GetTblFaclassById(int id);

		TblFaclass AddTblFaclass(TblFaclass tblFaclass);

		TblFaclass UpdateTblFaclass(TblFaclass tblFaclass);

		TblFaclass DeleteTblFaclass(int id);
	}
}
