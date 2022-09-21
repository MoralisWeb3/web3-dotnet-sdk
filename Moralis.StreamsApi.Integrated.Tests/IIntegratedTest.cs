
using Moralis.StreamsApi.Interfaces;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Integrated.Tests
{
    interface IIntegratedTest
    {
        Task<IntegratedTestResult> RunTests(IStreamsApiClient streamsApi, string address);
    }
}
