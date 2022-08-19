using System;
using System.Collections.Generic;
using System.Text;

namespace Moralis.Web3Api.Integrated.Tests
{
    class IntegratedTestResult
    {

        public IDictionary<string, string> FailedTests { get; set; }
        public IDictionary<string, string> PassedTests { get; set; }

        public IntegratedTestResult()
        {
            FailedTests = new Dictionary<string, string>();
            PassedTests = new Dictionary<string, string>();
        }

        public bool HasFailedTests() => FailedTests.Count > 0;

        public int TestCount() => FailedTests.Count + PassedTests.Count;
    }
}
