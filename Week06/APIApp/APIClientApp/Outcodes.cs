﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp
{
    public class OutCode
    {
        public int status { get; set; }
        public ResCode result { get; set; }
    }

    public class ResCode
    {
        public string outcode { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public int northings { get; set; }
        public int eastings { get; set; }
        public string[] admin_district { get; set; }
        public string[] parish { get; set; }
        public object[] admin_county { get; set; }
        public string[] admin_ward { get; set; }
        public string[] country { get; set; }
    }

}
