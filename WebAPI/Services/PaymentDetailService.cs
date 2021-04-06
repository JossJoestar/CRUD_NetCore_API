using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Services
{
	public interface IPaymentDetailService
	{
		List<PaymentDetail> getAll();
		PaymentDetail GetPayment(int id);
		PaymentDetail Insert(PaymentDetail paymentDetail);
		PaymentDetail Update(PaymentDetail paymentDetail);
		void Delete(int id);
	}
	public class PaymentDetailService : IPaymentDetailService
	{
		private readonly IPaymentDetailRepository paymentDetailRepository;

		public PaymentDetailService(IPaymentDetailRepository paymentDetailRepository)
		{
			this.paymentDetailRepository = paymentDetailRepository;
		}

		public void Delete(int id)
		{
			paymentDetailRepository.Delete(id);
		}

		public List<PaymentDetail> getAll()
		{
			return paymentDetailRepository.getAll().ToList();
		}

		public PaymentDetail GetPayment(int id)
		{
			return paymentDetailRepository.GetPayment(id);
		}

		public PaymentDetail Insert(PaymentDetail paymentDetail)
		{
			return paymentDetailRepository.Insert(paymentDetail);
		}

		public PaymentDetail Update(PaymentDetail paymentDetail)
		{
			return paymentDetailRepository.Update(paymentDetail);
		}
	}
}
