using System;

namespace Cleanarr.PluginBase.Common.Events
{
    public interface IPluginNotificationEvent
    {
        event EventHandler<PluginNotificationEventArgs> PluginNotificationEvent;
        void OnPluginNotificationEvent(PluginNotificationEventArgs e);
    }
}
