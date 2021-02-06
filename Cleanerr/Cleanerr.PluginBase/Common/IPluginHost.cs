using Cleanerr.PluginBase.Common.Events;
using System;

namespace Cleanerr.PluginBase.Common
{
    public interface IPluginHost
    {
        void RegisterPluginEvent(IPluginNotificationEvent notificationEvent);

        event EventHandler<ConfigurationChangedEventArgs> ConfigurationChanged;
    }
}
