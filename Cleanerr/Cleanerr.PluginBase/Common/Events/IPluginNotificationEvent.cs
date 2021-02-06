using System;

namespace Cleanerr.PluginBase.Common.Events
{
    public interface IPluginNotificationEvent
    {
        event EventHandler<PluginNotificationEventArgs> PluginNotificationEvent;
        void OnPluginNotificationEvent(PluginNotificationEventArgs e);
    }
}
