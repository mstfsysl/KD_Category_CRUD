﻿using System;
using System.Collections.Generic;

namespace KD_Category_CRUD.Models
{
    public partial class CategoryCategoryNew
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Guid? MasterCategoryId { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAdusername { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
    }
}
