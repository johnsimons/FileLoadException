using NServiceBus;

namespace Wwa.Lms.Services.CustomerManagement.Service10
{
    using System.Reflection;
    /*
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization
    {
        public void Init()
        {
            Configure.With()
                .DefaultBuilder()
                .DefineEndpointName(Assembly.GetExecutingAssembly().GetName().Name)
                .XmlSerializer()
                .MsmqTransport()
                .IsTransactional(true)
                .UnicastBus()
                .ImpersonateSender(false);
        }
    }
    */
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        public void Init()
        {
            Configure.With()
                .DefineEndpointName(Assembly.GetExecutingAssembly().GetName().Name);
        }
    }
}
