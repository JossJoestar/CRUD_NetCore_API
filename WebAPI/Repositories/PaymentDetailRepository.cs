using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
	public interface IPaymentDetailRepository
	{
		IEnumerable<PaymentDetail> getAll();
		PaymentDetail GetPayment(int id);
		PaymentDetail Insert(PaymentDetail paymentDetail);
		PaymentDetail Update(PaymentDetail paymentDetail);
		void Delete(int id);
	} 
	public class PaymentDetailRepository : IPaymentDetailRepository
	{
		private readonly DataDbContext _db = new DataDbContext();

		public void Delete(int id)
		{
			PaymentDetail payment = GetPayment(id);
			_db.PaymentDetails.Remove(payment);
			_db.SaveChanges();
		}

		public IEnumerable<PaymentDetail> getAll()
		{
			return _db.PaymentDetails;
		}

		public PaymentDetail GetPayment(int id)
		{
			return _db.PaymentDetails.Find(id);
		}

		public PaymentDetail Insert(PaymentDetail paymentDetail)
		{
			_db.PaymentDetails.Add(paymentDetail);
			_db.SaveChanges();
			return paymentDetail;
		}

		public PaymentDetail Update(PaymentDetail paymentDetail)
		{
			_db.PaymentDetails.Update(paymentDetail).State = EntityState.Modified;
			//_db.PaymentDetails.Update(paymentOld);
			_db.SaveChanges();
			return paymentDetail;
		}
	}
}
