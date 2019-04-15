﻿using System;
using System.Collections.Generic;

namespace KD_Category_CRUD.Models
{
    public partial class Sector
    {
        public Sector()
        {
            MasterProduct = new HashSet<MasterProduct>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int AutoId { get; set; }
        public int Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public bool IsFaulty { get; set; }

        public ICollection<MasterProduct> MasterProduct { get; set; }
    }
}
