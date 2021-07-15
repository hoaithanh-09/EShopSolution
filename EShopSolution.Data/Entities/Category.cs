﻿using EShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopSolution.Data.Entities
{
    public class Category
    {
        public int Id{get;set;}
        public int SortOrder{ get; set; }
        public bool IsShowOnHome{ get; set; }
        public int? Parentld{get;set;}
        public Status Status{get;set;}



    }
}
