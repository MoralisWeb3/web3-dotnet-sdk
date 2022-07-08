
using Moralis.AuthApi.Interfaces;
using System.Threading.Tasks;

namespace Moralis.AuthApi.Integrated.Tests
{
    interface IIntegratedTest
    {
        Task<IntegratedTestResult> RunTests(IAuthClientApi authApi, string address);
    }
}
