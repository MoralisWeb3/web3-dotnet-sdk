<a name='assembly'></a>

> ### :warning: Deprecated: **this repository is not being mantained.**

# Moralis

## Contents

- [AbiItem](#T-Moralis-Abi-AbiItem 'Moralis.Abi.AbiItem')
  - [Anonymous](#P-Moralis-Abi-AbiItem-Anonymous 'Moralis.Abi.AbiItem.Anonymous')
  - [Inputs](#P-Moralis-Abi-AbiItem-Inputs 'Moralis.Abi.AbiItem.Inputs')
  - [Name](#P-Moralis-Abi-AbiItem-Name 'Moralis.Abi.AbiItem.Name')
  - [Outputs](#P-Moralis-Abi-AbiItem-Outputs 'Moralis.Abi.AbiItem.Outputs')
  - [StateMutability](#P-Moralis-Abi-AbiItem-StateMutability 'Moralis.Abi.AbiItem.StateMutability')
  - [Type](#P-Moralis-Abi-AbiItem-Type 'Moralis.Abi.AbiItem.Type')
- [AbiParameter](#T-Moralis-Abi-AbiParameter 'Moralis.Abi.AbiParameter')
  - [Components](#P-Moralis-Abi-AbiParameter-Components 'Moralis.Abi.AbiParameter.Components')
  - [Indexed](#P-Moralis-Abi-AbiParameter-Indexed 'Moralis.Abi.AbiParameter.Indexed')
  - [InternalType](#P-Moralis-Abi-AbiParameter-InternalType 'Moralis.Abi.AbiParameter.InternalType')
  - [Name](#P-Moralis-Abi-AbiParameter-Name 'Moralis.Abi.AbiParameter.Name')
  - [Type](#P-Moralis-Abi-AbiParameter-Type 'Moralis.Abi.AbiParameter.Type')
- [AbiTools](#T-Moralis-Abi-AbiTools 'Moralis.Abi.AbiTools')
  - [JsonToAbiObject(json)](#M-Moralis-Abi-AbiTools-JsonToAbiObject-System-String- 'Moralis.Abi.AbiTools.JsonToAbiObject(System.String)')
- [AccountApi](#T-Moralis-SolanaApi-Api-AccountApi 'Moralis.SolanaApi.Api.AccountApi')
- [AccountApi](#T-Moralis-Web3Api-Api-AccountApi 'Moralis.Web3Api.Api.AccountApi')
  - [#ctor(apiClient)](#M-Moralis-SolanaApi-Api-AccountApi-#ctor-Moralis-Network-ApiClient- 'Moralis.SolanaApi.Api.AccountApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-SolanaApi-Api-AccountApi-#ctor-System-String- 'Moralis.SolanaApi.Api.AccountApi.#ctor(System.String)')
  - [#ctor(apiClient)](#M-Moralis-Web3Api-Api-AccountApi-#ctor-Moralis-Network-ApiClient- 'Moralis.Web3Api.Api.AccountApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-Web3Api-Api-AccountApi-#ctor-System-String- 'Moralis.Web3Api.Api.AccountApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-SolanaApi-Api-AccountApi-ApiClient 'Moralis.SolanaApi.Api.AccountApi.ApiClient')
  - [ApiClient](#P-Moralis-Web3Api-Api-AccountApi-ApiClient 'Moralis.Web3Api.Api.AccountApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-SolanaApi-Api-AccountApi-GetBasePath-System-String- 'Moralis.SolanaApi.Api.AccountApi.GetBasePath(System.String)')
  - [SetBasePath(basePath)](#M-Moralis-SolanaApi-Api-AccountApi-SetBasePath-System-String- 'Moralis.SolanaApi.Api.AccountApi.SetBasePath(System.String)')
  - [GetBasePath(basePath)](#M-Moralis-Web3Api-Api-AccountApi-GetBasePath-System-String- 'Moralis.Web3Api.Api.AccountApi.GetBasePath(System.String)')
  - [GetNFTTransfers(address,chain,format,direction,offset,limit)](#M-Moralis-Web3Api-Api-AccountApi-GetNFTTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.AccountApi.GetNFTTransfers(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTs(address,chain,format,offset,limit)](#M-Moralis-Web3Api-Api-AccountApi-GetNFTs-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.AccountApi.GetNFTs(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTsForContract(address,tokenAddress,chain,format,offset,limit)](#M-Moralis-Web3Api-Api-AccountApi-GetNFTsForContract-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.AccountApi.GetNFTsForContract(System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNativeBalance(address,chain,providerUrl,toBlock)](#M-Moralis-Web3Api-Api-AccountApi-GetNativeBalance-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Decimal}- 'Moralis.Web3Api.Api.AccountApi.GetNativeBalance(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Decimal})')
  - [GetTokenBalances(address,chain,subdomain,toBlock)](#M-Moralis-Web3Api-Api-AccountApi-GetTokenBalances-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Decimal}- 'Moralis.Web3Api.Api.AccountApi.GetTokenBalances(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Decimal})')
  - [GetTokenTransfers(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Api-AccountApi-GetTokenTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.AccountApi.GetTokenTransfers(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32})')
  - [GetTransactions(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Api-AccountApi-GetTransactions-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.AccountApi.GetTransactions(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32})')
  - [SetBasePath(basePath)](#M-Moralis-Web3Api-Api-AccountApi-SetBasePath-System-String- 'Moralis.Web3Api.Api.AccountApi.SetBasePath(System.String)')
- [ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient')
  - [#ctor(basePath)](#M-Moralis-Network-ApiClient-#ctor-System-String- 'Moralis.Network.ApiClient.#ctor(System.String)')
  - [BasePath](#P-Moralis-Network-ApiClient-BasePath 'Moralis.Network.ApiClient.BasePath')
  - [DefaultHeader](#P-Moralis-Network-ApiClient-DefaultHeader 'Moralis.Network.ApiClient.DefaultHeader')
  - [AddDefaultHeader(key,value)](#M-Moralis-Network-ApiClient-AddDefaultHeader-System-String,System-String- 'Moralis.Network.ApiClient.AddDefaultHeader(System.String,System.String)')
  - [Base64Encode(text)](#M-Moralis-Network-ApiClient-Base64Encode-System-String- 'Moralis.Network.ApiClient.Base64Encode(System.String)')
  - [CallApi(path,method,queryParams,postBody,headerParams,formParams,fileParams,authSettings)](#M-Moralis-Network-ApiClient-CallApi-System-String,System-Net-Http-HttpMethod,System-Collections-Generic-Dictionary{System-String,System-String},System-String,System-Collections-Generic-Dictionary{System-String,System-String},System-Collections-Generic-Dictionary{System-String,System-String},System-Collections-Generic-Dictionary{System-String,Moralis-Network-FileParameter},System-String[]- 'Moralis.Network.ApiClient.CallApi(System.String,System.Net.Http.HttpMethod,System.Collections.Generic.Dictionary{System.String,System.String},System.String,System.Collections.Generic.Dictionary{System.String,System.String},System.Collections.Generic.Dictionary{System.String,System.String},System.Collections.Generic.Dictionary{System.String,Moralis.Network.FileParameter},System.String[])')
  - [ConvertType(fromObject,toObject)](#M-Moralis-Network-ApiClient-ConvertType-System-Object,System-Type- 'Moralis.Network.ApiClient.ConvertType(System.Object,System.Type)')
  - [Deserialize(content,type,headers)](#M-Moralis-Network-ApiClient-Deserialize-System-String,System-Type,System-Collections-Generic-IList{Moralis-Network-Parameter}- 'Moralis.Network.ApiClient.Deserialize(System.String,System.Type,System.Collections.Generic.IList{Moralis.Network.Parameter})')
  - [EscapeString(str)](#M-Moralis-Network-ApiClient-EscapeString-System-String- 'Moralis.Network.ApiClient.EscapeString(System.String)')
  - [GetApiKeyWithPrefix(apiKeyIdentifier)](#M-Moralis-Network-ApiClient-GetApiKeyWithPrefix-System-String- 'Moralis.Network.ApiClient.GetApiKeyWithPrefix(System.String)')
  - [ParameterToFile(name,stream)](#M-Moralis-Network-ApiClient-ParameterToFile-System-String,System-IO-Stream- 'Moralis.Network.ApiClient.ParameterToFile(System.String,System.IO.Stream)')
  - [ParameterToHex(val)](#M-Moralis-Network-ApiClient-ParameterToHex-System-Int64- 'Moralis.Network.ApiClient.ParameterToHex(System.Int64)')
  - [ParameterToString(obj)](#M-Moralis-Network-ApiClient-ParameterToString-System-Object- 'Moralis.Network.ApiClient.ParameterToString(System.Object)')
  - [Serialize(obj)](#M-Moralis-Network-ApiClient-Serialize-System-Object- 'Moralis.Network.ApiClient.Serialize(System.Object)')
  - [UpdateParamsForAuth(queryParams,headerParams,authSettings)](#M-Moralis-Network-ApiClient-UpdateParamsForAuth-System-Collections-Generic-Dictionary{System-String,System-String},System-Collections-Generic-Dictionary{System-String,System-String},System-String[]- 'Moralis.Network.ApiClient.UpdateParamsForAuth(System.Collections.Generic.Dictionary{System.String,System.String},System.Collections.Generic.Dictionary{System.String,System.String},System.String[])')
- [ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException')
  - [#ctor()](#M-Moralis-Network-ApiException-#ctor 'Moralis.Network.ApiException.#ctor')
  - [#ctor(errorCode,message)](#M-Moralis-Network-ApiException-#ctor-System-Int32,System-String- 'Moralis.Network.ApiException.#ctor(System.Int32,System.String)')
  - [#ctor(errorCode,message,errorContent)](#M-Moralis-Network-ApiException-#ctor-System-Int32,System-String,System-Object- 'Moralis.Network.ApiException.#ctor(System.Int32,System.String,System.Object)')
  - [ErrorCode](#P-Moralis-Network-ApiException-ErrorCode 'Moralis.Network.ApiException.ErrorCode')
  - [ErrorContent](#P-Moralis-Network-ApiException-ErrorContent 'Moralis.Network.ApiException.ErrorContent')
- [AuthApiClient](#T-Moralis-AuthApi-Client-AuthApiClient 'Moralis.AuthApi.Client.AuthApiClient')
  - [#ctor()](#M-Moralis-AuthApi-Client-AuthApiClient-#ctor 'Moralis.AuthApi.Client.AuthApiClient.#ctor')
  - [#ctor(serverUrl)](#M-Moralis-AuthApi-Client-AuthApiClient-#ctor-System-String- 'Moralis.AuthApi.Client.AuthApiClient.#ctor(System.String)')
  - [AuthEndpoint](#P-Moralis-AuthApi-Client-AuthApiClient-AuthEndpoint 'Moralis.AuthApi.Client.AuthApiClient.AuthEndpoint')
  - [IsInitialized](#P-Moralis-AuthApi-Client-AuthApiClient-IsInitialized 'Moralis.AuthApi.Client.AuthApiClient.IsInitialized')
  - [Initialize(serverUrl)](#M-Moralis-AuthApi-Client-AuthApiClient-Initialize-System-String- 'Moralis.AuthApi.Client.AuthApiClient.Initialize(System.String)')
- [AuthenticationApi](#T-Moralis-AuthApi-Api-AuthenticationApi 'Moralis.AuthApi.Api.AuthenticationApi')
  - [#ctor(apiClient)](#M-Moralis-AuthApi-Api-AuthenticationApi-#ctor-Moralis-Network-ApiClient- 'Moralis.AuthApi.Api.AuthenticationApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-AuthApi-Api-AuthenticationApi-#ctor-System-String- 'Moralis.AuthApi.Api.AuthenticationApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-AuthApi-Api-AuthenticationApi-ApiClient 'Moralis.AuthApi.Api.AuthenticationApi.ApiClient')
  - [Challenge(request,network)](#M-Moralis-AuthApi-Api-AuthenticationApi-Challenge-Moralis-AuthApi-Models-ChallengeRequestDto,Moralis-AuthApi-Models-ChainNetworkType- 'Moralis.AuthApi.Api.AuthenticationApi.Challenge(Moralis.AuthApi.Models.ChallengeRequestDto,Moralis.AuthApi.Models.ChainNetworkType)')
  - [CompleteChallenge(request,network)](#M-Moralis-AuthApi-Api-AuthenticationApi-CompleteChallenge-Moralis-AuthApi-Models-CompleteChallengeRequestDto,Moralis-AuthApi-Models-ChainNetworkType- 'Moralis.AuthApi.Api.AuthenticationApi.CompleteChallenge(Moralis.AuthApi.Models.CompleteChallengeRequestDto,Moralis.AuthApi.Models.ChainNetworkType)')
  - [GetBasePath(basePath)](#M-Moralis-AuthApi-Api-AuthenticationApi-GetBasePath-System-String- 'Moralis.AuthApi.Api.AuthenticationApi.GetBasePath(System.String)')
  - [HealthCheck()](#M-Moralis-AuthApi-Api-AuthenticationApi-HealthCheck 'Moralis.AuthApi.Api.AuthenticationApi.HealthCheck')
  - [SetBasePath(basePath)](#M-Moralis-AuthApi-Api-AuthenticationApi-SetBasePath-System-String- 'Moralis.AuthApi.Api.AuthenticationApi.SetBasePath(System.String)')
- [BetaApi](#T-Moralis-StreamsApi-Api-BetaApi 'Moralis.StreamsApi.Api.BetaApi')
  - [#ctor(apiClient)](#M-Moralis-StreamsApi-Api-BetaApi-#ctor-Moralis-Network-ApiClient- 'Moralis.StreamsApi.Api.BetaApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-StreamsApi-Api-BetaApi-#ctor-System-String- 'Moralis.StreamsApi.Api.BetaApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-StreamsApi-Api-BetaApi-ApiClient 'Moralis.StreamsApi.Api.BetaApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-StreamsApi-Api-BetaApi-GetBasePath-System-String- 'Moralis.StreamsApi.Api.BetaApi.GetBasePath(System.String)')
  - [GetStats(limit,cursor)](#M-Moralis-StreamsApi-Api-BetaApi-GetStats 'Moralis.StreamsApi.Api.BetaApi.GetStats')
  - [SetBasePath(basePath)](#M-Moralis-StreamsApi-Api-BetaApi-SetBasePath-System-String- 'Moralis.StreamsApi.Api.BetaApi.SetBasePath(System.String)')
- [BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal')
  - [#ctor(bigDecimal,alwaysTruncate)](#M-Moralis-Unit-BigDecimal-#ctor-Moralis-Unit-BigDecimal,System-Boolean- 'Moralis.Unit.BigDecimal.#ctor(Moralis.Unit.BigDecimal,System.Boolean)')
  - [#ctor(value,alwaysTruncate)](#M-Moralis-Unit-BigDecimal-#ctor-System-Decimal,System-Boolean- 'Moralis.Unit.BigDecimal.#ctor(System.Decimal,System.Boolean)')
  - [#ctor(mantissa,exponent,alwaysTruncate)](#M-Moralis-Unit-BigDecimal-#ctor-System-Numerics-BigInteger,System-Int32,System-Boolean- 'Moralis.Unit.BigDecimal.#ctor(System.Numerics.BigInteger,System.Int32,System.Boolean)')
  - [Precision](#F-Moralis-Unit-BigDecimal-Precision 'Moralis.Unit.BigDecimal.Precision')
  - [Exponent](#P-Moralis-Unit-BigDecimal-Exponent 'Moralis.Unit.BigDecimal.Exponent')
  - [Mantissa](#P-Moralis-Unit-BigDecimal-Mantissa 'Moralis.Unit.BigDecimal.Mantissa')
  - [AlignExponent()](#M-Moralis-Unit-BigDecimal-AlignExponent-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.AlignExponent(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [CompareTo(obj)](#M-Moralis-Unit-BigDecimal-CompareTo-System-Object- 'Moralis.Unit.BigDecimal.CompareTo(System.Object)')
  - [CompareTo(other)](#M-Moralis-Unit-BigDecimal-CompareTo-Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.CompareTo(Moralis.Unit.BigDecimal)')
  - [Equals(other)](#M-Moralis-Unit-BigDecimal-Equals-Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.Equals(Moralis.Unit.BigDecimal)')
  - [Equals(obj)](#M-Moralis-Unit-BigDecimal-Equals-System-Object- 'Moralis.Unit.BigDecimal.Equals(System.Object)')
  - [Exp(exponent)](#M-Moralis-Unit-BigDecimal-Exp-System-Double- 'Moralis.Unit.BigDecimal.Exp(System.Double)')
  - [Floor()](#M-Moralis-Unit-BigDecimal-Floor 'Moralis.Unit.BigDecimal.Floor')
  - [GetHashCode()](#M-Moralis-Unit-BigDecimal-GetHashCode 'Moralis.Unit.BigDecimal.GetHashCode')
  - [NormaliseExponentBiggerThanZero()](#M-Moralis-Unit-BigDecimal-NormaliseExponentBiggerThanZero 'Moralis.Unit.BigDecimal.NormaliseExponentBiggerThanZero')
  - [Normalize()](#M-Moralis-Unit-BigDecimal-Normalize 'Moralis.Unit.BigDecimal.Normalize')
  - [Parse(value)](#M-Moralis-Unit-BigDecimal-Parse-System-String- 'Moralis.Unit.BigDecimal.Parse(System.String)')
  - [Pow(basis,exponent)](#M-Moralis-Unit-BigDecimal-Pow-System-Double,System-Double- 'Moralis.Unit.BigDecimal.Pow(System.Double,System.Double)')
  - [RoundAwayFromZero()](#M-Moralis-Unit-BigDecimal-RoundAwayFromZero-System-Int32- 'Moralis.Unit.BigDecimal.RoundAwayFromZero(System.Int32)')
  - [ToString()](#M-Moralis-Unit-BigDecimal-ToString 'Moralis.Unit.BigDecimal.ToString')
  - [ToString(formatSpecifier,format)](#M-Moralis-Unit-BigDecimal-ToString-System-String,System-IFormatProvider- 'Moralis.Unit.BigDecimal.ToString(System.String,System.IFormatProvider)')
  - [Truncate()](#M-Moralis-Unit-BigDecimal-Truncate-System-Int32- 'Moralis.Unit.BigDecimal.Truncate(System.Int32)')
  - [op_Addition(left,right)](#M-Moralis-Unit-BigDecimal-op_Addition-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_Addition(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_Decrement(value)](#M-Moralis-Unit-BigDecimal-op_Decrement-Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_Decrement(Moralis.Unit.BigDecimal)')
  - [op_Division(dividend,divisor)](#M-Moralis-Unit-BigDecimal-op_Division-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_Division(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_Equality(left,right)](#M-Moralis-Unit-BigDecimal-op_Equality-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_Equality(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_Explicit(value)](#M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-Double 'Moralis.Unit.BigDecimal.op_Explicit(Moralis.Unit.BigDecimal)~System.Double')
  - [op_Explicit(value)](#M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-Single 'Moralis.Unit.BigDecimal.op_Explicit(Moralis.Unit.BigDecimal)~System.Single')
  - [op_Explicit(value)](#M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-Decimal 'Moralis.Unit.BigDecimal.op_Explicit(Moralis.Unit.BigDecimal)~System.Decimal')
  - [op_Explicit(value)](#M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-Int32 'Moralis.Unit.BigDecimal.op_Explicit(Moralis.Unit.BigDecimal)~System.Int32')
  - [op_Explicit(value)](#M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-UInt32 'Moralis.Unit.BigDecimal.op_Explicit(Moralis.Unit.BigDecimal)~System.UInt32')
  - [op_GreaterThan(left,right)](#M-Moralis-Unit-BigDecimal-op_GreaterThan-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_GreaterThan(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_GreaterThanOrEqual(value)](#M-Moralis-Unit-BigDecimal-op_GreaterThanOrEqual-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_GreaterThanOrEqual(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_Implicit(value)](#M-Moralis-Unit-BigDecimal-op_Implicit-System-Int32-~Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal.op_Implicit(System.Int32)~Moralis.Unit.BigDecimal')
  - [op_Implicit(value)](#M-Moralis-Unit-BigDecimal-op_Implicit-System-Numerics-BigInteger-~Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal.op_Implicit(System.Numerics.BigInteger)~Moralis.Unit.BigDecimal')
  - [op_Implicit(value)](#M-Moralis-Unit-BigDecimal-op_Implicit-System-Double-~Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal.op_Implicit(System.Double)~Moralis.Unit.BigDecimal')
  - [op_Implicit(value)](#M-Moralis-Unit-BigDecimal-op_Implicit-System-Decimal-~Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal.op_Implicit(System.Decimal)~Moralis.Unit.BigDecimal')
  - [op_Increment(value)](#M-Moralis-Unit-BigDecimal-op_Increment-Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_Increment(Moralis.Unit.BigDecimal)')
  - [op_Inequality(left,right)](#M-Moralis-Unit-BigDecimal-op_Inequality-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_Inequality(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_LessThan(left,right)](#M-Moralis-Unit-BigDecimal-op_LessThan-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_LessThan(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_LessThanOrEqual(left,right)](#M-Moralis-Unit-BigDecimal-op_LessThanOrEqual-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_LessThanOrEqual(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_Multiply(left,right)](#M-Moralis-Unit-BigDecimal-op_Multiply-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_Multiply(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_Subtraction(left,right)](#M-Moralis-Unit-BigDecimal-op_Subtraction-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_Subtraction(Moralis.Unit.BigDecimal,Moralis.Unit.BigDecimal)')
  - [op_UnaryNegation(value)](#M-Moralis-Unit-BigDecimal-op_UnaryNegation-Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_UnaryNegation(Moralis.Unit.BigDecimal)')
  - [op_UnaryPlus(value)](#M-Moralis-Unit-BigDecimal-op_UnaryPlus-Moralis-Unit-BigDecimal- 'Moralis.Unit.BigDecimal.op_UnaryPlus(Moralis.Unit.BigDecimal)')
- [BigDecimalFormatter](#T-Moralis-Unit-BigDecimalFormatter 'Moralis.Unit.BigDecimalFormatter')
- [BigIntegerExtensions](#T-Moralis-Unit-BigIntegerExtensions 'Moralis.Unit.BigIntegerExtensions')
  - [NumberOfDigits(value)](#M-Moralis-Unit-BigIntegerExtensions-NumberOfDigits-System-Numerics-BigInteger- 'Moralis.Unit.BigIntegerExtensions.NumberOfDigits(System.Numerics.BigInteger)')
  - [ParseInvariant(value)](#M-Moralis-Unit-BigIntegerExtensions-ParseInvariant-System-String- 'Moralis.Unit.BigIntegerExtensions.ParseInvariant(System.String)')
- [Block](#T-Moralis-Web3Api-Models-Block 'Moralis.Web3Api.Models.Block')
  - [Difficulty](#P-Moralis-Web3Api-Models-Block-Difficulty 'Moralis.Web3Api.Models.Block.Difficulty')
  - [ExtraData](#P-Moralis-Web3Api-Models-Block-ExtraData 'Moralis.Web3Api.Models.Block.ExtraData')
  - [GasLimit](#P-Moralis-Web3Api-Models-Block-GasLimit 'Moralis.Web3Api.Models.Block.GasLimit')
  - [GasUsed](#P-Moralis-Web3Api-Models-Block-GasUsed 'Moralis.Web3Api.Models.Block.GasUsed')
  - [Hash](#P-Moralis-Web3Api-Models-Block-Hash 'Moralis.Web3Api.Models.Block.Hash')
  - [LogsBloom](#P-Moralis-Web3Api-Models-Block-LogsBloom 'Moralis.Web3Api.Models.Block.LogsBloom')
  - [Miner](#P-Moralis-Web3Api-Models-Block-Miner 'Moralis.Web3Api.Models.Block.Miner')
  - [Nonce](#P-Moralis-Web3Api-Models-Block-Nonce 'Moralis.Web3Api.Models.Block.Nonce')
  - [Number](#P-Moralis-Web3Api-Models-Block-Number 'Moralis.Web3Api.Models.Block.Number')
  - [ParentHash](#P-Moralis-Web3Api-Models-Block-ParentHash 'Moralis.Web3Api.Models.Block.ParentHash')
  - [ReceiptsRoot](#P-Moralis-Web3Api-Models-Block-ReceiptsRoot 'Moralis.Web3Api.Models.Block.ReceiptsRoot')
  - [Sha3Uncles](#P-Moralis-Web3Api-Models-Block-Sha3Uncles 'Moralis.Web3Api.Models.Block.Sha3Uncles')
  - [Size](#P-Moralis-Web3Api-Models-Block-Size 'Moralis.Web3Api.Models.Block.Size')
  - [StateRoot](#P-Moralis-Web3Api-Models-Block-StateRoot 'Moralis.Web3Api.Models.Block.StateRoot')
  - [Timestamp](#P-Moralis-Web3Api-Models-Block-Timestamp 'Moralis.Web3Api.Models.Block.Timestamp')
  - [TotalDifficulty](#P-Moralis-Web3Api-Models-Block-TotalDifficulty 'Moralis.Web3Api.Models.Block.TotalDifficulty')
  - [TransactionCount](#P-Moralis-Web3Api-Models-Block-TransactionCount 'Moralis.Web3Api.Models.Block.TransactionCount')
  - [Transactions](#P-Moralis-Web3Api-Models-Block-Transactions 'Moralis.Web3Api.Models.Block.Transactions')
  - [TransactionsRoot](#P-Moralis-Web3Api-Models-Block-TransactionsRoot 'Moralis.Web3Api.Models.Block.TransactionsRoot')
  - [ToJson()](#M-Moralis-Web3Api-Models-Block-ToJson 'Moralis.Web3Api.Models.Block.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Block-ToString 'Moralis.Web3Api.Models.Block.ToString')
- [BlockDate](#T-Moralis-Web3Api-Models-BlockDate 'Moralis.Web3Api.Models.BlockDate')
  - [Block](#P-Moralis-Web3Api-Models-BlockDate-Block 'Moralis.Web3Api.Models.BlockDate.Block')
  - [Date](#P-Moralis-Web3Api-Models-BlockDate-Date 'Moralis.Web3Api.Models.BlockDate.Date')
  - [Timestamp](#P-Moralis-Web3Api-Models-BlockDate-Timestamp 'Moralis.Web3Api.Models.BlockDate.Timestamp')
  - [ToJson()](#M-Moralis-Web3Api-Models-BlockDate-ToJson 'Moralis.Web3Api.Models.BlockDate.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-BlockDate-ToString 'Moralis.Web3Api.Models.BlockDate.ToString')
- [BlockTransaction](#T-Moralis-Web3Api-Models-BlockTransaction 'Moralis.Web3Api.Models.BlockTransaction')
  - [BlockHash](#P-Moralis-Web3Api-Models-BlockTransaction-BlockHash 'Moralis.Web3Api.Models.BlockTransaction.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-BlockTransaction-BlockNumber 'Moralis.Web3Api.Models.BlockTransaction.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-BlockTransaction-BlockTimestamp 'Moralis.Web3Api.Models.BlockTransaction.BlockTimestamp')
  - [FromAddress](#P-Moralis-Web3Api-Models-BlockTransaction-FromAddress 'Moralis.Web3Api.Models.BlockTransaction.FromAddress')
  - [Gas](#P-Moralis-Web3Api-Models-BlockTransaction-Gas 'Moralis.Web3Api.Models.BlockTransaction.Gas')
  - [GasPrice](#P-Moralis-Web3Api-Models-BlockTransaction-GasPrice 'Moralis.Web3Api.Models.BlockTransaction.GasPrice')
  - [Hash](#P-Moralis-Web3Api-Models-BlockTransaction-Hash 'Moralis.Web3Api.Models.BlockTransaction.Hash')
  - [Input](#P-Moralis-Web3Api-Models-BlockTransaction-Input 'Moralis.Web3Api.Models.BlockTransaction.Input')
  - [Logs](#P-Moralis-Web3Api-Models-BlockTransaction-Logs 'Moralis.Web3Api.Models.BlockTransaction.Logs')
  - [Nonce](#P-Moralis-Web3Api-Models-BlockTransaction-Nonce 'Moralis.Web3Api.Models.BlockTransaction.Nonce')
  - [ReceiptContractAddress](#P-Moralis-Web3Api-Models-BlockTransaction-ReceiptContractAddress 'Moralis.Web3Api.Models.BlockTransaction.ReceiptContractAddress')
  - [ReceiptCumulativeGasUsed](#P-Moralis-Web3Api-Models-BlockTransaction-ReceiptCumulativeGasUsed 'Moralis.Web3Api.Models.BlockTransaction.ReceiptCumulativeGasUsed')
  - [ReceiptGasUsed](#P-Moralis-Web3Api-Models-BlockTransaction-ReceiptGasUsed 'Moralis.Web3Api.Models.BlockTransaction.ReceiptGasUsed')
  - [ReceiptRoot](#P-Moralis-Web3Api-Models-BlockTransaction-ReceiptRoot 'Moralis.Web3Api.Models.BlockTransaction.ReceiptRoot')
  - [ReceiptStatus](#P-Moralis-Web3Api-Models-BlockTransaction-ReceiptStatus 'Moralis.Web3Api.Models.BlockTransaction.ReceiptStatus')
  - [ToAddress](#P-Moralis-Web3Api-Models-BlockTransaction-ToAddress 'Moralis.Web3Api.Models.BlockTransaction.ToAddress')
  - [TransactionIndex](#P-Moralis-Web3Api-Models-BlockTransaction-TransactionIndex 'Moralis.Web3Api.Models.BlockTransaction.TransactionIndex')
  - [Value](#P-Moralis-Web3Api-Models-BlockTransaction-Value 'Moralis.Web3Api.Models.BlockTransaction.Value')
  - [ToJson()](#M-Moralis-Web3Api-Models-BlockTransaction-ToJson 'Moralis.Web3Api.Models.BlockTransaction.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-BlockTransaction-ToString 'Moralis.Web3Api.Models.BlockTransaction.ToString')
- [ChainEntry](#T-Moralis-Models-ChainEntry 'Moralis.Models.ChainEntry')
  - [ChainId](#F-Moralis-Models-ChainEntry-ChainId 'Moralis.Models.ChainEntry.ChainId')
  - [Decimals](#F-Moralis-Models-ChainEntry-Decimals 'Moralis.Models.ChainEntry.Decimals')
  - [EnumValue](#F-Moralis-Models-ChainEntry-EnumValue 'Moralis.Models.ChainEntry.EnumValue')
  - [Name](#F-Moralis-Models-ChainEntry-Name 'Moralis.Models.ChainEntry.Name')
  - [Symbol](#F-Moralis-Models-ChainEntry-Symbol 'Moralis.Models.ChainEntry.Symbol')
- [ChainNetworkType](#T-Moralis-AuthApi-Models-ChainNetworkType 'Moralis.AuthApi.Models.ChainNetworkType')
  - [evm](#F-Moralis-AuthApi-Models-ChainNetworkType-evm 'Moralis.AuthApi.Models.ChainNetworkType.evm')
  - [solana](#F-Moralis-AuthApi-Models-ChainNetworkType-solana 'Moralis.AuthApi.Models.ChainNetworkType.solana')
- [ChallengeRequestDto](#T-Moralis-AuthApi-Models-ChallengeRequestDto 'Moralis.AuthApi.Models.ChallengeRequestDto')
  - [Address](#P-Moralis-AuthApi-Models-ChallengeRequestDto-Address 'Moralis.AuthApi.Models.ChallengeRequestDto.Address')
  - [ChainId](#P-Moralis-AuthApi-Models-ChallengeRequestDto-ChainId 'Moralis.AuthApi.Models.ChallengeRequestDto.ChainId')
  - [Domain](#P-Moralis-AuthApi-Models-ChallengeRequestDto-Domain 'Moralis.AuthApi.Models.ChallengeRequestDto.Domain')
  - [ExpirationTime](#P-Moralis-AuthApi-Models-ChallengeRequestDto-ExpirationTime 'Moralis.AuthApi.Models.ChallengeRequestDto.ExpirationTime')
  - [NotBefore](#P-Moralis-AuthApi-Models-ChallengeRequestDto-NotBefore 'Moralis.AuthApi.Models.ChallengeRequestDto.NotBefore')
  - [Resources](#P-Moralis-AuthApi-Models-ChallengeRequestDto-Resources 'Moralis.AuthApi.Models.ChallengeRequestDto.Resources')
  - [Statement](#P-Moralis-AuthApi-Models-ChallengeRequestDto-Statement 'Moralis.AuthApi.Models.ChallengeRequestDto.Statement')
  - [Timeout](#P-Moralis-AuthApi-Models-ChallengeRequestDto-Timeout 'Moralis.AuthApi.Models.ChallengeRequestDto.Timeout')
  - [Uri](#P-Moralis-AuthApi-Models-ChallengeRequestDto-Uri 'Moralis.AuthApi.Models.ChallengeRequestDto.Uri')
- [ChallengeResponseDto](#T-Moralis-AuthApi-Models-ChallengeResponseDto 'Moralis.AuthApi.Models.ChallengeResponseDto')
  - [Id](#P-Moralis-AuthApi-Models-ChallengeResponseDto-Id 'Moralis.AuthApi.Models.ChallengeResponseDto.Id')
  - [Message](#P-Moralis-AuthApi-Models-ChallengeResponseDto-Message 'Moralis.AuthApi.Models.ChallengeResponseDto.Message')
  - [ProfileId](#P-Moralis-AuthApi-Models-ChallengeResponseDto-ProfileId 'Moralis.AuthApi.Models.ChallengeResponseDto.ProfileId')
- [CompleteChallengeRequestDto](#T-Moralis-AuthApi-Models-CompleteChallengeRequestDto 'Moralis.AuthApi.Models.CompleteChallengeRequestDto')
  - [Message](#P-Moralis-AuthApi-Models-CompleteChallengeRequestDto-Message 'Moralis.AuthApi.Models.CompleteChallengeRequestDto.Message')
  - [Signature](#P-Moralis-AuthApi-Models-CompleteChallengeRequestDto-Signature 'Moralis.AuthApi.Models.CompleteChallengeRequestDto.Signature')
- [CompleteChallengeResponseDto](#T-Moralis-AuthApi-Models-CompleteChallengeResponseDto 'Moralis.AuthApi.Models.CompleteChallengeResponseDto')
  - [Address](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Address 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.Address')
  - [ChainId](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-ChainId 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.ChainId')
  - [Domain](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Domain 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.Domain')
  - [ExpirationTime](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-ExpirationTime 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.ExpirationTime')
  - [Id](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Id 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.Id')
  - [Nonce](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Nonce 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.Nonce')
  - [NotBefore](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-NotBefore 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.NotBefore')
  - [ProfileId](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-ProfileId 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.ProfileId')
  - [Resources](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Resources 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.Resources')
  - [Statement](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Statement 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.Statement')
  - [Uri](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Uri 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.Uri')
  - [Version](#P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Version 'Moralis.AuthApi.Models.CompleteChallengeResponseDto.Version')
- [Component](#T-Moralis-Abi-Component 'Moralis.Abi.Component')
  - [Components](#P-Moralis-Abi-Component-Components 'Moralis.Abi.Component.Components')
  - [Name](#P-Moralis-Abi-Component-Name 'Moralis.Abi.Component.Name')
  - [Type](#P-Moralis-Abi-Component-Type 'Moralis.Abi.Component.Type')
- [Configuration](#T-Moralis-Network-Configuration 'Moralis.Network.Configuration')
  - [ApiKey](#F-Moralis-Network-Configuration-ApiKey 'Moralis.Network.Configuration.ApiKey')
  - [ApiKeyPrefix](#F-Moralis-Network-Configuration-ApiKeyPrefix 'Moralis.Network.Configuration.ApiKeyPrefix')
  - [DefaultApiClient](#F-Moralis-Network-Configuration-DefaultApiClient 'Moralis.Network.Configuration.DefaultApiClient')
  - [Version](#F-Moralis-Network-Configuration-Version 'Moralis.Network.Configuration.Version')
  - [DateTimeFormat](#P-Moralis-Network-Configuration-DateTimeFormat 'Moralis.Network.Configuration.DateTimeFormat')
  - [Password](#P-Moralis-Network-Configuration-Password 'Moralis.Network.Configuration.Password')
  - [TempFolderPath](#P-Moralis-Network-Configuration-TempFolderPath 'Moralis.Network.Configuration.TempFolderPath')
  - [Username](#P-Moralis-Network-Configuration-Username 'Moralis.Network.Configuration.Username')
  - [ToDebugReport()](#M-Moralis-Network-Configuration-ToDebugReport 'Moralis.Network.Configuration.ToDebugReport')
- [DataFormat](#T-Moralis-Network-DataFormat 'Moralis.Network.DataFormat')
- [DatabaseStatus](#T-Moralis-AuthApi-Models-DatabaseStatus 'Moralis.AuthApi.Models.DatabaseStatus')
  - [Redis](#P-Moralis-AuthApi-Models-DatabaseStatus-Redis 'Moralis.AuthApi.Models.DatabaseStatus.Redis')
- [DatabaseStatusEntry](#T-Moralis-AuthApi-Models-DatabaseStatusEntry 'Moralis.AuthApi.Models.DatabaseStatusEntry')
  - [Status](#P-Moralis-AuthApi-Models-DatabaseStatusEntry-Status 'Moralis.AuthApi.Models.DatabaseStatusEntry.Status')
- [DefiApi](#T-Moralis-Web3Api-Api-DefiApi 'Moralis.Web3Api.Api.DefiApi')
  - [#ctor(apiClient)](#M-Moralis-Web3Api-Api-DefiApi-#ctor-Moralis-Network-ApiClient- 'Moralis.Web3Api.Api.DefiApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-Web3Api-Api-DefiApi-#ctor-System-String- 'Moralis.Web3Api.Api.DefiApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-Web3Api-Api-DefiApi-ApiClient 'Moralis.Web3Api.Api.DefiApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-Web3Api-Api-DefiApi-GetBasePath-System-String- 'Moralis.Web3Api.Api.DefiApi.GetBasePath(System.String)')
  - [GetPairAddress(exchange,token0Address,token1Address,chain,toBlock,toDate)](#M-Moralis-Web3Api-Api-DefiApi-GetPairAddress-System-String,System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String- 'Moralis.Web3Api.Api.DefiApi.GetPairAddress(System.String,System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String)')
  - [GetPairReserves(pairAddress,chain,toBlock,toDate,providerUrl)](#M-Moralis-Web3Api-Api-DefiApi-GetPairReserves-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String- 'Moralis.Web3Api.Api.DefiApi.GetPairReserves(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.String)')
  - [SetBasePath(basePath)](#M-Moralis-Web3Api-Api-DefiApi-SetBasePath-System-String- 'Moralis.Web3Api.Api.DefiApi.SetBasePath(System.String)')
- [Ens](#T-Moralis-Web3Api-Models-Ens 'Moralis.Web3Api.Models.Ens')
  - [Name](#P-Moralis-Web3Api-Models-Ens-Name 'Moralis.Web3Api.Models.Ens.Name')
  - [ToJson()](#M-Moralis-Web3Api-Models-Ens-ToJson 'Moralis.Web3Api.Models.Ens.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Ens-ToString 'Moralis.Web3Api.Models.Ens.ToString')
- [Erc20Allowance](#T-Moralis-Web3Api-Models-Erc20Allowance 'Moralis.Web3Api.Models.Erc20Allowance')
  - [Allowance](#P-Moralis-Web3Api-Models-Erc20Allowance-Allowance 'Moralis.Web3Api.Models.Erc20Allowance.Allowance')
  - [ToJson()](#M-Moralis-Web3Api-Models-Erc20Allowance-ToJson 'Moralis.Web3Api.Models.Erc20Allowance.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Erc20Allowance-ToString 'Moralis.Web3Api.Models.Erc20Allowance.ToString')
- [Erc20Metadata](#T-Moralis-Web3Api-Models-Erc20Metadata 'Moralis.Web3Api.Models.Erc20Metadata')
  - [Address](#P-Moralis-Web3Api-Models-Erc20Metadata-Address 'Moralis.Web3Api.Models.Erc20Metadata.Address')
  - [BlockNumber](#P-Moralis-Web3Api-Models-Erc20Metadata-BlockNumber 'Moralis.Web3Api.Models.Erc20Metadata.BlockNumber')
  - [Decimals](#P-Moralis-Web3Api-Models-Erc20Metadata-Decimals 'Moralis.Web3Api.Models.Erc20Metadata.Decimals')
  - [Logo](#P-Moralis-Web3Api-Models-Erc20Metadata-Logo 'Moralis.Web3Api.Models.Erc20Metadata.Logo')
  - [LogoHash](#P-Moralis-Web3Api-Models-Erc20Metadata-LogoHash 'Moralis.Web3Api.Models.Erc20Metadata.LogoHash')
  - [Name](#P-Moralis-Web3Api-Models-Erc20Metadata-Name 'Moralis.Web3Api.Models.Erc20Metadata.Name')
  - [Symbol](#P-Moralis-Web3Api-Models-Erc20Metadata-Symbol 'Moralis.Web3Api.Models.Erc20Metadata.Symbol')
  - [Thumbnail](#P-Moralis-Web3Api-Models-Erc20Metadata-Thumbnail 'Moralis.Web3Api.Models.Erc20Metadata.Thumbnail')
  - [Validated](#P-Moralis-Web3Api-Models-Erc20Metadata-Validated 'Moralis.Web3Api.Models.Erc20Metadata.Validated')
  - [ToJson()](#M-Moralis-Web3Api-Models-Erc20Metadata-ToJson 'Moralis.Web3Api.Models.Erc20Metadata.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Erc20Metadata-ToString 'Moralis.Web3Api.Models.Erc20Metadata.ToString')
- [Erc20Price](#T-Moralis-Web3Api-Models-Erc20Price 'Moralis.Web3Api.Models.Erc20Price')
  - [ExchangeAddress](#P-Moralis-Web3Api-Models-Erc20Price-ExchangeAddress 'Moralis.Web3Api.Models.Erc20Price.ExchangeAddress')
  - [ExchangeName](#P-Moralis-Web3Api-Models-Erc20Price-ExchangeName 'Moralis.Web3Api.Models.Erc20Price.ExchangeName')
  - [NativePrice](#P-Moralis-Web3Api-Models-Erc20Price-NativePrice 'Moralis.Web3Api.Models.Erc20Price.NativePrice')
  - [UsdPrice](#P-Moralis-Web3Api-Models-Erc20Price-UsdPrice 'Moralis.Web3Api.Models.Erc20Price.UsdPrice')
  - [ToJson()](#M-Moralis-Web3Api-Models-Erc20Price-ToJson 'Moralis.Web3Api.Models.Erc20Price.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Erc20Price-ToString 'Moralis.Web3Api.Models.Erc20Price.ToString')
- [Erc20TokenBalance](#T-Moralis-Web3Api-Models-Erc20TokenBalance 'Moralis.Web3Api.Models.Erc20TokenBalance')
  - [Balance](#P-Moralis-Web3Api-Models-Erc20TokenBalance-Balance 'Moralis.Web3Api.Models.Erc20TokenBalance.Balance')
  - [Decimals](#P-Moralis-Web3Api-Models-Erc20TokenBalance-Decimals 'Moralis.Web3Api.Models.Erc20TokenBalance.Decimals')
  - [Logo](#P-Moralis-Web3Api-Models-Erc20TokenBalance-Logo 'Moralis.Web3Api.Models.Erc20TokenBalance.Logo')
  - [Name](#P-Moralis-Web3Api-Models-Erc20TokenBalance-Name 'Moralis.Web3Api.Models.Erc20TokenBalance.Name')
  - [Symbol](#P-Moralis-Web3Api-Models-Erc20TokenBalance-Symbol 'Moralis.Web3Api.Models.Erc20TokenBalance.Symbol')
  - [Thumbnail](#P-Moralis-Web3Api-Models-Erc20TokenBalance-Thumbnail 'Moralis.Web3Api.Models.Erc20TokenBalance.Thumbnail')
  - [TokenAddress](#P-Moralis-Web3Api-Models-Erc20TokenBalance-TokenAddress 'Moralis.Web3Api.Models.Erc20TokenBalance.TokenAddress')
  - [RawBalance()](#M-Moralis-Web3Api-Models-Erc20TokenBalance-RawBalance 'Moralis.Web3Api.Models.Erc20TokenBalance.RawBalance')
  - [ToJson()](#M-Moralis-Web3Api-Models-Erc20TokenBalance-ToJson 'Moralis.Web3Api.Models.Erc20TokenBalance.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Erc20TokenBalance-ToString 'Moralis.Web3Api.Models.Erc20TokenBalance.ToString')
- [Erc20Transaction](#T-Moralis-Web3Api-Models-Erc20Transaction 'Moralis.Web3Api.Models.Erc20Transaction')
  - [Address](#P-Moralis-Web3Api-Models-Erc20Transaction-Address 'Moralis.Web3Api.Models.Erc20Transaction.Address')
  - [BlockHash](#P-Moralis-Web3Api-Models-Erc20Transaction-BlockHash 'Moralis.Web3Api.Models.Erc20Transaction.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-Erc20Transaction-BlockNumber 'Moralis.Web3Api.Models.Erc20Transaction.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-Erc20Transaction-BlockTimestamp 'Moralis.Web3Api.Models.Erc20Transaction.BlockTimestamp')
  - [FromAddress](#P-Moralis-Web3Api-Models-Erc20Transaction-FromAddress 'Moralis.Web3Api.Models.Erc20Transaction.FromAddress')
  - [ToAddress](#P-Moralis-Web3Api-Models-Erc20Transaction-ToAddress 'Moralis.Web3Api.Models.Erc20Transaction.ToAddress')
  - [TransactionHash](#P-Moralis-Web3Api-Models-Erc20Transaction-TransactionHash 'Moralis.Web3Api.Models.Erc20Transaction.TransactionHash')
  - [Value](#P-Moralis-Web3Api-Models-Erc20Transaction-Value 'Moralis.Web3Api.Models.Erc20Transaction.Value')
  - [RawBalance()](#M-Moralis-Web3Api-Models-Erc20Transaction-RawBalance 'Moralis.Web3Api.Models.Erc20Transaction.RawBalance')
  - [ToJson()](#M-Moralis-Web3Api-Models-Erc20Transaction-ToJson 'Moralis.Web3Api.Models.Erc20Transaction.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Erc20Transaction-ToString 'Moralis.Web3Api.Models.Erc20Transaction.ToString')
- [Erc20TransactionCollection](#T-Moralis-Web3Api-Models-Erc20TransactionCollection 'Moralis.Web3Api.Models.Erc20TransactionCollection')
  - [Page](#P-Moralis-Web3Api-Models-Erc20TransactionCollection-Page 'Moralis.Web3Api.Models.Erc20TransactionCollection.Page')
  - [PageSize](#P-Moralis-Web3Api-Models-Erc20TransactionCollection-PageSize 'Moralis.Web3Api.Models.Erc20TransactionCollection.PageSize')
  - [Result](#P-Moralis-Web3Api-Models-Erc20TransactionCollection-Result 'Moralis.Web3Api.Models.Erc20TransactionCollection.Result')
  - [Total](#P-Moralis-Web3Api-Models-Erc20TransactionCollection-Total 'Moralis.Web3Api.Models.Erc20TransactionCollection.Total')
  - [ToJson()](#M-Moralis-Web3Api-Models-Erc20TransactionCollection-ToJson 'Moralis.Web3Api.Models.Erc20TransactionCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Erc20TransactionCollection-ToString 'Moralis.Web3Api.Models.Erc20TransactionCollection.ToString')
- [Erc721Metadata](#T-Moralis-Web3Api-Models-Erc721Metadata 'Moralis.Web3Api.Models.Erc721Metadata')
  - [Name](#P-Moralis-Web3Api-Models-Erc721Metadata-Name 'Moralis.Web3Api.Models.Erc721Metadata.Name')
  - [Symbol](#P-Moralis-Web3Api-Models-Erc721Metadata-Symbol 'Moralis.Web3Api.Models.Erc721Metadata.Symbol')
  - [TokenUri](#P-Moralis-Web3Api-Models-Erc721Metadata-TokenUri 'Moralis.Web3Api.Models.Erc721Metadata.TokenUri')
  - [ToJson()](#M-Moralis-Web3Api-Models-Erc721Metadata-ToJson 'Moralis.Web3Api.Models.Erc721Metadata.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Erc721Metadata-ToString 'Moralis.Web3Api.Models.Erc721Metadata.ToString')
- [EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit')
- [Extensions](#T-Moralis-Web3Api-Models-Extensions 'Moralis.Web3Api.Models.Extensions')
  - [GetChainEntry(target)](#M-Moralis-Web3Api-Models-Extensions-GetChainEntry-Moralis-Web3Api-Models-NativeTokenBalanceBase- 'Moralis.Web3Api.Models.Extensions.GetChainEntry(Moralis.Web3Api.Models.NativeTokenBalanceBase)')
  - [ToBigNumber(val)](#M-Moralis-Web3Api-Models-Extensions-ToBigNumber-System-String- 'Moralis.Web3Api.Models.Extensions.ToBigNumber(System.String)')
  - [TokenSymbol(target)](#M-Moralis-Web3Api-Models-Extensions-TokenSymbol-Moralis-Web3Api-Models-ChainList- 'Moralis.Web3Api.Models.Extensions.TokenSymbol(Moralis.Web3Api.Models.ChainList)')
- [FileParameter](#T-Moralis-Network-FileParameter 'Moralis.Network.FileParameter')
  - [#ctor()](#M-Moralis-Network-FileParameter-#ctor 'Moralis.Network.FileParameter.#ctor')
  - [ContentLength](#P-Moralis-Network-FileParameter-ContentLength 'Moralis.Network.FileParameter.ContentLength')
  - [ContentType](#P-Moralis-Network-FileParameter-ContentType 'Moralis.Network.FileParameter.ContentType')
  - [FileName](#P-Moralis-Network-FileParameter-FileName 'Moralis.Network.FileParameter.FileName')
  - [Name](#P-Moralis-Network-FileParameter-Name 'Moralis.Network.FileParameter.Name')
  - [Writer](#P-Moralis-Network-FileParameter-Writer 'Moralis.Network.FileParameter.Writer')
  - [Create(name,data,filename,contentType)](#M-Moralis-Network-FileParameter-Create-System-String,System-Byte[],System-String,System-String- 'Moralis.Network.FileParameter.Create(System.String,System.Byte[],System.String,System.String)')
  - [Create(name,data,filename)](#M-Moralis-Network-FileParameter-Create-System-String,System-Byte[],System-String- 'Moralis.Network.FileParameter.Create(System.String,System.Byte[],System.String)')
  - [Create(name,writer,contentLength,fileName,contentType)](#M-Moralis-Network-FileParameter-Create-System-String,System-Action{System-IO-Stream},System-Int64,System-String,System-String- 'Moralis.Network.FileParameter.Create(System.String,System.Action{System.IO.Stream},System.Int64,System.String,System.String)')
- [FormattingExtensions](#T-Moralis-Unit-FormattingExtensions 'Moralis.Unit.FormattingExtensions')
  - [ToStringInvariant\`\`1()](#M-Moralis-Unit-FormattingExtensions-ToStringInvariant``1-``0- 'Moralis.Unit.FormattingExtensions.ToStringInvariant``1(``0)')
- [HealthCheckResponse](#T-Moralis-AuthApi-Models-HealthCheckResponse 'Moralis.AuthApi.Models.HealthCheckResponse')
  - [Details](#P-Moralis-AuthApi-Models-HealthCheckResponse-Details 'Moralis.AuthApi.Models.HealthCheckResponse.Details')
  - [Error](#P-Moralis-AuthApi-Models-HealthCheckResponse-Error 'Moralis.AuthApi.Models.HealthCheckResponse.Error')
  - [Info](#P-Moralis-AuthApi-Models-HealthCheckResponse-Info 'Moralis.AuthApi.Models.HealthCheckResponse.Info')
  - [Status](#P-Moralis-AuthApi-Models-HealthCheckResponse-Status 'Moralis.AuthApi.Models.HealthCheckResponse.Status')
- [HistoricalNftTransfer](#T-Moralis-Web3Api-Models-HistoricalNftTransfer 'Moralis.Web3Api.Models.HistoricalNftTransfer')
  - [Address](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-Address 'Moralis.Web3Api.Models.HistoricalNftTransfer.Address')
  - [Amounts](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-Amounts 'Moralis.Web3Api.Models.HistoricalNftTransfer.Amounts')
  - [BlockHash](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-BlockHash 'Moralis.Web3Api.Models.HistoricalNftTransfer.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-BlockNumber 'Moralis.Web3Api.Models.HistoricalNftTransfer.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-BlockTimestamp 'Moralis.Web3Api.Models.HistoricalNftTransfer.BlockTimestamp')
  - [ContractType](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-ContractType 'Moralis.Web3Api.Models.HistoricalNftTransfer.ContractType')
  - [FromAddress](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-FromAddress 'Moralis.Web3Api.Models.HistoricalNftTransfer.FromAddress')
  - [ToAddress](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-ToAddress 'Moralis.Web3Api.Models.HistoricalNftTransfer.ToAddress')
  - [TokenIds](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-TokenIds 'Moralis.Web3Api.Models.HistoricalNftTransfer.TokenIds')
  - [TransactionHash](#P-Moralis-Web3Api-Models-HistoricalNftTransfer-TransactionHash 'Moralis.Web3Api.Models.HistoricalNftTransfer.TransactionHash')
  - [ToJson()](#M-Moralis-Web3Api-Models-HistoricalNftTransfer-ToJson 'Moralis.Web3Api.Models.HistoricalNftTransfer.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-HistoricalNftTransfer-ToString 'Moralis.Web3Api.Models.HistoricalNftTransfer.ToString')
- [HistoryApi](#T-Moralis-StreamsApi-Api-HistoryApi 'Moralis.StreamsApi.Api.HistoryApi')
  - [#ctor(apiClient)](#M-Moralis-StreamsApi-Api-HistoryApi-#ctor-Moralis-Network-ApiClient- 'Moralis.StreamsApi.Api.HistoryApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-StreamsApi-Api-HistoryApi-#ctor-System-String- 'Moralis.StreamsApi.Api.HistoryApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-StreamsApi-Api-HistoryApi-ApiClient 'Moralis.StreamsApi.Api.HistoryApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-StreamsApi-Api-HistoryApi-GetBasePath-System-String- 'Moralis.StreamsApi.Api.HistoryApi.GetBasePath(System.String)')
  - [GetHistory(limit,cursor)](#M-Moralis-StreamsApi-Api-HistoryApi-GetHistory-System-Int64,System-String- 'Moralis.StreamsApi.Api.HistoryApi.GetHistory(System.Int64,System.String)')
  - [SetBasePath(basePath)](#M-Moralis-StreamsApi-Api-HistoryApi-SetBasePath-System-String- 'Moralis.StreamsApi.Api.HistoryApi.SetBasePath(System.String)')
- [IAccountApi](#T-Moralis-Web3Api-Interfaces-IAccountApi 'Moralis.Web3Api.Interfaces.IAccountApi')
  - [GetNFTTransfers(address,chain,format,direction,offset,limit)](#M-Moralis-Web3Api-Interfaces-IAccountApi-GetNFTTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.IAccountApi.GetNFTTransfers(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTs(address,chain,format,offset,limit)](#M-Moralis-Web3Api-Interfaces-IAccountApi-GetNFTs-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.IAccountApi.GetNFTs(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTsForContract(address,tokenAddress,chain,format,offset,limit)](#M-Moralis-Web3Api-Interfaces-IAccountApi-GetNFTsForContract-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.IAccountApi.GetNFTsForContract(System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNativeBalance(address,chain,providerUrl,toBlock)](#M-Moralis-Web3Api-Interfaces-IAccountApi-GetNativeBalance-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Decimal}- 'Moralis.Web3Api.Interfaces.IAccountApi.GetNativeBalance(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Decimal})')
  - [GetTokenBalances(address,chain,subdomain,toBlock)](#M-Moralis-Web3Api-Interfaces-IAccountApi-GetTokenBalances-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Decimal}- 'Moralis.Web3Api.Interfaces.IAccountApi.GetTokenBalances(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Decimal})')
  - [GetTokenTransfers(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Interfaces-IAccountApi-GetTokenTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.IAccountApi.GetTokenTransfers(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32})')
  - [GetTransactions(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Interfaces-IAccountApi-GetTransactions-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.IAccountApi.GetTransactions(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32})')
- [IAuthClientApi](#T-Moralis-AuthApi-Interfaces-IAuthClientApi 'Moralis.AuthApi.Interfaces.IAuthClientApi')
  - [AuthEndpoint](#P-Moralis-AuthApi-Interfaces-IAuthClientApi-AuthEndpoint 'Moralis.AuthApi.Interfaces.IAuthClientApi.AuthEndpoint')
  - [IsInitialized](#P-Moralis-AuthApi-Interfaces-IAuthClientApi-IsInitialized 'Moralis.AuthApi.Interfaces.IAuthClientApi.IsInitialized')
  - [Initialize(serverUrl)](#M-Moralis-AuthApi-Interfaces-IAuthClientApi-Initialize-System-String- 'Moralis.AuthApi.Interfaces.IAuthClientApi.Initialize(System.String)')
- [IAuthenticationApi](#T-Moralis-AuthApi-Interfaces-IAuthenticationApi 'Moralis.AuthApi.Interfaces.IAuthenticationApi')
  - [Challenge(request,network)](#M-Moralis-AuthApi-Interfaces-IAuthenticationApi-Challenge-Moralis-AuthApi-Models-ChallengeRequestDto,Moralis-AuthApi-Models-ChainNetworkType- 'Moralis.AuthApi.Interfaces.IAuthenticationApi.Challenge(Moralis.AuthApi.Models.ChallengeRequestDto,Moralis.AuthApi.Models.ChainNetworkType)')
  - [CompleteChallenge(request,network)](#M-Moralis-AuthApi-Interfaces-IAuthenticationApi-CompleteChallenge-Moralis-AuthApi-Models-CompleteChallengeRequestDto,Moralis-AuthApi-Models-ChainNetworkType- 'Moralis.AuthApi.Interfaces.IAuthenticationApi.CompleteChallenge(Moralis.AuthApi.Models.CompleteChallengeRequestDto,Moralis.AuthApi.Models.ChainNetworkType)')
  - [HealthCheck()](#M-Moralis-AuthApi-Interfaces-IAuthenticationApi-HealthCheck 'Moralis.AuthApi.Interfaces.IAuthenticationApi.HealthCheck')
- [IBetaApi](#T-Moralis-StreamsApi-Interfaces-IBetaApi 'Moralis.StreamsApi.Interfaces.IBetaApi')
  - [GetStats()](#M-Moralis-StreamsApi-Interfaces-IBetaApi-GetStats 'Moralis.StreamsApi.Interfaces.IBetaApi.GetStats')
- [IDefiApi](#T-Moralis-Web3Api-Interfaces-IDefiApi 'Moralis.Web3Api.Interfaces.IDefiApi')
  - [GetPairAddress(exchange,token0Address,token1Address,chain,toBlock,toDate)](#M-Moralis-Web3Api-Interfaces-IDefiApi-GetPairAddress-System-String,System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String- 'Moralis.Web3Api.Interfaces.IDefiApi.GetPairAddress(System.String,System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String)')
  - [GetPairReserves(pairAddress,chain,toBlock,toDate,providerUrl)](#M-Moralis-Web3Api-Interfaces-IDefiApi-GetPairReserves-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String- 'Moralis.Web3Api.Interfaces.IDefiApi.GetPairReserves(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.String)')
- [IHistoryApi](#T-Moralis-StreamsApi-Interfaces-IHistoryApi 'Moralis.StreamsApi.Interfaces.IHistoryApi')
  - [GetHistory(limit,cursor)](#M-Moralis-StreamsApi-Interfaces-IHistoryApi-GetHistory-System-Int64,System-String- 'Moralis.StreamsApi.Interfaces.IHistoryApi.GetHistory(System.Int64,System.String)')
  - [ReplayHistory(id)](#M-Moralis-StreamsApi-Interfaces-IHistoryApi-ReplayHistory-System-String- 'Moralis.StreamsApi.Interfaces.IHistoryApi.ReplayHistory(System.String)')
- [INativeApi](#T-Moralis-Web3Api-Interfaces-INativeApi 'Moralis.Web3Api.Interfaces.INativeApi')
  - [GetBlock(blockNumberOrHash,chain,subdomain)](#M-Moralis-Web3Api-Interfaces-INativeApi-GetBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Interfaces.INativeApi.GetBlock(System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetContractEvents(address,topic,abi,chain,subdomain,providerUrl,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Interfaces-INativeApi-GetContractEvents-System-String,System-String,System-Object,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.INativeApi.GetContractEvents(System.String,System.String,System.Object,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32})')
  - [GetDateToBlock(date,chain,providerUrl)](#M-Moralis-Web3Api-Interfaces-INativeApi-GetDateToBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Interfaces.INativeApi.GetDateToBlock(System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetLogsByAddress(address,chain,subdomain,blockNumber,fromBlock,toBlock,fromDate,toDate,topic0,topic1,topic2,topic3)](#M-Moralis-Web3Api-Interfaces-INativeApi-GetLogsByAddress-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.INativeApi.GetLogsByAddress(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTTransfersByBlock(blockNumberOrHash,chain,subdomain,offset,limit)](#M-Moralis-Web3Api-Interfaces-INativeApi-GetNFTTransfersByBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.INativeApi.GetNFTTransfersByBlock(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetTransaction(transactionHash,chain,subdomain)](#M-Moralis-Web3Api-Interfaces-INativeApi-GetTransaction-System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Interfaces.INativeApi.GetTransaction(System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [RunContractFunction\`\`1(address,functionName,abi,chain,subdomain,providerUrl)](#M-Moralis-Web3Api-Interfaces-INativeApi-RunContractFunction``1-System-String,System-String,Moralis-Web3Api-Models-RunContractDto,Moralis-Web3Api-Models-ChainList,System-String,System-String- 'Moralis.Web3Api.Interfaces.INativeApi.RunContractFunction``1(System.String,System.String,Moralis.Web3Api.Models.RunContractDto,Moralis.Web3Api.Models.ChainList,System.String,System.String)')
- [IResolveApi](#T-Moralis-Web3Api-Interfaces-IResolveApi 'Moralis.Web3Api.Interfaces.IResolveApi')
  - [ResolveAddress(address)](#M-Moralis-Web3Api-Interfaces-IResolveApi-ResolveAddress-System-String- 'Moralis.Web3Api.Interfaces.IResolveApi.ResolveAddress(System.String)')
  - [ResolveDomain(domain,currency)](#M-Moralis-Web3Api-Interfaces-IResolveApi-ResolveDomain-System-String,System-String- 'Moralis.Web3Api.Interfaces.IResolveApi.ResolveDomain(System.String,System.String)')
- [ISolanaApi](#T-Moralis-SolanaApi-Interfaces-ISolanaApi 'Moralis.SolanaApi.Interfaces.ISolanaApi')
  - [Account](#P-Moralis-SolanaApi-Interfaces-ISolanaApi-Account 'Moralis.SolanaApi.Interfaces.ISolanaApi.Account')
  - [IsInitialized](#P-Moralis-SolanaApi-Interfaces-ISolanaApi-IsInitialized 'Moralis.SolanaApi.Interfaces.ISolanaApi.IsInitialized')
  - [Nft](#P-Moralis-SolanaApi-Interfaces-ISolanaApi-Nft 'Moralis.SolanaApi.Interfaces.ISolanaApi.Nft')
  - [Initialize(serverUrl)](#M-Moralis-SolanaApi-Interfaces-ISolanaApi-Initialize-System-String- 'Moralis.SolanaApi.Interfaces.ISolanaApi.Initialize(System.String)')
- [IStorageApi](#T-Moralis-Web3Api-Interfaces-IStorageApi 'Moralis.Web3Api.Interfaces.IStorageApi')
  - [UploadFolder(abi)](#M-Moralis-Web3Api-Interfaces-IStorageApi-UploadFolder-System-Collections-Generic-List{Moralis-Web3Api-Models-IpfsFileRequest}- 'Moralis.Web3Api.Interfaces.IStorageApi.UploadFolder(System.Collections.Generic.List{Moralis.Web3Api.Models.IpfsFileRequest})')
- [IStreamsApi](#T-Moralis-StreamsApi-Interfaces-IStreamsApi 'Moralis.StreamsApi.Interfaces.IStreamsApi')
  - [BindStream(req)](#M-Moralis-StreamsApi-Interfaces-IStreamsApi-BindStream-Moralis-StreamsApi-Models-StreamBindingDto- 'Moralis.StreamsApi.Interfaces.IStreamsApi.BindStream(Moralis.StreamsApi.Models.StreamBindingDto)')
  - [DeleteStream(id)](#M-Moralis-StreamsApi-Interfaces-IStreamsApi-DeleteStream-System-String- 'Moralis.StreamsApi.Interfaces.IStreamsApi.DeleteStream(System.String)')
  - [GetStream(id)](#M-Moralis-StreamsApi-Interfaces-IStreamsApi-GetStream-System-String- 'Moralis.StreamsApi.Interfaces.IStreamsApi.GetStream(System.String)')
  - [UpdateStream(req)](#M-Moralis-StreamsApi-Interfaces-IStreamsApi-UpdateStream-Moralis-StreamsApi-Models-StreamBindingDto- 'Moralis.StreamsApi.Interfaces.IStreamsApi.UpdateStream(Moralis.StreamsApi.Models.StreamBindingDto)')
- [IStreamsApiClient](#T-Moralis-StreamsApi-Interfaces-IStreamsApiClient 'Moralis.StreamsApi.Interfaces.IStreamsApiClient')
  - [BetaEndpoint](#P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-BetaEndpoint 'Moralis.StreamsApi.Interfaces.IStreamsApiClient.BetaEndpoint')
  - [HistoryEndpoint](#P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-HistoryEndpoint 'Moralis.StreamsApi.Interfaces.IStreamsApiClient.HistoryEndpoint')
  - [IsInitialized](#P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-IsInitialized 'Moralis.StreamsApi.Interfaces.IStreamsApiClient.IsInitialized')
  - [SettingsEndpoint](#P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-SettingsEndpoint 'Moralis.StreamsApi.Interfaces.IStreamsApiClient.SettingsEndpoint')
  - [StreamsEndpoint](#P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-StreamsEndpoint 'Moralis.StreamsApi.Interfaces.IStreamsApiClient.StreamsEndpoint')
  - [Initialize(serverUrl)](#M-Moralis-StreamsApi-Interfaces-IStreamsApiClient-Initialize-System-String- 'Moralis.StreamsApi.Interfaces.IStreamsApiClient.Initialize(System.String)')
  - [VerifySignature(signature,requestBody)](#M-Moralis-StreamsApi-Interfaces-IStreamsApiClient-VerifySignature-System-String,System-String- 'Moralis.StreamsApi.Interfaces.IStreamsApiClient.VerifySignature(System.String,System.String)')
- [ITokenApi](#T-Moralis-Web3Api-Interfaces-ITokenApi 'Moralis.Web3Api.Interfaces.ITokenApi')
  - [GetAllTokenIds(address,chain,format,offset,limit)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetAllTokenIds-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.GetAllTokenIds(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetContractNFTTransfers(address,chain,format,offset,limit)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetContractNFTTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.GetContractNFTTransfers(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTLowestPrice(address,chain,days,providerUrl,marketplace)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetNFTLowestPrice-System-String,Moralis-Web3Api-Models-ChainList,System-Nullable{System-Int32},System-String,System-String- 'Moralis.Web3Api.Interfaces.ITokenApi.GetNFTLowestPrice(System.String,Moralis.Web3Api.Models.ChainList,System.Nullable{System.Int32},System.String,System.String)')
  - [GetNFTMetadata(address,chain)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetNFTMetadata-System-String,Moralis-Web3Api-Models-ChainList- 'Moralis.Web3Api.Interfaces.ITokenApi.GetNFTMetadata(System.String,Moralis.Web3Api.Models.ChainList)')
  - [GetNFTOwners(address,chain,format,offset,limit)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetNFTOwners-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.GetNFTOwners(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTTrades(address,chain,fromBlock,toBlock,fromDate,toDate,providerUrl,marketplace,offset,limit)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetNFTTrades-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-String,System-String,System-String,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.GetNFTTrades(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Int32},System.String,System.String,System.String,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNftTransfersFromToBlock(chain,fromBlock,toBlock,fromDate,toDate,format,offset,limit)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetNftTransfersFromToBlock-Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.GetNftTransfersFromToBlock(Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.String,System.Nullable{System.Int32})')
  - [GetTokenAddressTransfers(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenAddressTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.GetTokenAddressTransfers(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32})')
  - [GetTokenAllowance(address,ownerAddress,spenderAddress,chain,providerUrl)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenAllowance-System-String,System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Interfaces.ITokenApi.GetTokenAllowance(System.String,System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetTokenIdMetadata(address,tokenId,chain,format)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenIdMetadata-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Interfaces.ITokenApi.GetTokenIdMetadata(System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetTokenIdOwners(address,tokenId,chain,format,offset,limit)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenIdOwners-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.GetTokenIdOwners(System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetTokenMetadata(addresses,chain,subdomain,providerUrl)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenMetadata-System-Collections-Generic-List{System-String},Moralis-Web3Api-Models-ChainList,System-String,System-String- 'Moralis.Web3Api.Interfaces.ITokenApi.GetTokenMetadata(System.Collections.Generic.List{System.String},Moralis.Web3Api.Models.ChainList,System.String,System.String)')
  - [GetTokenMetadataBySymbol(symbols,chain,subdomain)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenMetadataBySymbol-System-Collections-Generic-List{System-String},Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Interfaces.ITokenApi.GetTokenMetadataBySymbol(System.Collections.Generic.List{System.String},Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetTokenPrice(address,chain,providerUrl,exchange,toBlock)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenPrice-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.GetTokenPrice(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetWalletTokenIdTransfers(address,tokenId,chain,format,offset,limit,order)](#M-Moralis-Web3Api-Interfaces-ITokenApi-GetWalletTokenIdTransfers-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-String- 'Moralis.Web3Api.Interfaces.ITokenApi.GetWalletTokenIdTransfers(System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32},System.String)')
  - [ReSyncMetadata(address,tokenId,chain)](#M-Moralis-Web3Api-Interfaces-ITokenApi-ReSyncMetadata-System-String,System-String,Moralis-Web3Api-Models-ChainList- 'Moralis.Web3Api.Interfaces.ITokenApi.ReSyncMetadata(System.String,System.String,Moralis.Web3Api.Models.ChainList)')
  - [SearchNFTs(q,chain,format,filter,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Interfaces-ITokenApi-SearchNFTs-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Interfaces.ITokenApi.SearchNFTs(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32})')
  - [SyncNFTContract(address,chain)](#M-Moralis-Web3Api-Interfaces-ITokenApi-SyncNFTContract-System-String,Moralis-Web3Api-Models-ChainList- 'Moralis.Web3Api.Interfaces.ITokenApi.SyncNFTContract(System.String,Moralis.Web3Api.Models.ChainList)')
- [IWeb3Api](#T-Moralis-Web3Api-Interfaces-IWeb3Api 'Moralis.Web3Api.Interfaces.IWeb3Api')
  - [Account](#P-Moralis-Web3Api-Interfaces-IWeb3Api-Account 'Moralis.Web3Api.Interfaces.IWeb3Api.Account')
  - [Defi](#P-Moralis-Web3Api-Interfaces-IWeb3Api-Defi 'Moralis.Web3Api.Interfaces.IWeb3Api.Defi')
  - [Info](#P-Moralis-Web3Api-Interfaces-IWeb3Api-Info 'Moralis.Web3Api.Interfaces.IWeb3Api.Info')
  - [IsInitialized](#P-Moralis-Web3Api-Interfaces-IWeb3Api-IsInitialized 'Moralis.Web3Api.Interfaces.IWeb3Api.IsInitialized')
  - [Native](#P-Moralis-Web3Api-Interfaces-IWeb3Api-Native 'Moralis.Web3Api.Interfaces.IWeb3Api.Native')
  - [Resolve](#P-Moralis-Web3Api-Interfaces-IWeb3Api-Resolve 'Moralis.Web3Api.Interfaces.IWeb3Api.Resolve')
  - [Storage](#P-Moralis-Web3Api-Interfaces-IWeb3Api-Storage 'Moralis.Web3Api.Interfaces.IWeb3Api.Storage')
  - [Token](#P-Moralis-Web3Api-Interfaces-IWeb3Api-Token 'Moralis.Web3Api.Interfaces.IWeb3Api.Token')
  - [Initialize(serverUrl)](#M-Moralis-Web3Api-Interfaces-IWeb3Api-Initialize-System-String- 'Moralis.Web3Api.Interfaces.IWeb3Api.Initialize(System.String)')
- [IWebClient](#T-Moralis-SolanaApi-Interfaces-IWebClient 'Moralis.SolanaApi.Interfaces.IWebClient')
- [IWebClient](#T-Moralis-Web3Api-Interfaces-IWebClient 'Moralis.Web3Api.Interfaces.IWebClient')
  - [ExecuteAsync(httpRequest)](#M-Moralis-SolanaApi-Interfaces-IWebClient-ExecuteAsync-Moralis-SolanaApi-Models-WebRequest- 'Moralis.SolanaApi.Interfaces.IWebClient.ExecuteAsync(Moralis.SolanaApi.Models.WebRequest)')
  - [ExecuteAsync(httpRequest)](#M-Moralis-Web3Api-Interfaces-IWebClient-ExecuteAsync-Moralis-Web3Api-Models-WebRequest- 'Moralis.Web3Api.Interfaces.IWebClient.ExecuteAsync(Moralis.Web3Api.Models.WebRequest)')
- [InfoApi](#T-Moralis-Web3Api-Api-InfoApi 'Moralis.Web3Api.Api.InfoApi')
  - [#ctor(apiClient)](#M-Moralis-Web3Api-Api-InfoApi-#ctor-Moralis-Network-ApiClient- 'Moralis.Web3Api.Api.InfoApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-Web3Api-Api-InfoApi-#ctor-System-String- 'Moralis.Web3Api.Api.InfoApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-Web3Api-Api-InfoApi-ApiClient 'Moralis.Web3Api.Api.InfoApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-Web3Api-Api-InfoApi-GetBasePath-System-String- 'Moralis.Web3Api.Api.InfoApi.GetBasePath(System.String)')
  - [GetEndpointWeights()](#M-Moralis-Web3Api-Api-InfoApi-GetEndpointWeights 'Moralis.Web3Api.Api.InfoApi.GetEndpointWeights')
  - [GetWeb3ApiVersion()](#M-Moralis-Web3Api-Api-InfoApi-GetWeb3ApiVersion 'Moralis.Web3Api.Api.InfoApi.GetWeb3ApiVersion')
  - [SetBasePath(basePath)](#M-Moralis-Web3Api-Api-InfoApi-SetBasePath-System-String- 'Moralis.Web3Api.Api.InfoApi.SetBasePath(System.String)')
- [IpfsFile](#T-Moralis-Web3Api-Models-IpfsFile 'Moralis.Web3Api.Models.IpfsFile')
  - [Path](#P-Moralis-Web3Api-Models-IpfsFile-Path 'Moralis.Web3Api.Models.IpfsFile.Path')
  - [ToJson()](#M-Moralis-Web3Api-Models-IpfsFile-ToJson 'Moralis.Web3Api.Models.IpfsFile.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-IpfsFile-ToString 'Moralis.Web3Api.Models.IpfsFile.ToString')
- [IpfsFileRequest](#T-Moralis-Web3Api-Models-IpfsFileRequest 'Moralis.Web3Api.Models.IpfsFileRequest')
  - [Content](#P-Moralis-Web3Api-Models-IpfsFileRequest-Content 'Moralis.Web3Api.Models.IpfsFileRequest.Content')
  - [Path](#P-Moralis-Web3Api-Models-IpfsFileRequest-Path 'Moralis.Web3Api.Models.IpfsFileRequest.Path')
  - [ToJson()](#M-Moralis-Web3Api-Models-IpfsFileRequest-ToJson 'Moralis.Web3Api.Models.IpfsFileRequest.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-IpfsFileRequest-ToString 'Moralis.Web3Api.Models.IpfsFileRequest.ToString')
- [Log](#T-Moralis-Web3Api-Models-Log 'Moralis.Web3Api.Models.Log')
  - [Address](#P-Moralis-Web3Api-Models-Log-Address 'Moralis.Web3Api.Models.Log.Address')
  - [BlockHash](#P-Moralis-Web3Api-Models-Log-BlockHash 'Moralis.Web3Api.Models.Log.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-Log-BlockNumber 'Moralis.Web3Api.Models.Log.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-Log-BlockTimestamp 'Moralis.Web3Api.Models.Log.BlockTimestamp')
  - [Data](#P-Moralis-Web3Api-Models-Log-Data 'Moralis.Web3Api.Models.Log.Data')
  - [LogIndex](#P-Moralis-Web3Api-Models-Log-LogIndex 'Moralis.Web3Api.Models.Log.LogIndex')
  - [Topic0](#P-Moralis-Web3Api-Models-Log-Topic0 'Moralis.Web3Api.Models.Log.Topic0')
  - [Topic1](#P-Moralis-Web3Api-Models-Log-Topic1 'Moralis.Web3Api.Models.Log.Topic1')
  - [Topic2](#P-Moralis-Web3Api-Models-Log-Topic2 'Moralis.Web3Api.Models.Log.Topic2')
  - [Topic3](#P-Moralis-Web3Api-Models-Log-Topic3 'Moralis.Web3Api.Models.Log.Topic3')
  - [TransactionHash](#P-Moralis-Web3Api-Models-Log-TransactionHash 'Moralis.Web3Api.Models.Log.TransactionHash')
  - [TransactionIndex](#P-Moralis-Web3Api-Models-Log-TransactionIndex 'Moralis.Web3Api.Models.Log.TransactionIndex')
  - [ToJson()](#M-Moralis-Web3Api-Models-Log-ToJson 'Moralis.Web3Api.Models.Log.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Log-ToString 'Moralis.Web3Api.Models.Log.ToString')
- [LogEvent](#T-Moralis-Web3Api-Models-LogEvent 'Moralis.Web3Api.Models.LogEvent')
  - [Address](#P-Moralis-Web3Api-Models-LogEvent-Address 'Moralis.Web3Api.Models.LogEvent.Address')
  - [BlockHash](#P-Moralis-Web3Api-Models-LogEvent-BlockHash 'Moralis.Web3Api.Models.LogEvent.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-LogEvent-BlockNumber 'Moralis.Web3Api.Models.LogEvent.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-LogEvent-BlockTimestamp 'Moralis.Web3Api.Models.LogEvent.BlockTimestamp')
  - [Data](#P-Moralis-Web3Api-Models-LogEvent-Data 'Moralis.Web3Api.Models.LogEvent.Data')
  - [TransactionHash](#P-Moralis-Web3Api-Models-LogEvent-TransactionHash 'Moralis.Web3Api.Models.LogEvent.TransactionHash')
  - [ToJson()](#M-Moralis-Web3Api-Models-LogEvent-ToJson 'Moralis.Web3Api.Models.LogEvent.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-LogEvent-ToString 'Moralis.Web3Api.Models.LogEvent.ToString')
- [LogEventByAddress](#T-Moralis-Web3Api-Models-LogEventByAddress 'Moralis.Web3Api.Models.LogEventByAddress')
  - [Address](#P-Moralis-Web3Api-Models-LogEventByAddress-Address 'Moralis.Web3Api.Models.LogEventByAddress.Address')
  - [BlockHash](#P-Moralis-Web3Api-Models-LogEventByAddress-BlockHash 'Moralis.Web3Api.Models.LogEventByAddress.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-LogEventByAddress-BlockNumber 'Moralis.Web3Api.Models.LogEventByAddress.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-LogEventByAddress-BlockTimestamp 'Moralis.Web3Api.Models.LogEventByAddress.BlockTimestamp')
  - [Data](#P-Moralis-Web3Api-Models-LogEventByAddress-Data 'Moralis.Web3Api.Models.LogEventByAddress.Data')
  - [Topic0](#P-Moralis-Web3Api-Models-LogEventByAddress-Topic0 'Moralis.Web3Api.Models.LogEventByAddress.Topic0')
  - [Topic1](#P-Moralis-Web3Api-Models-LogEventByAddress-Topic1 'Moralis.Web3Api.Models.LogEventByAddress.Topic1')
  - [Topic2](#P-Moralis-Web3Api-Models-LogEventByAddress-Topic2 'Moralis.Web3Api.Models.LogEventByAddress.Topic2')
  - [Topic3](#P-Moralis-Web3Api-Models-LogEventByAddress-Topic3 'Moralis.Web3Api.Models.LogEventByAddress.Topic3')
  - [TransactionHash](#P-Moralis-Web3Api-Models-LogEventByAddress-TransactionHash 'Moralis.Web3Api.Models.LogEventByAddress.TransactionHash')
  - [ToJson()](#M-Moralis-Web3Api-Models-LogEventByAddress-ToJson 'Moralis.Web3Api.Models.LogEventByAddress.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-LogEventByAddress-ToString 'Moralis.Web3Api.Models.LogEventByAddress.ToString')
- [Method](#T-Moralis-Network-Method 'Moralis.Network.Method')
- [MoralisAuthApiClient](#T-Moralis-AuthApi-MoralisAuthApiClient 'Moralis.AuthApi.MoralisAuthApiClient')
  - [AuthenticationApi](#P-Moralis-AuthApi-MoralisAuthApiClient-AuthenticationApi 'Moralis.AuthApi.MoralisAuthApiClient.AuthenticationApi')
  - [Initialize(apiKey,url)](#M-Moralis-AuthApi-MoralisAuthApiClient-Initialize-System-String,System-String- 'Moralis.AuthApi.MoralisAuthApiClient.Initialize(System.String,System.String)')
- [MoralisClient](#T-Moralis-MoralisClient 'Moralis.MoralisClient')
  - [#ctor(connectionData,authApi,streamsApi,web3Api)](#M-Moralis-MoralisClient-#ctor-Moralis-Models-ServerConnectionData,Moralis-AuthApi-Interfaces-IAuthClientApi,Moralis-SolanaApi-Interfaces-ISolanaApi,Moralis-StreamsApi-Interfaces-IStreamsApiClient,Moralis-Web3Api-Interfaces-IWeb3Api- 'Moralis.MoralisClient.#ctor(Moralis.Models.ServerConnectionData,Moralis.AuthApi.Interfaces.IAuthClientApi,Moralis.SolanaApi.Interfaces.ISolanaApi,Moralis.StreamsApi.Interfaces.IStreamsApiClient,Moralis.Web3Api.Interfaces.IWeb3Api)')
  - [AuthenticationApi](#P-Moralis-MoralisClient-AuthenticationApi 'Moralis.MoralisClient.AuthenticationApi')
  - [ConnectionData](#P-Moralis-MoralisClient-ConnectionData 'Moralis.MoralisClient.ConnectionData')
  - [IsInitialized](#P-Moralis-MoralisClient-IsInitialized 'Moralis.MoralisClient.IsInitialized')
  - [SolanaApi](#P-Moralis-MoralisClient-SolanaApi 'Moralis.MoralisClient.SolanaApi')
  - [StreamsApi](#P-Moralis-MoralisClient-StreamsApi 'Moralis.MoralisClient.StreamsApi')
  - [Web3Api](#P-Moralis-MoralisClient-Web3Api 'Moralis.MoralisClient.Web3Api')
  - [Start()](#M-Moralis-MoralisClient-Start 'Moralis.MoralisClient.Start')
  - [Start(connectionData)](#M-Moralis-MoralisClient-Start-Moralis-Models-ServerConnectionData- 'Moralis.MoralisClient.Start(Moralis.Models.ServerConnectionData)')
  - [Start(connectionData,authApi,streamsApi,web3Api)](#M-Moralis-MoralisClient-Start-Moralis-Models-ServerConnectionData,Moralis-AuthApi-Interfaces-IAuthClientApi,Moralis-SolanaApi-Interfaces-ISolanaApi,Moralis-StreamsApi-Interfaces-IStreamsApiClient,Moralis-Web3Api-Interfaces-IWeb3Api- 'Moralis.MoralisClient.Start(Moralis.Models.ServerConnectionData,Moralis.AuthApi.Interfaces.IAuthClientApi,Moralis.SolanaApi.Interfaces.ISolanaApi,Moralis.StreamsApi.Interfaces.IStreamsApiClient,Moralis.Web3Api.Interfaces.IWeb3Api)')
- [MoralisSolanaApiClient](#T-Moralis-SolanaApi-MoralisSolanaApiClient 'Moralis.SolanaApi.MoralisSolanaApiClient')
  - [SolanaApi](#P-Moralis-SolanaApi-MoralisSolanaApiClient-SolanaApi 'Moralis.SolanaApi.MoralisSolanaApiClient.SolanaApi')
  - [Initialize(url,apiKey)](#M-Moralis-SolanaApi-MoralisSolanaApiClient-Initialize-System-String,System-String- 'Moralis.SolanaApi.MoralisSolanaApiClient.Initialize(System.String,System.String)')
- [MoralisStreamsApiClient](#T-Moralis-StreamsApi-MoralisStreamsApiClient 'Moralis.StreamsApi.MoralisStreamsApiClient')
  - [StreamsApiClient](#P-Moralis-StreamsApi-MoralisStreamsApiClient-StreamsApiClient 'Moralis.StreamsApi.MoralisStreamsApiClient.StreamsApiClient')
  - [Initialize(apiKey,url)](#M-Moralis-StreamsApi-MoralisStreamsApiClient-Initialize-System-String,System-String- 'Moralis.StreamsApi.MoralisStreamsApiClient.Initialize(System.String,System.String)')
- [MoralisWeb3ApiClient](#T-Moralis-Web3Api-MoralisWeb3ApiClient 'Moralis.Web3Api.MoralisWeb3ApiClient')
  - [Web3Api](#P-Moralis-Web3Api-MoralisWeb3ApiClient-Web3Api 'Moralis.Web3Api.MoralisWeb3ApiClient.Web3Api')
  - [Initialize(url,apiKey)](#M-Moralis-Web3Api-MoralisWeb3ApiClient-Initialize-System-String,System-String- 'Moralis.Web3Api.MoralisWeb3ApiClient.Initialize(System.String,System.String)')
- [NativeApi](#T-Moralis-Web3Api-Api-NativeApi 'Moralis.Web3Api.Api.NativeApi')
  - [#ctor(apiClient)](#M-Moralis-Web3Api-Api-NativeApi-#ctor-Moralis-Network-ApiClient- 'Moralis.Web3Api.Api.NativeApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-Web3Api-Api-NativeApi-#ctor-System-String- 'Moralis.Web3Api.Api.NativeApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-Web3Api-Api-NativeApi-ApiClient 'Moralis.Web3Api.Api.NativeApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-Web3Api-Api-NativeApi-GetBasePath-System-String- 'Moralis.Web3Api.Api.NativeApi.GetBasePath(System.String)')
  - [GetBlock(blockNumberOrHash,chain,subdomain)](#M-Moralis-Web3Api-Api-NativeApi-GetBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Api.NativeApi.GetBlock(System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetContractEvents(address,topic,abi,chain,subdomain,providerUrl,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Api-NativeApi-GetContractEvents-System-String,System-String,System-Object,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.NativeApi.GetContractEvents(System.String,System.String,System.Object,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32})')
  - [GetDateToBlock(date,chain,providerUrl)](#M-Moralis-Web3Api-Api-NativeApi-GetDateToBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Api.NativeApi.GetDateToBlock(System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetLogsByAddress(address,chain,subdomain,blockNumber,fromBlock,toBlock,fromDate,toDate,topic0,topic1,topic2,topic3)](#M-Moralis-Web3Api-Api-NativeApi-GetLogsByAddress-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.NativeApi.GetLogsByAddress(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTTransfersByBlock(blockNumberOrHash,chain,subdomain,offset,limit)](#M-Moralis-Web3Api-Api-NativeApi-GetNFTTransfersByBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.NativeApi.GetNFTTransfersByBlock(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetTransaction(transactionHash,chain,subdomain)](#M-Moralis-Web3Api-Api-NativeApi-GetTransaction-System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Api.NativeApi.GetTransaction(System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [RunContractFunction\`\`1(address,functionName,abi,chain,subdomain,providerUrl)](#M-Moralis-Web3Api-Api-NativeApi-RunContractFunction``1-System-String,System-String,Moralis-Web3Api-Models-RunContractDto,Moralis-Web3Api-Models-ChainList,System-String,System-String- 'Moralis.Web3Api.Api.NativeApi.RunContractFunction``1(System.String,System.String,Moralis.Web3Api.Models.RunContractDto,Moralis.Web3Api.Models.ChainList,System.String,System.String)')
  - [SetBasePath(basePath)](#M-Moralis-Web3Api-Api-NativeApi-SetBasePath-System-String- 'Moralis.Web3Api.Api.NativeApi.SetBasePath(System.String)')
- [NativeBalance](#T-Moralis-Web3Api-Models-NativeBalance 'Moralis.Web3Api.Models.NativeBalance')
  - [Balance](#P-Moralis-Web3Api-Models-NativeBalance-Balance 'Moralis.Web3Api.Models.NativeBalance.Balance')
  - [RawBalance()](#M-Moralis-Web3Api-Models-NativeBalance-RawBalance 'Moralis.Web3Api.Models.NativeBalance.RawBalance')
  - [ToJson()](#M-Moralis-Web3Api-Models-NativeBalance-ToJson 'Moralis.Web3Api.Models.NativeBalance.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NativeBalance-ToString 'Moralis.Web3Api.Models.NativeBalance.ToString')
- [NativeErc20Price](#T-Moralis-Web3Api-Models-NativeErc20Price 'Moralis.Web3Api.Models.NativeErc20Price')
  - [Decimals](#P-Moralis-Web3Api-Models-NativeErc20Price-Decimals 'Moralis.Web3Api.Models.NativeErc20Price.Decimals')
  - [Name](#P-Moralis-Web3Api-Models-NativeErc20Price-Name 'Moralis.Web3Api.Models.NativeErc20Price.Name')
  - [Symbol](#P-Moralis-Web3Api-Models-NativeErc20Price-Symbol 'Moralis.Web3Api.Models.NativeErc20Price.Symbol')
  - [Value](#P-Moralis-Web3Api-Models-NativeErc20Price-Value 'Moralis.Web3Api.Models.NativeErc20Price.Value')
  - [RawBalance()](#M-Moralis-Web3Api-Models-NativeErc20Price-RawBalance 'Moralis.Web3Api.Models.NativeErc20Price.RawBalance')
  - [ToJson()](#M-Moralis-Web3Api-Models-NativeErc20Price-ToJson 'Moralis.Web3Api.Models.NativeErc20Price.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NativeErc20Price-ToString 'Moralis.Web3Api.Models.NativeErc20Price.ToString')
- [NativeTokenBalanceBase](#T-Moralis-Web3Api-Models-NativeTokenBalanceBase 'Moralis.Web3Api.Models.NativeTokenBalanceBase')
  - [ChainId](#P-Moralis-Web3Api-Models-NativeTokenBalanceBase-ChainId 'Moralis.Web3Api.Models.NativeTokenBalanceBase.ChainId')
  - [Decimals](#P-Moralis-Web3Api-Models-NativeTokenBalanceBase-Decimals 'Moralis.Web3Api.Models.NativeTokenBalanceBase.Decimals')
  - [NativeTokenBalance](#P-Moralis-Web3Api-Models-NativeTokenBalanceBase-NativeTokenBalance 'Moralis.Web3Api.Models.NativeTokenBalanceBase.NativeTokenBalance')
  - [RawBalance()](#M-Moralis-Web3Api-Models-NativeTokenBalanceBase-RawBalance 'Moralis.Web3Api.Models.NativeTokenBalanceBase.RawBalance')
- [NetworkExtensions](#T-Moralis-Network-NetworkExtensions 'Moralis.Network.NetworkExtensions')
  - [ReadAsBytes(s)](#M-Moralis-Network-NetworkExtensions-ReadAsBytes-System-IO-Stream- 'Moralis.Network.NetworkExtensions.ReadAsBytes(System.IO.Stream)')
- [NetworkTypes](#T-Moralis-Network-NetworkTypes 'Moralis.Network.NetworkTypes')
- [Nft](#T-Moralis-Web3Api-Models-Nft 'Moralis.Web3Api.Models.Nft')
  - [Amount](#P-Moralis-Web3Api-Models-Nft-Amount 'Moralis.Web3Api.Models.Nft.Amount')
  - [ContractType](#P-Moralis-Web3Api-Models-Nft-ContractType 'Moralis.Web3Api.Models.Nft.ContractType')
  - [Metadata](#P-Moralis-Web3Api-Models-Nft-Metadata 'Moralis.Web3Api.Models.Nft.Metadata')
  - [Name](#P-Moralis-Web3Api-Models-Nft-Name 'Moralis.Web3Api.Models.Nft.Name')
  - [Symbol](#P-Moralis-Web3Api-Models-Nft-Symbol 'Moralis.Web3Api.Models.Nft.Symbol')
  - [SyncedAt](#P-Moralis-Web3Api-Models-Nft-SyncedAt 'Moralis.Web3Api.Models.Nft.SyncedAt')
  - [TokenAddress](#P-Moralis-Web3Api-Models-Nft-TokenAddress 'Moralis.Web3Api.Models.Nft.TokenAddress')
  - [TokenId](#P-Moralis-Web3Api-Models-Nft-TokenId 'Moralis.Web3Api.Models.Nft.TokenId')
  - [TokenUri](#P-Moralis-Web3Api-Models-Nft-TokenUri 'Moralis.Web3Api.Models.Nft.TokenUri')
  - [ToJson()](#M-Moralis-Web3Api-Models-Nft-ToJson 'Moralis.Web3Api.Models.Nft.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Nft-ToString 'Moralis.Web3Api.Models.Nft.ToString')
- [NftApi](#T-Moralis-SolanaApi-Api-NftApi 'Moralis.SolanaApi.Api.NftApi')
  - [#ctor(apiClient)](#M-Moralis-SolanaApi-Api-NftApi-#ctor-Moralis-Network-ApiClient- 'Moralis.SolanaApi.Api.NftApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-SolanaApi-Api-NftApi-#ctor-System-String- 'Moralis.SolanaApi.Api.NftApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-SolanaApi-Api-NftApi-ApiClient 'Moralis.SolanaApi.Api.NftApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-SolanaApi-Api-NftApi-GetBasePath-System-String- 'Moralis.SolanaApi.Api.NftApi.GetBasePath(System.String)')
  - [SetBasePath(basePath)](#M-Moralis-SolanaApi-Api-NftApi-SetBasePath-System-String- 'Moralis.SolanaApi.Api.NftApi.SetBasePath(System.String)')
- [NftCollection](#T-Moralis-Web3Api-Models-NftCollection 'Moralis.Web3Api.Models.NftCollection')
  - [Page](#P-Moralis-Web3Api-Models-NftCollection-Page 'Moralis.Web3Api.Models.NftCollection.Page')
  - [PageSize](#P-Moralis-Web3Api-Models-NftCollection-PageSize 'Moralis.Web3Api.Models.NftCollection.PageSize')
  - [Result](#P-Moralis-Web3Api-Models-NftCollection-Result 'Moralis.Web3Api.Models.NftCollection.Result')
  - [Total](#P-Moralis-Web3Api-Models-NftCollection-Total 'Moralis.Web3Api.Models.NftCollection.Total')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftCollection-ToJson 'Moralis.Web3Api.Models.NftCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftCollection-ToString 'Moralis.Web3Api.Models.NftCollection.ToString')
- [NftContractMetadata](#T-Moralis-Web3Api-Models-NftContractMetadata 'Moralis.Web3Api.Models.NftContractMetadata')
  - [Abi](#P-Moralis-Web3Api-Models-NftContractMetadata-Abi 'Moralis.Web3Api.Models.NftContractMetadata.Abi')
  - [ContractType](#P-Moralis-Web3Api-Models-NftContractMetadata-ContractType 'Moralis.Web3Api.Models.NftContractMetadata.ContractType')
  - [Name](#P-Moralis-Web3Api-Models-NftContractMetadata-Name 'Moralis.Web3Api.Models.NftContractMetadata.Name')
  - [SupportsTokenUri](#P-Moralis-Web3Api-Models-NftContractMetadata-SupportsTokenUri 'Moralis.Web3Api.Models.NftContractMetadata.SupportsTokenUri')
  - [Symbol](#P-Moralis-Web3Api-Models-NftContractMetadata-Symbol 'Moralis.Web3Api.Models.NftContractMetadata.Symbol')
  - [SyncedAt](#P-Moralis-Web3Api-Models-NftContractMetadata-SyncedAt 'Moralis.Web3Api.Models.NftContractMetadata.SyncedAt')
  - [TokenAddress](#P-Moralis-Web3Api-Models-NftContractMetadata-TokenAddress 'Moralis.Web3Api.Models.NftContractMetadata.TokenAddress')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftContractMetadata-ToJson 'Moralis.Web3Api.Models.NftContractMetadata.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftContractMetadata-ToString 'Moralis.Web3Api.Models.NftContractMetadata.ToString')
- [NftContractMetadataCollection](#T-Moralis-Web3Api-Models-NftContractMetadataCollection 'Moralis.Web3Api.Models.NftContractMetadataCollection')
  - [Page](#P-Moralis-Web3Api-Models-NftContractMetadataCollection-Page 'Moralis.Web3Api.Models.NftContractMetadataCollection.Page')
  - [PageSize](#P-Moralis-Web3Api-Models-NftContractMetadataCollection-PageSize 'Moralis.Web3Api.Models.NftContractMetadataCollection.PageSize')
  - [Result](#P-Moralis-Web3Api-Models-NftContractMetadataCollection-Result 'Moralis.Web3Api.Models.NftContractMetadataCollection.Result')
  - [Total](#P-Moralis-Web3Api-Models-NftContractMetadataCollection-Total 'Moralis.Web3Api.Models.NftContractMetadataCollection.Total')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftContractMetadataCollection-ToJson 'Moralis.Web3Api.Models.NftContractMetadataCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftContractMetadataCollection-ToString 'Moralis.Web3Api.Models.NftContractMetadataCollection.ToString')
- [NftMetadata](#T-Moralis-Web3Api-Models-NftMetadata 'Moralis.Web3Api.Models.NftMetadata')
  - [ContractType](#P-Moralis-Web3Api-Models-NftMetadata-ContractType 'Moralis.Web3Api.Models.NftMetadata.ContractType')
  - [Metadata](#P-Moralis-Web3Api-Models-NftMetadata-Metadata 'Moralis.Web3Api.Models.NftMetadata.Metadata')
  - [SyncedAt](#P-Moralis-Web3Api-Models-NftMetadata-SyncedAt 'Moralis.Web3Api.Models.NftMetadata.SyncedAt')
  - [TokenAddress](#P-Moralis-Web3Api-Models-NftMetadata-TokenAddress 'Moralis.Web3Api.Models.NftMetadata.TokenAddress')
  - [TokenId](#P-Moralis-Web3Api-Models-NftMetadata-TokenId 'Moralis.Web3Api.Models.NftMetadata.TokenId')
  - [TokenUri](#P-Moralis-Web3Api-Models-NftMetadata-TokenUri 'Moralis.Web3Api.Models.NftMetadata.TokenUri')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftMetadata-ToJson 'Moralis.Web3Api.Models.NftMetadata.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftMetadata-ToString 'Moralis.Web3Api.Models.NftMetadata.ToString')
- [NftMetadataCollection](#T-Moralis-Web3Api-Models-NftMetadataCollection 'Moralis.Web3Api.Models.NftMetadataCollection')
  - [Page](#P-Moralis-Web3Api-Models-NftMetadataCollection-Page 'Moralis.Web3Api.Models.NftMetadataCollection.Page')
  - [PageSize](#P-Moralis-Web3Api-Models-NftMetadataCollection-PageSize 'Moralis.Web3Api.Models.NftMetadataCollection.PageSize')
  - [Result](#P-Moralis-Web3Api-Models-NftMetadataCollection-Result 'Moralis.Web3Api.Models.NftMetadataCollection.Result')
  - [Total](#P-Moralis-Web3Api-Models-NftMetadataCollection-Total 'Moralis.Web3Api.Models.NftMetadataCollection.Total')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftMetadataCollection-ToJson 'Moralis.Web3Api.Models.NftMetadataCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftMetadataCollection-ToString 'Moralis.Web3Api.Models.NftMetadataCollection.ToString')
- [NftOwner](#T-Moralis-Web3Api-Models-NftOwner 'Moralis.Web3Api.Models.NftOwner')
  - [Amount](#P-Moralis-Web3Api-Models-NftOwner-Amount 'Moralis.Web3Api.Models.NftOwner.Amount')
  - [BlockNumber](#P-Moralis-Web3Api-Models-NftOwner-BlockNumber 'Moralis.Web3Api.Models.NftOwner.BlockNumber')
  - [BlockNumberMinted](#P-Moralis-Web3Api-Models-NftOwner-BlockNumberMinted 'Moralis.Web3Api.Models.NftOwner.BlockNumberMinted')
  - [ContractType](#P-Moralis-Web3Api-Models-NftOwner-ContractType 'Moralis.Web3Api.Models.NftOwner.ContractType')
  - [Metadata](#P-Moralis-Web3Api-Models-NftOwner-Metadata 'Moralis.Web3Api.Models.NftOwner.Metadata')
  - [Name](#P-Moralis-Web3Api-Models-NftOwner-Name 'Moralis.Web3Api.Models.NftOwner.Name')
  - [OwnerOf](#P-Moralis-Web3Api-Models-NftOwner-OwnerOf 'Moralis.Web3Api.Models.NftOwner.OwnerOf')
  - [Symbol](#P-Moralis-Web3Api-Models-NftOwner-Symbol 'Moralis.Web3Api.Models.NftOwner.Symbol')
  - [SyncedAt](#P-Moralis-Web3Api-Models-NftOwner-SyncedAt 'Moralis.Web3Api.Models.NftOwner.SyncedAt')
  - [TokenAddress](#P-Moralis-Web3Api-Models-NftOwner-TokenAddress 'Moralis.Web3Api.Models.NftOwner.TokenAddress')
  - [TokenId](#P-Moralis-Web3Api-Models-NftOwner-TokenId 'Moralis.Web3Api.Models.NftOwner.TokenId')
  - [TokenUri](#P-Moralis-Web3Api-Models-NftOwner-TokenUri 'Moralis.Web3Api.Models.NftOwner.TokenUri')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftOwner-ToJson 'Moralis.Web3Api.Models.NftOwner.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftOwner-ToString 'Moralis.Web3Api.Models.NftOwner.ToString')
- [NftOwnerCollection](#T-Moralis-Web3Api-Models-NftOwnerCollection 'Moralis.Web3Api.Models.NftOwnerCollection')
  - [Page](#P-Moralis-Web3Api-Models-NftOwnerCollection-Page 'Moralis.Web3Api.Models.NftOwnerCollection.Page')
  - [PageSize](#P-Moralis-Web3Api-Models-NftOwnerCollection-PageSize 'Moralis.Web3Api.Models.NftOwnerCollection.PageSize')
  - [Result](#P-Moralis-Web3Api-Models-NftOwnerCollection-Result 'Moralis.Web3Api.Models.NftOwnerCollection.Result')
  - [Status](#P-Moralis-Web3Api-Models-NftOwnerCollection-Status 'Moralis.Web3Api.Models.NftOwnerCollection.Status')
  - [Total](#P-Moralis-Web3Api-Models-NftOwnerCollection-Total 'Moralis.Web3Api.Models.NftOwnerCollection.Total')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftOwnerCollection-ToJson 'Moralis.Web3Api.Models.NftOwnerCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftOwnerCollection-ToString 'Moralis.Web3Api.Models.NftOwnerCollection.ToString')
- [NftTransfer](#T-Moralis-Web3Api-Models-NftTransfer 'Moralis.Web3Api.Models.NftTransfer')
  - [Amount](#P-Moralis-Web3Api-Models-NftTransfer-Amount 'Moralis.Web3Api.Models.NftTransfer.Amount')
  - [BlockHash](#P-Moralis-Web3Api-Models-NftTransfer-BlockHash 'Moralis.Web3Api.Models.NftTransfer.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-NftTransfer-BlockNumber 'Moralis.Web3Api.Models.NftTransfer.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-NftTransfer-BlockTimestamp 'Moralis.Web3Api.Models.NftTransfer.BlockTimestamp')
  - [ContractType](#P-Moralis-Web3Api-Models-NftTransfer-ContractType 'Moralis.Web3Api.Models.NftTransfer.ContractType')
  - [FromAddress](#P-Moralis-Web3Api-Models-NftTransfer-FromAddress 'Moralis.Web3Api.Models.NftTransfer.FromAddress')
  - [LogIndex](#P-Moralis-Web3Api-Models-NftTransfer-LogIndex 'Moralis.Web3Api.Models.NftTransfer.LogIndex')
  - [Operator](#P-Moralis-Web3Api-Models-NftTransfer-Operator 'Moralis.Web3Api.Models.NftTransfer.Operator')
  - [ToAddress](#P-Moralis-Web3Api-Models-NftTransfer-ToAddress 'Moralis.Web3Api.Models.NftTransfer.ToAddress')
  - [TokenAddress](#P-Moralis-Web3Api-Models-NftTransfer-TokenAddress 'Moralis.Web3Api.Models.NftTransfer.TokenAddress')
  - [TokenId](#P-Moralis-Web3Api-Models-NftTransfer-TokenId 'Moralis.Web3Api.Models.NftTransfer.TokenId')
  - [TransactionHash](#P-Moralis-Web3Api-Models-NftTransfer-TransactionHash 'Moralis.Web3Api.Models.NftTransfer.TransactionHash')
  - [TransactionIndex](#P-Moralis-Web3Api-Models-NftTransfer-TransactionIndex 'Moralis.Web3Api.Models.NftTransfer.TransactionIndex')
  - [TransactionType](#P-Moralis-Web3Api-Models-NftTransfer-TransactionType 'Moralis.Web3Api.Models.NftTransfer.TransactionType')
  - [Value](#P-Moralis-Web3Api-Models-NftTransfer-Value 'Moralis.Web3Api.Models.NftTransfer.Value')
  - [RawBalance()](#M-Moralis-Web3Api-Models-NftTransfer-RawBalance 'Moralis.Web3Api.Models.NftTransfer.RawBalance')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftTransfer-ToJson 'Moralis.Web3Api.Models.NftTransfer.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftTransfer-ToString 'Moralis.Web3Api.Models.NftTransfer.ToString')
- [NftTransferCollection](#T-Moralis-Web3Api-Models-NftTransferCollection 'Moralis.Web3Api.Models.NftTransferCollection')
  - [BlockExists](#P-Moralis-Web3Api-Models-NftTransferCollection-BlockExists 'Moralis.Web3Api.Models.NftTransferCollection.BlockExists')
  - [Page](#P-Moralis-Web3Api-Models-NftTransferCollection-Page 'Moralis.Web3Api.Models.NftTransferCollection.Page')
  - [PageSize](#P-Moralis-Web3Api-Models-NftTransferCollection-PageSize 'Moralis.Web3Api.Models.NftTransferCollection.PageSize')
  - [Result](#P-Moralis-Web3Api-Models-NftTransferCollection-Result 'Moralis.Web3Api.Models.NftTransferCollection.Result')
  - [Total](#P-Moralis-Web3Api-Models-NftTransferCollection-Total 'Moralis.Web3Api.Models.NftTransferCollection.Total')
  - [ToJson()](#M-Moralis-Web3Api-Models-NftTransferCollection-ToJson 'Moralis.Web3Api.Models.NftTransferCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-NftTransferCollection-ToString 'Moralis.Web3Api.Models.NftTransferCollection.ToString')
- [NumberFormatting](#T-Moralis-Unit-NumberFormatting 'Moralis.Unit.NumberFormatting')
- [Parameter](#T-Moralis-Network-Parameter 'Moralis.Network.Parameter')
  - [#ctor(name,value,type)](#M-Moralis-Network-Parameter-#ctor-System-String,System-Object,Moralis-Network-ParameterType- 'Moralis.Network.Parameter.#ctor(System.String,System.Object,Moralis.Network.ParameterType)')
  - [#ctor(name,value,contentType,type)](#M-Moralis-Network-Parameter-#ctor-System-String,System-Object,System-String,Moralis-Network-ParameterType- 'Moralis.Network.Parameter.#ctor(System.String,System.Object,System.String,Moralis.Network.ParameterType)')
  - [ContentType](#P-Moralis-Network-Parameter-ContentType 'Moralis.Network.Parameter.ContentType')
  - [DataFormat](#P-Moralis-Network-Parameter-DataFormat 'Moralis.Network.Parameter.DataFormat')
  - [Name](#P-Moralis-Network-Parameter-Name 'Moralis.Network.Parameter.Name')
  - [Type](#P-Moralis-Network-Parameter-Type 'Moralis.Network.Parameter.Type')
  - [Value](#P-Moralis-Network-Parameter-Value 'Moralis.Network.Parameter.Value')
  - [Equals(other)](#M-Moralis-Network-Parameter-Equals-Moralis-Network-Parameter- 'Moralis.Network.Parameter.Equals(Moralis.Network.Parameter)')
  - [Equals(obj)](#M-Moralis-Network-Parameter-Equals-System-Object- 'Moralis.Network.Parameter.Equals(System.Object)')
  - [GetHashCode()](#M-Moralis-Network-Parameter-GetHashCode 'Moralis.Network.Parameter.GetHashCode')
  - [ToString()](#M-Moralis-Network-Parameter-ToString 'Moralis.Network.Parameter.ToString')
- [ParameterType](#T-Moralis-Network-ParameterType 'Moralis.Network.ParameterType')
- [ProjectApi](#T-Moralis-StreamsApi-Api-ProjectApi 'Moralis.StreamsApi.Api.ProjectApi')
  - [#ctor(apiClient)](#M-Moralis-StreamsApi-Api-ProjectApi-#ctor-Moralis-Network-ApiClient- 'Moralis.StreamsApi.Api.ProjectApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-StreamsApi-Api-ProjectApi-#ctor-System-String- 'Moralis.StreamsApi.Api.ProjectApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-StreamsApi-Api-ProjectApi-ApiClient 'Moralis.StreamsApi.Api.ProjectApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-StreamsApi-Api-ProjectApi-GetBasePath-System-String- 'Moralis.StreamsApi.Api.ProjectApi.GetBasePath(System.String)')
  - [GetSettings()](#M-Moralis-StreamsApi-Api-ProjectApi-GetSettings 'Moralis.StreamsApi.Api.ProjectApi.GetSettings')
  - [PostSettings(req)](#M-Moralis-StreamsApi-Api-ProjectApi-PostSettings-Moralis-StreamsApi-Models-SettingsDetail- 'Moralis.StreamsApi.Api.ProjectApi.PostSettings(Moralis.StreamsApi.Models.SettingsDetail)')
  - [SetBasePath(basePath)](#M-Moralis-StreamsApi-Api-ProjectApi-SetBasePath-System-String- 'Moralis.StreamsApi.Api.ProjectApi.SetBasePath(System.String)')
- [ReservesCollection](#T-Moralis-Web3Api-Models-ReservesCollection 'Moralis.Web3Api.Models.ReservesCollection')
  - [Reserve0](#P-Moralis-Web3Api-Models-ReservesCollection-Reserve0 'Moralis.Web3Api.Models.ReservesCollection.Reserve0')
  - [Reserve1](#P-Moralis-Web3Api-Models-ReservesCollection-Reserve1 'Moralis.Web3Api.Models.ReservesCollection.Reserve1')
  - [ToJson()](#M-Moralis-Web3Api-Models-ReservesCollection-ToJson 'Moralis.Web3Api.Models.ReservesCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-ReservesCollection-ToString 'Moralis.Web3Api.Models.ReservesCollection.ToString')
- [Resolve](#T-Moralis-Web3Api-Models-Resolve 'Moralis.Web3Api.Models.Resolve')
  - [Address](#P-Moralis-Web3Api-Models-Resolve-Address 'Moralis.Web3Api.Models.Resolve.Address')
  - [ToJson()](#M-Moralis-Web3Api-Models-Resolve-ToJson 'Moralis.Web3Api.Models.Resolve.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Resolve-ToString 'Moralis.Web3Api.Models.Resolve.ToString')
- [ResolveApi](#T-Moralis-Web3Api-Api-ResolveApi 'Moralis.Web3Api.Api.ResolveApi')
  - [#ctor(apiClient)](#M-Moralis-Web3Api-Api-ResolveApi-#ctor-Moralis-Network-ApiClient- 'Moralis.Web3Api.Api.ResolveApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-Web3Api-Api-ResolveApi-#ctor-System-String- 'Moralis.Web3Api.Api.ResolveApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-Web3Api-Api-ResolveApi-ApiClient 'Moralis.Web3Api.Api.ResolveApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-Web3Api-Api-ResolveApi-GetBasePath-System-String- 'Moralis.Web3Api.Api.ResolveApi.GetBasePath(System.String)')
  - [ResolveAddress(address)](#M-Moralis-Web3Api-Api-ResolveApi-ResolveAddress-System-String- 'Moralis.Web3Api.Api.ResolveApi.ResolveAddress(System.String)')
  - [ResolveDomain(domain,currency)](#M-Moralis-Web3Api-Api-ResolveApi-ResolveDomain-System-String,System-String- 'Moralis.Web3Api.Api.ResolveApi.ResolveDomain(System.String,System.String)')
  - [SetBasePath(basePath)](#M-Moralis-Web3Api-Api-ResolveApi-SetBasePath-System-String- 'Moralis.Web3Api.Api.ResolveApi.SetBasePath(System.String)')
- [RunContractDto](#T-Moralis-Web3Api-Models-RunContractDto 'Moralis.Web3Api.Models.RunContractDto')
  - [Abi](#P-Moralis-Web3Api-Models-RunContractDto-Abi 'Moralis.Web3Api.Models.RunContractDto.Abi')
  - [Params](#P-Moralis-Web3Api-Models-RunContractDto-Params 'Moralis.Web3Api.Models.RunContractDto.Params')
  - [ToJson()](#M-Moralis-Web3Api-Models-RunContractDto-ToJson 'Moralis.Web3Api.Models.RunContractDto.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-RunContractDto-ToString 'Moralis.Web3Api.Models.RunContractDto.ToString')
- [ServerConnectionData](#T-Moralis-Models-ServerConnectionData 'Moralis.Models.ServerConnectionData')
  - [#ctor()](#M-Moralis-Models-ServerConnectionData-#ctor 'Moralis.Models.ServerConnectionData.#ctor')
  - [ApiKey](#P-Moralis-Models-ServerConnectionData-ApiKey 'Moralis.Models.ServerConnectionData.ApiKey')
  - [AuthenticationApiUrl](#P-Moralis-Models-ServerConnectionData-AuthenticationApiUrl 'Moralis.Models.ServerConnectionData.AuthenticationApiUrl')
  - [Headers](#P-Moralis-Models-ServerConnectionData-Headers 'Moralis.Models.ServerConnectionData.Headers')
  - [MasterKey](#P-Moralis-Models-ServerConnectionData-MasterKey 'Moralis.Models.ServerConnectionData.MasterKey')
  - [SolanaApiUrl](#P-Moralis-Models-ServerConnectionData-SolanaApiUrl 'Moralis.Models.ServerConnectionData.SolanaApiUrl')
  - [StreamsApiUrl](#P-Moralis-Models-ServerConnectionData-StreamsApiUrl 'Moralis.Models.ServerConnectionData.StreamsApiUrl')
  - [Web3ApiUrl](#P-Moralis-Models-ServerConnectionData-Web3ApiUrl 'Moralis.Models.ServerConnectionData.Web3ApiUrl')
- [SolanaApiClient](#T-Moralis-SolanaApi-Client-SolanaApiClient 'Moralis.SolanaApi.Client.SolanaApiClient')
  - [#ctor(serverUrl)](#M-Moralis-SolanaApi-Client-SolanaApiClient-#ctor-System-String- 'Moralis.SolanaApi.Client.SolanaApiClient.#ctor(System.String)')
  - [Account](#P-Moralis-SolanaApi-Client-SolanaApiClient-Account 'Moralis.SolanaApi.Client.SolanaApiClient.Account')
  - [IsInitialized](#P-Moralis-SolanaApi-Client-SolanaApiClient-IsInitialized 'Moralis.SolanaApi.Client.SolanaApiClient.IsInitialized')
  - [Nft](#P-Moralis-SolanaApi-Client-SolanaApiClient-Nft 'Moralis.SolanaApi.Client.SolanaApiClient.Nft')
  - [Initialize(serverUrl)](#M-Moralis-SolanaApi-Client-SolanaApiClient-Initialize-System-String- 'Moralis.SolanaApi.Client.SolanaApiClient.Initialize(System.String)')
- [StorageApi](#T-Moralis-Web3Api-Api-StorageApi 'Moralis.Web3Api.Api.StorageApi')
  - [#ctor(apiClient)](#M-Moralis-Web3Api-Api-StorageApi-#ctor-Moralis-Network-ApiClient- 'Moralis.Web3Api.Api.StorageApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-Web3Api-Api-StorageApi-#ctor-System-String- 'Moralis.Web3Api.Api.StorageApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-Web3Api-Api-StorageApi-ApiClient 'Moralis.Web3Api.Api.StorageApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-Web3Api-Api-StorageApi-GetBasePath-System-String- 'Moralis.Web3Api.Api.StorageApi.GetBasePath(System.String)')
  - [SetBasePath(basePath)](#M-Moralis-Web3Api-Api-StorageApi-SetBasePath-System-String- 'Moralis.Web3Api.Api.StorageApi.SetBasePath(System.String)')
  - [UploadFolder(abi)](#M-Moralis-Web3Api-Api-StorageApi-UploadFolder-System-Collections-Generic-List{Moralis-Web3Api-Models-IpfsFileRequest}- 'Moralis.Web3Api.Api.StorageApi.UploadFolder(System.Collections.Generic.List{Moralis.Web3Api.Models.IpfsFileRequest})')
- [StreamsApi](#T-Moralis-StreamsApi-Api-StreamsApi 'Moralis.StreamsApi.Api.StreamsApi')
  - [#ctor(apiClient)](#M-Moralis-StreamsApi-Api-StreamsApi-#ctor-Moralis-Network-ApiClient- 'Moralis.StreamsApi.Api.StreamsApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-StreamsApi-Api-StreamsApi-#ctor-System-String- 'Moralis.StreamsApi.Api.StreamsApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-StreamsApi-Api-StreamsApi-ApiClient 'Moralis.StreamsApi.Api.StreamsApi.ApiClient')
  - [BindStream(req)](#M-Moralis-StreamsApi-Api-StreamsApi-BindStream-Moralis-StreamsApi-Models-StreamBindingDto- 'Moralis.StreamsApi.Api.StreamsApi.BindStream(Moralis.StreamsApi.Models.StreamBindingDto)')
  - [DeleteStream(streamId)](#M-Moralis-StreamsApi-Api-StreamsApi-DeleteStream-System-String- 'Moralis.StreamsApi.Api.StreamsApi.DeleteStream(System.String)')
  - [GetBasePath(basePath)](#M-Moralis-StreamsApi-Api-StreamsApi-GetBasePath-System-String- 'Moralis.StreamsApi.Api.StreamsApi.GetBasePath(System.String)')
  - [GetStream(streamId)](#M-Moralis-StreamsApi-Api-StreamsApi-GetStream-System-String- 'Moralis.StreamsApi.Api.StreamsApi.GetStream(System.String)')
  - [GetStreams()](#M-Moralis-StreamsApi-Api-StreamsApi-GetStreams-System-Int64,System-String- 'Moralis.StreamsApi.Api.StreamsApi.GetStreams(System.Int64,System.String)')
  - [SetBasePath(basePath)](#M-Moralis-StreamsApi-Api-StreamsApi-SetBasePath-System-String- 'Moralis.StreamsApi.Api.StreamsApi.SetBasePath(System.String)')
  - [UpdateStream(req)](#M-Moralis-StreamsApi-Api-StreamsApi-UpdateStream-Moralis-StreamsApi-Models-StreamBindingDto- 'Moralis.StreamsApi.Api.StreamsApi.UpdateStream(Moralis.StreamsApi.Models.StreamBindingDto)')
  - [ValidateUuid(uuid)](#M-Moralis-StreamsApi-Api-StreamsApi-ValidateUuid-System-String- 'Moralis.StreamsApi.Api.StreamsApi.ValidateUuid(System.String)')
- [StreamsApiClient](#T-Moralis-StreamsApi-Client-StreamsApiClient 'Moralis.StreamsApi.Client.StreamsApiClient')
  - [#ctor()](#M-Moralis-StreamsApi-Client-StreamsApiClient-#ctor 'Moralis.StreamsApi.Client.StreamsApiClient.#ctor')
  - [#ctor(serverUrl)](#M-Moralis-StreamsApi-Client-StreamsApiClient-#ctor-System-String- 'Moralis.StreamsApi.Client.StreamsApiClient.#ctor(System.String)')
  - [BetaEndpoint](#P-Moralis-StreamsApi-Client-StreamsApiClient-BetaEndpoint 'Moralis.StreamsApi.Client.StreamsApiClient.BetaEndpoint')
  - [HistoryEndpoint](#P-Moralis-StreamsApi-Client-StreamsApiClient-HistoryEndpoint 'Moralis.StreamsApi.Client.StreamsApiClient.HistoryEndpoint')
  - [IsInitialized](#P-Moralis-StreamsApi-Client-StreamsApiClient-IsInitialized 'Moralis.StreamsApi.Client.StreamsApiClient.IsInitialized')
  - [SettingsEndpoint](#P-Moralis-StreamsApi-Client-StreamsApiClient-SettingsEndpoint 'Moralis.StreamsApi.Client.StreamsApiClient.SettingsEndpoint')
  - [StreamsEndpoint](#P-Moralis-StreamsApi-Client-StreamsApiClient-StreamsEndpoint 'Moralis.StreamsApi.Client.StreamsApiClient.StreamsEndpoint')
  - [Initialize(serverUrl)](#M-Moralis-StreamsApi-Client-StreamsApiClient-Initialize-System-String- 'Moralis.StreamsApi.Client.StreamsApiClient.Initialize(System.String)')
  - [VerifySignature(signature,requestBody)](#M-Moralis-StreamsApi-Client-StreamsApiClient-VerifySignature-System-String,System-String- 'Moralis.StreamsApi.Client.StreamsApiClient.VerifySignature(System.String,System.String)')
- [StreamsResponse](#T-Moralis-StreamsApi-Models-StreamsResponse 'Moralis.StreamsApi.Models.StreamsResponse')
  - [Result](#P-Moralis-StreamsApi-Models-StreamsResponse-Result 'Moralis.StreamsApi.Models.StreamsResponse.Result')
  - [Total](#P-Moralis-StreamsApi-Models-StreamsResponse-Total 'Moralis.StreamsApi.Models.StreamsResponse.Total')
- [SupportedEvmChains](#T-Moralis-Models-SupportedEvmChains 'Moralis.Models.SupportedEvmChains')
  - [SupportedChains](#P-Moralis-Models-SupportedEvmChains-SupportedChains 'Moralis.Models.SupportedEvmChains.SupportedChains')
  - [FromChainList(target)](#M-Moralis-Models-SupportedEvmChains-FromChainList-Moralis-Web3Api-Models-ChainList- 'Moralis.Models.SupportedEvmChains.FromChainList(Moralis.Web3Api.Models.ChainList)')
  - [FromChainList(target)](#M-Moralis-Models-SupportedEvmChains-FromChainList-System-String- 'Moralis.Models.SupportedEvmChains.FromChainList(System.String)')
  - [FromChainList(target)](#M-Moralis-Models-SupportedEvmChains-FromChainList-System-Int32- 'Moralis.Models.SupportedEvmChains.FromChainList(System.Int32)')
  - [PopulateChainList()](#M-Moralis-Models-SupportedEvmChains-PopulateChainList 'Moralis.Models.SupportedEvmChains.PopulateChainList')
- [TokenApi](#T-Moralis-SolanaApi-Api-TokenApi 'Moralis.SolanaApi.Api.TokenApi')
- [TokenApi](#T-Moralis-Web3Api-Api-TokenApi 'Moralis.Web3Api.Api.TokenApi')
  - [#ctor(apiClient)](#M-Moralis-SolanaApi-Api-TokenApi-#ctor-Moralis-Network-ApiClient- 'Moralis.SolanaApi.Api.TokenApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-SolanaApi-Api-TokenApi-#ctor-System-String- 'Moralis.SolanaApi.Api.TokenApi.#ctor(System.String)')
  - [#ctor(apiClient)](#M-Moralis-Web3Api-Api-TokenApi-#ctor-Moralis-Network-ApiClient- 'Moralis.Web3Api.Api.TokenApi.#ctor(Moralis.Network.ApiClient)')
  - [#ctor()](#M-Moralis-Web3Api-Api-TokenApi-#ctor-System-String- 'Moralis.Web3Api.Api.TokenApi.#ctor(System.String)')
  - [ApiClient](#P-Moralis-SolanaApi-Api-TokenApi-ApiClient 'Moralis.SolanaApi.Api.TokenApi.ApiClient')
  - [ApiClient](#P-Moralis-Web3Api-Api-TokenApi-ApiClient 'Moralis.Web3Api.Api.TokenApi.ApiClient')
  - [GetBasePath(basePath)](#M-Moralis-SolanaApi-Api-TokenApi-GetBasePath-System-String- 'Moralis.SolanaApi.Api.TokenApi.GetBasePath(System.String)')
  - [SetBasePath(basePath)](#M-Moralis-SolanaApi-Api-TokenApi-SetBasePath-System-String- 'Moralis.SolanaApi.Api.TokenApi.SetBasePath(System.String)')
  - [GetAllTokenIds(address,chain,format,cursor,limit)](#M-Moralis-Web3Api-Api-TokenApi-GetAllTokenIds-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.GetAllTokenIds(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetBasePath(basePath)](#M-Moralis-Web3Api-Api-TokenApi-GetBasePath-System-String- 'Moralis.Web3Api.Api.TokenApi.GetBasePath(System.String)')
  - [GetContractNFTTransfers(address,chain,format,cursor,limit)](#M-Moralis-Web3Api-Api-TokenApi-GetContractNFTTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.GetContractNFTTransfers(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTLowestPrice(address,chain,days,providerUrl,marketplace)](#M-Moralis-Web3Api-Api-TokenApi-GetNFTLowestPrice-System-String,Moralis-Web3Api-Models-ChainList,System-Nullable{System-Int32},System-String,System-String- 'Moralis.Web3Api.Api.TokenApi.GetNFTLowestPrice(System.String,Moralis.Web3Api.Models.ChainList,System.Nullable{System.Int32},System.String,System.String)')
  - [GetNFTMetadata(address,chain)](#M-Moralis-Web3Api-Api-TokenApi-GetNFTMetadata-System-String,Moralis-Web3Api-Models-ChainList- 'Moralis.Web3Api.Api.TokenApi.GetNFTMetadata(System.String,Moralis.Web3Api.Models.ChainList)')
  - [GetNFTOwners(address,chain,format,cursor,limit)](#M-Moralis-Web3Api-Api-TokenApi-GetNFTOwners-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.GetNFTOwners(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNFTTrades(address,chain,fromBlock,toBlock,fromDate,toDate,providerUrl,marketplace,cursor,limit)](#M-Moralis-Web3Api-Api-TokenApi-GetNFTTrades-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-String,System-String,System-String,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.GetNFTTrades(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Int32},System.String,System.String,System.String,System.String,System.String,System.Nullable{System.Int32})')
  - [GetNftTransfersFromToBlock(chain,fromBlock,toBlock,fromDate,toDate,format,cursor,limit)](#M-Moralis-Web3Api-Api-TokenApi-GetNftTransfersFromToBlock-Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.GetNftTransfersFromToBlock(Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.String,System.Nullable{System.Int32})')
  - [GetTokenAddressTransfers(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit)](#M-Moralis-Web3Api-Api-TokenApi-GetTokenAddressTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.GetTokenAddressTransfers(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32})')
  - [GetTokenAllowance(address,ownerAddress,spenderAddress,chain,providerUrl)](#M-Moralis-Web3Api-Api-TokenApi-GetTokenAllowance-System-String,System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Api.TokenApi.GetTokenAllowance(System.String,System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetTokenIdMetadata(address,tokenId,chain,format)](#M-Moralis-Web3Api-Api-TokenApi-GetTokenIdMetadata-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Api.TokenApi.GetTokenIdMetadata(System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetTokenIdOwners(address,tokenId,chain,format,cursor,limit)](#M-Moralis-Web3Api-Api-TokenApi-GetTokenIdOwners-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.GetTokenIdOwners(System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetTokenMetadata(addresses,chain,subdomain,providerUrl)](#M-Moralis-Web3Api-Api-TokenApi-GetTokenMetadata-System-Collections-Generic-List{System-String},Moralis-Web3Api-Models-ChainList,System-String,System-String- 'Moralis.Web3Api.Api.TokenApi.GetTokenMetadata(System.Collections.Generic.List{System.String},Moralis.Web3Api.Models.ChainList,System.String,System.String)')
  - [GetTokenMetadataBySymbol(symbols,chain,subdomain)](#M-Moralis-Web3Api-Api-TokenApi-GetTokenMetadataBySymbol-System-Collections-Generic-List{System-String},Moralis-Web3Api-Models-ChainList,System-String- 'Moralis.Web3Api.Api.TokenApi.GetTokenMetadataBySymbol(System.Collections.Generic.List{System.String},Moralis.Web3Api.Models.ChainList,System.String)')
  - [GetTokenPrice(address,chain,providerUrl,exchange,toBlock)](#M-Moralis-Web3Api-Api-TokenApi-GetTokenPrice-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.GetTokenPrice(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32})')
  - [GetWalletTokenIdTransfers(address,tokenId,chain,format,cursor,limit,order)](#M-Moralis-Web3Api-Api-TokenApi-GetWalletTokenIdTransfers-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-String- 'Moralis.Web3Api.Api.TokenApi.GetWalletTokenIdTransfers(System.String,System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.Nullable{System.Int32},System.String)')
  - [ReSyncMetadata(address,tokenId,chain)](#M-Moralis-Web3Api-Api-TokenApi-ReSyncMetadata-System-String,System-String,Moralis-Web3Api-Models-ChainList- 'Moralis.Web3Api.Api.TokenApi.ReSyncMetadata(System.String,System.String,Moralis.Web3Api.Models.ChainList)')
  - [SearchNFTs(q,chain,format,filter,fromBlock,toBlock,fromDate,toDate,cursor,limit)](#M-Moralis-Web3Api-Api-TokenApi-SearchNFTs-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}- 'Moralis.Web3Api.Api.TokenApi.SearchNFTs(System.String,Moralis.Web3Api.Models.ChainList,System.String,System.String,System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String,System.String,System.Nullable{System.Int32})')
  - [SetBasePath(basePath)](#M-Moralis-Web3Api-Api-TokenApi-SetBasePath-System-String- 'Moralis.Web3Api.Api.TokenApi.SetBasePath(System.String)')
  - [SyncNFTContract(address,chain)](#M-Moralis-Web3Api-Api-TokenApi-SyncNFTContract-System-String,Moralis-Web3Api-Models-ChainList- 'Moralis.Web3Api.Api.TokenApi.SyncNFTContract(System.String,Moralis.Web3Api.Models.ChainList)')
- [Trade](#T-Moralis-Web3Api-Models-Trade 'Moralis.Web3Api.Models.Trade')
  - [BlockHash](#P-Moralis-Web3Api-Models-Trade-BlockHash 'Moralis.Web3Api.Models.Trade.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-Trade-BlockNumber 'Moralis.Web3Api.Models.Trade.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-Trade-BlockTimestamp 'Moralis.Web3Api.Models.Trade.BlockTimestamp')
  - [BuyerAddress](#P-Moralis-Web3Api-Models-Trade-BuyerAddress 'Moralis.Web3Api.Models.Trade.BuyerAddress')
  - [MarketplaceAddress](#P-Moralis-Web3Api-Models-Trade-MarketplaceAddress 'Moralis.Web3Api.Models.Trade.MarketplaceAddress')
  - [Price](#P-Moralis-Web3Api-Models-Trade-Price 'Moralis.Web3Api.Models.Trade.Price')
  - [SellerAddress](#P-Moralis-Web3Api-Models-Trade-SellerAddress 'Moralis.Web3Api.Models.Trade.SellerAddress')
  - [TokenIds](#P-Moralis-Web3Api-Models-Trade-TokenIds 'Moralis.Web3Api.Models.Trade.TokenIds')
  - [TransactionHash](#P-Moralis-Web3Api-Models-Trade-TransactionHash 'Moralis.Web3Api.Models.Trade.TransactionHash')
  - [TransactionIndex](#P-Moralis-Web3Api-Models-Trade-TransactionIndex 'Moralis.Web3Api.Models.Trade.TransactionIndex')
  - [RawBalance()](#M-Moralis-Web3Api-Models-Trade-RawBalance 'Moralis.Web3Api.Models.Trade.RawBalance')
  - [ToJson()](#M-Moralis-Web3Api-Models-Trade-ToJson 'Moralis.Web3Api.Models.Trade.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Trade-ToString 'Moralis.Web3Api.Models.Trade.ToString')
- [TradeCollection](#T-Moralis-Web3Api-Models-TradeCollection 'Moralis.Web3Api.Models.TradeCollection')
  - [Page](#P-Moralis-Web3Api-Models-TradeCollection-Page 'Moralis.Web3Api.Models.TradeCollection.Page')
  - [PageSize](#P-Moralis-Web3Api-Models-TradeCollection-PageSize 'Moralis.Web3Api.Models.TradeCollection.PageSize')
  - [Result](#P-Moralis-Web3Api-Models-TradeCollection-Result 'Moralis.Web3Api.Models.TradeCollection.Result')
  - [Total](#P-Moralis-Web3Api-Models-TradeCollection-Total 'Moralis.Web3Api.Models.TradeCollection.Total')
  - [ToJson()](#M-Moralis-Web3Api-Models-TradeCollection-ToJson 'Moralis.Web3Api.Models.TradeCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-TradeCollection-ToString 'Moralis.Web3Api.Models.TradeCollection.ToString')
- [TradesCollection](#T-Moralis-Web3Api-Models-TradesCollection 'Moralis.Web3Api.Models.TradesCollection')
  - [BlockNumber](#P-Moralis-Web3Api-Models-TradesCollection-BlockNumber 'Moralis.Web3Api.Models.TradesCollection.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-TradesCollection-BlockTimestamp 'Moralis.Web3Api.Models.TradesCollection.BlockTimestamp')
  - [FromAddress](#P-Moralis-Web3Api-Models-TradesCollection-FromAddress 'Moralis.Web3Api.Models.TradesCollection.FromAddress')
  - [Gas](#P-Moralis-Web3Api-Models-TradesCollection-Gas 'Moralis.Web3Api.Models.TradesCollection.Gas')
  - [GasPrice](#P-Moralis-Web3Api-Models-TradesCollection-GasPrice 'Moralis.Web3Api.Models.TradesCollection.GasPrice')
  - [ReceiptCumulativeGasUsed](#P-Moralis-Web3Api-Models-TradesCollection-ReceiptCumulativeGasUsed 'Moralis.Web3Api.Models.TradesCollection.ReceiptCumulativeGasUsed')
  - [ReceiptGasUsed](#P-Moralis-Web3Api-Models-TradesCollection-ReceiptGasUsed 'Moralis.Web3Api.Models.TradesCollection.ReceiptGasUsed')
  - [ToAddress](#P-Moralis-Web3Api-Models-TradesCollection-ToAddress 'Moralis.Web3Api.Models.TradesCollection.ToAddress')
  - [TokenIds](#P-Moralis-Web3Api-Models-TradesCollection-TokenIds 'Moralis.Web3Api.Models.TradesCollection.TokenIds')
  - [TransactionHash](#P-Moralis-Web3Api-Models-TradesCollection-TransactionHash 'Moralis.Web3Api.Models.TradesCollection.TransactionHash')
  - [TransactionIndex](#P-Moralis-Web3Api-Models-TradesCollection-TransactionIndex 'Moralis.Web3Api.Models.TradesCollection.TransactionIndex')
  - [Value](#P-Moralis-Web3Api-Models-TradesCollection-Value 'Moralis.Web3Api.Models.TradesCollection.Value')
  - [ToJson()](#M-Moralis-Web3Api-Models-TradesCollection-ToJson 'Moralis.Web3Api.Models.TradesCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-TradesCollection-ToString 'Moralis.Web3Api.Models.TradesCollection.ToString')
- [Transaction](#T-Moralis-Web3Api-Models-Transaction 'Moralis.Web3Api.Models.Transaction')
  - [BlockHash](#P-Moralis-Web3Api-Models-Transaction-BlockHash 'Moralis.Web3Api.Models.Transaction.BlockHash')
  - [BlockNumber](#P-Moralis-Web3Api-Models-Transaction-BlockNumber 'Moralis.Web3Api.Models.Transaction.BlockNumber')
  - [BlockTimestamp](#P-Moralis-Web3Api-Models-Transaction-BlockTimestamp 'Moralis.Web3Api.Models.Transaction.BlockTimestamp')
  - [FromAddress](#P-Moralis-Web3Api-Models-Transaction-FromAddress 'Moralis.Web3Api.Models.Transaction.FromAddress')
  - [Gas](#P-Moralis-Web3Api-Models-Transaction-Gas 'Moralis.Web3Api.Models.Transaction.Gas')
  - [GasPrice](#P-Moralis-Web3Api-Models-Transaction-GasPrice 'Moralis.Web3Api.Models.Transaction.GasPrice')
  - [Hash](#P-Moralis-Web3Api-Models-Transaction-Hash 'Moralis.Web3Api.Models.Transaction.Hash')
  - [Input](#P-Moralis-Web3Api-Models-Transaction-Input 'Moralis.Web3Api.Models.Transaction.Input')
  - [Nonce](#P-Moralis-Web3Api-Models-Transaction-Nonce 'Moralis.Web3Api.Models.Transaction.Nonce')
  - [ReceiptContractAddress](#P-Moralis-Web3Api-Models-Transaction-ReceiptContractAddress 'Moralis.Web3Api.Models.Transaction.ReceiptContractAddress')
  - [ReceiptCumulativeGasUsed](#P-Moralis-Web3Api-Models-Transaction-ReceiptCumulativeGasUsed 'Moralis.Web3Api.Models.Transaction.ReceiptCumulativeGasUsed')
  - [ReceiptGasUsed](#P-Moralis-Web3Api-Models-Transaction-ReceiptGasUsed 'Moralis.Web3Api.Models.Transaction.ReceiptGasUsed')
  - [ReceiptRoot](#P-Moralis-Web3Api-Models-Transaction-ReceiptRoot 'Moralis.Web3Api.Models.Transaction.ReceiptRoot')
  - [ReceiptStatus](#P-Moralis-Web3Api-Models-Transaction-ReceiptStatus 'Moralis.Web3Api.Models.Transaction.ReceiptStatus')
  - [ToAddress](#P-Moralis-Web3Api-Models-Transaction-ToAddress 'Moralis.Web3Api.Models.Transaction.ToAddress')
  - [TransactionIndex](#P-Moralis-Web3Api-Models-Transaction-TransactionIndex 'Moralis.Web3Api.Models.Transaction.TransactionIndex')
  - [Value](#P-Moralis-Web3Api-Models-Transaction-Value 'Moralis.Web3Api.Models.Transaction.Value')
  - [RawBalance()](#M-Moralis-Web3Api-Models-Transaction-RawBalance 'Moralis.Web3Api.Models.Transaction.RawBalance')
  - [ToJson()](#M-Moralis-Web3Api-Models-Transaction-ToJson 'Moralis.Web3Api.Models.Transaction.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-Transaction-ToString 'Moralis.Web3Api.Models.Transaction.ToString')
- [TransactionCollection](#T-Moralis-Web3Api-Models-TransactionCollection 'Moralis.Web3Api.Models.TransactionCollection')
  - [Page](#P-Moralis-Web3Api-Models-TransactionCollection-Page 'Moralis.Web3Api.Models.TransactionCollection.Page')
  - [PageSize](#P-Moralis-Web3Api-Models-TransactionCollection-PageSize 'Moralis.Web3Api.Models.TransactionCollection.PageSize')
  - [Result](#P-Moralis-Web3Api-Models-TransactionCollection-Result 'Moralis.Web3Api.Models.TransactionCollection.Result')
  - [Total](#P-Moralis-Web3Api-Models-TransactionCollection-Total 'Moralis.Web3Api.Models.TransactionCollection.Total')
  - [ToJson()](#M-Moralis-Web3Api-Models-TransactionCollection-ToJson 'Moralis.Web3Api.Models.TransactionCollection.ToJson')
  - [ToString()](#M-Moralis-Web3Api-Models-TransactionCollection-ToString 'Moralis.Web3Api.Models.TransactionCollection.ToString')
- [UnitConversion](#T-Moralis-Unit-UnitConversion 'Moralis.Unit.UnitConversion')
  - [Convert](#P-Moralis-Unit-UnitConversion-Convert 'Moralis.Unit.UnitConversion.Convert')
  - [FromWei()](#M-Moralis-Unit-UnitConversion-FromWei-System-Numerics-BigInteger,System-Numerics-BigInteger- 'Moralis.Unit.UnitConversion.FromWei(System.Numerics.BigInteger,System.Numerics.BigInteger)')
  - [FromWei()](#M-Moralis-Unit-UnitConversion-FromWei-System-Numerics-BigInteger,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.FromWei(System.Numerics.BigInteger,Moralis.Unit.UnitConversion.EthUnit)')
  - [FromWei()](#M-Moralis-Unit-UnitConversion-FromWei-System-Numerics-BigInteger,System-Int32- 'Moralis.Unit.UnitConversion.FromWei(System.Numerics.BigInteger,System.Int32)')
  - [FromWeiToBigDecimal(value,decimalPlacesToUnit)](#M-Moralis-Unit-UnitConversion-FromWeiToBigDecimal-System-Numerics-BigInteger,System-Int32- 'Moralis.Unit.UnitConversion.FromWeiToBigDecimal(System.Numerics.BigInteger,System.Int32)')
  - [FromWeiToBigDecimal(value,toUnit)](#M-Moralis-Unit-UnitConversion-FromWeiToBigDecimal-System-Numerics-BigInteger,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.FromWeiToBigDecimal(System.Numerics.BigInteger,Moralis.Unit.UnitConversion.EthUnit)')
  - [FromWeiToBigDecimal(value,toUnit)](#M-Moralis-Unit-UnitConversion-FromWeiToBigDecimal-System-Numerics-BigInteger,System-Numerics-BigInteger- 'Moralis.Unit.UnitConversion.FromWeiToBigDecimal(System.Numerics.BigInteger,System.Numerics.BigInteger)')
  - [GetEthUnitValue(ethUnit)](#M-Moralis-Unit-UnitConversion-GetEthUnitValue-Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.GetEthUnitValue(Moralis.Unit.UnitConversion.EthUnit)')
  - [GetEthUnitValueLength(unitValue)](#M-Moralis-Unit-UnitConversion-GetEthUnitValueLength-System-Numerics-BigInteger- 'Moralis.Unit.UnitConversion.GetEthUnitValueLength(System.Numerics.BigInteger)')
  - [ToWei(amount,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-Moralis-Unit-BigDecimal,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.ToWei(Moralis.Unit.BigDecimal,Moralis.Unit.UnitConversion.EthUnit)')
  - [ToWei(amount,decimalPlacesFromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-Moralis-Unit-BigDecimal,System-Int32- 'Moralis.Unit.UnitConversion.ToWei(Moralis.Unit.BigDecimal,System.Int32)')
  - [ToWei(amount,decimalPlacesFromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-System-Decimal,System-Int32- 'Moralis.Unit.UnitConversion.ToWei(System.Decimal,System.Int32)')
  - [ToWei(amount,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-System-Decimal,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.ToWei(System.Decimal,Moralis.Unit.UnitConversion.EthUnit)')
  - [ToWei(value,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-System-Numerics-BigInteger,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.ToWei(System.Numerics.BigInteger,Moralis.Unit.UnitConversion.EthUnit)')
  - [ToWei(value,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-System-Int32,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.ToWei(System.Int32,Moralis.Unit.UnitConversion.EthUnit)')
  - [ToWei(value,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-System-Double,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.ToWei(System.Double,Moralis.Unit.UnitConversion.EthUnit)')
  - [ToWei(value,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-System-Single,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.ToWei(System.Single,Moralis.Unit.UnitConversion.EthUnit)')
  - [ToWei(value,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-System-Int64,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.ToWei(System.Int64,Moralis.Unit.UnitConversion.EthUnit)')
  - [ToWei(value,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWei-System-String,Moralis-Unit-UnitConversion-EthUnit- 'Moralis.Unit.UnitConversion.ToWei(System.String,Moralis.Unit.UnitConversion.EthUnit)')
  - [ToWeiFromUnit(amount,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWeiFromUnit-System-Decimal,System-Numerics-BigInteger- 'Moralis.Unit.UnitConversion.ToWeiFromUnit(System.Decimal,System.Numerics.BigInteger)')
  - [ToWeiFromUnit(amount,fromUnit)](#M-Moralis-Unit-UnitConversion-ToWeiFromUnit-Moralis-Unit-BigDecimal,System-Numerics-BigInteger- 'Moralis.Unit.UnitConversion.ToWeiFromUnit(Moralis.Unit.BigDecimal,System.Numerics.BigInteger)')
  - [TryValidateUnitValue(ethUnit)](#M-Moralis-Unit-UnitConversion-TryValidateUnitValue-System-Numerics-BigInteger- 'Moralis.Unit.UnitConversion.TryValidateUnitValue(System.Numerics.BigInteger)')
- [Web3ApiClient](#T-Moralis-Web3Api-Client-Web3ApiClient 'Moralis.Web3Api.Client.Web3ApiClient')
  - [#ctor(serverUrl)](#M-Moralis-Web3Api-Client-Web3ApiClient-#ctor-System-String- 'Moralis.Web3Api.Client.Web3ApiClient.#ctor(System.String)')
  - [Account](#P-Moralis-Web3Api-Client-Web3ApiClient-Account 'Moralis.Web3Api.Client.Web3ApiClient.Account')
  - [Defi](#P-Moralis-Web3Api-Client-Web3ApiClient-Defi 'Moralis.Web3Api.Client.Web3ApiClient.Defi')
  - [Info](#P-Moralis-Web3Api-Client-Web3ApiClient-Info 'Moralis.Web3Api.Client.Web3ApiClient.Info')
  - [IsInitialized](#P-Moralis-Web3Api-Client-Web3ApiClient-IsInitialized 'Moralis.Web3Api.Client.Web3ApiClient.IsInitialized')
  - [Native](#P-Moralis-Web3Api-Client-Web3ApiClient-Native 'Moralis.Web3Api.Client.Web3ApiClient.Native')
  - [Resolve](#P-Moralis-Web3Api-Client-Web3ApiClient-Resolve 'Moralis.Web3Api.Client.Web3ApiClient.Resolve')
  - [Storage](#P-Moralis-Web3Api-Client-Web3ApiClient-Storage 'Moralis.Web3Api.Client.Web3ApiClient.Storage')
  - [Token](#P-Moralis-Web3Api-Client-Web3ApiClient-Token 'Moralis.Web3Api.Client.Web3ApiClient.Token')
  - [Initialize(serverUrl)](#M-Moralis-Web3Api-Client-Web3ApiClient-Initialize-System-String- 'Moralis.Web3Api.Client.Web3ApiClient.Initialize(System.String)')
- [WebRequest](#T-Moralis-SolanaApi-Models-WebRequest 'Moralis.SolanaApi.Models.WebRequest')
- [WebRequest](#T-Moralis-Web3Api-Models-WebRequest 'Moralis.Web3Api.Models.WebRequest')
  - [Data](#P-Moralis-SolanaApi-Models-WebRequest-Data 'Moralis.SolanaApi.Models.WebRequest.Data')
  - [Method](#P-Moralis-SolanaApi-Models-WebRequest-Method 'Moralis.SolanaApi.Models.WebRequest.Method')
  - [Data](#P-Moralis-Web3Api-Models-WebRequest-Data 'Moralis.Web3Api.Models.WebRequest.Data')
  - [Method](#P-Moralis-Web3Api-Models-WebRequest-Method 'Moralis.Web3Api.Models.WebRequest.Method')

<a name='T-Moralis-Abi-AbiItem'></a>
## AbiItem `type`

##### Namespace

Moralis.Abi

##### Summary

Defines an Abi Entry item.

<a name='P-Moralis-Abi-AbiItem-Anonymous'></a>
### Anonymous `property`

##### Summary

Indicates if event or function is anonymous.

<a name='P-Moralis-Abi-AbiItem-Inputs'></a>
### Inputs `property`

##### Summary

A set of input parameters

<a name='P-Moralis-Abi-AbiItem-Name'></a>
### Name `property`

##### Summary

Name of the function or event.

<a name='P-Moralis-Abi-AbiItem-Outputs'></a>
### Outputs `property`

##### Summary

A set of putput parameters.

<a name='P-Moralis-Abi-AbiItem-StateMutability'></a>
### StateMutability `property`

##### Summary

Type of function (view, etc.)

<a name='P-Moralis-Abi-AbiItem-Type'></a>
### Type `property`

##### Summary

Indicates if item is a function or event

<a name='T-Moralis-Abi-AbiParameter'></a>
## AbiParameter `type`

##### Namespace

Moralis.Abi

<a name='P-Moralis-Abi-AbiParameter-Components'></a>
### Components `property`

##### Summary

Used for tuple types

<a name='P-Moralis-Abi-AbiParameter-Indexed'></a>
### Indexed `property`

##### Summary

True if the field is part of the log’s topics, false if it one of the log’s data segment.

<a name='P-Moralis-Abi-AbiParameter-InternalType'></a>
### InternalType `property`

##### Summary

the canonical type of the parameter

<a name='P-Moralis-Abi-AbiParameter-Name'></a>
### Name `property`

##### Summary

The parameter name

<a name='P-Moralis-Abi-AbiParameter-Type'></a>
### Type `property`

##### Summary

The canonical type of the parameter

<a name='T-Moralis-Abi-AbiTools'></a>
## AbiTools `type`

##### Namespace

Moralis.Abi

##### Summary

Tools used to process contract ABI

<a name='M-Moralis-Abi-AbiTools-JsonToAbiObject-System-String-'></a>
### JsonToAbiObject(json) `method`

##### Summary

Converts an ABI Json string to an ABI object.

##### Returns

List of AbiItem

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-SolanaApi-Api-AccountApi'></a>
## AccountApi `type`

##### Namespace

Moralis.SolanaApi.Api

<a name='T-Moralis-Web3Api-Api-AccountApi'></a>
## AccountApi `type`

##### Namespace

Moralis.Web3Api.Api

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-SolanaApi-Api-AccountApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [AccountApi](#T-Moralis-SolanaApi-Api-AccountApi 'Moralis.SolanaApi.Api.AccountApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-SolanaApi-Api-AccountApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AccountApi](#T-Moralis-SolanaApi-Api-AccountApi 'Moralis.SolanaApi.Api.AccountApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='M-Moralis-Web3Api-Api-AccountApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [AccountApi](#T-Moralis-Web3Api-Api-AccountApi 'Moralis.Web3Api.Api.AccountApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-Web3Api-Api-AccountApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AccountApi](#T-Moralis-Web3Api-Api-AccountApi 'Moralis.Web3Api.Api.AccountApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='P-Moralis-SolanaApi-Api-AccountApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='P-Moralis-Web3Api-Api-AccountApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-SolanaApi-Api-AccountApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-SolanaApi-Api-AccountApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-AccountApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-AccountApi-GetNFTTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTTransfers(address,chain,format,direction,offset,limit) `method`

##### Summary

Gets the transfers of the tokens matching the given parameters

##### Returns

Returns a collection of NFT transfer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The sender or recepient of the transfer |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| direction | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The transfer direction |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-AccountApi-GetNFTs-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTs(address,chain,format,offset,limit) `method`

##### Summary

Gets NFTs owned by the given address
* The response will include status [SYNCED/SYNCING] based on the contracts being indexed.
* Use the token_address param to get results for a specific contract only
* Note results will include all indexed NFTs
* Any request which includes the token_address param will start the indexing process for that NFT collection the very first time it is requested

##### Returns

Returns a collection of nft owners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The owner of a given token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-AccountApi-GetNFTsForContract-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTsForContract(address,tokenAddress,chain,format,offset,limit) `method`

##### Summary

Gets NFTs owned by the given address
* Use the token_address param to get results for a specific contract only
* Note results will include all indexed NFTs
* Any request which includes the token_address param will start the indexing process for that NFT collection the very first time it is requested

##### Returns

Returns a collection of nft owners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The owner of a given token |
| tokenAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-AccountApi-GetNativeBalance-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Decimal}-'></a>
### GetNativeBalance(address,chain,providerUrl,toBlock) `method`

##### Summary

Gets native balance for a specific address

##### Returns

Returns native balance for a specific address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address for which the native balance will be checked |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| toBlock | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | The block number on which the balances should be checked |

<a name='M-Moralis-Web3Api-Api-AccountApi-GetTokenBalances-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Decimal}-'></a>
### GetTokenBalances(address,chain,subdomain,toBlock) `method`

##### Summary

Gets token balances for a specific address

##### Returns

Returns token balances for a specific address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address for which token balances will be checked |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| toBlock | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | The block number on which the balances should be checked |

<a name='M-Moralis-Web3Api-Api-AccountApi-GetTokenTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetTokenTransfers(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets ERC20 token transactions in descending order based on block number

##### Returns

Returns a collection of token transactions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the transactions
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the transactions.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The date from where to get the transactions (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the transactions to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-AccountApi-GetTransactions-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetTransactions(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets native transactions in descending order based on block number

##### Returns

Returns a collection of native transactions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the transactions
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the transactions.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The date from where to get the transactions (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the transactions to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-AccountApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Network-ApiClient'></a>
## ApiClient `type`

##### Namespace

Moralis.Network

##### Summary

API client is mainly responible for making the HTTP call to the API backend.

<a name='M-Moralis-Network-ApiClient-#ctor-System-String-'></a>
### #ctor(basePath) `constructor`

##### Summary

Initializes a new instance of the [ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path. |

<a name='P-Moralis-Network-ApiClient-BasePath'></a>
### BasePath `property`

##### Summary

Gets or sets the base path.

<a name='P-Moralis-Network-ApiClient-DefaultHeader'></a>
### DefaultHeader `property`

##### Summary

Gets the default header.

<a name='M-Moralis-Network-ApiClient-AddDefaultHeader-System-String,System-String-'></a>
### AddDefaultHeader(key,value) `method`

##### Summary

Add default header.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Header field name. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Header field value. |

<a name='M-Moralis-Network-ApiClient-Base64Encode-System-String-'></a>
### Base64Encode(text) `method`

##### Summary

Encode string in base64 format.

##### Returns

Encoded string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to be encoded. |

<a name='M-Moralis-Network-ApiClient-CallApi-System-String,System-Net-Http-HttpMethod,System-Collections-Generic-Dictionary{System-String,System-String},System-String,System-Collections-Generic-Dictionary{System-String,System-String},System-Collections-Generic-Dictionary{System-String,System-String},System-Collections-Generic-Dictionary{System-String,Moralis-Network-FileParameter},System-String[]-'></a>
### CallApi(path,method,queryParams,postBody,headerParams,formParams,fileParams,authSettings) `method`

##### Summary

Makes the HTTP request (Sync).

##### Returns

HttpResponseMessage

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL path. |
| method | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | HTTP method. |
| queryParams | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | Query parameters. |
| postBody | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | HTTP body (POST request). |
| headerParams | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | Header parameters. |
| formParams | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | Form parameters. |
| fileParams | [System.Collections.Generic.Dictionary{System.String,Moralis.Network.FileParameter}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,Moralis.Network.FileParameter}') | File parameters. |
| authSettings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Authentication settings. |

<a name='M-Moralis-Network-ApiClient-ConvertType-System-Object,System-Type-'></a>
### ConvertType(fromObject,toObject) `method`

##### Summary

Dynamically cast the object into target type.

##### Returns

Casted object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fromObject | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object to be casted |
| toObject | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Target type |

<a name='M-Moralis-Network-ApiClient-Deserialize-System-String,System-Type,System-Collections-Generic-IList{Moralis-Network-Parameter}-'></a>
### Deserialize(content,type,headers) `method`

##### Summary

Deserialize the JSON string into a proper object.

##### Returns

Object representation of the JSON string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | HTTP body (e.g. string, JSON). |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Object type. |
| headers | [System.Collections.Generic.IList{Moralis.Network.Parameter}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{Moralis.Network.Parameter}') | HTTP headers. |

<a name='M-Moralis-Network-ApiClient-EscapeString-System-String-'></a>
### EscapeString(str) `method`

##### Summary

Escape string (url-encoded).

##### Returns

Escaped string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String to be escaped. |

<a name='M-Moralis-Network-ApiClient-GetApiKeyWithPrefix-System-String-'></a>
### GetApiKeyWithPrefix(apiKeyIdentifier) `method`

##### Summary

Get the API key with prefix.

##### Returns

API key with prefix.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKeyIdentifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | API key identifier (authentication scheme). |

<a name='M-Moralis-Network-ApiClient-ParameterToFile-System-String,System-IO-Stream-'></a>
### ParameterToFile(name,stream) `method`

##### Summary

Create FileParameter based on Stream.

##### Returns

FileParameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Parameter name. |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Input stream. |

<a name='M-Moralis-Network-ApiClient-ParameterToHex-System-Int64-'></a>
### ParameterToHex(val) `method`

##### Summary

Convert a number to a HEX string.

##### Returns

Hex string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | Value to convert |

<a name='M-Moralis-Network-ApiClient-ParameterToString-System-Object-'></a>
### ParameterToString(obj) `method`

##### Summary

If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
If parameter is a list of string, join the list with ",".
Otherwise just return the string.

##### Returns

Formatted string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The parameter (header, path, query, form). |

<a name='M-Moralis-Network-ApiClient-Serialize-System-Object-'></a>
### Serialize(obj) `method`

##### Summary

Serialize an object into JSON string.

##### Returns

JSON string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object. |

<a name='M-Moralis-Network-ApiClient-UpdateParamsForAuth-System-Collections-Generic-Dictionary{System-String,System-String},System-Collections-Generic-Dictionary{System-String,System-String},System-String[]-'></a>
### UpdateParamsForAuth(queryParams,headerParams,authSettings) `method`

##### Summary

Update parameters based on authentication.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryParams | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | Query parameters. |
| headerParams | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | Header parameters. |
| authSettings | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Authentication settings. |

<a name='T-Moralis-Network-ApiException'></a>
## ApiException `type`

##### Namespace

Moralis.Network

##### Summary

API Exception

<a name='M-Moralis-Network-ApiException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') class.

##### Parameters

This constructor has no parameters.

<a name='M-Moralis-Network-ApiException-#ctor-System-Int32,System-String-'></a>
### #ctor(errorCode,message) `constructor`

##### Summary

Initializes a new instance of the [ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errorCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | HTTP status code. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error message. |

<a name='M-Moralis-Network-ApiException-#ctor-System-Int32,System-String,System-Object-'></a>
### #ctor(errorCode,message,errorContent) `constructor`

##### Summary

Initializes a new instance of the [ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errorCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | HTTP status code. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Error message. |
| errorContent | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Error content. |

<a name='P-Moralis-Network-ApiException-ErrorCode'></a>
### ErrorCode `property`

##### Summary

Gets or sets the error code (HTTP status code)

<a name='P-Moralis-Network-ApiException-ErrorContent'></a>
### ErrorContent `property`

##### Summary

Gets or sets the error content (body json object)

<a name='T-Moralis-AuthApi-Client-AuthApiClient'></a>
## AuthApiClient `type`

##### Namespace

Moralis.AuthApi.Client

##### Summary

Provides public exposure of the Authentication Api Endpoint.

<a name='M-Moralis-AuthApi-Client-AuthApiClient-#ctor'></a>
### #ctor() `constructor`

##### Summary

Default constructor.

##### Parameters

This constructor has no parameters.

<a name='M-Moralis-AuthApi-Client-AuthApiClient-#ctor-System-String-'></a>
### #ctor(serverUrl) `constructor`

##### Summary

Initialize client using just server url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Moralis-AuthApi-Client-AuthApiClient-AuthEndpoint'></a>
### AuthEndpoint `property`

##### Summary

Target Authentication Endpoint.

<a name='P-Moralis-AuthApi-Client-AuthApiClient-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates that the client has been initialized.

<a name='M-Moralis-AuthApi-Client-AuthApiClient-Initialize-System-String-'></a>
### Initialize(serverUrl) `method`

##### Summary

Initialize the client using serverUrl. If serverUrl is null default is used. 
ApiKey is passed via Configuration signleton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-AuthApi-Api-AuthenticationApi'></a>
## AuthenticationApi `type`

##### Namespace

Moralis.AuthApi.Api

##### Summary

Defines a client endpoint the enables application to execute Moralis Authentication Api operations.

<a name='M-Moralis-AuthApi-Api-AuthenticationApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [AuthenticationApi](#T-Moralis-AuthApi-Api-AuthenticationApi 'Moralis.AuthApi.Api.AuthenticationApi') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-AuthApi-Api-AuthenticationApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AuthenticationApi](#T-Moralis-AuthApi-Api-AuthenticationApi 'Moralis.AuthApi.Api.AuthenticationApi') class.

##### Parameters

This constructor has no parameters.

<a name='P-Moralis-AuthApi-Api-AuthenticationApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-AuthApi-Api-AuthenticationApi-Challenge-Moralis-AuthApi-Models-ChallengeRequestDto,Moralis-AuthApi-Models-ChainNetworkType-'></a>
### Challenge(request,network) `method`

##### Summary

Calls the Moralis Authentication Api Challenge operation to generate an authentication message.

##### Returns

ChallengeResponseDto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Moralis.AuthApi.Models.ChallengeRequestDto](#T-Moralis-AuthApi-Models-ChallengeRequestDto 'Moralis.AuthApi.Models.ChallengeRequestDto') |  |
| network | [Moralis.AuthApi.Models.ChainNetworkType](#T-Moralis-AuthApi-Models-ChainNetworkType 'Moralis.AuthApi.Models.ChainNetworkType') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-AuthApi-Api-AuthenticationApi-CompleteChallenge-Moralis-AuthApi-Models-CompleteChallengeRequestDto,Moralis-AuthApi-Models-ChainNetworkType-'></a>
### CompleteChallenge(request,network) `method`

##### Summary

After a message is signed this operation is used to call the Moralis Authentication Challenge Verify operation to validate the signature.

##### Returns

CompleteChallengeResponseDto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Moralis.AuthApi.Models.CompleteChallengeRequestDto](#T-Moralis-AuthApi-Models-CompleteChallengeRequestDto 'Moralis.AuthApi.Models.CompleteChallengeRequestDto') |  |
| network | [Moralis.AuthApi.Models.ChainNetworkType](#T-Moralis-AuthApi-Models-ChainNetworkType 'Moralis.AuthApi.Models.ChainNetworkType') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-AuthApi-Api-AuthenticationApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-AuthApi-Api-AuthenticationApi-HealthCheck'></a>
### HealthCheck() `method`

##### Summary

Exposes the HealthCheck operation of the Moralis Authentication API which enables client applications a way to determine that the Moralis Authentrication Api is available.

##### Returns

HealthCheckResponse

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-AuthApi-Api-AuthenticationApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-StreamsApi-Api-BetaApi'></a>
## BetaApi `type`

##### Namespace

Moralis.StreamsApi.Api

<a name='M-Moralis-StreamsApi-Api-BetaApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [HistoryApi](#T-Moralis-StreamsApi-Api-HistoryApi 'Moralis.StreamsApi.Api.HistoryApi') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-StreamsApi-Api-BetaApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [HistoryApi](#T-Moralis-StreamsApi-Api-HistoryApi 'Moralis.StreamsApi.Api.HistoryApi') class.

##### Parameters

This constructor has no parameters.

<a name='P-Moralis-StreamsApi-Api-BetaApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-StreamsApi-Api-BetaApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-StreamsApi-Api-BetaApi-GetStats'></a>
### GetStats(limit,cursor) `method`

##### Summary

Retrieves history.

##### Returns

LogResponse

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| limit | [M:Moralis.StreamsApi.Api.BetaApi.GetStats](#T-M-Moralis-StreamsApi-Api-BetaApi-GetStats 'M:Moralis.StreamsApi.Api.BetaApi.GetStats') | double |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-StreamsApi-Api-BetaApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Unit-BigDecimal'></a>
## BigDecimal `type`

##### Namespace

Moralis.Unit

##### Summary

Arbitrary precision Decimal.
    All operations are exact, except for division.
    Division never determines more digits than the given precision of 50.

<a name='M-Moralis-Unit-BigDecimal-#ctor-Moralis-Unit-BigDecimal,System-Boolean-'></a>
### #ctor(bigDecimal,alwaysTruncate) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigDecimal | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') |  |
| alwaysTruncate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Moralis-Unit-BigDecimal-#ctor-System-Decimal,System-Boolean-'></a>
### #ctor(value,alwaysTruncate) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |
| alwaysTruncate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-Moralis-Unit-BigDecimal-#ctor-System-Numerics-BigInteger,System-Int32,System-Boolean-'></a>
### #ctor(mantissa,exponent,alwaysTruncate) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mantissa | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') |  |
| exponent | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of decimal units for example (-18). A positive value will be normalised as 10 ^
    exponent |
| alwaysTruncate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Specifies whether the significant digits should be truncated to the given precision after
    each operation. |

<a name='F-Moralis-Unit-BigDecimal-Precision'></a>
### Precision `constants`

##### Summary

Sets the maximum precision of division operations.
    If AlwaysTruncate is set to true all operations are affected.

<a name='P-Moralis-Unit-BigDecimal-Exponent'></a>
### Exponent `property`

##### Summary

A number denoting the power to which that number, symbol, or expression is to be raised.

<a name='P-Moralis-Unit-BigDecimal-Mantissa'></a>
### Mantissa `property`

##### Summary

The significant digits of a floating-point number or a number in scientific notation

<a name='M-Moralis-Unit-BigDecimal-AlignExponent-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### AlignExponent() `method`

##### Summary

Returns the mantissa of value, aligned to the exponent of reference.
    Assumes the exponent of value is larger than of value.

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-BigDecimal-CompareTo-System-Object-'></a>
### CompareTo(obj) `method`

##### Summary

Defines a general comparison operator.

##### Returns

int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

<a name='M-Moralis-Unit-BigDecimal-CompareTo-Moralis-Unit-BigDecimal-'></a>
### CompareTo(other) `method`

##### Summary

Defines a comparison operator to compare against other BigDecimals.

##### Returns

int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') |  |

<a name='M-Moralis-Unit-BigDecimal-Equals-Moralis-Unit-BigDecimal-'></a>
### Equals(other) `method`

##### Summary

Provides equality operator against other BigDecimal objects.

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') |  |

<a name='M-Moralis-Unit-BigDecimal-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Provides a general equality operation

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-Moralis-Unit-BigDecimal-Exp-System-Double-'></a>
### Exp(exponent) `method`

##### Summary

Applies exponent to BigDecimal.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exponent | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | double |

<a name='M-Moralis-Unit-BigDecimal-Floor'></a>
### Floor() `method`

##### Summary

Truncate the number, removing all decimal digits.

##### Returns

The truncated number

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-BigDecimal-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Provides GetHashCode operation.

##### Returns

int

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-BigDecimal-NormaliseExponentBiggerThanZero'></a>
### NormaliseExponentBiggerThanZero() `method`

##### Summary

Uses Mantissa to normalize when exponent is greater than zero.

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-BigDecimal-Normalize'></a>
### Normalize() `method`

##### Summary

Removes trailing zeros on the mantissa

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-BigDecimal-Parse-System-String-'></a>
### Parse(value) `method`

##### Summary

Provide a way to convert valid numeric strings to BigDecimal

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string |

<a name='M-Moralis-Unit-BigDecimal-Pow-System-Double,System-Double-'></a>
### Pow(basis,exponent) `method`

##### Summary

Provide a Power operation

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basis | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | double |
| exponent | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | double |

<a name='M-Moralis-Unit-BigDecimal-RoundAwayFromZero-System-Int32-'></a>
### RoundAwayFromZero() `method`

##### Summary

Rounds the number to the specified amount of significant digits.
Midpoints (like 0.5 or -0.5) are rounded away from 0 (e.g. to 1 and -1 respectively).

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-BigDecimal-ToString'></a>
### ToString() `method`

##### Summary

Provides a ToString operation

##### Returns

string

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-BigDecimal-ToString-System-String,System-IFormatProvider-'></a>
### ToString(formatSpecifier,format) `method`

##### Summary

Formated string

##### Returns

string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formatSpecifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string |
| format | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | IFormatProvider |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Moralis-Unit-BigDecimal-Truncate-System-Int32-'></a>
### Truncate() `method`

##### Summary

Truncate the number to the given precision by removing the least significant digits.

##### Returns

The truncated number

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-BigDecimal-op_Addition-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_Addition(left,right) `method`

##### Summary

Defines addtion operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| right | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Decrement-Moralis-Unit-BigDecimal-'></a>
### op_Decrement(value) `method`

##### Summary

Defines decrement operation for BigDecimal value.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Division-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_Division(dividend,divisor) `method`

##### Summary

Defines division operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dividend | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| divisor | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Equality-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_Equality(left,right) `method`

##### Summary

Defines equality operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| right | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-Double'></a>
### op_Explicit(value) `method`

##### Summary

Convert BigDecimal to double - possible data loss

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal)~System.Double](#T-Moralis-Unit-BigDecimal-~System-Double 'Moralis.Unit.BigDecimal)~System.Double') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-Single'></a>
### op_Explicit(value) `method`

##### Summary

Convert BigDecimal to float - possible data loss

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal)~System.Single](#T-Moralis-Unit-BigDecimal-~System-Single 'Moralis.Unit.BigDecimal)~System.Single') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-Decimal'></a>
### op_Explicit(value) `method`

##### Summary

Convert BigDecimal to decimal - possible data loss

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal)~System.Decimal](#T-Moralis-Unit-BigDecimal-~System-Decimal 'Moralis.Unit.BigDecimal)~System.Decimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-Int32'></a>
### op_Explicit(value) `method`

##### Summary

Convert BigDecimal to int - possible data loss

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal)~System.Int32](#T-Moralis-Unit-BigDecimal-~System-Int32 'Moralis.Unit.BigDecimal)~System.Int32') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Explicit-Moralis-Unit-BigDecimal-~System-UInt32'></a>
### op_Explicit(value) `method`

##### Summary

Convert BigDecimal to uint - possible data loss

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal)~System.UInt32](#T-Moralis-Unit-BigDecimal-~System-UInt32 'Moralis.Unit.BigDecimal)~System.UInt32') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_GreaterThan-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_GreaterThan(left,right) `method`

##### Summary

Defines greater than operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| right | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_GreaterThanOrEqual-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_GreaterThanOrEqual(value) `method`

##### Summary

Defines greater than or equal to operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Implicit-System-Int32-~Moralis-Unit-BigDecimal'></a>
### op_Implicit(value) `method`

##### Summary

Convert int to BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32)~Moralis.Unit.BigDecimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32)~Moralis.Unit.BigDecimal 'System.Int32)~Moralis.Unit.BigDecimal') | int |

<a name='M-Moralis-Unit-BigDecimal-op_Implicit-System-Numerics-BigInteger-~Moralis-Unit-BigDecimal'></a>
### op_Implicit(value) `method`

##### Summary

Convert BigInteger to BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Numerics.BigInteger)~Moralis.Unit.BigDecimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger)~Moralis.Unit.BigDecimal 'System.Numerics.BigInteger)~Moralis.Unit.BigDecimal') | BigInteger |

<a name='M-Moralis-Unit-BigDecimal-op_Implicit-System-Double-~Moralis-Unit-BigDecimal'></a>
### op_Implicit(value) `method`

##### Summary

Convert double to BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double)~Moralis.Unit.BigDecimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double)~Moralis.Unit.BigDecimal 'System.Double)~Moralis.Unit.BigDecimal') | double |

<a name='M-Moralis-Unit-BigDecimal-op_Implicit-System-Decimal-~Moralis-Unit-BigDecimal'></a>
### op_Implicit(value) `method`

##### Summary

Convert decimal to BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal)~Moralis.Unit.BigDecimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal)~Moralis.Unit.BigDecimal 'System.Decimal)~Moralis.Unit.BigDecimal') | decimal |

<a name='M-Moralis-Unit-BigDecimal-op_Increment-Moralis-Unit-BigDecimal-'></a>
### op_Increment(value) `method`

##### Summary

Defines increment operation for BigDecimal value.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Inequality-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_Inequality(left,right) `method`

##### Summary

Defines not equal operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| right | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_LessThan-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_LessThan(left,right) `method`

##### Summary

Defines less than operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| right | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_LessThanOrEqual-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_LessThanOrEqual(left,right) `method`

##### Summary

Defines less than or equal to operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| right | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Multiply-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_Multiply(left,right) `method`

##### Summary

Defines multiplication operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| right | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_Subtraction-Moralis-Unit-BigDecimal,Moralis-Unit-BigDecimal-'></a>
### op_Subtraction(left,right) `method`

##### Summary

Defines subtraction operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| left | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| right | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_UnaryNegation-Moralis-Unit-BigDecimal-'></a>
### op_UnaryNegation(value) `method`

##### Summary

Defines subtraction operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='M-Moralis-Unit-BigDecimal-op_UnaryPlus-Moralis-Unit-BigDecimal-'></a>
### op_UnaryPlus(value) `method`

##### Summary

Defines addition operation for two BigDecimal values.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |

<a name='T-Moralis-Unit-BigDecimalFormatter'></a>
## BigDecimalFormatter `type`

##### Namespace

Moralis.Unit

##### Summary

Provides functions for formating number
[](#!-Nethereum-Util-BigDecimalFormatter 'Nethereum.Util.BigDecimalFormatter')

<a name='T-Moralis-Unit-BigIntegerExtensions'></a>
## BigIntegerExtensions `type`

##### Namespace

Moralis.Unit

##### Summary

Provides functions for BigInteger
[](#!-Nethereum-Util-BigIntegerExtensions 'Nethereum.Util.BigIntegerExtensions')

<a name='M-Moralis-Unit-BigIntegerExtensions-NumberOfDigits-System-Numerics-BigInteger-'></a>
### NumberOfDigits(value) `method`

##### Summary

Number of digits in a BigInteger value.

##### Returns

int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |

<a name='M-Moralis-Unit-BigIntegerExtensions-ParseInvariant-System-String-'></a>
### ParseInvariant(value) `method`

##### Summary

Parse an invariat value.

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='T-Moralis-Web3Api-Models-Block'></a>
## Block `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Block-Difficulty'></a>
### Difficulty `property`

##### Summary

The difficulty of the block
example: 7253857437305950

<a name='P-Moralis-Web3Api-Models-Block-ExtraData'></a>
### ExtraData `property`

##### Summary

example: 0x65746865726d696e652d6575726f70652d7765737433

<a name='P-Moralis-Web3Api-Models-Block-GasLimit'></a>
### GasLimit `property`

##### Summary

The gas limit
example: 14977947

<a name='P-Moralis-Web3Api-Models-Block-GasUsed'></a>
### GasUsed `property`

##### Summary

The gas used
example: 14964688

<a name='P-Moralis-Web3Api-Models-Block-Hash'></a>
### Hash `property`

##### Summary

The block hash
example: 0x9b559aef7ea858608c2e554246fe4a24287e7aeeb976848df2b9a2531f4b9171

<a name='P-Moralis-Web3Api-Models-Block-LogsBloom'></a>
### LogsBloom `property`

##### Summary

example: 0xdde5fc46c5d8bcbd58207bc9f267bf43298e23791a326ff02661e99790da9996b3e0dd912c0b8202d389d282c56e4d11eb2dec4898a32b6b165f1f4cae6aa0079498eab50293f3b8defbf6af11bb75f0408a563ddfc26a3323d1ff5f9849e95d5f034d88a757ddea032c75c00708c9ff34d2207f997cc7d93fd1fa160a6bfaf62a54e31f9fe67ab95752106ba9d185bfdc9b6dc3e17427f844ee74e5c09b17b83ad6e8fc7360f5c7c3e4e1939e77a6374bee57d1fa6b2322b11ad56ad0398302de9b26d6fbfe414aa416bff141fad9d4af6aea19322e47595e342cd377403f417dfd396ab5f151095a5535f51cbc34a40ce9648927b7d1d72ab9daf253e31daf

<a name='P-Moralis-Web3Api-Models-Block-Miner'></a>
### Miner `property`

##### Summary

The address of the miner
example: 0xea674fdde714fd979de3edf0f56aa9716b898ec8

<a name='P-Moralis-Web3Api-Models-Block-Nonce'></a>
### Nonce `property`

##### Summary

The nonce
example: 0xedeb2d8fd2b2bdec

<a name='P-Moralis-Web3Api-Models-Block-Number'></a>
### Number `property`

##### Summary

The block number
example: 12386788

<a name='P-Moralis-Web3Api-Models-Block-ParentHash'></a>
### ParentHash `property`

##### Summary

The block hash of the parent block
example: 0x011d1fc45839de975cc55d758943f9f1d204f80a90eb631f3bf064b80d53e045

<a name='P-Moralis-Web3Api-Models-Block-ReceiptsRoot'></a>
### ReceiptsRoot `property`

##### Summary

example: 0x7cf43d7e837284f036cf92c56973f5e27bdd253ca46168fa195a6b07fa719f23

<a name='P-Moralis-Web3Api-Models-Block-Sha3Uncles'></a>
### Sha3Uncles `property`

##### Summary

example: 0x1dcc4de8dec75d7aab85b567b6ccd41ad312451b948a7413f0a142fd40d49347

<a name='P-Moralis-Web3Api-Models-Block-Size'></a>
### Size `property`

##### Summary

The block size
example: 61271

<a name='P-Moralis-Web3Api-Models-Block-StateRoot'></a>
### StateRoot `property`

##### Summary

example: 0x49e3bfe7b618e27fde8fa08884803a8458b502c6534af69873a3cc926a7c724b

<a name='P-Moralis-Web3Api-Models-Block-Timestamp'></a>
### Timestamp `property`

##### Summary

The block timestamp
example: 5/7/2021 11:08:35 AM

<a name='P-Moralis-Web3Api-Models-Block-TotalDifficulty'></a>
### TotalDifficulty `property`

##### Summary

The total difficulty
example: 24325637817906576196890

<a name='P-Moralis-Web3Api-Models-Block-TransactionCount'></a>
### TransactionCount `property`

##### Summary

The number of transactions in the block
example: 252

<a name='P-Moralis-Web3Api-Models-Block-Transactions'></a>
### Transactions `property`

##### Summary

The transactions in the block

<a name='P-Moralis-Web3Api-Models-Block-TransactionsRoot'></a>
### TransactionsRoot `property`

##### Summary

example: 0xe4c7bf3aff7ad07f9e80d57f7189f0252592fee6321c2a9bd9b09b6ce0690d27

<a name='M-Moralis-Web3Api-Models-Block-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Block-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-BlockDate'></a>
## BlockDate `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-BlockDate-Block'></a>
### Block `property`

##### Summary

The blocknumber
example: 9193266

<a name='P-Moralis-Web3Api-Models-BlockDate-Date'></a>
### Date `property`

##### Summary

The date of the block
example: 12/31/2019 7:00:00 PM

<a name='P-Moralis-Web3Api-Models-BlockDate-Timestamp'></a>
### Timestamp `property`

##### Summary

The timestamp of the block
example: 1577836811

<a name='M-Moralis-Web3Api-Models-BlockDate-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-BlockDate-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-BlockTransaction'></a>
## BlockTransaction `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-BlockTransaction-BlockHash'></a>
### BlockHash `property`

##### Summary

The hash of the block
example: 0x9b559aef7ea858608c2e554246fe4a24287e7aeeb976848df2b9a2531f4b9171

<a name='P-Moralis-Web3Api-Models-BlockTransaction-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The block number
example: 12386788

<a name='P-Moralis-Web3Api-Models-BlockTransaction-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 5/7/2021 11:08:35 AM

<a name='P-Moralis-Web3Api-Models-BlockTransaction-FromAddress'></a>
### FromAddress `property`

##### Summary

The from address
example: 0x267be1c1d684f78cb4f6a176c4911b741e4ffdc0

<a name='P-Moralis-Web3Api-Models-BlockTransaction-Gas'></a>
### Gas `property`

##### Summary

example: 30000

<a name='P-Moralis-Web3Api-Models-BlockTransaction-GasPrice'></a>
### GasPrice `property`

##### Summary

The gas price
example: 52500000000

<a name='P-Moralis-Web3Api-Models-BlockTransaction-Hash'></a>
### Hash `property`

##### Summary

The hash of the transaction
example: 0x1ed85b3757a6d31d01a4d6677fc52fd3911d649a0af21fe5ca3f886b153773ed

<a name='P-Moralis-Web3Api-Models-BlockTransaction-Input'></a>
### Input `property`

##### Summary

example: 0x

<a name='P-Moralis-Web3Api-Models-BlockTransaction-Logs'></a>
### Logs `property`

##### Summary

The logs of the transaction

<a name='P-Moralis-Web3Api-Models-BlockTransaction-Nonce'></a>
### Nonce `property`

##### Summary

The nonce
example: 1848059

<a name='P-Moralis-Web3Api-Models-BlockTransaction-ReceiptContractAddress'></a>
### ReceiptContractAddress `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-BlockTransaction-ReceiptCumulativeGasUsed'></a>
### ReceiptCumulativeGasUsed `property`

##### Summary

example: 4923073

<a name='P-Moralis-Web3Api-Models-BlockTransaction-ReceiptGasUsed'></a>
### ReceiptGasUsed `property`

##### Summary

example: 21000

<a name='P-Moralis-Web3Api-Models-BlockTransaction-ReceiptRoot'></a>
### ReceiptRoot `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-BlockTransaction-ReceiptStatus'></a>
### ReceiptStatus `property`

##### Summary

example: 1

<a name='P-Moralis-Web3Api-Models-BlockTransaction-ToAddress'></a>
### ToAddress `property`

##### Summary

The to address
example: 0x003dde3494f30d861d063232c6a8c04394b686ff

<a name='P-Moralis-Web3Api-Models-BlockTransaction-TransactionIndex'></a>
### TransactionIndex `property`

##### Summary

example: 108

<a name='P-Moralis-Web3Api-Models-BlockTransaction-Value'></a>
### Value `property`

##### Summary

The value sent
example: 115580000000000000

<a name='M-Moralis-Web3Api-Models-BlockTransaction-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-BlockTransaction-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Models-ChainEntry'></a>
## ChainEntry `type`

##### Namespace

Moralis.Models

##### Summary

Provides detail around a supported EVM chain.

<a name='F-Moralis-Models-ChainEntry-ChainId'></a>
### ChainId `constants`

##### Summary

Chain Id as integer

<a name='F-Moralis-Models-ChainEntry-Decimals'></a>
### Decimals `constants`

##### Summary

Number of decimals in the currency.

<a name='F-Moralis-Models-ChainEntry-EnumValue'></a>
### EnumValue `constants`

##### Summary

Chain Id as Enum value.

<a name='F-Moralis-Models-ChainEntry-Name'></a>
### Name `constants`

##### Summary

Name of the chain.

<a name='F-Moralis-Models-ChainEntry-Symbol'></a>
### Symbol `constants`

##### Summary

Native currency's symbol.

<a name='T-Moralis-AuthApi-Models-ChainNetworkType'></a>
## ChainNetworkType `type`

##### Namespace

Moralis.AuthApi.Models

##### Summary

Blockchain network types

<a name='F-Moralis-AuthApi-Models-ChainNetworkType-evm'></a>
### evm `constants`

##### Summary

Ethereum Virtual Machine (EVM) compatible networks

<a name='F-Moralis-AuthApi-Models-ChainNetworkType-solana'></a>
### solana `constants`

##### Summary

Solana compatible networks.

<a name='T-Moralis-AuthApi-Models-ChallengeRequestDto'></a>
## ChallengeRequestDto `type`

##### Namespace

Moralis.AuthApi.Models

##### Summary

Request object for the Challenge operation.

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-Address'></a>
### Address `property`

##### Summary

The Ethereum address performing the signing conformant to capitalization encoded checksum specified in EIP-55 where applicable.

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-ChainId'></a>
### ChainId `property`

##### Summary

The EIP-155 Chain ID to which the session is bound, and the network where Contract Accounts MUST be resolved.

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-Domain'></a>
### Domain `property`

##### Summary

The RFC 3986 authority that is requesting the signing

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-ExpirationTime'></a>
### ExpirationTime `property`

##### Summary

The ISO 8601 datetime string that, if present, indicates when the signed authentication message is no longer valid.

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-NotBefore'></a>
### NotBefore `property`

##### Summary

The ISO 8601 datetime string that, if present, indicates when the signed authentication message will become valid.

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-Resources'></a>
### Resources `property`

##### Summary

A list of information or references to information the user wishes to have resolved as part of authentication by the relying party. They are expressed as RFC 3986 URIs separated by "\n- " where \n is the byte 0x0a.

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-Statement'></a>
### Statement `property`

##### Summary

A human-readable ASCII assertion that the user will sign, and it must not contain '\n' (the byte 0x0a).

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-Timeout'></a>
### Timeout `property`

##### Summary

Time is seconds at which point this request becomes invalid.

<a name='P-Moralis-AuthApi-Models-ChallengeRequestDto-Uri'></a>
### Uri `property`

##### Summary

An RFC 3986 URI referring to the resource that is the subject of the signing (as in the subject of a claim).

<a name='T-Moralis-AuthApi-Models-ChallengeResponseDto'></a>
## ChallengeResponseDto `type`

##### Namespace

Moralis.AuthApi.Models

##### Summary

Respopnse returned by the Challenge operation.

<a name='P-Moralis-AuthApi-Models-ChallengeResponseDto-Id'></a>
### Id `property`

##### Summary

Internal identifier

<a name='P-Moralis-AuthApi-Models-ChallengeResponseDto-Message'></a>
### Message `property`

##### Summary

Message meant to be signed.

<a name='P-Moralis-AuthApi-Models-ChallengeResponseDto-ProfileId'></a>
### ProfileId `property`

##### Summary

Profile Id generated by the Moralis Authentication API.

<a name='T-Moralis-AuthApi-Models-CompleteChallengeRequestDto'></a>
## CompleteChallengeRequestDto `type`

##### Namespace

Moralis.AuthApi.Models

##### Summary

Request used to call the Challenge verify operation of the Authentication Api.

<a name='P-Moralis-AuthApi-Models-CompleteChallengeRequestDto-Message'></a>
### Message `property`

##### Summary

Original message that was generated to be signed.

<a name='P-Moralis-AuthApi-Models-CompleteChallengeRequestDto-Signature'></a>
### Signature `property`

##### Summary

The crypotgraphic signature of the message.

<a name='T-Moralis-AuthApi-Models-CompleteChallengeResponseDto'></a>
## CompleteChallengeResponseDto `type`

##### Namespace

Moralis.AuthApi.Models

##### Summary

The response returned by the Challenge Verify when the a signature/message is verified successfully.

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Address'></a>
### Address `property`

##### Summary

The Ethereum address performing the signing conformant to capitalization encoded checksum specified in EIP-55 where applicable.

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-ChainId'></a>
### ChainId `property`

##### Summary

The EIP-155 Chain ID to which the session is bound, and the network where Contract Accounts MUST be resolved.

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Domain'></a>
### Domain `property`

##### Summary

The RFC 3986 authority that is requesting the signing

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-ExpirationTime'></a>
### ExpirationTime `property`

##### Summary

The ISO 8601 datetime string that, if present, indicates when the signed authentication message is no longer valid.

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Id'></a>
### Id `property`

##### Summary

Internal Identifier

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Nonce'></a>
### Nonce `property`

##### Summary

Nonce used to make message unique

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-NotBefore'></a>
### NotBefore `property`

##### Summary

The ISO 8601 datetime string that, if present, indicates when the signed authentication message will become valid.

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-ProfileId'></a>
### ProfileId `property`

##### Summary

Moralis Profile Id

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Resources'></a>
### Resources `property`

##### Summary

A list of information or references to information the user wishes to have resolved as part of authentication by the relying party. They are expressed as RFC 3986 URIs separated by "\n- " where \n is the byte 0x0a.

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Statement'></a>
### Statement `property`

##### Summary

A human-readable ASCII assertion that the user will sign, and it must not contain '\n' (the byte 0x0a).

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Uri'></a>
### Uri `property`

##### Summary

An RFC 3986 URI referring to the resource that is the subject of the signing (as in the subject of a claim).

<a name='P-Moralis-AuthApi-Models-CompleteChallengeResponseDto-Version'></a>
### Version `property`

##### Summary

Api version

<a name='T-Moralis-Abi-Component'></a>
## Component `type`

##### Namespace

Moralis.Abi

##### Summary

Defines a component type used for tuple types.

<a name='P-Moralis-Abi-Component-Components'></a>
### Components `property`

##### Summary

Used for tuple types

<a name='P-Moralis-Abi-Component-Name'></a>
### Name `property`

##### Summary

The parameter name

<a name='P-Moralis-Abi-Component-Type'></a>
### Type `property`

##### Summary

The canonical type of the parameter

<a name='T-Moralis-Network-Configuration'></a>
## Configuration `type`

##### Namespace

Moralis.Network

##### Summary

Represents a set of configuration settings

<a name='F-Moralis-Network-Configuration-ApiKey'></a>
### ApiKey `constants`

##### Summary

Gets or sets the API key based on the authentication name.

<a name='F-Moralis-Network-Configuration-ApiKeyPrefix'></a>
### ApiKeyPrefix `constants`

##### Summary

Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.

<a name='F-Moralis-Network-Configuration-DefaultApiClient'></a>
### DefaultApiClient `constants`

##### Summary

Gets or sets the default API client for making HTTP calls.

<a name='F-Moralis-Network-Configuration-Version'></a>
### Version `constants`

##### Summary

Version of the package.

<a name='P-Moralis-Network-Configuration-DateTimeFormat'></a>
### DateTimeFormat `property`

##### Summary

Gets or sets the the date time format used when serializing in the ApiClient
By default, it's set to ISO 8601 - "o", for others see:
https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
No validation is done to ensure that the string you're providing is valid

<a name='P-Moralis-Network-Configuration-Password'></a>
### Password `property`

##### Summary

Gets or sets the password (HTTP basic authentication).

<a name='P-Moralis-Network-Configuration-TempFolderPath'></a>
### TempFolderPath `property`

##### Summary

Gets or sets the temporary folder path to store the files downloaded from the server.

<a name='P-Moralis-Network-Configuration-Username'></a>
### Username `property`

##### Summary

Gets or sets the username (HTTP basic authentication).

<a name='M-Moralis-Network-Configuration-ToDebugReport'></a>
### ToDebugReport() `method`

##### Summary

Returns a string with essential information for debugging.

##### Parameters

This method has no parameters.

<a name='T-Moralis-Network-DataFormat'></a>
## DataFormat `type`

##### Namespace

Moralis.Network

##### Summary

Expected / supported format

<a name='T-Moralis-AuthApi-Models-DatabaseStatus'></a>
## DatabaseStatus `type`

##### Namespace

Moralis.AuthApi.Models

##### Summary

Helathcheck DB status

<a name='P-Moralis-AuthApi-Models-DatabaseStatus-Redis'></a>
### Redis `property`

##### Summary

Redis entry response.

<a name='T-Moralis-AuthApi-Models-DatabaseStatusEntry'></a>
## DatabaseStatusEntry `type`

##### Namespace

Moralis.AuthApi.Models

##### Summary

Healthcheck DB status for specific instance.

<a name='P-Moralis-AuthApi-Models-DatabaseStatusEntry-Status'></a>
### Status `property`

##### Summary

Status of the server.

<a name='T-Moralis-Web3Api-Api-DefiApi'></a>
## DefiApi `type`

##### Namespace

Moralis.Web3Api.Api

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Api-DefiApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [DefiApi](#T-Moralis-Web3Api-Api-DefiApi 'Moralis.Web3Api.Api.DefiApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-Web3Api-Api-DefiApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DefiApi](#T-Moralis-Web3Api-Api-DefiApi 'Moralis.Web3Api.Api.DefiApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='P-Moralis-Web3Api-Api-DefiApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-Web3Api-Api-DefiApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-DefiApi-GetPairAddress-System-String,System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String-'></a>
### GetPairAddress(exchange,token0Address,token1Address,chain,toBlock,toDate) `method`

##### Summary

Fetches and returns pair data of the provided token0+token1 combination.
The token0 and token1 options are interchangable (ie. there is no different outcome in "token0=WETH and token1=USDT" or "token0=USDT and token1=WETH")

##### Returns

Returns the pair address of the two tokens

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exchange | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The factory name or address of the token exchange |
| token0Address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Token0 address |
| token1Address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Token1 address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| toBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | To get the reserves at this block number |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the reserves to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |

<a name='M-Moralis-Web3Api-Api-DefiApi-GetPairReserves-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String-'></a>
### GetPairReserves(pairAddress,chain,toBlock,toDate,providerUrl) `method`

##### Summary

Get the liquidity reserves for a given pair address

##### Returns

Returns the pair reserves

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pairAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Liquidity pair address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| toBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | To get the reserves at this block number |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the reserves to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='M-Moralis-Web3Api-Api-DefiApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Web3Api-Models-Ens'></a>
## Ens `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Ens-Name'></a>
### Name `property`

##### Summary

Resolved ENS address
example: Vitalik.eth

<a name='M-Moralis-Web3Api-Models-Ens-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Ens-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Erc20Allowance'></a>
## Erc20Allowance `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Erc20Allowance-Allowance'></a>
### Allowance `property`

##### Summary

The allowance

<a name='M-Moralis-Web3Api-Models-Erc20Allowance-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc20Allowance-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Erc20Metadata'></a>
## Erc20Metadata `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Erc20Metadata-Address'></a>
### Address `property`

##### Summary

The address of the token contract
example: 0x2d30ca6f024dbc1307ac8a1a44ca27de6f797ec22ef20627a1307243b0ab7d09

<a name='P-Moralis-Web3Api-Models-Erc20Metadata-BlockNumber'></a>
### BlockNumber `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-Erc20Metadata-Decimals'></a>
### Decimals `property`

##### Summary

The number of decimals on of the token
example: 18

<a name='P-Moralis-Web3Api-Models-Erc20Metadata-Logo'></a>
### Logo `property`

##### Summary

The logo of the token
example: https://cdn.moralis.io/eth/0x67b6d479c7bb412c54e03dca8e1bc6740ce6b99c.png

<a name='P-Moralis-Web3Api-Models-Erc20Metadata-LogoHash'></a>
### LogoHash `property`

##### Summary

The logo hash
example: ee7aa2cdf100649a3521a082116258e862e6971261a39b5cd4e4354fcccbc54d

<a name='P-Moralis-Web3Api-Models-Erc20Metadata-Name'></a>
### Name `property`

##### Summary

The name of the token Contract
example: Kylin Network

<a name='P-Moralis-Web3Api-Models-Erc20Metadata-Symbol'></a>
### Symbol `property`

##### Summary

The symbol of the NFT contract
example: KYL

<a name='P-Moralis-Web3Api-Models-Erc20Metadata-Thumbnail'></a>
### Thumbnail `property`

##### Summary

The thumbnail of the logo
example: https://cdn.moralis.io/eth/0x67b6d479c7bb412c54e03dca8e1bc6740ce6b99c_thumb.png

<a name='P-Moralis-Web3Api-Models-Erc20Metadata-Validated'></a>
### Validated `property`

##### Summary



<a name='M-Moralis-Web3Api-Models-Erc20Metadata-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc20Metadata-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Erc20Price'></a>
## Erc20Price `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Erc20Price-ExchangeAddress'></a>
### ExchangeAddress `property`

##### Summary

The address of the exchange used to calculate the price
example: 0x1f98431c8ad98523631ae4a59f267346ea31f984

<a name='P-Moralis-Web3Api-Models-Erc20Price-ExchangeName'></a>
### ExchangeName `property`

##### Summary

The name of the exchange used for calculating the price
example: Uniswap v3

<a name='P-Moralis-Web3Api-Models-Erc20Price-NativePrice'></a>
### NativePrice `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-Erc20Price-UsdPrice'></a>
### UsdPrice `property`

##### Summary

format: double
The price in USD for the token
example: 19.722370676

<a name='M-Moralis-Web3Api-Models-Erc20Price-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc20Price-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Erc20TokenBalance'></a>
## Erc20TokenBalance `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Erc20TokenBalance-Balance'></a>
### Balance `property`

##### Summary

Timestamp of when the contract was last synced with the node
example: 123456789

<a name='P-Moralis-Web3Api-Models-Erc20TokenBalance-Decimals'></a>
### Decimals `property`

##### Summary

The number of decimals on of the token
example: 18

<a name='P-Moralis-Web3Api-Models-Erc20TokenBalance-Logo'></a>
### Logo `property`

##### Summary

The logo of the token
example: https://cdn.moralis.io/eth/0x67b6d479c7bb412c54e03dca8e1bc6740ce6b99c.png

<a name='P-Moralis-Web3Api-Models-Erc20TokenBalance-Name'></a>
### Name `property`

##### Summary

The name of the token Contract
example: Kylin Network

<a name='P-Moralis-Web3Api-Models-Erc20TokenBalance-Symbol'></a>
### Symbol `property`

##### Summary

The symbol of the NFT contract
example: KYL

<a name='P-Moralis-Web3Api-Models-Erc20TokenBalance-Thumbnail'></a>
### Thumbnail `property`

##### Summary

The thumbnail of the logo
example: https://cdn.moralis.io/eth/0x67b6d479c7bb412c54e03dca8e1bc6740ce6b99c_thumb.png

<a name='P-Moralis-Web3Api-Models-Erc20TokenBalance-TokenAddress'></a>
### TokenAddress `property`

##### Summary

The address of the token contract
example: 0x2d30ca6f024dbc1307ac8a1a44ca27de6f797ec22ef20627a1307243b0ab7d09

<a name='M-Moralis-Web3Api-Models-Erc20TokenBalance-RawBalance'></a>
### RawBalance() `method`

##### Summary

Used by base class to access the raw WEI string value.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc20TokenBalance-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc20TokenBalance-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Erc20Transaction'></a>
## Erc20Transaction `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Erc20Transaction-Address'></a>
### Address `property`

##### Summary

The address of the token
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-Erc20Transaction-BlockHash'></a>
### BlockHash `property`

##### Summary

The block hash
example: 0x0372c302e3c52e8f2e15d155e2c545e6d802e479236564af052759253b20fd86

<a name='P-Moralis-Web3Api-Models-Erc20Transaction-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The block number
example: 12526958

<a name='P-Moralis-Web3Api-Models-Erc20Transaction-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 4/2/2021 10:07:54 AM

<a name='P-Moralis-Web3Api-Models-Erc20Transaction-FromAddress'></a>
### FromAddress `property`

##### Summary

The sender
example: 0xd4a3BebD824189481FC45363602b83C9c7e9cbDf

<a name='P-Moralis-Web3Api-Models-Erc20Transaction-ToAddress'></a>
### ToAddress `property`

##### Summary

The recipient
example: 0x62AED87d21Ad0F3cdE4D147Fdcc9245401Af0044

<a name='P-Moralis-Web3Api-Models-Erc20Transaction-TransactionHash'></a>
### TransactionHash `property`

##### Summary

The transaction hash
example: 0x2d30ca6f024dbc1307ac8a1a44ca27de6f797ec22ef20627a1307243b0ab7d09

<a name='P-Moralis-Web3Api-Models-Erc20Transaction-Value'></a>
### Value `property`

##### Summary

The value that was transfered (in wei)
example: 650000000000000000

<a name='M-Moralis-Web3Api-Models-Erc20Transaction-RawBalance'></a>
### RawBalance() `method`

##### Summary

Used by base class to access the raw WEI string value.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc20Transaction-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc20Transaction-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Erc20TransactionCollection'></a>
## Erc20TransactionCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Erc20TransactionCollection-Page'></a>
### Page `property`

##### Summary

The page of the current result
example: 2

<a name='P-Moralis-Web3Api-Models-Erc20TransactionCollection-PageSize'></a>
### PageSize `property`

##### Summary

The number of results per page
example: 100

<a name='P-Moralis-Web3Api-Models-Erc20TransactionCollection-Result'></a>
### Result `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-Erc20TransactionCollection-Total'></a>
### Total `property`

##### Summary

The total number of matches for this query
example: 2000

<a name='M-Moralis-Web3Api-Models-Erc20TransactionCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc20TransactionCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Erc721Metadata'></a>
## Erc721Metadata `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Erc721Metadata-Name'></a>
### Name `property`

##### Summary

The name of the token Contract
example: Kylin Network

<a name='P-Moralis-Web3Api-Models-Erc721Metadata-Symbol'></a>
### Symbol `property`

##### Summary

The symbol of the NFT contract
example: KYL

<a name='P-Moralis-Web3Api-Models-Erc721Metadata-TokenUri'></a>
### TokenUri `property`

##### Summary



<a name='M-Moralis-Web3Api-Models-Erc721Metadata-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Erc721Metadata-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Unit-UnitConversion-EthUnit'></a>
## EthUnit `type`

##### Namespace

Moralis.Unit.UnitConversion

##### Summary

Define Ethereum divisional units.

<a name='T-Moralis-Web3Api-Models-Extensions'></a>
## Extensions `type`

##### Namespace

Moralis.Web3Api.Models

<a name='M-Moralis-Web3Api-Models-Extensions-GetChainEntry-Moralis-Web3Api-Models-NativeTokenBalanceBase-'></a>
### GetChainEntry(target) `method`

##### Summary

Returns the ChainEntry associated with the ChainId of the target.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Moralis.Web3Api.Models.NativeTokenBalanceBase](#T-Moralis-Web3Api-Models-NativeTokenBalanceBase 'Moralis.Web3Api.Models.NativeTokenBalanceBase') |  |

<a name='M-Moralis-Web3Api-Models-Extensions-ToBigNumber-System-String-'></a>
### ToBigNumber(val) `method`

##### Summary

Converts a numeric string to a BigIntegrer. If val is not a valid integer
result is 0

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Must be numeric |

<a name='M-Moralis-Web3Api-Models-Extensions-TokenSymbol-Moralis-Web3Api-Models-ChainList-'></a>
### TokenSymbol(target) `method`

##### Summary

Returns the symbol for the target Chain Id

##### Returns

string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') |  |

<a name='T-Moralis-Network-FileParameter'></a>
## FileParameter `type`

##### Namespace

Moralis.Network

##### Summary

Defines a parameter representing a file stream for nwetwork transfer.

<a name='M-Moralis-Network-FileParameter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Default constructor.

##### Parameters

This constructor has no parameters.

<a name='P-Moralis-Network-FileParameter-ContentLength'></a>
### ContentLength `property`

##### Summary

Length of the data stream.

<a name='P-Moralis-Network-FileParameter-ContentType'></a>
### ContentType `property`

##### Summary

Data ContentType

<a name='P-Moralis-Network-FileParameter-FileName'></a>
### FileName `property`

##### Summary

Name of the file being transfered.

<a name='P-Moralis-Network-FileParameter-Name'></a>
### Name `property`

##### Summary

Parameter name

<a name='P-Moralis-Network-FileParameter-Writer'></a>
### Writer `property`

##### Summary

Stream Writer object.

<a name='M-Moralis-Network-FileParameter-Create-System-String,System-Byte[],System-String,System-String-'></a>
### Create(name,data,filename,contentType) `method`

##### Summary

Creates a FileParameter

##### Returns

FileParameter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') |  |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| contentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Moralis-Network-FileParameter-Create-System-String,System-Byte[],System-String-'></a>
### Create(name,data,filename) `method`

##### Summary

Creates a FileParameter.

##### Returns

FileParameter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') |  |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Moralis-Network-FileParameter-Create-System-String,System-Action{System-IO-Stream},System-Int64,System-String,System-String-'></a>
### Create(name,writer,contentLength,fileName,contentType) `method`

##### Summary

Creates a FileParameter

##### Returns

FileParameter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| writer | [System.Action{System.IO.Stream}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.IO.Stream}') |  |
| contentLength | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| contentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-Unit-FormattingExtensions'></a>
## FormattingExtensions `type`

##### Namespace

Moralis.Unit

##### Summary

Defines formatting utility functions.

<a name='M-Moralis-Unit-FormattingExtensions-ToStringInvariant``1-``0-'></a>
### ToStringInvariant\`\`1() `method`

##### Summary

Converts formattable value to string in a culture-independent way.

##### Parameters

This method has no parameters.

<a name='T-Moralis-AuthApi-Models-HealthCheckResponse'></a>
## HealthCheckResponse `type`

##### Namespace

Moralis.AuthApi.Models

##### Summary

Authentication Api Server Healthcheck response.

<a name='P-Moralis-AuthApi-Models-HealthCheckResponse-Details'></a>
### Details `property`

##### Summary

Database status details.

<a name='P-Moralis-AuthApi-Models-HealthCheckResponse-Error'></a>
### Error `property`

##### Summary

Error detail if healthcheck fails.

<a name='P-Moralis-AuthApi-Models-HealthCheckResponse-Info'></a>
### Info `property`

##### Summary

Server information if successfull

<a name='P-Moralis-AuthApi-Models-HealthCheckResponse-Status'></a>
### Status `property`

##### Summary

Overall status of the endpoint.

<a name='T-Moralis-Web3Api-Models-HistoricalNftTransfer'></a>
## HistoricalNftTransfer `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-Address'></a>
### Address `property`

##### Summary

The address of the token
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-Amounts'></a>
### Amounts `property`

##### Summary

The amounts that were transfered

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-BlockHash'></a>
### BlockHash `property`

##### Summary

The block hash
example: 0x0372c302e3c52e8f2e15d155e2c545e6d802e479236564af052759253b20fd86

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The block number
example: 12526958

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 4/2/2021 10:07:54 AM

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-ContractType'></a>
### ContractType `property`

##### Summary

They contract type of the transfer
example: ERC721

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-FromAddress'></a>
### FromAddress `property`

##### Summary

The sender
example: 0xd4a3BebD824189481FC45363602b83C9c7e9cbDf

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-ToAddress'></a>
### ToAddress `property`

##### Summary

The recipient
example: 0x62AED87d21Ad0F3cdE4D147Fdcc9245401Af0044

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-TokenIds'></a>
### TokenIds `property`

##### Summary

The token ids of the tokens that were transfered

<a name='P-Moralis-Web3Api-Models-HistoricalNftTransfer-TransactionHash'></a>
### TransactionHash `property`

##### Summary

The transaction hash
example: 0x2d30ca6f024dbc1307ac8a1a44ca27de6f797ec22ef20627a1307243b0ab7d09

<a name='M-Moralis-Web3Api-Models-HistoricalNftTransfer-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-HistoricalNftTransfer-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-StreamsApi-Api-HistoryApi'></a>
## HistoryApi `type`

##### Namespace

Moralis.StreamsApi.Api

<a name='M-Moralis-StreamsApi-Api-HistoryApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [HistoryApi](#T-Moralis-StreamsApi-Api-HistoryApi 'Moralis.StreamsApi.Api.HistoryApi') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-StreamsApi-Api-HistoryApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [HistoryApi](#T-Moralis-StreamsApi-Api-HistoryApi 'Moralis.StreamsApi.Api.HistoryApi') class.

##### Parameters

This constructor has no parameters.

<a name='P-Moralis-StreamsApi-Api-HistoryApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-StreamsApi-Api-HistoryApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-StreamsApi-Api-HistoryApi-GetHistory-System-Int64,System-String-'></a>
### GetHistory(limit,cursor) `method`

##### Summary

Retrieves history.

##### Returns

LogResponse

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| limit | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | double |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-StreamsApi-Api-HistoryApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Web3Api-Interfaces-IAccountApi'></a>
## IAccountApi `type`

##### Namespace

Moralis.Web3Api.Interfaces

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Interfaces-IAccountApi-GetNFTTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTTransfers(address,chain,format,direction,offset,limit) `method`

##### Summary

Gets the transfers of the tokens matching the given parameters

##### Returns

Returns a collection of NFT transfer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The sender or recepient of the transfer |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| direction | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The transfer direction |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-IAccountApi-GetNFTs-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTs(address,chain,format,offset,limit) `method`

##### Summary

Gets NFTs owned by the given address
* The response will include status [SYNCED/SYNCING] based on the contracts being indexed.
* Use the token_address param to get results for a specific contract only
* Note results will include all indexed NFTs
* Any request which includes the token_address param will start the indexing process for that NFT collection the very first time it is requested

##### Returns

Returns a collection of nft owners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The owner of a given token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-IAccountApi-GetNFTsForContract-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTsForContract(address,tokenAddress,chain,format,offset,limit) `method`

##### Summary

Gets NFTs owned by the given address
* Use the token_address param to get results for a specific contract only
* Note results will include all indexed NFTs
* Any request which includes the token_address param will start the indexing process for that NFT collection the very first time it is requested

##### Returns

Returns a collection of nft owners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The owner of a given token |
| tokenAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-IAccountApi-GetNativeBalance-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Decimal}-'></a>
### GetNativeBalance(address,chain,providerUrl,toBlock) `method`

##### Summary

Gets native balance for a specific address

##### Returns

Returns native balance for a specific address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address for which the native balance will be checked |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| toBlock | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | The block number on which the balances should be checked |

<a name='M-Moralis-Web3Api-Interfaces-IAccountApi-GetTokenBalances-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Decimal}-'></a>
### GetTokenBalances(address,chain,subdomain,toBlock) `method`

##### Summary

Gets token balances for a specific address

##### Returns

Returns token balances for a specific address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address for which token balances will be checked |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| toBlock | [System.Nullable{System.Decimal}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Decimal}') | The block number on which the balances should be checked |

<a name='M-Moralis-Web3Api-Interfaces-IAccountApi-GetTokenTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetTokenTransfers(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets ERC20 token transactions in descending order based on block number

##### Returns

Returns a collection of token transactions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the transactions
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the transactions.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The date from where to get the transactions (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the transactions to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-IAccountApi-GetTransactions-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetTransactions(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets native transactions in descending order based on block number

##### Returns

Returns a collection of native transactions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the transactions
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the transactions.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The date from where to get the transactions (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the transactions to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='T-Moralis-AuthApi-Interfaces-IAuthClientApi'></a>
## IAuthClientApi `type`

##### Namespace

Moralis.AuthApi.Interfaces

##### Summary

Defines methods and properties of an Authentication Api Client

<a name='P-Moralis-AuthApi-Interfaces-IAuthClientApi-AuthEndpoint'></a>
### AuthEndpoint `property`

##### Summary

Target Authentication Endpoint.

<a name='P-Moralis-AuthApi-Interfaces-IAuthClientApi-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates that the client has been initialized.

<a name='M-Moralis-AuthApi-Interfaces-IAuthClientApi-Initialize-System-String-'></a>
### Initialize(serverUrl) `method`

##### Summary

Initialize the client using serverUrl. If serverUrl is null default is used. 
ApiKey is passed via Configuration signleton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-AuthApi-Interfaces-IAuthenticationApi'></a>
## IAuthenticationApi `type`

##### Namespace

Moralis.AuthApi.Interfaces

##### Summary

Defines properties and methods of an Authentication Api Endpoint.

<a name='M-Moralis-AuthApi-Interfaces-IAuthenticationApi-Challenge-Moralis-AuthApi-Models-ChallengeRequestDto,Moralis-AuthApi-Models-ChainNetworkType-'></a>
### Challenge(request,network) `method`

##### Summary

Calls the Moralis Authentication Api Challenge operation to generate an authentication message.

##### Returns

ChallengeResponseDto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Moralis.AuthApi.Models.ChallengeRequestDto](#T-Moralis-AuthApi-Models-ChallengeRequestDto 'Moralis.AuthApi.Models.ChallengeRequestDto') |  |
| network | [Moralis.AuthApi.Models.ChainNetworkType](#T-Moralis-AuthApi-Models-ChainNetworkType 'Moralis.AuthApi.Models.ChainNetworkType') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ApiException](#!-ApiException 'ApiException') |  |

<a name='M-Moralis-AuthApi-Interfaces-IAuthenticationApi-CompleteChallenge-Moralis-AuthApi-Models-CompleteChallengeRequestDto,Moralis-AuthApi-Models-ChainNetworkType-'></a>
### CompleteChallenge(request,network) `method`

##### Summary

After a message is signed this operation is used to call the Moralis Authentication Challenge Verify operation to validate the signature.

##### Returns

CompleteChallengeResponseDto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Moralis.AuthApi.Models.CompleteChallengeRequestDto](#T-Moralis-AuthApi-Models-CompleteChallengeRequestDto 'Moralis.AuthApi.Models.CompleteChallengeRequestDto') |  |
| network | [Moralis.AuthApi.Models.ChainNetworkType](#T-Moralis-AuthApi-Models-ChainNetworkType 'Moralis.AuthApi.Models.ChainNetworkType') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ApiException](#!-ApiException 'ApiException') |  |

<a name='M-Moralis-AuthApi-Interfaces-IAuthenticationApi-HealthCheck'></a>
### HealthCheck() `method`

##### Summary

Exposes the HealthCheck operation of the Moralis Authentication API which enables client applications a way to determine that the Moralis Authentrication Api is available.

##### Returns

HealthCheckResponse

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ApiException](#!-ApiException 'ApiException') |  |

<a name='T-Moralis-StreamsApi-Interfaces-IBetaApi'></a>
## IBetaApi `type`

##### Namespace

Moralis.StreamsApi.Interfaces

<a name='M-Moralis-StreamsApi-Interfaces-IBetaApi-GetStats'></a>
### GetStats() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Interfaces-IDefiApi'></a>
## IDefiApi `type`

##### Namespace

Moralis.Web3Api.Interfaces

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Interfaces-IDefiApi-GetPairAddress-System-String,System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String-'></a>
### GetPairAddress(exchange,token0Address,token1Address,chain,toBlock,toDate) `method`

##### Summary

Fetches and returns pair data of the provided token0+token1 combination.
The token0 and token1 options are interchangable (ie. there is no different outcome in "token0=WETH and token1=USDT" or "token0=USDT and token1=WETH")

##### Returns

Returns the pair address of the two tokens

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exchange | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The factory name or address of the token exchange |
| token0Address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Token0 address |
| token1Address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Token1 address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| toBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | To get the reserves at this block number |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the reserves to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |

<a name='M-Moralis-Web3Api-Interfaces-IDefiApi-GetPairReserves-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String-'></a>
### GetPairReserves(pairAddress,chain,toBlock,toDate,providerUrl) `method`

##### Summary

Get the liquidity reserves for a given pair address

##### Returns

Returns the pair reserves

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pairAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Liquidity pair address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| toBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | To get the reserves at this block number |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the reserves to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='T-Moralis-StreamsApi-Interfaces-IHistoryApi'></a>
## IHistoryApi `type`

##### Namespace

Moralis.StreamsApi.Interfaces

<a name='M-Moralis-StreamsApi-Interfaces-IHistoryApi-GetHistory-System-Int64,System-String-'></a>
### GetHistory(limit,cursor) `method`

##### Summary

Returns Webhook information - currently only Failed webhook information returned.

##### Returns

HistoryResponse

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| limit | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Moralis-StreamsApi-Interfaces-IHistoryApi-ReplayHistory-System-String-'></a>
### ReplayHistory(id) `method`

##### Summary

Replay a specific history.

##### Returns

HistoryDetail

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-Web3Api-Interfaces-INativeApi'></a>
## INativeApi `type`

##### Namespace

Moralis.Web3Api.Interfaces

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Interfaces-INativeApi-GetBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetBlock(blockNumberOrHash,chain,subdomain) `method`

##### Summary

Gets the contents of a block by block hash

##### Returns

Returns the contents of a block

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| blockNumberOrHash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The block hash or block number |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |

<a name='M-Moralis-Web3Api-Interfaces-INativeApi-GetContractEvents-System-String,System-String,System-Object,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}-'></a>
### GetContractEvents(address,topic,abi,chain,subdomain,providerUrl,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets events in descending order based on block number

##### Returns

Returns a collection of events by topic

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| topic | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The topic of the event |
| abi | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | ABI of the specific event |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| fromBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The minimum block number from where to get the logs
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the logs.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The date from where to get the logs (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the logs to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-INativeApi-GetDateToBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetDateToBlock(date,chain,providerUrl) `method`

##### Summary

Gets the closest block of the provided date

##### Returns

Returns the blocknumber and corresponding date and timestamp

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unix date in miliseconds or a datestring (any format that is accepted by momentjs) |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='M-Moralis-Web3Api-Interfaces-INativeApi-GetLogsByAddress-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetLogsByAddress(address,chain,subdomain,blockNumber,fromBlock,toBlock,fromDate,toDate,topic0,topic1,topic2,topic3) `method`

##### Summary

Gets the logs from an address

##### Returns

Returns the logs of an address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| blockNumber | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The block number
* Provide the param 'block_numer' or ('from_block' and / or 'to_block')
* If 'block_numer' is provided in conbinaison with 'from_block' and / or 'to_block', 'block_number' will will be used |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the logs
* Provide the param 'block_numer' or ('from_block' and / or 'to_block')
* If 'block_numer' is provided in conbinaison with 'from_block' and / or 'to_block', 'block_number' will will be used |
| toBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum block number from where to get the logs
* Provide the param 'block_numer' or ('from_block' and / or 'to_block')
* If 'block_numer' is provided in conbinaison with 'from_block' and / or 'to_block', 'block_number' will will be used |
| fromDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The date from where to get the logs (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used.
* If 'from_date' and the block params are provided, the block params will be used. Please refer to the blocks params sections (block_number,from_block and to_block) on how to use them |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the logs to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used.
* If 'to_date' and the block params are provided, the block params will be used. Please refer to the blocks params sections (block_number,from_block and to_block) on how to use them |
| topic0 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | topic0 |
| topic1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | topic1 |
| topic2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | topic2 |
| topic3 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | topic3 |

<a name='M-Moralis-Web3Api-Interfaces-INativeApi-GetNFTTransfersByBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTTransfersByBlock(blockNumberOrHash,chain,subdomain,offset,limit) `method`

##### Summary

Gets NFT transfers by block number or block hash

##### Returns

Returns the contents of a block

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| blockNumberOrHash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The block hash or block number |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-INativeApi-GetTransaction-System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetTransaction(transactionHash,chain,subdomain) `method`

##### Summary

Gets the contents of a block transaction by hash

##### Returns

Returns the contents of a block transaction

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| transactionHash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The transaction hash |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |

<a name='M-Moralis-Web3Api-Interfaces-INativeApi-RunContractFunction``1-System-String,System-String,Moralis-Web3Api-Models-RunContractDto,Moralis-Web3Api-Models-ChainList,System-String,System-String-'></a>
### RunContractFunction\`\`1(address,functionName,abi,chain,subdomain,providerUrl) `method`

##### Summary

Runs a given function of a contract abi and returns readonly data

##### Returns

Returns response of the function executed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| functionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | function_name |
| abi | [Moralis.Web3Api.Models.RunContractDto](#T-Moralis-Web3Api-Models-RunContractDto 'Moralis.Web3Api.Models.RunContractDto') | Body |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='T-Moralis-Web3Api-Interfaces-IResolveApi'></a>
## IResolveApi `type`

##### Namespace

Moralis.Web3Api.Interfaces

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Interfaces-IResolveApi-ResolveAddress-System-String-'></a>
### ResolveAddress(address) `method`

##### Summary

Resolves an ETH address and find the ENS name

##### Returns

Returns an ENS

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address to be resolved |

<a name='M-Moralis-Web3Api-Interfaces-IResolveApi-ResolveDomain-System-String,System-String-'></a>
### ResolveDomain(domain,currency) `method`

##### Summary

Resolves an Unstoppable domain and returns the address

##### Returns

Returns an address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Domain to be resolved |
| currency | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The currency to query |

<a name='T-Moralis-SolanaApi-Interfaces-ISolanaApi'></a>
## ISolanaApi `type`

##### Namespace

Moralis.SolanaApi.Interfaces

<a name='P-Moralis-SolanaApi-Interfaces-ISolanaApi-Account'></a>
### Account `property`

##### Summary

AccountApi operations.

<a name='P-Moralis-SolanaApi-Interfaces-ISolanaApi-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates that the client has been initialized.

<a name='P-Moralis-SolanaApi-Interfaces-ISolanaApi-Nft'></a>
### Nft `property`

##### Summary

TokenApi operations.

<a name='M-Moralis-SolanaApi-Interfaces-ISolanaApi-Initialize-System-String-'></a>
### Initialize(serverUrl) `method`

##### Summary

Initialize the client using serverUrl. If serverUrl is null default is used. 
ApiKey is passed via Configuration signleton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-Web3Api-Interfaces-IStorageApi'></a>
## IStorageApi `type`

##### Namespace

Moralis.Web3Api.Interfaces

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Interfaces-IStorageApi-UploadFolder-System-Collections-Generic-List{Moralis-Web3Api-Models-IpfsFileRequest}-'></a>
### UploadFolder(abi) `method`

##### Summary

Uploads multiple files and place them in a folder directory

##### Returns

Returns the path to the uploaded files

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| abi | [System.Collections.Generic.List{Moralis.Web3Api.Models.IpfsFileRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Moralis.Web3Api.Models.IpfsFileRequest}') | Array of JSON and Base64 Supported |

<a name='T-Moralis-StreamsApi-Interfaces-IStreamsApi'></a>
## IStreamsApi `type`

##### Namespace

Moralis.StreamsApi.Interfaces

<a name='M-Moralis-StreamsApi-Interfaces-IStreamsApi-BindStream-Moralis-StreamsApi-Models-StreamBindingDto-'></a>
### BindStream(req) `method`

##### Summary

Creates a new stream.

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| req | [Moralis.StreamsApi.Models.StreamBindingDto](#T-Moralis-StreamsApi-Models-StreamBindingDto 'Moralis.StreamsApi.Models.StreamBindingDto') |  |

<a name='M-Moralis-StreamsApi-Interfaces-IStreamsApi-DeleteStream-System-String-'></a>
### DeleteStream(id) `method`

##### Summary

Delete a specific stream.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Moralis-StreamsApi-Interfaces-IStreamsApi-GetStream-System-String-'></a>
### GetStream(id) `method`

##### Summary

Get a specific stream.

##### Returns

StreamBindingDto[]

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Moralis-StreamsApi-Interfaces-IStreamsApi-UpdateStream-Moralis-StreamsApi-Models-StreamBindingDto-'></a>
### UpdateStream(req) `method`

##### Summary

Updates a specific stream.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| req | [Moralis.StreamsApi.Models.StreamBindingDto](#T-Moralis-StreamsApi-Models-StreamBindingDto 'Moralis.StreamsApi.Models.StreamBindingDto') |  |

<a name='T-Moralis-StreamsApi-Interfaces-IStreamsApiClient'></a>
## IStreamsApiClient `type`

##### Namespace

Moralis.StreamsApi.Interfaces

<a name='P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-BetaEndpoint'></a>
### BetaEndpoint `property`

##### Summary



<a name='P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-HistoryEndpoint'></a>
### HistoryEndpoint `property`

##### Summary



<a name='P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates that the client has been initialized.

<a name='P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-SettingsEndpoint'></a>
### SettingsEndpoint `property`

##### Summary

Target Settings Endpoint

<a name='P-Moralis-StreamsApi-Interfaces-IStreamsApiClient-StreamsEndpoint'></a>
### StreamsEndpoint `property`

##### Summary

Target Streams Endpoint

<a name='M-Moralis-StreamsApi-Interfaces-IStreamsApiClient-Initialize-System-String-'></a>
### Initialize(serverUrl) `method`

##### Summary

Initialize the client using serverUrl. If serverUrl is null default is used. 
ApiKey is passed via Configuration signleton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Moralis-StreamsApi-Interfaces-IStreamsApiClient-VerifySignature-System-String,System-String-'></a>
### VerifySignature(signature,requestBody) `method`

##### Summary

Verifies that a WebHook message was sent by Moralis using sha3(REQUEST_BODY + WEB3_API_KEY);

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| signature | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| requestBody | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-Web3Api-Interfaces-ITokenApi'></a>
## ITokenApi `type`

##### Namespace

Moralis.Web3Api.Interfaces

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetAllTokenIds-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetAllTokenIds(address,chain,format,offset,limit) `method`

##### Summary

Gets data, including metadata (where available), for all token ids for the given contract address.
* Results are sorted by the block the token id was minted (descending) and limited to 100 per page by default
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns a collection of nfts

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetContractNFTTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetContractNFTTransfers(address,chain,format,offset,limit) `method`

##### Summary

Gets the transfers of the tokens matching the given parameters

##### Returns

Returns a collection of NFT transfers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetNFTLowestPrice-System-String,Moralis-Web3Api-Models-ChainList,System-Nullable{System-Int32},System-String,System-String-'></a>
### GetNFTLowestPrice(address,chain,days,providerUrl,marketplace) `method`

##### Summary

Get the lowest price found for a nft token contract for the last x days (only trades paid in ETH)

##### Returns

Returns the trade with the lowest price

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| days | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The number of days to look back to find the lowest price
If not provided 7 days will be the default |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| marketplace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | marketplace from where to get the trades (only opensea is supported at the moment) |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetNFTMetadata-System-String,Moralis-Web3Api-Models-ChainList-'></a>
### GetNFTMetadata(address,chain) `method`

##### Summary

Gets the contract level metadata (name, symbol, base token uri) for the given contract
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns a collection NFT collections.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetNFTOwners-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTOwners(address,chain,format,offset,limit) `method`

##### Summary

Gets all owners of NFT items within a given contract collection
* Use after /nft/contract/{token_address} to find out who owns each token id in a collection
* Make sure to include a sort parm on a column like block_number_minted for consistent pagination results
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns a collection of nft owners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetNFTTrades-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-String,System-String,System-String,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTTrades(address,chain,fromBlock,toBlock,fromDate,toDate,providerUrl,marketplace,offset,limit) `method`

##### Summary

Get the nft trades for a given contracts and marketplace

##### Returns

Returns the trades

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the transfers
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | To get the reserves at this block number |
| fromDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The date from where to get the transfers (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the reserves to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| marketplace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | marketplace from where to get the trades (only opensea is supported at the moment) |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetNftTransfersFromToBlock-Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNftTransfersFromToBlock(chain,fromBlock,toBlock,fromDate,toDate,format,offset,limit) `method`

##### Summary

Gets the transfers of the tokens from a block number to a block number

##### Returns

Returns a collection of NFT transfers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the transfers
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the transfers.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The date from where to get the transfers (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get transfers up until this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenAddressTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}-'></a>
### GetTokenAddressTransfers(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets ERC20 token contract transactions in descending order based on block number

##### Returns

Returns a collection of token contract transactions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| fromBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The minimum block number from where to get the transfers
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the transfers.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The date from where to get the transfers (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the transfers to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenAllowance-System-String,System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetTokenAllowance(address,ownerAddress,spenderAddress,chain,providerUrl) `method`

##### Summary

Gets the amount which the spender is allowed to withdraw from the spender

##### Returns

Returns the amount which the spender is allowed to withdraw from the owner..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token contract |
| ownerAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token owner |
| spenderAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token spender |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenIdMetadata-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetTokenIdMetadata(address,tokenId,chain,format) `method`

##### Summary

Gets data, including metadata (where available), for the given token id of the given contract address.
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns the specified NFT

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| tokenId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenIdOwners-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetTokenIdOwners(address,tokenId,chain,format,offset,limit) `method`

##### Summary

Gets all owners of NFT items within a given contract collection
* Use after /nft/contract/{token_address} to find out who owns each token id in a collection
* Make sure to include a sort parm on a column like block_number_minted for consistent pagination results
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns a collection of NFTs with their respective owners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| tokenId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenMetadata-System-Collections-Generic-List{System-String},Moralis-Web3Api-Models-ChainList,System-String,System-String-'></a>
### GetTokenMetadata(addresses,chain,subdomain,providerUrl) `method`

##### Summary

Returns metadata (name, symbol, decimals, logo) for a given token contract address.

##### Returns

Returns metadata (name, symbol, decimals, logo) for a given token contract address.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| addresses | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | The addresses to get metadata for |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenMetadataBySymbol-System-Collections-Generic-List{System-String},Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetTokenMetadataBySymbol(symbols,chain,subdomain) `method`

##### Summary

Returns metadata (name, symbol, decimals, logo) for a given token contract address.

##### Returns

Returns metadata (name, symbol, decimals, logo) for a given token contract address.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbols | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | The symbols to get metadata for |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetTokenPrice-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetTokenPrice(address,chain,providerUrl,exchange,toBlock) `method`

##### Summary

Returns the price nominated in the native token and usd for a given token contract address.

##### Returns

Returns the price nominated in the native token and usd for a given token contract address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| exchange | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The factory name or address of the token exchange |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | to_block |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-GetWalletTokenIdTransfers-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-String-'></a>
### GetWalletTokenIdTransfers(address,tokenId,chain,format,offset,limit,order) `method`

##### Summary

Gets the transfers of the tokens matching the given parameters

##### Returns

Returns a collection of NFT transfers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| tokenId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |
| order | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The field(s) to order on and if it should be ordered in ascending or descending order. Specified by: fieldName1.order,fieldName2.order. Example 1: "block_number", "block_number.ASC", "block_number.DESC", Example 2: "block_number and contract_type", "block_number.ASC,contract_type.DESC" |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-ReSyncMetadata-System-String,System-String,Moralis-Web3Api-Models-ChainList-'></a>
### ReSyncMetadata(address,tokenId,chain) `method`

##### Summary

ReSync the metadata for an NFT

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| tokenId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-SearchNFTs-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}-'></a>
### SearchNFTs(q,chain,format,filter,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets NFTs that match a given metadata search.

##### Returns

Returns the matching NFTs

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| q | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The search string |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | What fields the search should match on. To look into the entire metadata set the value to 'global'. To have a better response time you can look into a specific field like name |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to start the search
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to end the search
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The date from where to start the search (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get search results up until this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Interfaces-ITokenApi-SyncNFTContract-System-String,Moralis-Web3Api-Models-ChainList-'></a>
### SyncNFTContract(address,chain) `method`

##### Summary

Sync a Contract for NFT Index

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |

<a name='T-Moralis-Web3Api-Interfaces-IWeb3Api'></a>
## IWeb3Api `type`

##### Namespace

Moralis.Web3Api.Interfaces

<a name='P-Moralis-Web3Api-Interfaces-IWeb3Api-Account'></a>
### Account `property`

##### Summary

AccountApi operations.

<a name='P-Moralis-Web3Api-Interfaces-IWeb3Api-Defi'></a>
### Defi `property`

##### Summary

DefiApi operations

<a name='P-Moralis-Web3Api-Interfaces-IWeb3Api-Info'></a>
### Info `property`

##### Summary

InfoApi operations

<a name='P-Moralis-Web3Api-Interfaces-IWeb3Api-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates that the client has been initialized.

<a name='P-Moralis-Web3Api-Interfaces-IWeb3Api-Native'></a>
### Native `property`

##### Summary

NativeApi operations.

<a name='P-Moralis-Web3Api-Interfaces-IWeb3Api-Resolve'></a>
### Resolve `property`

##### Summary

ResolveApi operations.

<a name='P-Moralis-Web3Api-Interfaces-IWeb3Api-Storage'></a>
### Storage `property`

##### Summary

StorageApi operations.

<a name='P-Moralis-Web3Api-Interfaces-IWeb3Api-Token'></a>
### Token `property`

##### Summary

TokenApi operations.

<a name='M-Moralis-Web3Api-Interfaces-IWeb3Api-Initialize-System-String-'></a>
### Initialize(serverUrl) `method`

##### Summary

Initialize the client using serverUrl. If serverUrl is null default is used. 
ApiKey is passed via Configuration signleton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-SolanaApi-Interfaces-IWebClient'></a>
## IWebClient `type`

##### Namespace

Moralis.SolanaApi.Interfaces

<a name='T-Moralis-Web3Api-Interfaces-IWebClient'></a>
## IWebClient `type`

##### Namespace

Moralis.Web3Api.Interfaces

<a name='M-Moralis-SolanaApi-Interfaces-IWebClient-ExecuteAsync-Moralis-SolanaApi-Models-WebRequest-'></a>
### ExecuteAsync(httpRequest) `method`

##### Summary

Executes HTTP request to a [Target](#P-Moralis-SolanaApi-Models-WebRequest-Target 'Moralis.SolanaApi.Models.WebRequest.Target') with [Method](#P-Moralis-SolanaApi-Models-WebRequest-Method 'Moralis.SolanaApi.Models.WebRequest.Method') HTTP verb
and [Headers](#P-Moralis-SolanaApi-Models-WebRequest-Headers 'Moralis.SolanaApi.Models.WebRequest.Headers').

##### Returns

A task that resolves to Htt

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpRequest | [Moralis.SolanaApi.Models.WebRequest](#T-Moralis-SolanaApi-Models-WebRequest 'Moralis.SolanaApi.Models.WebRequest') | The HTTP request to be executed. |

<a name='M-Moralis-Web3Api-Interfaces-IWebClient-ExecuteAsync-Moralis-Web3Api-Models-WebRequest-'></a>
### ExecuteAsync(httpRequest) `method`

##### Summary

Executes HTTP request to a [Target](#P-Moralis-Web3Api-Models-WebRequest-Target 'Moralis.Web3Api.Models.WebRequest.Target') with [Method](#P-Moralis-Web3Api-Models-WebRequest-Method 'Moralis.Web3Api.Models.WebRequest.Method') HTTP verb
and [Headers](#P-Moralis-Web3Api-Models-WebRequest-Headers 'Moralis.Web3Api.Models.WebRequest.Headers').

##### Returns

A task that resolves to Htt

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpRequest | [Moralis.Web3Api.Models.WebRequest](#T-Moralis-Web3Api-Models-WebRequest 'Moralis.Web3Api.Models.WebRequest') | The HTTP request to be executed. |

<a name='T-Moralis-Web3Api-Api-InfoApi'></a>
## InfoApi `type`

##### Namespace

Moralis.Web3Api.Api

<a name='M-Moralis-Web3Api-Api-InfoApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [DefiApi](#T-Moralis-Web3Api-Api-DefiApi 'Moralis.Web3Api.Api.DefiApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-Web3Api-Api-InfoApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DefiApi](#T-Moralis-Web3Api-Api-DefiApi 'Moralis.Web3Api.Api.DefiApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='P-Moralis-Web3Api-Api-InfoApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-Web3Api-Api-InfoApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-InfoApi-GetEndpointWeights'></a>
### GetEndpointWeights() `method`

##### Summary

Returns the endpoint price list for rate limits and costs.

##### Returns



##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-Web3Api-Api-InfoApi-GetWeb3ApiVersion'></a>
### GetWeb3ApiVersion() `method`

##### Summary

Returns the current version of the Web3 API

##### Returns



##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-Web3Api-Api-InfoApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Web3Api-Models-IpfsFile'></a>
## IpfsFile `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-IpfsFile-Path'></a>
### Path `property`

##### Summary

Path to file
example: https://ipfs.moralis.io/QmPQ3YJ3hgfsBzJ1U4MGyV2C1GhDy6MWCENr1qMdMpKVnY/moralis/logo.jpg

<a name='M-Moralis-Web3Api-Models-IpfsFile-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-IpfsFile-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-IpfsFileRequest'></a>
## IpfsFileRequest `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-IpfsFileRequest-Content'></a>
### Content `property`

##### Summary

base64 or JSON
example: iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAApgAAAKYB3X3

<a name='P-Moralis-Web3Api-Models-IpfsFileRequest-Path'></a>
### Path `property`

##### Summary

Path to file
example: moralis/logo.jpg

<a name='M-Moralis-Web3Api-Models-IpfsFileRequest-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-IpfsFileRequest-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Log'></a>
## Log `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Log-Address'></a>
### Address `property`

##### Summary

The address of the contract
example: 0x3105d328c66d8d55092358cf595d54608178e9b5

<a name='P-Moralis-Web3Api-Models-Log-BlockHash'></a>
### BlockHash `property`

##### Summary

The hash of the block
example: 0x9b559aef7ea858608c2e554246fe4a24287e7aeeb976848df2b9a2531f4b9171

<a name='P-Moralis-Web3Api-Models-Log-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The block number
example: 12386788

<a name='P-Moralis-Web3Api-Models-Log-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The timestamp of the block
example: 5/7/2021 11:08:35 AM

<a name='P-Moralis-Web3Api-Models-Log-Data'></a>
### Data `property`

##### Summary

The data of the log
example: 0x00000000000000000000000000000000000000000000000de05239bccd4d537400000000000000000000000000024dbc80a9f80e3d5fc0a0ee30e2693781a443

<a name='P-Moralis-Web3Api-Models-Log-LogIndex'></a>
### LogIndex `property`

##### Summary

example: 273

<a name='P-Moralis-Web3Api-Models-Log-Topic0'></a>
### Topic0 `property`

##### Summary

example: 0x2caecd17d02f56fa897705dcc740da2d237c373f70686f4e0d9bd3bf0400ea7a

<a name='P-Moralis-Web3Api-Models-Log-Topic1'></a>
### Topic1 `property`

##### Summary

example: 0x000000000000000000000000031002d15b0d0cd7c9129d6f644446368deae391

<a name='P-Moralis-Web3Api-Models-Log-Topic2'></a>
### Topic2 `property`

##### Summary

example: 0x000000000000000000000000d25943be09f968ba740e0782a34e710100defae9

<a name='P-Moralis-Web3Api-Models-Log-Topic3'></a>
### Topic3 `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-Log-TransactionHash'></a>
### TransactionHash `property`

##### Summary

The hash of the transaction
example: 0xdd9006489e46670e0e85d1fb88823099e7f596b08aeaac023e9da0851f26fdd5

<a name='P-Moralis-Web3Api-Models-Log-TransactionIndex'></a>
### TransactionIndex `property`

##### Summary

example: 204

<a name='M-Moralis-Web3Api-Models-Log-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Log-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-LogEvent'></a>
## LogEvent `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-LogEvent-Address'></a>
### Address `property`

##### Summary

The address of the contract
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-LogEvent-BlockHash'></a>
### BlockHash `property`

##### Summary

The block hash
example: 0x0372c302e3c52e8f2e15d155e2c545e6d802e479236564af052759253b20fd86

<a name='P-Moralis-Web3Api-Models-LogEvent-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The block number
example: 12526958

<a name='P-Moralis-Web3Api-Models-LogEvent-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 4/2/2021 10:07:54 AM

<a name='P-Moralis-Web3Api-Models-LogEvent-Data'></a>
### Data `property`

##### Summary

The content of the event

<a name='P-Moralis-Web3Api-Models-LogEvent-TransactionHash'></a>
### TransactionHash `property`

##### Summary

The transaction hash
example: 0x2d30ca6f024dbc1307ac8a1a44ca27de6f797ec22ef20627a1307243b0ab7d09

<a name='M-Moralis-Web3Api-Models-LogEvent-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-LogEvent-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-LogEventByAddress'></a>
## LogEventByAddress `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-Address'></a>
### Address `property`

##### Summary

The address of the contract
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-BlockHash'></a>
### BlockHash `property`

##### Summary

The block hash
example: 0x0372c302e3c52e8f2e15d155e2c545e6d802e479236564af052759253b20fd86

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The block number
example: 12526958

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 4/2/2021 10:07:54 AM

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-Data'></a>
### Data `property`

##### Summary

The data of the log
example: 0x00000000000000000000000000000000000000000000000de05239bccd4d537400000000000000000000000000024dbc80a9f80e3d5fc0a0ee30e2693781a443

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-Topic0'></a>
### Topic0 `property`

##### Summary

example: 0x2caecd17d02f56fa897705dcc740da2d237c373f70686f4e0d9bd3bf0400ea7a

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-Topic1'></a>
### Topic1 `property`

##### Summary

example: 0x000000000000000000000000031002d15b0d0cd7c9129d6f644446368deae391

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-Topic2'></a>
### Topic2 `property`

##### Summary

example: 0x000000000000000000000000d25943be09f968ba740e0782a34e710100defae9

<a name='P-Moralis-Web3Api-Models-LogEventByAddress-Topic3'></a>
### Topic3 `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-LogEventByAddress-TransactionHash'></a>
### TransactionHash `property`

##### Summary

The transaction hash
example: 0x2d30ca6f024dbc1307ac8a1a44ca27de6f797ec22ef20627a1307243b0ab7d09

<a name='M-Moralis-Web3Api-Models-LogEventByAddress-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-LogEventByAddress-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Network-Method'></a>
## Method `type`

##### Namespace

Moralis.Network

##### Summary

REST Verbs

<a name='T-Moralis-AuthApi-MoralisAuthApiClient'></a>
## MoralisAuthApiClient `type`

##### Namespace

Moralis.AuthApi

##### Summary

Provides an easy to wrapper around the Moralis Web3Api REST services.

<a name='P-Moralis-AuthApi-MoralisAuthApiClient-AuthenticationApi'></a>
### AuthenticationApi `property`

##### Summary

Gets the AuthApiClient instance. Moralis.Initialize must be called first.
If Moralis is not initialized this will throw an ApiException.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') | Thrown when Moralis.Initialize has not been called. |

<a name='M-Moralis-AuthApi-MoralisAuthApiClient-Initialize-System-String,System-String-'></a>
### Initialize(apiKey,url) `method`

##### Summary

Initialize Moralis Web3API.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Required if useStandardServer is true |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional server url. If not provided default standard server Url is used. |

<a name='T-Moralis-MoralisClient'></a>
## MoralisClient `type`

##### Namespace

Moralis

##### Summary

Main object used to access Moralis APIs and other functioinality. 

The MoralisClient is provided as a singleto object. It need only 
be setup once within an application.

Before the Moralis Client can be used, it must be started (initialized). 
There are several ways to do the, however the easiest way to do so is 
to setup _MoralisClient.ConnectionData_ before doing anything else with 
the MoralisClient. The MoralisClient is self initializing provided 
_MoralisClient.ConnectionData_ has been setup with valid information.

For Example:

```
MoralisClient.ConnectionData = new ServerConnectionData()
{
    ApiKey = "YOUR API KEY HERE"
};
IWeb3Api apiClient = MoralisClient.Web3Api;
```

This code is perfectly valid as, since ConnectionData was instantiated properly, 
calling any public class level object on MoralisClient will, if MoralisClient
has not already been initialize, automatically initialize MoralisClient
using the information provided in ConnectionData.

<a name='M-Moralis-MoralisClient-#ctor-Moralis-Models-ServerConnectionData,Moralis-AuthApi-Interfaces-IAuthClientApi,Moralis-SolanaApi-Interfaces-ISolanaApi,Moralis-StreamsApi-Interfaces-IStreamsApiClient,Moralis-Web3Api-Interfaces-IWeb3Api-'></a>
### #ctor(connectionData,authApi,streamsApi,web3Api) `constructor`

##### Summary

Creates an instance of the Moralis Client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| connectionData | [Moralis.Models.ServerConnectionData](#T-Moralis-Models-ServerConnectionData 'Moralis.Models.ServerConnectionData') |  |
| authApi | [Moralis.AuthApi.Interfaces.IAuthClientApi](#T-Moralis-AuthApi-Interfaces-IAuthClientApi 'Moralis.AuthApi.Interfaces.IAuthClientApi') |  |
| streamsApi | [Moralis.SolanaApi.Interfaces.ISolanaApi](#T-Moralis-SolanaApi-Interfaces-ISolanaApi 'Moralis.SolanaApi.Interfaces.ISolanaApi') |  |
| web3Api | [Moralis.StreamsApi.Interfaces.IStreamsApiClient](#T-Moralis-StreamsApi-Interfaces-IStreamsApiClient 'Moralis.StreamsApi.Interfaces.IStreamsApiClient') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='P-Moralis-MoralisClient-AuthenticationApi'></a>
### AuthenticationApi `property`

##### Summary

Instance of the Authentication API

<a name='P-Moralis-MoralisClient-ConnectionData'></a>
### ConnectionData `property`

##### Summary

The information used to connect to Moralis Services

<a name='P-Moralis-MoralisClient-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates if the Moralis Client has been initialized.

<a name='P-Moralis-MoralisClient-SolanaApi'></a>
### SolanaApi `property`

##### Summary

Instance of the Solana API

<a name='P-Moralis-MoralisClient-StreamsApi'></a>
### StreamsApi `property`

##### Summary

Instance of the Streams Api

<a name='P-Moralis-MoralisClient-Web3Api'></a>
### Web3Api `property`

##### Summary

Instance of the Web3 Api

<a name='M-Moralis-MoralisClient-Start'></a>
### Start() `method`

##### Summary

Default initializer of the Moralis Client

##### Parameters

This method has no parameters.

<a name='M-Moralis-MoralisClient-Start-Moralis-Models-ServerConnectionData-'></a>
### Start(connectionData) `method`

##### Summary

Initialize Moralis Client using Connection Data to derive all API clients

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| connectionData | [Moralis.Models.ServerConnectionData](#T-Moralis-Models-ServerConnectionData 'Moralis.Models.ServerConnectionData') |  |

<a name='M-Moralis-MoralisClient-Start-Moralis-Models-ServerConnectionData,Moralis-AuthApi-Interfaces-IAuthClientApi,Moralis-SolanaApi-Interfaces-ISolanaApi,Moralis-StreamsApi-Interfaces-IStreamsApiClient,Moralis-Web3Api-Interfaces-IWeb3Api-'></a>
### Start(connectionData,authApi,streamsApi,web3Api) `method`

##### Summary

Initialize Moralis Client by providing connection data and pre-initialized Api Clients

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| connectionData | [Moralis.Models.ServerConnectionData](#T-Moralis-Models-ServerConnectionData 'Moralis.Models.ServerConnectionData') |  |
| authApi | [Moralis.AuthApi.Interfaces.IAuthClientApi](#T-Moralis-AuthApi-Interfaces-IAuthClientApi 'Moralis.AuthApi.Interfaces.IAuthClientApi') |  |
| streamsApi | [Moralis.SolanaApi.Interfaces.ISolanaApi](#T-Moralis-SolanaApi-Interfaces-ISolanaApi 'Moralis.SolanaApi.Interfaces.ISolanaApi') |  |
| web3Api | [Moralis.StreamsApi.Interfaces.IStreamsApiClient](#T-Moralis-StreamsApi-Interfaces-IStreamsApiClient 'Moralis.StreamsApi.Interfaces.IStreamsApiClient') |  |

<a name='T-Moralis-SolanaApi-MoralisSolanaApiClient'></a>
## MoralisSolanaApiClient `type`

##### Namespace

Moralis.SolanaApi

<a name='P-Moralis-SolanaApi-MoralisSolanaApiClient-SolanaApi'></a>
### SolanaApi `property`

##### Summary

Gets the Web3ApiClient instance. Moralis.Initialize must be called first.
If Moralis is not initialized this will throw an ApiException.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') | Thrown when Moralis.Initialize has not been called. |

<a name='M-Moralis-SolanaApi-MoralisSolanaApiClient-Initialize-System-String,System-String-'></a>
### Initialize(url,apiKey) `method`

##### Summary

Initialize Moralis Web3API.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional server url. If not provided default standard server Url is used. |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Required if useStandardServer is true |

<a name='T-Moralis-StreamsApi-MoralisStreamsApiClient'></a>
## MoralisStreamsApiClient `type`

##### Namespace

Moralis.StreamsApi

##### Summary

Simple, easy to use Api Client initializer.

<a name='P-Moralis-StreamsApi-MoralisStreamsApiClient-StreamsApiClient'></a>
### StreamsApiClient `property`

##### Summary

Gets the StreamsApiClient instance. Moralis.Initialize must be called first.
If Moralis is not initialized this will throw an ApiException.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') | Thrown when Moralis.Initialize has not been called. |

<a name='M-Moralis-StreamsApi-MoralisStreamsApiClient-Initialize-System-String,System-String-'></a>
### Initialize(apiKey,url) `method`

##### Summary

Initialize Moralis Web3API.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Required if useStandardServer is true |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional server url. If not provided default standard server Url is used. |

<a name='T-Moralis-Web3Api-MoralisWeb3ApiClient'></a>
## MoralisWeb3ApiClient `type`

##### Namespace

Moralis.Web3Api

##### Summary

Provides an easy to wrapper around the Moralis Web3Api REST services.

<a name='P-Moralis-Web3Api-MoralisWeb3ApiClient-Web3Api'></a>
### Web3Api `property`

##### Summary

Gets the Web3ApiClient instance. Moralis.Initialize must be called first.
If Moralis is not initialized this will throw an ApiException.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') | Thrown when Moralis.Initialize has not been called. |

<a name='M-Moralis-Web3Api-MoralisWeb3ApiClient-Initialize-System-String,System-String-'></a>
### Initialize(url,apiKey) `method`

##### Summary

Initialize Moralis Web3API.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional server url. If not provided default standard server Url is used. |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Required if useStandardServer is true |

<a name='T-Moralis-Web3Api-Api-NativeApi'></a>
## NativeApi `type`

##### Namespace

Moralis.Web3Api.Api

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Api-NativeApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [NativeApi](#T-Moralis-Web3Api-Api-NativeApi 'Moralis.Web3Api.Api.NativeApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-Web3Api-Api-NativeApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [NativeApi](#T-Moralis-Web3Api-Api-NativeApi 'Moralis.Web3Api.Api.NativeApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='P-Moralis-Web3Api-Api-NativeApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-Web3Api-Api-NativeApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-NativeApi-GetBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetBlock(blockNumberOrHash,chain,subdomain) `method`

##### Summary

Gets the contents of a block by block hash

##### Returns

Returns the contents of a block

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| blockNumberOrHash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The block hash or block number |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |

<a name='M-Moralis-Web3Api-Api-NativeApi-GetContractEvents-System-String,System-String,System-Object,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}-'></a>
### GetContractEvents(address,topic,abi,chain,subdomain,providerUrl,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets events in descending order based on block number

##### Returns

Returns a collection of events by topic

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| topic | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The topic of the event |
| abi | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | ABI of the specific event |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| fromBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The minimum block number from where to get the logs
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the logs.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The date from where to get the logs (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the logs to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-NativeApi-GetDateToBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetDateToBlock(date,chain,providerUrl) `method`

##### Summary

Gets the closest block of the provided date

##### Returns

Returns the blocknumber and corresponding date and timestamp

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unix date in miliseconds or a datestring (any format that is accepted by momentjs) |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='M-Moralis-Web3Api-Api-NativeApi-GetLogsByAddress-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetLogsByAddress(address,chain,subdomain,blockNumber,fromBlock,toBlock,fromDate,toDate,topic0,topic1,topic2,topic3) `method`

##### Summary

Gets the logs from an address

##### Returns

Returns the logs of an address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| blockNumber | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The block number
* Provide the param 'block_numer' or ('from_block' and / or 'to_block')
* If 'block_numer' is provided in conbinaison with 'from_block' and / or 'to_block', 'block_number' will will be used |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the logs
* Provide the param 'block_numer' or ('from_block' and / or 'to_block')
* If 'block_numer' is provided in conbinaison with 'from_block' and / or 'to_block', 'block_number' will will be used |
| toBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum block number from where to get the logs
* Provide the param 'block_numer' or ('from_block' and / or 'to_block')
* If 'block_numer' is provided in conbinaison with 'from_block' and / or 'to_block', 'block_number' will will be used |
| fromDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The date from where to get the logs (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used.
* If 'from_date' and the block params are provided, the block params will be used. Please refer to the blocks params sections (block_number,from_block and to_block) on how to use them |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the logs to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used.
* If 'to_date' and the block params are provided, the block params will be used. Please refer to the blocks params sections (block_number,from_block and to_block) on how to use them |
| topic0 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | topic0 |
| topic1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | topic1 |
| topic2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | topic2 |
| topic3 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | topic3 |

<a name='M-Moralis-Web3Api-Api-NativeApi-GetNFTTransfersByBlock-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTTransfersByBlock(blockNumberOrHash,chain,subdomain,offset,limit) `method`

##### Summary

Gets NFT transfers by block number or block hash

##### Returns

Returns the contents of a block

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| blockNumberOrHash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The block hash or block number |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| offset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-NativeApi-GetTransaction-System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetTransaction(transactionHash,chain,subdomain) `method`

##### Summary

Gets the contents of a block transaction by hash

##### Returns

Returns the contents of a block transaction

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| transactionHash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The transaction hash |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |

<a name='M-Moralis-Web3Api-Api-NativeApi-RunContractFunction``1-System-String,System-String,Moralis-Web3Api-Models-RunContractDto,Moralis-Web3Api-Models-ChainList,System-String,System-String-'></a>
### RunContractFunction\`\`1(address,functionName,abi,chain,subdomain,providerUrl) `method`

##### Summary

Runs a given function of a contract abi and returns readonly data

##### Returns

Returns response of the function executed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | address |
| functionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | function_name |
| abi | [Moralis.Web3Api.Models.RunContractDto](#T-Moralis-Web3Api-Models-RunContractDto 'Moralis.Web3Api.Models.RunContractDto') | Body |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='M-Moralis-Web3Api-Api-NativeApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Web3Api-Models-NativeBalance'></a>
## NativeBalance `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NativeBalance-Balance'></a>
### Balance `property`

##### Summary

The balance
example: 1234567890

<a name='M-Moralis-Web3Api-Models-NativeBalance-RawBalance'></a>
### RawBalance() `method`

##### Summary

Used by base class to access the raw WEI string value.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NativeBalance-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NativeBalance-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NativeErc20Price'></a>
## NativeErc20Price `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NativeErc20Price-Decimals'></a>
### Decimals `property`

##### Summary

The number of decimals of the token
example: 18

<a name='P-Moralis-Web3Api-Models-NativeErc20Price-Name'></a>
### Name `property`

##### Summary

The Name of the token
example: Ether

<a name='P-Moralis-Web3Api-Models-NativeErc20Price-Symbol'></a>
### Symbol `property`

##### Summary

The Symbol of the token
example: ETH

<a name='P-Moralis-Web3Api-Models-NativeErc20Price-Value'></a>
### Value `property`

##### Summary

The native price of the token
example: 8409770570506626

<a name='M-Moralis-Web3Api-Models-NativeErc20Price-RawBalance'></a>
### RawBalance() `method`

##### Summary

Used by base class to access the raw WEI string value.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NativeErc20Price-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NativeErc20Price-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NativeTokenBalanceBase'></a>
## NativeTokenBalanceBase `type`

##### Namespace

Moralis.Web3Api.Models

##### Summary

Abstract class used to provide basic value utilities.

<a name='P-Moralis-Web3Api-Models-NativeTokenBalanceBase-ChainId'></a>
### ChainId `property`

##### Summary

Chain Associated with this object.

<a name='P-Moralis-Web3Api-Models-NativeTokenBalanceBase-Decimals'></a>
### Decimals `property`

##### Summary

The number of decimals to express WEI as Native Token.

<a name='P-Moralis-Web3Api-Models-NativeTokenBalanceBase-NativeTokenBalance'></a>
### NativeTokenBalance `property`

##### Summary

Returns the Native Token balance as derived from WEI value and Decinmals.

<a name='M-Moralis-Web3Api-Models-NativeTokenBalanceBase-RawBalance'></a>
### RawBalance() `method`

##### Summary

Derived class should override and return target value amount.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Moralis-Network-NetworkExtensions'></a>
## NetworkExtensions `type`

##### Namespace

Moralis.Network

##### Summary

Extension utility methods for network objects.

<a name='M-Moralis-Network-NetworkExtensions-ReadAsBytes-System-IO-Stream-'></a>
### ReadAsBytes(s) `method`

##### Summary

Adds a ReadAsBytes function to a standard stream object.

##### Returns

byte[]

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') |  |

<a name='T-Moralis-Network-NetworkTypes'></a>
## NetworkTypes `type`

##### Namespace

Moralis.Network

##### Summary

Indicates Main or test networks.

<a name='T-Moralis-Web3Api-Models-Nft'></a>
## Nft `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Nft-Amount'></a>
### Amount `property`

##### Summary

The number of this item the user owns (used by ERC1155)
example: 1

<a name='P-Moralis-Web3Api-Models-Nft-ContractType'></a>
### ContractType `property`

##### Summary

The type of NFT contract standard
example: ERC721

<a name='P-Moralis-Web3Api-Models-Nft-Metadata'></a>
### Metadata `property`

##### Summary

The metadata of the token

<a name='P-Moralis-Web3Api-Models-Nft-Name'></a>
### Name `property`

##### Summary

The name of the Token contract
example: CryptoKitties

<a name='P-Moralis-Web3Api-Models-Nft-Symbol'></a>
### Symbol `property`

##### Summary

The symbol of the NFT contract
example: RARI

<a name='P-Moralis-Web3Api-Models-Nft-SyncedAt'></a>
### SyncedAt `property`

##### Summary

when the metadata was last updated

<a name='P-Moralis-Web3Api-Models-Nft-TokenAddress'></a>
### TokenAddress `property`

##### Summary

The address of the contract of the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-Nft-TokenId'></a>
### TokenId `property`

##### Summary

The token id of the NFT
example: 15

<a name='P-Moralis-Web3Api-Models-Nft-TokenUri'></a>
### TokenUri `property`

##### Summary

The uri to the metadata of the token

<a name='M-Moralis-Web3Api-Models-Nft-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Nft-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-SolanaApi-Api-NftApi'></a>
## NftApi `type`

##### Namespace

Moralis.SolanaApi.Api

<a name='M-Moralis-SolanaApi-Api-NftApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [](#!-NativeApi 'NativeApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-SolanaApi-Api-NftApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [](#!-NativeApi 'NativeApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='P-Moralis-SolanaApi-Api-NftApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-SolanaApi-Api-NftApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-SolanaApi-Api-NftApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Web3Api-Models-NftCollection'></a>
## NftCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftCollection-Page'></a>
### Page `property`

##### Summary

The page of the current result
example: 2

<a name='P-Moralis-Web3Api-Models-NftCollection-PageSize'></a>
### PageSize `property`

##### Summary

The number of results per page
example: 100

<a name='P-Moralis-Web3Api-Models-NftCollection-Result'></a>
### Result `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-NftCollection-Total'></a>
### Total `property`

##### Summary

The total number of matches for this query
example: 2000

<a name='M-Moralis-Web3Api-Models-NftCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NftContractMetadata'></a>
## NftContractMetadata `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftContractMetadata-Abi'></a>
### Abi `property`

##### Summary

The abi of the token Contract

<a name='P-Moralis-Web3Api-Models-NftContractMetadata-ContractType'></a>
### ContractType `property`

##### Summary

The type of NFT contract
example: ERC721

<a name='P-Moralis-Web3Api-Models-NftContractMetadata-Name'></a>
### Name `property`

##### Summary

The name of the token Contract
example: KryptoKitties

<a name='P-Moralis-Web3Api-Models-NftContractMetadata-SupportsTokenUri'></a>
### SupportsTokenUri `property`

##### Summary

value -1 if the contract does not support token_uri

<a name='P-Moralis-Web3Api-Models-NftContractMetadata-Symbol'></a>
### Symbol `property`

##### Summary

The symbol of the NFT contract
example: RARI

<a name='P-Moralis-Web3Api-Models-NftContractMetadata-SyncedAt'></a>
### SyncedAt `property`

##### Summary

Timestamp of when the contract was last synced with the node

<a name='P-Moralis-Web3Api-Models-NftContractMetadata-TokenAddress'></a>
### TokenAddress `property`

##### Summary

The address of the token contract
example: 0x2d30ca6f024dbc1307ac8a1a44ca27de6f797ec22ef20627a1307243b0ab7d09

<a name='M-Moralis-Web3Api-Models-NftContractMetadata-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftContractMetadata-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NftContractMetadataCollection'></a>
## NftContractMetadataCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftContractMetadataCollection-Page'></a>
### Page `property`

##### Summary

The page of the current result
example: 2

<a name='P-Moralis-Web3Api-Models-NftContractMetadataCollection-PageSize'></a>
### PageSize `property`

##### Summary

The number of results per page
example: 100

<a name='P-Moralis-Web3Api-Models-NftContractMetadataCollection-Result'></a>
### Result `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-NftContractMetadataCollection-Total'></a>
### Total `property`

##### Summary

The total number of matches for this query
example: 2000

<a name='M-Moralis-Web3Api-Models-NftContractMetadataCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftContractMetadataCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NftMetadata'></a>
## NftMetadata `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftMetadata-ContractType'></a>
### ContractType `property`

##### Summary

The type of NFT contract standard
example: ERC721

<a name='P-Moralis-Web3Api-Models-NftMetadata-Metadata'></a>
### Metadata `property`

##### Summary

The metadata of the token

<a name='P-Moralis-Web3Api-Models-NftMetadata-SyncedAt'></a>
### SyncedAt `property`

##### Summary

when the metadata was last updated

<a name='P-Moralis-Web3Api-Models-NftMetadata-TokenAddress'></a>
### TokenAddress `property`

##### Summary

The address of the contract of the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-NftMetadata-TokenId'></a>
### TokenId `property`

##### Summary

The token id of the NFT
example: 15

<a name='P-Moralis-Web3Api-Models-NftMetadata-TokenUri'></a>
### TokenUri `property`

##### Summary

The uri to the metadata of the token

<a name='M-Moralis-Web3Api-Models-NftMetadata-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftMetadata-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NftMetadataCollection'></a>
## NftMetadataCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftMetadataCollection-Page'></a>
### Page `property`

##### Summary

The page of the current result
example: 2

<a name='P-Moralis-Web3Api-Models-NftMetadataCollection-PageSize'></a>
### PageSize `property`

##### Summary

The number of results per page
example: 100

<a name='P-Moralis-Web3Api-Models-NftMetadataCollection-Result'></a>
### Result `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-NftMetadataCollection-Total'></a>
### Total `property`

##### Summary

The total number of matches for this query
example: 2000

<a name='M-Moralis-Web3Api-Models-NftMetadataCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftMetadataCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NftOwner'></a>
## NftOwner `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftOwner-Amount'></a>
### Amount `property`

##### Summary

The number of this item the user owns (used by ERC1155)
example: 1

<a name='P-Moralis-Web3Api-Models-NftOwner-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The blocknumber when the amount or owner changed
example: 88256

<a name='P-Moralis-Web3Api-Models-NftOwner-BlockNumberMinted'></a>
### BlockNumberMinted `property`

##### Summary

The blocknumber when the NFT was minted
example: 88256

<a name='P-Moralis-Web3Api-Models-NftOwner-ContractType'></a>
### ContractType `property`

##### Summary

The type of NFT contract standard
example: ERC721

<a name='P-Moralis-Web3Api-Models-NftOwner-Metadata'></a>
### Metadata `property`

##### Summary

The metadata of the token

<a name='P-Moralis-Web3Api-Models-NftOwner-Name'></a>
### Name `property`

##### Summary

The name of the Token contract
example: CryptoKitties

<a name='P-Moralis-Web3Api-Models-NftOwner-OwnerOf'></a>
### OwnerOf `property`

##### Summary

The address of the owner of the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-NftOwner-Symbol'></a>
### Symbol `property`

##### Summary

The symbol of the NFT contract
example: RARI

<a name='P-Moralis-Web3Api-Models-NftOwner-SyncedAt'></a>
### SyncedAt `property`

##### Summary

when the metadata was last updated

<a name='P-Moralis-Web3Api-Models-NftOwner-TokenAddress'></a>
### TokenAddress `property`

##### Summary

The address of the contract of the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-NftOwner-TokenId'></a>
### TokenId `property`

##### Summary

The token id of the NFT
example: 15

<a name='P-Moralis-Web3Api-Models-NftOwner-TokenUri'></a>
### TokenUri `property`

##### Summary

The uri to the metadata of the token

<a name='M-Moralis-Web3Api-Models-NftOwner-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftOwner-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NftOwnerCollection'></a>
## NftOwnerCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftOwnerCollection-Page'></a>
### Page `property`

##### Summary

The page of the current result
example: 2

<a name='P-Moralis-Web3Api-Models-NftOwnerCollection-PageSize'></a>
### PageSize `property`

##### Summary

The number of results per page
example: 100

<a name='P-Moralis-Web3Api-Models-NftOwnerCollection-Result'></a>
### Result `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-NftOwnerCollection-Status'></a>
### Status `property`

##### Summary

The syncing status of the address [SYNCING/SYNCED]
example: SYNCING

<a name='P-Moralis-Web3Api-Models-NftOwnerCollection-Total'></a>
### Total `property`

##### Summary

The total number of matches for this query
example: 2000

<a name='M-Moralis-Web3Api-Models-NftOwnerCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftOwnerCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NftTransfer'></a>
## NftTransfer `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftTransfer-Amount'></a>
### Amount `property`

##### Summary

The number of tokens transferred
example: 1

<a name='P-Moralis-Web3Api-Models-NftTransfer-BlockHash'></a>
### BlockHash `property`

##### Summary

The block hash of the transaction

<a name='P-Moralis-Web3Api-Models-NftTransfer-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The blocknumber of the transaction
example: 88256

<a name='P-Moralis-Web3Api-Models-NftTransfer-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 6/4/2021 4:00:15 PM

<a name='P-Moralis-Web3Api-Models-NftTransfer-ContractType'></a>
### ContractType `property`

##### Summary

The type of NFT contract standard
example: ERC721

<a name='P-Moralis-Web3Api-Models-NftTransfer-FromAddress'></a>
### FromAddress `property`

##### Summary

The address that sent the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-NftTransfer-LogIndex'></a>
### LogIndex `property`

##### Summary

The log index

<a name='P-Moralis-Web3Api-Models-NftTransfer-Operator'></a>
### Operator `property`

##### Summary

The operator present only for ERC1155 Transfers
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-NftTransfer-ToAddress'></a>
### ToAddress `property`

##### Summary

The address that recieved the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-NftTransfer-TokenAddress'></a>
### TokenAddress `property`

##### Summary

The address of the contract of the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-NftTransfer-TokenId'></a>
### TokenId `property`

##### Summary

The token id of the NFT
example: 15

<a name='P-Moralis-Web3Api-Models-NftTransfer-TransactionHash'></a>
### TransactionHash `property`

##### Summary

The transaction hash
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-NftTransfer-TransactionIndex'></a>
### TransactionIndex `property`

##### Summary

The transaction index

<a name='P-Moralis-Web3Api-Models-NftTransfer-TransactionType'></a>
### TransactionType `property`

##### Summary

The transaction type

<a name='P-Moralis-Web3Api-Models-NftTransfer-Value'></a>
### Value `property`

##### Summary

The value that was sent in the transaction (ETH/BNB/etc..)
example: 1000000000000000

<a name='M-Moralis-Web3Api-Models-NftTransfer-RawBalance'></a>
### RawBalance() `method`

##### Summary

Used by base class to access the raw WEI string value.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftTransfer-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftTransfer-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-NftTransferCollection'></a>
## NftTransferCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-NftTransferCollection-BlockExists'></a>
### BlockExists `property`

##### Summary

Indicator if the block exists
example: True

<a name='P-Moralis-Web3Api-Models-NftTransferCollection-Page'></a>
### Page `property`

##### Summary

The page of the current result
example: 2

<a name='P-Moralis-Web3Api-Models-NftTransferCollection-PageSize'></a>
### PageSize `property`

##### Summary

The number of results per page
example: 100

<a name='P-Moralis-Web3Api-Models-NftTransferCollection-Result'></a>
### Result `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-NftTransferCollection-Total'></a>
### Total `property`

##### Summary

The total number of matches for this query
example: 2000

<a name='M-Moralis-Web3Api-Models-NftTransferCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-NftTransferCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Unit-NumberFormatting'></a>
## NumberFormatting `type`

##### Namespace

Moralis.Unit

##### Summary

Provides functions for formating number
[](#!-Nethereum-Util-NumberFormatting 'Nethereum.Util.NumberFormatting')

<a name='T-Moralis-Network-Parameter'></a>
## Parameter `type`

##### Namespace

Moralis.Network

##### Summary

A defined transfer parameter values.

<a name='M-Moralis-Network-Parameter-#ctor-System-String,System-Object,Moralis-Network-ParameterType-'></a>
### #ctor(name,value,type) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| type | [Moralis.Network.ParameterType](#T-Moralis-Network-ParameterType 'Moralis.Network.ParameterType') |  |

<a name='M-Moralis-Network-Parameter-#ctor-System-String,System-Object,System-String,Moralis-Network-ParameterType-'></a>
### #ctor(name,value,contentType,type) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| contentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [Moralis.Network.ParameterType](#T-Moralis-Network-ParameterType 'Moralis.Network.ParameterType') |  |

<a name='P-Moralis-Network-Parameter-ContentType'></a>
### ContentType `property`

##### Summary

Transfer Content Type of the parameter.

<a name='P-Moralis-Network-Parameter-DataFormat'></a>
### DataFormat `property`

##### Summary

Dataformat the parameter is passed in.

<a name='P-Moralis-Network-Parameter-Name'></a>
### Name `property`

##### Summary

Parameter name.

<a name='P-Moralis-Network-Parameter-Type'></a>
### Type `property`

##### Summary

Type represented by the parameter.

<a name='P-Moralis-Network-Parameter-Value'></a>
### Value `property`

##### Summary

Value passed in the parameter.

<a name='M-Moralis-Network-Parameter-Equals-Moralis-Network-Parameter-'></a>
### Equals(other) `method`

##### Summary

Provides equality operation against another Parameter.

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [Moralis.Network.Parameter](#T-Moralis-Network-Parameter 'Moralis.Network.Parameter') |  |

<a name='M-Moralis-Network-Parameter-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Provides equality operation against another object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-Moralis-Network-Parameter-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Overrides the Hash code method.

##### Returns

int

##### Parameters

This method has no parameters.

<a name='M-Moralis-Network-Parameter-ToString'></a>
### ToString() `method`

##### Summary

Overrides the ToString function.

##### Returns

string

##### Parameters

This method has no parameters.

<a name='T-Moralis-Network-ParameterType'></a>
## ParameterType `type`

##### Namespace

Moralis.Network

##### Summary

Parmeters types

<a name='T-Moralis-StreamsApi-Api-ProjectApi'></a>
## ProjectApi `type`

##### Namespace

Moralis.StreamsApi.Api

<a name='M-Moralis-StreamsApi-Api-ProjectApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [](#!-AuthenticationApi 'AuthenticationApi') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-StreamsApi-Api-ProjectApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [](#!-AuthenticationApi 'AuthenticationApi') class.

##### Parameters

This constructor has no parameters.

<a name='P-Moralis-StreamsApi-Api-ProjectApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-StreamsApi-Api-ProjectApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-StreamsApi-Api-ProjectApi-GetSettings'></a>
### GetSettings() `method`

##### Summary

Retrieves current stream settings.

##### Returns

SettingsDetail

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-StreamsApi-Api-ProjectApi-PostSettings-Moralis-StreamsApi-Models-SettingsDetail-'></a>
### PostSettings(req) `method`

##### Summary

Set the settings for the current project based on the project api-key.

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| req | [Moralis.StreamsApi.Models.SettingsDetail](#T-Moralis-StreamsApi-Models-SettingsDetail 'Moralis.StreamsApi.Models.SettingsDetail') | SettingsDetail |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-StreamsApi-Api-ProjectApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Web3Api-Models-ReservesCollection'></a>
## ReservesCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-ReservesCollection-Reserve0'></a>
### Reserve0 `property`

##### Summary

reserve0
example: 1177323085102288091856004

<a name='P-Moralis-Web3Api-Models-ReservesCollection-Reserve1'></a>
### Reserve1 `property`

##### Summary

reserve1
example: 9424175928981149993184

<a name='M-Moralis-Web3Api-Models-ReservesCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-ReservesCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Resolve'></a>
## Resolve `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Resolve-Address'></a>
### Address `property`

##### Summary

Resolved domain address
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='M-Moralis-Web3Api-Models-Resolve-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Resolve-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Api-ResolveApi'></a>
## ResolveApi `type`

##### Namespace

Moralis.Web3Api.Api

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Api-ResolveApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [ResolveApi](#T-Moralis-Web3Api-Api-ResolveApi 'Moralis.Web3Api.Api.ResolveApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-Web3Api-Api-ResolveApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ResolveApi](#T-Moralis-Web3Api-Api-ResolveApi 'Moralis.Web3Api.Api.ResolveApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='P-Moralis-Web3Api-Api-ResolveApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-Web3Api-Api-ResolveApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-ResolveApi-ResolveAddress-System-String-'></a>
### ResolveAddress(address) `method`

##### Summary

Resolves an ETH address and find the ENS name

##### Returns

Returns an ENS

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address to be resolved |

<a name='M-Moralis-Web3Api-Api-ResolveApi-ResolveDomain-System-String,System-String-'></a>
### ResolveDomain(domain,currency) `method`

##### Summary

Resolves an Unstoppable domain and returns the address

##### Returns

Returns an address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Domain to be resolved |
| currency | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The currency to query |

<a name='M-Moralis-Web3Api-Api-ResolveApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='T-Moralis-Web3Api-Models-RunContractDto'></a>
## RunContractDto `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-RunContractDto-Abi'></a>
### Abi `property`

##### Summary

The contract abi

<a name='P-Moralis-Web3Api-Models-RunContractDto-Params'></a>
### Params `property`

##### Summary

The params for the given function

<a name='M-Moralis-Web3Api-Models-RunContractDto-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-RunContractDto-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Models-ServerConnectionData'></a>
## ServerConnectionData `type`

##### Namespace

Moralis.Models

##### Summary

The set of properties required to access Moralis services.

<a name='M-Moralis-Models-ServerConnectionData-#ctor'></a>
### #ctor() `constructor`

##### Summary

Default constructor - sets default configuration values.

##### Parameters

This constructor has no parameters.

<a name='P-Moralis-Models-ServerConnectionData-ApiKey'></a>
### ApiKey `property`

##### Summary

The Web3Api key, must be supplied to initialize Web3Api to use 
standard REST server.

<a name='P-Moralis-Models-ServerConnectionData-AuthenticationApiUrl'></a>
### AuthenticationApiUrl `property`

##### Summary

URL for the Authentication 2.0 API

<a name='P-Moralis-Models-ServerConnectionData-Headers'></a>
### Headers `property`

##### Summary

Additional HTTP headers to be sent with network requests from the SDK.

<a name='P-Moralis-Models-ServerConnectionData-MasterKey'></a>
### MasterKey `property`

##### Summary

The Master Key for the Moralis app targeted by [](#!-Key 'Key').

<a name='P-Moralis-Models-ServerConnectionData-SolanaApiUrl'></a>
### SolanaApiUrl `property`

##### Summary

URL for the Solana API

<a name='P-Moralis-Models-ServerConnectionData-StreamsApiUrl'></a>
### StreamsApiUrl `property`

##### Summary

URL for Streams Api

<a name='P-Moralis-Models-ServerConnectionData-Web3ApiUrl'></a>
### Web3ApiUrl `property`

##### Summary

URL for Web3 Api and Solana Api

<a name='T-Moralis-SolanaApi-Client-SolanaApiClient'></a>
## SolanaApiClient `type`

##### Namespace

Moralis.SolanaApi.Client

##### Summary

Provides a wrapper class around the Moralis Web3Api REST service. 
Automagically initializes client to use standard server or
personal server Cloud Function API based on use of Api Key.

<a name='M-Moralis-SolanaApi-Client-SolanaApiClient-#ctor-System-String-'></a>
### #ctor(serverUrl) `constructor`

##### Summary

Initialize client using just server url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Moralis-SolanaApi-Client-SolanaApiClient-Account'></a>
### Account `property`

##### Summary

AccountApi operations.

<a name='P-Moralis-SolanaApi-Client-SolanaApiClient-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates that the client has been initialized.

<a name='P-Moralis-SolanaApi-Client-SolanaApiClient-Nft'></a>
### Nft `property`

##### Summary

DefiApi operations

<a name='M-Moralis-SolanaApi-Client-SolanaApiClient-Initialize-System-String-'></a>
### Initialize(serverUrl) `method`

##### Summary

Initialize the client using serverUrl. If serverUrl is null default is used. 
ApiKey is passed via Configuration signleton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-Web3Api-Api-StorageApi'></a>
## StorageApi `type`

##### Namespace

Moralis.Web3Api.Api

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-Web3Api-Api-StorageApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [StorageApi](#T-Moralis-Web3Api-Api-StorageApi 'Moralis.Web3Api.Api.StorageApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-Web3Api-Api-StorageApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [StorageApi](#T-Moralis-Web3Api-Api-StorageApi 'Moralis.Web3Api.Api.StorageApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='P-Moralis-Web3Api-Api-StorageApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-Web3Api-Api-StorageApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-StorageApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-StorageApi-UploadFolder-System-Collections-Generic-List{Moralis-Web3Api-Models-IpfsFileRequest}-'></a>
### UploadFolder(abi) `method`

##### Summary

Uploads multiple files and place them in a folder directory

##### Returns

Returns the path to the uploaded files

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| abi | [System.Collections.Generic.List{Moralis.Web3Api.Models.IpfsFileRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Moralis.Web3Api.Models.IpfsFileRequest}') | Array of JSON and Base64 Supported |

<a name='T-Moralis-StreamsApi-Api-StreamsApi'></a>
## StreamsApi `type`

##### Namespace

Moralis.StreamsApi.Api

<a name='M-Moralis-StreamsApi-Api-StreamsApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [](#!-AuthenticationApi 'AuthenticationApi') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-StreamsApi-Api-StreamsApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [](#!-AuthenticationApi 'AuthenticationApi') class.

##### Parameters

This constructor has no parameters.

<a name='P-Moralis-StreamsApi-Api-StreamsApi-ApiClient'></a>
### ApiClient `property`

##### Summary



<a name='M-Moralis-StreamsApi-Api-StreamsApi-BindStream-Moralis-StreamsApi-Models-StreamBindingDto-'></a>
### BindStream(req) `method`

##### Summary

Creates a new stream

##### Returns

StreamBindingDto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| req | [Moralis.StreamsApi.Models.StreamBindingDto](#T-Moralis-StreamsApi-Models-StreamBindingDto 'Moralis.StreamsApi.Models.StreamBindingDto') | StreamBindingDto |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-StreamsApi-Api-StreamsApi-DeleteStream-System-String-'></a>
### DeleteStream(streamId) `method`

##### Summary

Removes a specified atream binding.

##### Returns

StreamBindingDto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| streamId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-StreamsApi-Api-StreamsApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-StreamsApi-Api-StreamsApi-GetStream-System-String-'></a>
### GetStream(streamId) `method`

##### Summary

Gets a specific stream definition.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| streamId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Moralis-StreamsApi-Api-StreamsApi-GetStreams-System-Int64,System-String-'></a>
### GetStreams() `method`

##### Summary

Get all the stream definitions for the current project based on the project api-key.

##### Returns

StreamBindingDto List

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Moralis-StreamsApi-Api-StreamsApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-StreamsApi-Api-StreamsApi-UpdateStream-Moralis-StreamsApi-Models-StreamBindingDto-'></a>
### UpdateStream(req) `method`

##### Summary

Updates a specific stream.

##### Returns

StreamBindingDto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| req | [Moralis.StreamsApi.Models.StreamBindingDto](#T-Moralis-StreamsApi-Models-StreamBindingDto 'Moralis.StreamsApi.Models.StreamBindingDto') | StreamBindingDto |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Moralis.Network.ApiException](#T-Moralis-Network-ApiException 'Moralis.Network.ApiException') |  |

<a name='M-Moralis-StreamsApi-Api-StreamsApi-ValidateUuid-System-String-'></a>
### ValidateUuid(uuid) `method`

##### Summary

Validates that the specified value qualifies as valid under [RFC_4122](https://www.rfc-editor.org/rfc/rfc4122)

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uuid | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string |

<a name='T-Moralis-StreamsApi-Client-StreamsApiClient'></a>
## StreamsApiClient `type`

##### Namespace

Moralis.StreamsApi.Client

##### Summary

Client that

<a name='M-Moralis-StreamsApi-Client-StreamsApiClient-#ctor'></a>
### #ctor() `constructor`

##### Summary

Default constructor.

##### Parameters

This constructor has no parameters.

<a name='M-Moralis-StreamsApi-Client-StreamsApiClient-#ctor-System-String-'></a>
### #ctor(serverUrl) `constructor`

##### Summary

Initialize client using just server url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Moralis-StreamsApi-Client-StreamsApiClient-BetaEndpoint'></a>
### BetaEndpoint `property`

##### Summary



<a name='P-Moralis-StreamsApi-Client-StreamsApiClient-HistoryEndpoint'></a>
### HistoryEndpoint `property`

##### Summary



<a name='P-Moralis-StreamsApi-Client-StreamsApiClient-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates that the client has been initialized.

<a name='P-Moralis-StreamsApi-Client-StreamsApiClient-SettingsEndpoint'></a>
### SettingsEndpoint `property`

##### Summary

Target Settings Endpoint

<a name='P-Moralis-StreamsApi-Client-StreamsApiClient-StreamsEndpoint'></a>
### StreamsEndpoint `property`

##### Summary

Target Streams Endpoint

<a name='M-Moralis-StreamsApi-Client-StreamsApiClient-Initialize-System-String-'></a>
### Initialize(serverUrl) `method`

##### Summary

Initialize the client using serverUrl. If serverUrl is null default is used. 
ApiKey is passed via Configuration signleton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Moralis-StreamsApi-Client-StreamsApiClient-VerifySignature-System-String,System-String-'></a>
### VerifySignature(signature,requestBody) `method`

##### Summary

Verifies that a WebHook message was sent by Moralis using sha3(REQUEST_BODY + WEB3_API_KEY);

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| signature | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| requestBody | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-StreamsApi-Models-StreamsResponse'></a>
## StreamsResponse `type`

##### Namespace

Moralis.StreamsApi.Models

##### Summary

Response returned by a streams lookup.

<a name='P-Moralis-StreamsApi-Models-StreamsResponse-Result'></a>
### Result `property`

##### Summary

The list of stream definitions

<a name='P-Moralis-StreamsApi-Models-StreamsResponse-Total'></a>
### Total `property`

##### Summary

Total number of streams returned.

<a name='T-Moralis-Models-SupportedEvmChains'></a>
## SupportedEvmChains `type`

##### Namespace

Moralis.Models

##### Summary

Provides a easy way to get detail about an EVM chain for all EVM chains 
supported by the Moralis Web3API

<a name='P-Moralis-Models-SupportedEvmChains-SupportedChains'></a>
### SupportedChains `property`

##### Summary

The list of EVM chains supported by the Moralis Web3API.

<a name='M-Moralis-Models-SupportedEvmChains-FromChainList-Moralis-Web3Api-Models-ChainList-'></a>
### FromChainList(target) `method`

##### Summary

Retrieve an chain entry by enum value.

##### Returns

Moralis.Models.ChainEntry

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') |  |

<a name='M-Moralis-Models-SupportedEvmChains-FromChainList-System-String-'></a>
### FromChainList(target) `method`

##### Summary

Retrieve an chain entry by enum value.

##### Returns

Moralis.Models.ChainEntry

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Moralis-Models-SupportedEvmChains-FromChainList-System-Int32-'></a>
### FromChainList(target) `method`

##### Summary

Retrieve an chain entry by enum value.

##### Returns

Moralis.Models.ChainEntry

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| target | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Moralis-Models-SupportedEvmChains-PopulateChainList'></a>
### PopulateChainList() `method`

##### Summary

Loops through the current ChainList enum and builds a friendly to use 
name / chainId, enum val entry.

##### Parameters

This method has no parameters.

<a name='T-Moralis-SolanaApi-Api-TokenApi'></a>
## TokenApi `type`

##### Namespace

Moralis.SolanaApi.Api

<a name='T-Moralis-Web3Api-Api-TokenApi'></a>
## TokenApi `type`

##### Namespace

Moralis.Web3Api.Api

##### Summary

Represents a collection of functions to interact with the API endpoints

<a name='M-Moralis-SolanaApi-Api-TokenApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [TokenApi](#T-Moralis-SolanaApi-Api-TokenApi 'Moralis.SolanaApi.Api.TokenApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-SolanaApi-Api-TokenApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TokenApi](#T-Moralis-SolanaApi-Api-TokenApi 'Moralis.SolanaApi.Api.TokenApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='M-Moralis-Web3Api-Api-TokenApi-#ctor-Moralis-Network-ApiClient-'></a>
### #ctor(apiClient) `constructor`

##### Summary

Initializes a new instance of the [TokenApi](#T-Moralis-Web3Api-Api-TokenApi 'Moralis.Web3Api.Api.TokenApi') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiClient | [Moralis.Network.ApiClient](#T-Moralis-Network-ApiClient 'Moralis.Network.ApiClient') | an instance of ApiClient (optional) |

<a name='M-Moralis-Web3Api-Api-TokenApi-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [TokenApi](#T-Moralis-Web3Api-Api-TokenApi 'Moralis.Web3Api.Api.TokenApi') class.

##### Returns



##### Parameters

This constructor has no parameters.

<a name='P-Moralis-SolanaApi-Api-TokenApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='P-Moralis-Web3Api-Api-TokenApi-ApiClient'></a>
### ApiClient `property`

##### Summary

Gets or sets the API client.

<a name='M-Moralis-SolanaApi-Api-TokenApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-SolanaApi-Api-TokenApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetAllTokenIds-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetAllTokenIds(address,chain,format,cursor,limit) `method`

##### Summary

Gets data, including metadata (where available), for all token ids for the given contract address.
* Results are sorted by the block the token id was minted (descending) and limited to 100 per page by default
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns a collection of nfts

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | cursor |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetBasePath-System-String-'></a>
### GetBasePath(basePath) `method`

##### Summary

Gets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetContractNFTTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetContractNFTTransfers(address,chain,format,cursor,limit) `method`

##### Summary

Gets the transfers of the tokens matching the given parameters

##### Returns

Returns a collection of NFT transfers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | cursor |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetNFTLowestPrice-System-String,Moralis-Web3Api-Models-ChainList,System-Nullable{System-Int32},System-String,System-String-'></a>
### GetNFTLowestPrice(address,chain,days,providerUrl,marketplace) `method`

##### Summary

Get the lowest price found for a nft token contract for the last x days (only trades paid in ETH)

##### Returns

Returns the trade with the lowest price

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| days | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The number of days to look back to find the lowest price
If not provided 7 days will be the default |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| marketplace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | marketplace from where to get the trades (only opensea is supported at the moment) |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetNFTMetadata-System-String,Moralis-Web3Api-Models-ChainList-'></a>
### GetNFTMetadata(address,chain) `method`

##### Summary

Gets the contract level metadata (name, symbol, base token uri) for the given contract
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns a collection NFT collections.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetNFTOwners-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTOwners(address,chain,format,cursor,limit) `method`

##### Summary

Gets all owners of NFT items within a given contract collection
* Use after /nft/contract/{token_address} to find out who owns each token id in a collection
* Make sure to include a sort parm on a column like block_number_minted for consistent pagination results
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns a collection of nft owners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | cursor |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetNFTTrades-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-String,System-String,System-String,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNFTTrades(address,chain,fromBlock,toBlock,fromDate,toDate,providerUrl,marketplace,cursor,limit) `method`

##### Summary

Get the nft trades for a given contracts and marketplace

##### Returns

Returns the trades

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the transfers
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | To get the reserves at this block number |
| fromDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The date from where to get the transfers (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the reserves to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| marketplace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | marketplace from where to get the trades (only opensea is supported at the moment) |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | cursor |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetNftTransfersFromToBlock-Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetNftTransfersFromToBlock(chain,fromBlock,toBlock,fromDate,toDate,format,cursor,limit) `method`

##### Summary

Gets the transfers of the tokens from a block number to a block number

##### Returns

Returns a collection of NFT transfers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to get the transfers
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the transfers.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The date from where to get the transfers (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get transfers up until this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | cursor |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetTokenAddressTransfers-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32}-'></a>
### GetTokenAddressTransfers(address,chain,subdomain,fromBlock,toBlock,fromDate,toDate,offset,limit) `method`

##### Summary

Gets ERC20 token contract transactions in descending order based on block number

##### Returns

Returns a collection of token contract transactions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| fromBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The minimum block number from where to get the transfers
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to get the transfers.
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The date from where to get the transfers (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get the transfers to this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| offset | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | offset |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetTokenAllowance-System-String,System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetTokenAllowance(address,ownerAddress,spenderAddress,chain,providerUrl) `method`

##### Summary

Gets the amount which the spender is allowed to withdraw from the spender

##### Returns

Returns the amount which the spender is allowed to withdraw from the owner..

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token contract |
| ownerAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token owner |
| spenderAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token spender |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetTokenIdMetadata-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetTokenIdMetadata(address,tokenId,chain,format) `method`

##### Summary

Gets data, including metadata (where available), for the given token id of the given contract address.
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns the specified NFT

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| tokenId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetTokenIdOwners-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetTokenIdOwners(address,tokenId,chain,format,cursor,limit) `method`

##### Summary

Gets all owners of NFT items within a given contract collection
* Use after /nft/contract/{token_address} to find out who owns each token id in a collection
* Make sure to include a sort parm on a column like block_number_minted for consistent pagination results
* Requests for contract addresses not yet indexed will automatically start the indexing process for that NFT collection

##### Returns

Returns a collection of NFTs with their respective owners

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| tokenId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | cursor |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetTokenMetadata-System-Collections-Generic-List{System-String},Moralis-Web3Api-Models-ChainList,System-String,System-String-'></a>
### GetTokenMetadata(addresses,chain,subdomain,providerUrl) `method`

##### Summary

Returns metadata (name, symbol, decimals, logo) for a given token contract address.

##### Returns

Returns metadata (name, symbol, decimals, logo) for a given token contract address.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| addresses | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | The addresses to get metadata for |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetTokenMetadataBySymbol-System-Collections-Generic-List{System-String},Moralis-Web3Api-Models-ChainList,System-String-'></a>
### GetTokenMetadataBySymbol(symbols,chain,subdomain) `method`

##### Summary

Returns metadata (name, symbol, decimals, logo) for a given token contract address.

##### Returns

Returns metadata (name, symbol, decimals, logo) for a given token contract address.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbols | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | The symbols to get metadata for |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| subdomain | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subdomain of the moralis server to use (Only use when selecting local devchain as chain) |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetTokenPrice-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32}-'></a>
### GetTokenPrice(address,chain,providerUrl,exchange,toBlock) `method`

##### Summary

Returns the price nominated in the native token and usd for a given token contract address.

##### Returns

Returns the price nominated in the native token and usd for a given token contract address

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The address of the token contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| providerUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | web3 provider url to user when using local dev chain |
| exchange | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The factory name or address of the token exchange |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | to_block |

<a name='M-Moralis-Web3Api-Api-TokenApi-GetWalletTokenIdTransfers-System-String,System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-Nullable{System-Int32},System-String-'></a>
### GetWalletTokenIdTransfers(address,tokenId,chain,format,cursor,limit,order) `method`

##### Summary

Gets the transfers of the tokens matching the given parameters

##### Returns

Returns a collection of NFT transfers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| tokenId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | cursor |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |
| order | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The field(s) to order on and if it should be ordered in ascending or descending order. Specified by: fieldName1.order,fieldName2.order. Example 1: "block_number", "block_number.ASC", "block_number.DESC", Example 2: "block_number and contract_type", "block_number.ASC,contract_type.DESC" |

<a name='M-Moralis-Web3Api-Api-TokenApi-ReSyncMetadata-System-String,System-String,Moralis-Web3Api-Models-ChainList-'></a>
### ReSyncMetadata(address,tokenId,chain) `method`

##### Summary

ReSync the metadata for an NFT

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| tokenId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The id of the token |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |

<a name='M-Moralis-Web3Api-Api-TokenApi-SearchNFTs-System-String,Moralis-Web3Api-Models-ChainList,System-String,System-String,System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-String,System-String,System-Nullable{System-Int32}-'></a>
### SearchNFTs(q,chain,format,filter,fromBlock,toBlock,fromDate,toDate,cursor,limit) `method`

##### Summary

Gets NFTs that match a given metadata search.

##### Returns

Returns the matching NFTs

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| q | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The search string |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format of the token id |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | What fields the search should match on. To look into the entire metadata set the value to 'global'. To have a better response time you can look into a specific field like name |
| fromBlock | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The minimum block number from where to start the search
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toBlock | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum block number from where to end the search
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| fromDate | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The date from where to start the search (any format that is accepted by momentjs)
* Provide the param 'from_block' or 'from_date'
* If 'from_date' and 'from_block' are provided, 'from_block' will be used. |
| toDate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Get search results up until this date (any format that is accepted by momentjs)
* Provide the param 'to_block' or 'to_date'
* If 'to_date' and 'to_block' are provided, 'to_block' will be used. |
| cursor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | cursor |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | limit |

<a name='M-Moralis-Web3Api-Api-TokenApi-SetBasePath-System-String-'></a>
### SetBasePath(basePath) `method`

##### Summary

Sets the base path of the API client.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path |

<a name='M-Moralis-Web3Api-Api-TokenApi-SyncNFTContract-System-String,Moralis-Web3Api-Models-ChainList-'></a>
### SyncNFTContract(address,chain) `method`

##### Summary

Sync a Contract for NFT Index

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Address of the contract |
| chain | [Moralis.Web3Api.Models.ChainList](#T-Moralis-Web3Api-Models-ChainList 'Moralis.Web3Api.Models.ChainList') | The chain to query |

<a name='T-Moralis-Web3Api-Models-Trade'></a>
## Trade `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Trade-BlockHash'></a>
### BlockHash `property`

##### Summary

The block hash
example: 0x4a7c916ca4a970358b9df90051008f729685ff05e9724a9dddba32630c37cb96

<a name='P-Moralis-Web3Api-Models-Trade-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The blocknumber of the transaction
example: 13680123

<a name='P-Moralis-Web3Api-Models-Trade-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 6/4/2021 4:00:15 PM

<a name='P-Moralis-Web3Api-Models-Trade-BuyerAddress'></a>
### BuyerAddress `property`

##### Summary

The address that bought the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-Trade-MarketplaceAddress'></a>
### MarketplaceAddress `property`

##### Summary

The address of the contract that traded the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-Trade-Price'></a>
### Price `property`

##### Summary

The value that was sent in the transaction (ETH/BNB/etc..)
example: 1000000000000000

<a name='P-Moralis-Web3Api-Models-Trade-SellerAddress'></a>
### SellerAddress `property`

##### Summary

The address that sold the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-Trade-TokenIds'></a>
### TokenIds `property`

##### Summary

The token id(s) traded

<a name='P-Moralis-Web3Api-Models-Trade-TransactionHash'></a>
### TransactionHash `property`

##### Summary

The transaction hash
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-Trade-TransactionIndex'></a>
### TransactionIndex `property`

##### Summary

The transaction index

<a name='M-Moralis-Web3Api-Models-Trade-RawBalance'></a>
### RawBalance() `method`

##### Summary

Used by base class to access the raw WEI string value.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Trade-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Trade-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-TradeCollection'></a>
## TradeCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-TradeCollection-Page'></a>
### Page `property`

##### Summary

The page of the current result
example: 2

<a name='P-Moralis-Web3Api-Models-TradeCollection-PageSize'></a>
### PageSize `property`

##### Summary

The number of results per page
example: 100

<a name='P-Moralis-Web3Api-Models-TradeCollection-Result'></a>
### Result `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-TradeCollection-Total'></a>
### Total `property`

##### Summary

The total number of matches for this query
example: 2000

<a name='M-Moralis-Web3Api-Models-TradeCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-TradeCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-TradesCollection'></a>
## TradesCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-TradesCollection-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The blocknumber of the transaction
example: 88256

<a name='P-Moralis-Web3Api-Models-TradesCollection-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 6/4/2021 4:00:15 PM

<a name='P-Moralis-Web3Api-Models-TradesCollection-FromAddress'></a>
### FromAddress `property`

##### Summary

The address that sent the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-TradesCollection-Gas'></a>
### Gas `property`

##### Summary

The gas of the transaction
example: 6721975

<a name='P-Moralis-Web3Api-Models-TradesCollection-GasPrice'></a>
### GasPrice `property`

##### Summary

The gas price
example: 20000000000

<a name='P-Moralis-Web3Api-Models-TradesCollection-ReceiptCumulativeGasUsed'></a>
### ReceiptCumulativeGasUsed `property`

##### Summary

The receipt cumulative gas used
example: 1340925

<a name='P-Moralis-Web3Api-Models-TradesCollection-ReceiptGasUsed'></a>
### ReceiptGasUsed `property`

##### Summary

The receipt gas used
example: 1340925

<a name='P-Moralis-Web3Api-Models-TradesCollection-ToAddress'></a>
### ToAddress `property`

##### Summary

The address that recieved the NFT
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-TradesCollection-TokenIds'></a>
### TokenIds `property`

##### Summary

The token id(s) traded

<a name='P-Moralis-Web3Api-Models-TradesCollection-TransactionHash'></a>
### TransactionHash `property`

##### Summary

The transaction hash
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-TradesCollection-TransactionIndex'></a>
### TransactionIndex `property`

##### Summary

The transaction index

<a name='P-Moralis-Web3Api-Models-TradesCollection-Value'></a>
### Value `property`

##### Summary

The value that was sent in the transaction (ETH/BNB/etc..)
example: 1000000000000000

<a name='M-Moralis-Web3Api-Models-TradesCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-TradesCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-Transaction'></a>
## Transaction `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-Transaction-BlockHash'></a>
### BlockHash `property`

##### Summary

The block hash
example: 0x0372c302e3c52e8f2e15d155e2c545e6d802e479236564af052759253b20fd86

<a name='P-Moralis-Web3Api-Models-Transaction-BlockNumber'></a>
### BlockNumber `property`

##### Summary

The block number
example: 12526958

<a name='P-Moralis-Web3Api-Models-Transaction-BlockTimestamp'></a>
### BlockTimestamp `property`

##### Summary

The block timestamp
example: 4/2/2021 10:07:54 AM

<a name='P-Moralis-Web3Api-Models-Transaction-FromAddress'></a>
### FromAddress `property`

##### Summary

The sender
example: 0xd4a3BebD824189481FC45363602b83C9c7e9cbDf

<a name='P-Moralis-Web3Api-Models-Transaction-Gas'></a>
### Gas `property`

##### Summary

The gas of the transaction
example: 6721975

<a name='P-Moralis-Web3Api-Models-Transaction-GasPrice'></a>
### GasPrice `property`

##### Summary

The gas price
example: 20000000000

<a name='P-Moralis-Web3Api-Models-Transaction-Hash'></a>
### Hash `property`

##### Summary

The hash of the transaction
example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e

<a name='P-Moralis-Web3Api-Models-Transaction-Input'></a>
### Input `property`

##### Summary

The input

<a name='P-Moralis-Web3Api-Models-Transaction-Nonce'></a>
### Nonce `property`

##### Summary

The nonce of the transaction
example: 326595425

<a name='P-Moralis-Web3Api-Models-Transaction-ReceiptContractAddress'></a>
### ReceiptContractAddress `property`

##### Summary

The receipt contract address
example: 0x1d6a4cf64b52f6c73f201839aded7379ce58059c

<a name='P-Moralis-Web3Api-Models-Transaction-ReceiptCumulativeGasUsed'></a>
### ReceiptCumulativeGasUsed `property`

##### Summary

The receipt cumulative gas used
example: 1340925

<a name='P-Moralis-Web3Api-Models-Transaction-ReceiptGasUsed'></a>
### ReceiptGasUsed `property`

##### Summary

The receipt gas used
example: 1340925

<a name='P-Moralis-Web3Api-Models-Transaction-ReceiptRoot'></a>
### ReceiptRoot `property`

##### Summary

The receipt root

<a name='P-Moralis-Web3Api-Models-Transaction-ReceiptStatus'></a>
### ReceiptStatus `property`

##### Summary

The receipt status
example: 1

<a name='P-Moralis-Web3Api-Models-Transaction-ToAddress'></a>
### ToAddress `property`

##### Summary

The recipient
example: 0xa71db868318f0a0bae9411347cd4a6fa23d8d4ef

<a name='P-Moralis-Web3Api-Models-Transaction-TransactionIndex'></a>
### TransactionIndex `property`

##### Summary

The transaction index
example: 25

<a name='P-Moralis-Web3Api-Models-Transaction-Value'></a>
### Value `property`

##### Summary

The value that was transfered (in wei)
example: 650000000000000000

<a name='M-Moralis-Web3Api-Models-Transaction-RawBalance'></a>
### RawBalance() `method`

##### Summary

Used by base class to access the raw WEI string value.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Transaction-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-Transaction-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Web3Api-Models-TransactionCollection'></a>
## TransactionCollection `type`

##### Namespace

Moralis.Web3Api.Models

<a name='P-Moralis-Web3Api-Models-TransactionCollection-Page'></a>
### Page `property`

##### Summary

The page of the current result
example: 2

<a name='P-Moralis-Web3Api-Models-TransactionCollection-PageSize'></a>
### PageSize `property`

##### Summary

The number of results per page
example: 100

<a name='P-Moralis-Web3Api-Models-TransactionCollection-Result'></a>
### Result `property`

##### Summary



<a name='P-Moralis-Web3Api-Models-TransactionCollection-Total'></a>
### Total `property`

##### Summary

The total number of matches for this query
example: 2000

<a name='M-Moralis-Web3Api-Models-TransactionCollection-ToJson'></a>
### ToJson() `method`

##### Summary

Get the JSON string presentation of the object

##### Returns

JSON string presentation of the object

##### Parameters

This method has no parameters.

<a name='M-Moralis-Web3Api-Models-TransactionCollection-ToString'></a>
### ToString() `method`

##### Summary

Get the string presentation of the object

##### Returns

String presentation of the object

##### Parameters

This method has no parameters.

<a name='T-Moralis-Unit-UnitConversion'></a>
## UnitConversion `type`

##### Namespace

Moralis.Unit

##### Summary

[](#!-Nethereum-Util-UnitConversion 'Nethereum.Util.UnitConversion')

<a name='P-Moralis-Unit-UnitConversion-Convert'></a>
### Convert `property`

##### Summary

Current unit of conversion

<a name='M-Moralis-Unit-UnitConversion-FromWei-System-Numerics-BigInteger,System-Numerics-BigInteger-'></a>
### FromWei() `method`

##### Summary

Converts from wei to a unit, NOTE: When the total number of digits is bigger than 29 they will be rounded the less
    significant digits

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-UnitConversion-FromWei-System-Numerics-BigInteger,Moralis-Unit-UnitConversion-EthUnit-'></a>
### FromWei() `method`

##### Summary

Converts from wei to a unit, NOTE: When the total number of digits is bigger than 29 they will be rounded the less
    significant digits

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-UnitConversion-FromWei-System-Numerics-BigInteger,System-Int32-'></a>
### FromWei() `method`

##### Summary

Converts from wei to a unit, NOTE: When the total number of digits is bigger than 29 they will be rounded the less
    significant digits

##### Parameters

This method has no parameters.

<a name='M-Moralis-Unit-UnitConversion-FromWeiToBigDecimal-System-Numerics-BigInteger,System-Int32-'></a>
### FromWeiToBigDecimal(value,decimalPlacesToUnit) `method`

##### Summary

Convert WEI value to BigDecimal.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |
| decimalPlacesToUnit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | int |

<a name='M-Moralis-Unit-UnitConversion-FromWeiToBigDecimal-System-Numerics-BigInteger,Moralis-Unit-UnitConversion-EthUnit-'></a>
### FromWeiToBigDecimal(value,toUnit) `method`

##### Summary

Convert WEI value to BigDecimal.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |
| toUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-FromWeiToBigDecimal-System-Numerics-BigInteger,System-Numerics-BigInteger-'></a>
### FromWeiToBigDecimal(value,toUnit) `method`

##### Summary

Convert WEI value to BigDecimal.

##### Returns

BigDecimal

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |
| toUnit | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |

<a name='M-Moralis-Unit-UnitConversion-GetEthUnitValue-Moralis-Unit-UnitConversion-EthUnit-'></a>
### GetEthUnitValue(ethUnit) `method`

##### Summary

Numeric value of EthUnit

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ethUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Moralis-Unit-UnitConversion-GetEthUnitValueLength-System-Numerics-BigInteger-'></a>
### GetEthUnitValueLength(unitValue) `method`

##### Summary

returns length of value.

##### Returns

int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| unitValue | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |

<a name='M-Moralis-Unit-UnitConversion-ToWei-Moralis-Unit-BigDecimal,Moralis-Unit-UnitConversion-EthUnit-'></a>
### ToWei(amount,fromUnit) `method`

##### Summary

Convert BigDecimal value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| amount | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| fromUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-ToWei-Moralis-Unit-BigDecimal,System-Int32-'></a>
### ToWei(amount,decimalPlacesFromUnit) `method`

##### Summary

Convert BigDecimal value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| amount | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| decimalPlacesFromUnit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | int |

<a name='M-Moralis-Unit-UnitConversion-ToWei-System-Decimal,System-Int32-'></a>
### ToWei(amount,decimalPlacesFromUnit) `method`

##### Summary

Convert decimal value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| amount | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | decimal |
| decimalPlacesFromUnit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | int |

<a name='M-Moralis-Unit-UnitConversion-ToWei-System-Decimal,Moralis-Unit-UnitConversion-EthUnit-'></a>
### ToWei(amount,fromUnit) `method`

##### Summary

Convert decimal value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| amount | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | decinmal |
| fromUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-ToWei-System-Numerics-BigInteger,Moralis-Unit-UnitConversion-EthUnit-'></a>
### ToWei(value,fromUnit) `method`

##### Summary

Convert BigInteger value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |
| fromUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-ToWei-System-Int32,Moralis-Unit-UnitConversion-EthUnit-'></a>
### ToWei(value,fromUnit) `method`

##### Summary

Convert int value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | int |
| fromUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-ToWei-System-Double,Moralis-Unit-UnitConversion-EthUnit-'></a>
### ToWei(value,fromUnit) `method`

##### Summary

Convert double value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | double |
| fromUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-ToWei-System-Single,Moralis-Unit-UnitConversion-EthUnit-'></a>
### ToWei(value,fromUnit) `method`

##### Summary

Convert float value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | float |
| fromUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-ToWei-System-Int64,Moralis-Unit-UnitConversion-EthUnit-'></a>
### ToWei(value,fromUnit) `method`

##### Summary

Convert long value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | long |
| fromUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-ToWei-System-String,Moralis-Unit-UnitConversion-EthUnit-'></a>
### ToWei(value,fromUnit) `method`

##### Summary

Convert string value to WEI

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string |
| fromUnit | [Moralis.Unit.UnitConversion.EthUnit](#T-Moralis-Unit-UnitConversion-EthUnit 'Moralis.Unit.UnitConversion.EthUnit') | EthUnit |

<a name='M-Moralis-Unit-UnitConversion-ToWeiFromUnit-System-Decimal,System-Numerics-BigInteger-'></a>
### ToWeiFromUnit(amount,fromUnit) `method`

##### Summary

Convert decimal from unit

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| amount | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | decimal |
| fromUnit | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |

<a name='M-Moralis-Unit-UnitConversion-ToWeiFromUnit-Moralis-Unit-BigDecimal,System-Numerics-BigInteger-'></a>
### ToWeiFromUnit(amount,fromUnit) `method`

##### Summary

Convert BigDecimal from unit

##### Returns

BigInteger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| amount | [Moralis.Unit.BigDecimal](#T-Moralis-Unit-BigDecimal 'Moralis.Unit.BigDecimal') | BigDecimal |
| fromUnit | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |

<a name='M-Moralis-Unit-UnitConversion-TryValidateUnitValue-System-Numerics-BigInteger-'></a>
### TryValidateUnitValue(ethUnit) `method`

##### Summary

Valdiate that value in paower of 10

##### Returns

bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ethUnit | [System.Numerics.BigInteger](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Numerics.BigInteger 'System.Numerics.BigInteger') | BigInteger |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |

<a name='T-Moralis-Web3Api-Client-Web3ApiClient'></a>
## Web3ApiClient `type`

##### Namespace

Moralis.Web3Api.Client

##### Summary

Provides a wrapper class around the Moralis Web3Api REST service. 
Automagically initializes client to use standard server or
personal server Cloud Function API based on use of Api Key.

<a name='M-Moralis-Web3Api-Client-Web3ApiClient-#ctor-System-String-'></a>
### #ctor(serverUrl) `constructor`

##### Summary

Initialize client using just server url.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Moralis-Web3Api-Client-Web3ApiClient-Account'></a>
### Account `property`

##### Summary

AccountApi operations.

<a name='P-Moralis-Web3Api-Client-Web3ApiClient-Defi'></a>
### Defi `property`

##### Summary

DefiApi operations

<a name='P-Moralis-Web3Api-Client-Web3ApiClient-Info'></a>
### Info `property`

##### Summary

InfoApi operations.

<a name='P-Moralis-Web3Api-Client-Web3ApiClient-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Indicates that the client has been initialized.

<a name='P-Moralis-Web3Api-Client-Web3ApiClient-Native'></a>
### Native `property`

##### Summary

NativeApi operations.

<a name='P-Moralis-Web3Api-Client-Web3ApiClient-Resolve'></a>
### Resolve `property`

##### Summary

ResolveApi operations.

<a name='P-Moralis-Web3Api-Client-Web3ApiClient-Storage'></a>
### Storage `property`

##### Summary

StorageApi operations.

<a name='P-Moralis-Web3Api-Client-Web3ApiClient-Token'></a>
### Token `property`

##### Summary

TokenApi operations.

<a name='M-Moralis-Web3Api-Client-Web3ApiClient-Initialize-System-String-'></a>
### Initialize(serverUrl) `method`

##### Summary

Initialize the client using serverUrl. If serverUrl is null default is used. 
ApiKey is passed via Configuration signleton.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serverUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Moralis-SolanaApi-Models-WebRequest'></a>
## WebRequest `type`

##### Namespace

Moralis.SolanaApi.Models

##### Summary

```
IHttpRequest
```

is an interface that provides an API to execute HTTP request data.

<a name='T-Moralis-Web3Api-Models-WebRequest'></a>
## WebRequest `type`

##### Namespace

Moralis.Web3Api.Models

##### Summary

```
IHttpRequest
```

is an interface that provides an API to execute HTTP request data.

<a name='P-Moralis-SolanaApi-Models-WebRequest-Data'></a>
### Data `property`

##### Summary

Data stream to be uploaded.

<a name='P-Moralis-SolanaApi-Models-WebRequest-Method'></a>
### Method `property`

##### Summary

HTTP method. One of `DELETE`, `GET`, `HEAD`, `POST` or `PUT`

<a name='P-Moralis-Web3Api-Models-WebRequest-Data'></a>
### Data `property`

##### Summary

Data stream to be uploaded.

<a name='P-Moralis-Web3Api-Models-WebRequest-Method'></a>
### Method `property`

##### Summary

HTTP method. One of `DELETE`, `GET`, `HEAD`, `POST` or `PUT`
