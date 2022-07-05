

namespace Moralis.Platform.Integrated.Tests
{
    interface IIntegratedTest
    {
        Task<IntegratedTestResult> RunTests(MoralisClient moralisClient);
    }
}
