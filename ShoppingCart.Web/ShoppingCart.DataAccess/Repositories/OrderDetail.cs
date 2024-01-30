﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ShoppingCart.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.DataAccess.Repositories
{
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]

        public int OrderHeaderId { get; set; }
        [ValidateNever]
        public OrderHeader OrderHeader { get; set;}
        [Required]
        public int ProductId {  get; set; }
        [ValidateNever]
        public Product Product { get; set; }

        public double Price { get; set; }

        public int Count {  get; set; }
    }
}