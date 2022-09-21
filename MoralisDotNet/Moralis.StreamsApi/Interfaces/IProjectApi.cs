using Moralis.StreamsApi.Models;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Interfaces
{
    public interface IProjectApi
    {
        public Task<bool> PostSettings(SettingsDetail req);

        public Task<SettingsDetail> GetSettings();
    }
}
