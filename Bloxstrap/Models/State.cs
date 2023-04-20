﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloxstrap.Models
{
    public class State
    {
        public string VersionGuid { get; set; } = "";
        public bool HadReShadeInstalled { get; set; } = false;
        public List<string> ModManifest { get; set; } = new();
    }
}
