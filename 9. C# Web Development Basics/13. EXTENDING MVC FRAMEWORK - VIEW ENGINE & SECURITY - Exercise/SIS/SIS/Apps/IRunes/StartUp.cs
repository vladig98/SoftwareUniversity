using IRunes.Data;
using IRunes.Services;
using SIS.Framework.Api;
using SIS.Framework.Services;

namespace IRunes
{
    public class StartUp : MvcApplication
    {
        public override void ConfigureServices(IDependencyContainer dependencyContainer)
        {
            dependencyContainer.RegisterDependency<IEncryptionService, EncryptionService>();
            dependencyContainer.RegisterDependency<IRunesDbContext, IRunesDbContext>();
        }
    }
}
