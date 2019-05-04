using Microsoft.AspNetCore.Mvc.Testing;
using NarikDemo.Web;
using Xunit;

namespace NarikDemo.Test.Base
{
    public class ControllerTest: IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly WebApplicationFactory<Startup> Factory;

        public ControllerTest(WebApplicationFactory<Startup> factory)
        {
            Factory = factory;
        }
    }
}
