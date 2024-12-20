﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.D.Y_Serivce.ViewModels
{
    public class PaymentViewModel
    {
        public int PaymentId { get; set; }
        public string UserId { get; set; } = null!;
        public string? UserName { get; set; }    
        public double Money { get; set; }
        public DateTime Date { get; set; }
        public int? Status { get; set; }
        public string? PaymentInfo { get; set; }
        public string? Title { get; set; }
        public string? BankCode { get; set; }   
    }
}
