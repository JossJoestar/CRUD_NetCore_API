using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Produces("application/json")]
	public class PaymentDetailController : Controller
	{
		private readonly IPaymentDetailService paymentDetailService;

		public PaymentDetailController(IPaymentDetailService paymentDetailService)
		{
			this.paymentDetailService = paymentDetailService;
		}
		// GET: PaymentDetailController
		[HttpGet]
		public IActionResult Index()
		{
			return Ok(paymentDetailService.getAll());
		}

		// GET: PaymentDetailController/Details/5
		[HttpGet("{id}")]
		public IActionResult Details(int id)
		{
			try
			{
				return Ok(paymentDetailService.GetPayment(id));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpPost]
		public IActionResult Post([FromBody] PaymentDetail paymentDetail)
		{
			try
			{
				PaymentDetail payment = paymentDetailService.Insert(paymentDetail);
				return Ok(payment);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] PaymentDetail paymentDetail)
		{
			try
			{
				paymentDetail.PMId = id;
				return Ok(paymentDetailService.Update(paymentDetail));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			try
			{
				paymentDetailService.Delete(id);
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
