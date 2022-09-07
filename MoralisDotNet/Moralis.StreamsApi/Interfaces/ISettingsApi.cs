using Moralis.StreamsApi.Models;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Interfaces
{
    public interface ISettingsApi
    {
        public Task<bool> PostSettings(SettingsDetail req);

        public Task<SettingsDetail> GetSettings();
    }
}
