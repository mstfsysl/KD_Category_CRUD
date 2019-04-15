﻿using System;
using System.Collections.Generic;

namespace KD_Category_CRUD.Models
{
    public partial class ProductAttributeSelection
    {
        public ProductAttributeSelection()
        {
            ProductAttributeValue = new HashSet<ProductAttributeValue>();
        }

        public Guid Id { get; set; }
        public Guid AttributeId { get; set; }
        public string Value { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public ProductAttribute Attribute { get; set; }
        public ICollection<ProductAttributeValue> ProductAttributeValue { get; set; }
    }
}