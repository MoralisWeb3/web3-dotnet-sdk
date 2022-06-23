using System;
using Moralis.Platform.Utilities;
using System.Threading.Tasks;
using Moralis.Platform.Abstractions;

namespace Moralis.Platform.Services.Infrastructure
{
    public class InstallationService : IInstallationService
    {

        static string InstallationIdKey { get; } = "InstallationId";

        object Mutex { get; } = new object { };

        public Guid? InstallationId { get; private set; }

        ICacheService StorageController { get; }

        public InstallationService(ICacheService storageController) => StorageController = storageController;

        public async Task SetAsync(Guid? installationId)
        {
            //lock (Mutex)
            //{

            if (installationId != null)
            {
                IDataCache<string, object> storage = await StorageController.LoadAsync();

                await storage.AddAsync(InstallationIdKey, installationId.ToString());
            }
            else
            {
                IDataCache<string, object> storage = await StorageController.LoadAsync();
                
                await storage.RemoveAsync(InstallationIdKey);
            }

            InstallationId = installationId;
        }

        public async Task<Guid?> GetAsync()
        {
            lock (Mutex)
                if (InstallationId != null)
                    return InstallationId;

            IDataCache<string, object> storage = await StorageController.LoadAsync();

            storage.TryGetValue(InstallationIdKey, out object id);

            try
            {
                lock (Mutex)
                    return InstallationId = new Guid(id as string);
            }
            catch (Exception)
            {
                Guid newInstallationId = Guid.NewGuid();
                await SetAsync(newInstallationId);
                return newInstallationId;
            }
        }

        public async Task ClearAsync() => await SetAsync(null);
    }
}
