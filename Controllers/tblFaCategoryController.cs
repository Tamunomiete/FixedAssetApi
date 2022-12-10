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
	public class tblFaCategoryController : ControllerBase
	{
		private readonly ITblFacategory facategoryService;
		public tblFaCategoryController(ITblFacategory facategory)
		{
			facategoryService = facategory;
		}
		[HttpGet]
		[Route("[action]")]
		public IEnumerable<TblFacategory> GetTblFacategory()
		{
			return facategoryService.GetTblFacategory();
		}

	[HttpGet]
	[Route ("[action]")]
		public TblFacategory GetTblFacategoryById(int id)
		{
			return facategoryService.GetTblFacategoryById(id);
		}

		[HttpPost]
		[Route("[action]")]
		public TblFacategory AddTblFacategory(TblFacategory tblFacategory)
		{
			return facategoryService.AddTblFacategory(tblFacategory);
		}
		[HttpPut]
		[Route("[action]")]
		public TblFacategory UpdateTblFacategory(TblFacategory tblFacategory)
		{
			return facategoryService.UpdateTblFacategory(tblFacategory);
		}

		[HttpDelete]
		[Route("[action]")]

		public TblFacategory DeleteTblFacategory(int id)
		{
			return facategoryService.DeleteTblFacategory(id);
		}



	}
}
