using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountAPI.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        public int AccountNumber { get; set; }

        [Required]
        public int AccountBranchCode { get; set; }

        [Required]
        public int AccountSuffix { get; set; }

        [Required]
        public decimal Balance { get; set; }

        [Required]
        public decimal AvailableBalance { get; set; }
    }
}
