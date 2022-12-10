using FixedAssetApi.IServices;
using FixedAssetApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FixedAssetApi.Services
{
	public class TblFacategoryService : ITblFacategory
	{
		FixedAssetContext dbContext;
		// creating constructor for this
		public TblFacategoryService(FixedAssetContext _db) {
			dbContext = _db;
		}
		public IEnumerable<TblFacategory> GetTblFacategory()
		{
			var facategory = dbContext.TblFacategories.ToList();
			return facategory;
		}

		public TblFacategory GetTblFacategoryById(int id)
		{
			var facategory = dbContext.TblFacategories.FirstOrDefault(x => x.Id == id);
			return facategory;
		}

		public TblFacategory AddTblFacategory(TblFacategory tblFacategory)
		{
			if (tblFacategory != null)
			{
			 dbContext.TblFacategories.Add(tblFacategory);
				dbContext.SaveChanges();
				return tblFacategory;
				
			}
			return null;
		}

		public TblFacategory UpdateTblFacategory(TblFacategory tblFacategory)
		{
			dbContext.Entry(tblFacategory).State = EntityState.Modified;
			dbContext.SaveChanges();
			return tblFacategory;
		}





		public TblFacategory DeleteTblFacategory(int id)
		{
			var facategory = dbContext.TblFacategories.FirstOrDefault(x => x.Id == id);
			dbContext.Entry(facategory).State = EntityState.Deleted;
			dbContext.SaveChanges();
			return facategory;
		}


	}
}
