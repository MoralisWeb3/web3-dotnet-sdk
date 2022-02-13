
using Moralis.Web3Api.Interfaces;
using System.Threading.Tasks;

namespace Moralis.Web3Api.Integrated.Tests
{
    interface IIntegratedTest
    {
        Task<IntegratedTestResult> RunTests(IWeb3Api web3Api, string address);
    }
}
