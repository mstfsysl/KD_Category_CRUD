﻿using System;
using System.Collections.Generic;

namespace KD_Category_CRUD.Models
{
    public partial class ProductHistory
    {
        public Guid Id { get; set; }
        public Guid MasterId { get; set; }
        public string Name { get; set; }
        public string StockCode { get; set; }
        public string PackageBarcode { get; set; }
        public string BoxBarcode { get; set; }
        public string Barcode { get; set; }
        public decimal MainPrice { get; set; }
        public Guid MasterProductId { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
    }
}
