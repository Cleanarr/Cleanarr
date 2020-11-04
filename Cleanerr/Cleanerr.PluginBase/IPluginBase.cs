using System.Collections.Generic;

namespace Cleanerr.PluginBase
{
    public interface IPluginBase
    {
        IEnumerable<IPluginOption> Options { get; set; }

        
    }
}
