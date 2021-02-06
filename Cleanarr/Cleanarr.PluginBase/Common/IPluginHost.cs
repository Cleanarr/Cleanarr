using Cleanarr.PluginBase.Common.Events;
using System;

namespace Cleanarr.PluginBase.Common
{
    public interface IPluginHost
    {
        void RegisterPluginEvent(IPluginNotificationEvent notificationEvent);

        event EventHandler<ConfigurationChangedEventArgs> ConfigurationChanged;
    }
}
