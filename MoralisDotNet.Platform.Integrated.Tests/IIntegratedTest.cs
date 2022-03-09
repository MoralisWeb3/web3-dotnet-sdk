
using Moralis;
using System.Threading.Tasks;

namespace MoralisDotNet.Platform.Integrated.Tests
{
    interface IIntegratedTest
    {
        Task<IntegratedTestResult> RunTests(MoralisClient moralis);
    }
}
