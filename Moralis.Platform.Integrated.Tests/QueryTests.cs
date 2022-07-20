using Moralis.Platform.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.Platform.Integrated.Tests
{
    class QueryTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(MoralisClient moralisClient)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Please note that these tests require that you have created \n a series of Hero records. If any tests fail please double check \nyour DB for a 'Hero' table with records.");
            Console.WriteLine("Additionally, you may need to adjust either tests or yor data to match each other.");
            Console.WriteLine("Running test FetchFirstQuery");
            if (await FetchFirstQuery(moralisClient))
            {
                testResults.PassedTests.Add("FetchFirstQuery", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("FetchFirstQuery", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test FindQuery");
            if (await FindQuery(moralisClient))
            {
                testResults.PassedTests.Add("FindQuery", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("FindQuery", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test WhereEqualToQuery");
            if (await WhereEqualToQuery(moralisClient))
            {
                testResults.PassedTests.Add("WhereEqualToQuery", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("WhereEqualToQuery", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test WhereGreaterThanQuery");
            if (await WhereGreaterThanQuery(moralisClient))
            {
                testResults.PassedTests.Add("WhereGreaterThanQuery", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("WhereGreaterThanQuery", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test WhereLessThanQuery");
            if (await WhereLessThanQuery(moralisClient))
            {
                testResults.PassedTests.Add("WhereLessThanQuery", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("WhereLessThanQuery", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test CompoundQuery");
            if (await CompoundQuery(moralisClient))
            {
                testResults.PassedTests.Add("CompoundQuery", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("CompoundQuery", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> FetchFirstQuery(MoralisClient moralisClient)
        {
            bool result = false;

            try
            {
                MoralisQuery<Hero> q = await moralisClient.Query<Hero>();

                Hero h = await q.FirstAsync();

                if (h != null)
                {
                    result = true;
                }
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> FindQuery(MoralisClient moralisClient)
        {
            bool result = false;

            try
            {
                MoralisQuery<Hero> q = await moralisClient.Query<Hero>();

                IEnumerable<Hero> heros = await q.FindAsync();

                if (heros != null && heros.Count() > 0)
                {
                    result = true;
                }
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> WhereEqualToQuery(MoralisClient moralisClient)
        {
            bool result = false;

            try
            {
                MoralisQuery<Hero> q = await moralisClient.Query<Hero>();
                q = q.WhereEqualTo("Warcry", "Decaf is a lie!");
                IEnumerable<Hero> heros = await q.FindAsync();

                if (heros != null && heros.Count() > 0)
                {
                    result = true;
                }
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> WhereGreaterThanQuery(MoralisClient moralisClient)
        {
            bool result = false;

            try
            {
                MoralisQuery<Hero> q = await moralisClient.Query<Hero>();
                q = q.WhereGreaterThan("Level", 2);
                IEnumerable<Hero> heros = await q.FindAsync();

                if (heros != null && heros.Count() > 0)
                {
                    result = true;
                }
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> WhereLessThanQuery(MoralisClient moralisClient)
        {
            bool result = false;

            try
            {
                MoralisQuery<Hero> q = await moralisClient.Query<Hero>();
                q = q.WhereLessThan("Level", 7);
                IEnumerable<Hero> heros = await q.FindAsync();

                if (heros != null && heros.Count() > 0)
                {
                    result = true;
                }
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> CompoundQuery(MoralisClient moralisClient)
        {
            bool result = false;

            try
            {
                MoralisQuery<Hero> q = await moralisClient.Query<Hero>();
                q = q.WhereLessThan("Level", 7)
                    .WhereGreaterThan("Strength", 3);

                IEnumerable<Hero> heros = await q.FindAsync();

                if (heros != null && heros.Count() > 0)
                {
                    result = true;
                }
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
    }
}
