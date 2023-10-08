﻿using PANDA.DbModels.Enums;

namespace PANDA.DbModels
{
    public class Package
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public string ShippingAddress { get; set; }
        public Status Status { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public User Recipient { get; set; }
        public string RecipientId { get; set; }
        public Receipt Receipt { get; set; }
        public string? ReceiptId { get; set; }
    }
}
