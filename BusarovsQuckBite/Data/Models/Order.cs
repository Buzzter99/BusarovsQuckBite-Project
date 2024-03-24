﻿using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BusarovsQuckBite.Constants.DataConstants.OrderConstants;

namespace BusarovsQuckBite.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(UserConstants.UserIdMaxLength)]
        public string Who { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Who))]
        public virtual ApplicationUser User { get; set; } = null!;
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.None;
        [Required]
        [Precision(TotalAmountPrecision,TotalAmountScale)]
        public decimal TotalAmount { get; set; }
        [Required]
        public int CartId { get; set; }
        [Required]
        [ForeignKey(nameof(CartId))]
        public virtual Cart Cart { get; set; } = null!;
        [Required]
        public PaymentType PaymentType { get; set; } = PaymentType.Cash;

    }
}
