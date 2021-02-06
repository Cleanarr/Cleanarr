using System;

namespace Cleanarr.PluginBase.Common.Events
{
    public class ConfigurationChangedEventArgs : EventArgs
    {
        string ConfigurationName { get; set; }
        string OldValue { get; set; }
        string NewValue { get; set; }
    }
}
