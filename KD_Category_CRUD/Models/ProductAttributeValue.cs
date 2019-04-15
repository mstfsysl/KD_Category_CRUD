﻿using System;
using System.Collections.Generic;

namespace KD_Category_CRUD.Models
{
    public partial class ProductAttributeValue
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductAttributeId { get; set; }
        public Guid ProductAttributeSelectionId { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public MasterProduct Product { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public ProductAttributeSelection ProductAttributeSelection { get; set; }
    }
}
