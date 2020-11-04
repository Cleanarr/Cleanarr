using System;
using System.Collections.Generic;
using System.Text;

namespace Cleanerr.PluginBase
{
    class Class2 : IPluginOptionClass
    {
        public IPluginOption Host  { get; set; }
        public IPluginOption Token { get; set; }
    }
} 
