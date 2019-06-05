using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRMvc.App_Start.SignalRMvc))]

namespace SignalRMvc.App_Start
{
    public class SignalRMvc
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
