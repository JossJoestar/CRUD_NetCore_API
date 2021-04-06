using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAPI.Models
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
		public PaymentDetail()
		{

		}

        [Key]
        [JsonPropertyName("PMId")]
        public int PMId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [JsonPropertyName("CardOwnerName")]
        public string CardOwnerName { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        [JsonPropertyName("CardNumber")]
        public string CardNumber { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        [JsonPropertyName("ExpirationDate")]
        public string ExpirationDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        [JsonPropertyName("CVV")]
        public string CVV { get; set; }
    }
}
