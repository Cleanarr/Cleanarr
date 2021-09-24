using Cleanarr.PluginBase.Models.RequestProvider;
using System;
using System.Collections.Generic;

namespace Cleanarr.PluginBase
{
    public interface IRequestProviderPlugin : IPlugin
    {
        public List<Request> GetRequests();
        public List<Request> GetRequests(DateTime StartDate, DateTime EndDate);
        public List<Request> GetRequestsByUser(string UserId);
        public List<Request> GetRequestsByUser(string UserId, DateTime StartDate, DateTime EndDate);
        public List<Request> GetRequestsByMedia(string MediaId);
        public List<Request> GetRequestsByMedia(string MediaId, DateTime StartDate, DateTime EndDate);
    }
}
