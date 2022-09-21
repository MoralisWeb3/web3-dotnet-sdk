
using Moralis.SolanaApi.Interfaces;
using System.Threading.Tasks;

namespace Moralis.SolanaApi.Integrated.Tests
{
    interface IIntegratedTest
    {
        Task<IntegratedTestResult> RunTests(ISolanaApi solanaApi, string address);
    }
}
