using FixedAssetApi.IServices;
using FixedAssetApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FixedAssetApi.Services
{
	public class TblFaclassService: ItblFaclassService
	{
		// creating constructor for this service 
		FixedAssetContext dbContext;
		public TblFaclassService(FixedAssetContext _db)
		{
			dbContext = _db;
		}
		public IEnumerable<TblFaclass> GetTblFaclasses()
		{
			var tblfaclass = dbContext.TblFaclasses.ToList();
			return tblfaclass;
		}

		public TblFaclass GetTblFaclassById(int id)
		{
			var tblfaclass = dbContext.TblFaclasses.FirstOrDefault(x => x.Id == id);
			return tblfaclass;
		}

		public TblFaclass AddTblFaclass(TblFaclass tblFaclass)
		{
			if (tblFaclass != null)
			{
				dbContext.TblFaclasses.Add(tblFaclass);
				dbContext.SaveChanges();
				return tblFaclass;
			}
			return null;
		}

		public TblFaclass UpdateTblFaclass(TblFaclass tblFaclass)
		{
			dbContext.Entry(tblFaclass).State = EntityState.Modified;
			dbContext.SaveChanges();
			return tblFaclass;

		}

		public TblFaclass DeleteTblFaclass(int id) {
			var tblfaclass = dbContext.TblFaclasses.FirstOrDefault(x => x.Id == id);
			dbContext.Entry(tblfaclass).State = EntityState.Deleted;
			dbContext.SaveChanges();
			return tblfaclass;

		}
	}
	}

