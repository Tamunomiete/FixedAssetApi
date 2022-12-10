using FixedAssetApi.IServices;
using FixedAssetApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixedAssetApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class tblFaClassController : ControllerBase
	{
		private readonly ItblFaclassService faclassService;
		public tblFaClassController(ItblFaclassService faclass)
		{
			faclassService = faclass;
		}
		[HttpGet]
		[Route("[action]")]
		
		public IEnumerable<TblFaclass> GetTblFaclasses()
		{
			return faclassService.GetTblFaclasses();
		}

		[HttpGet]
		[Route("[action]")]
		public TblFaclass GetTblFaclassById(int id)
		{
			return faclassService.GetTblFaclassById(id);
		}

		[HttpPost]
		[Route("[action]")]
		public TblFaclass AddTblFaclass(TblFaclass tblFaclass)
		{
			return faclassService.AddTblFaclass(tblFaclass);
		}

		[HttpPut]
		[Route("[action]")]
		public TblFaclass UpdateTblFaclass(TblFaclass tblFaclass)
		{
			return faclassService.UpdateTblFaclass(tblFaclass);
		}


		[HttpDelete]
		[Route("[action]")]
		public TblFaclass DeleteTblFaclass(int id) {
			return faclassService.DeleteTblFaclass(id);
		}
	}
}
