using System.Threading;
using Moralis.Platform.Utilities;
using System.Threading.Tasks;
using System.Net;
using System;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Objects;
using Moralis.Platform.Services.Models;

namespace Moralis.Platform.Services.ClientServices
{
    public class MoralisSessionService<TUser> : ISessionService<TUser> where TUser : MoralisUser
    {
        IMoralisCommandRunner CommandRunner { get; }

        IJsonSerializer JsonSerializer { get; }

        public MoralisSessionService(IMoralisCommandRunner commandRunner, IJsonSerializer jsonSerializer) => (CommandRunner, JsonSerializer) = (commandRunner, jsonSerializer);

        public async Task<MoralisSession> GetSessionAsync(string sessionToken, IServiceHub<TUser> serviceHub, CancellationToken cancellationToken = default)
        {
            Tuple<HttpStatusCode, string> cmdResp = await CommandRunner.RunCommandAsync(new MoralisCommand("sessions/me", method: "GET", sessionToken: sessionToken, data: null), cancellationToken: cancellationToken);
         
            MoralisSession session = default;

            if ((int)cmdResp.Item1 < 300)
            {
                session = JsonSerializer.Deserialize<MoralisSession>(cmdResp.Item2);
            }

            return session;
        }

        public async Task RevokeAsync(string sessionToken, CancellationToken cancellationToken = default)
        {
            await CommandRunner.RunCommandAsync(new MoralisCommand("logout", method: "POST", sessionToken: sessionToken, data: "{}"), cancellationToken: cancellationToken);
        }

        public async Task<MoralisSession> UpgradeToRevocableSessionAsync(string sessionToken, IServiceHub<TUser> serviceHub, CancellationToken cancellationToken = default)
        {
            Tuple<HttpStatusCode, string> cmdResp = await CommandRunner.RunCommandAsync(new MoralisCommand("upgradeToRevocableSession", method: "POST", sessionToken: sessionToken, data: "{}"), cancellationToken: cancellationToken);
              
            MoralisSession session = default;

            if ((int)cmdResp.Item1 < 300)
            {
                session = JsonSerializer.Deserialize<MoralisSession>(cmdResp.Item2);
            }

            return session;
        }

        public bool IsRevocableSessionToken(string sessionToken) => sessionToken.Contains("r:");
    }
}
