﻿using DataLayer.SSOT;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.ViewModels.Keyword
{
    public class KeywordsUpdateViewModel
    {
        public int Id { get; set; }

        public string Keyword { get; set; }

        public KeywordTypeSSOT Type { get; set; }

        public bool IsActive { get; set; }
    }
}
