using Microsoft.AspNetCore.Blazor;
using PersonalSite.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace PersonalSite.Client
{
    public class AppState
    {
        public UserProfile Profile { get; set; }

        // Lets components receive change notifications
        // Could have whatever granularity you want (more events, hierarchy...)
        public event Action OnChange;

        // Receive 'http' instance from DI
        private readonly HttpClient _http;
        public AppState(HttpClient httpInstance)
        {
            _http = httpInstance;
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
