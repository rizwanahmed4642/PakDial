﻿using PAKDial.Domains.DomainModels;
using PAKDial.Domains.SqlViewModels;
using System.Collections.Generic;

namespace PAKDial.Domains.ResponseModels
{
    public class HomeSecMainMenuCatResponse
    {
        public int RowCount { get; set; }
        public IEnumerable<VHomeSecMainMenuCat> VHomeSecMainMenuCats  { get; set; }
    }
}
