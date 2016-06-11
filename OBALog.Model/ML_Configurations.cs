﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBALog.Model
{
    public class ML_Configurations
    {
        public string ConfigurationName { get; set; }
        public string ConfigurationValue { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Key { get; set; }
        public int UserKey { get; set; }
    }
}