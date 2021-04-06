using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
	public class PaymentDetail
	{
		public PaymentDetail(int pMId, string cardOwnerName, string cardNumber, string expirationDate, string cVV)
		{
			PMId = pMId;
			CardOwnerName = cardOwnerName;
			CardNumber = cardNumber;
			ExpirationDate = expirationDate;
			CVV = cVV;
		}

		[Key]
		public int PMId { get; set; }
		[Required]
		public string CardOwnerName { get; set; }
		[Required]
		public string CardNumber { get; set; }
		[Required]
		public string ExpirationDate { get; set; }
		[Required]
		public string CVV { get; set; }
	}
}
