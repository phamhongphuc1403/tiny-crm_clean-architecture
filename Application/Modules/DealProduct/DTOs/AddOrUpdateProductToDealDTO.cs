﻿namespace TinyCRM.Application.Modules.DealProduct.DTOs
{
    public class AddOrUpdateProductToDealDTO
    {
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public double PricePerUnit { get; set; }
    }
}