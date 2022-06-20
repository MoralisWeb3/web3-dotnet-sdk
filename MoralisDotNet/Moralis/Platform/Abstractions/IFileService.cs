using System;
using System.IO;
using System.Threading;
using Cysharp.Threading.Tasks;
using Moralis.Platform.Objects;

namespace Moralis.Platform.Abstractions
{
    public interface IFileService
    {
        UniTask<MoralisFileState> SaveAsync(MoralisFileState state, Stream dataStream, string sessionToken, IProgress<IDataTransferLevel> progress, CancellationToken cancellationToken);
    }
}
