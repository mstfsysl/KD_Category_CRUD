﻿using System;
using System.Collections.Generic;

namespace KD_Category_CRUD.Models
{
    public partial class ExcelImportedProduct
    {
        public Guid Id { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
        public Guid FileId { get; set; }
        public Guid MasterProductId { get; set; }

        public File File { get; set; }
        public MasterProduct MasterProduct { get; set; }
    }
}
