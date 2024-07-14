using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using poolz.finance.csharp.contracts.BNBPartyFactory.ContractDefinition;

namespace poolz.finance.csharp.contracts.BNBPartyFactory
{
    public interface IBNBPartyFactoryService
    {
        public Task<string> BNBPositionManagerQueryAsync(BNBPositionManagerFunction bNBPositionManagerFunction, BlockParameter blockParameter = null);

        public Task<string> BNBPositionManagerQueryAsync(BlockParameter blockParameter = null);

        public Task<string> WbnbQueryAsync(WbnbFunction wbnbFunction, BlockParameter blockParameter = null);

        public Task<string> WbnbQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> BonusPartyCreatorQueryAsync(BonusPartyCreatorFunction bonusPartyCreatorFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> BonusPartyCreatorQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> BonusTargetReachQueryAsync(BonusTargetReachFunction bonusTargetReachFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> BonusTargetReachQueryAsync(BlockParameter blockParameter = null);

        public Task<string> CreatePartyRequestAsync(CreatePartyFunction createPartyFunction);

        public Task<TransactionReceipt> CreatePartyRequestAndWaitForReceiptAsync(CreatePartyFunction createPartyFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreatePartyRequestAsync(string name, string symbol);

        public Task<TransactionReceipt> CreatePartyRequestAndWaitForReceiptAsync(string name, string symbol, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> CreateTokenFeeQueryAsync(CreateTokenFeeFunction createTokenFeeFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> CreateTokenFeeQueryAsync(BlockParameter blockParameter = null);

        public Task<string> HandleSwapRequestAsync(HandleSwapFunction handleSwapFunction);

        public Task<TransactionReceipt> HandleSwapRequestAndWaitForReceiptAsync(HandleSwapFunction handleSwapFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> HandleSwapRequestAsync(string recipient);

        public Task<TransactionReceipt> HandleSwapRequestAndWaitForReceiptAsync(string recipient, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> InitialTokenAmountQueryAsync(InitialTokenAmountFunction initialTokenAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> InitialTokenAmountQueryAsync(BlockParameter blockParameter = null);

        public Task<bool> IsPartyQueryAsync(IsPartyFunction isPartyFunction, BlockParameter blockParameter = null);

        public Task<bool> IsPartyQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        public Task<uint> LpFeeQueryAsync(LpFeeFunction lpFeeFunction, BlockParameter blockParameter = null);

        public Task<uint> LpFeeQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> LpToTokenIdQueryAsync(LpToTokenIdFunction lpToTokenIdFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> LpToTokenIdQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null);

        public Task<uint> PartyLPFeeQueryAsync(PartyLPFeeFunction partyLPFeeFunction, BlockParameter blockParameter = null);

        public Task<uint> PartyLPFeeQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> PartyTargetQueryAsync(PartyTargetFunction partyTargetFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> PartyTargetQueryAsync(BlockParameter blockParameter = null);

        public Task<string> PositionManagerQueryAsync(PositionManagerFunction positionManagerFunction, BlockParameter blockParameter = null);

        public Task<string> PositionManagerQueryAsync(BlockParameter blockParameter = null);

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction);

        public Task<string> RenounceOwnershipRequestAsync();

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> ReturnAmountQueryAsync(ReturnAmountFunction returnAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> ReturnAmountQueryAsync(BlockParameter blockParameter = null);

        public Task<string> SetNonfungiblePositionManagerRequestAsync(SetNonfungiblePositionManagerFunction setNonfungiblePositionManagerFunction);

        public Task<TransactionReceipt> SetNonfungiblePositionManagerRequestAndWaitForReceiptAsync(SetNonfungiblePositionManagerFunction setNonfungiblePositionManagerFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetNonfungiblePositionManagerRequestAsync(string bNBPositionManager, string positionManager);

        public Task<TransactionReceipt> SetNonfungiblePositionManagerRequestAndWaitForReceiptAsync(string bNBPositionManager, string positionManager, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> SqrtPriceX96QueryAsync(SqrtPriceX96Function sqrtPriceX96Function, BlockParameter blockParameter = null);

        public Task<BigInteger> SqrtPriceX96QueryAsync(BlockParameter blockParameter = null);

        public Task<int> TickLowerQueryAsync(TickLowerFunction tickLowerFunction, BlockParameter blockParameter = null);

        public Task<int> TickLowerQueryAsync(BlockParameter blockParameter = null);

        public Task<int> TickUpperQueryAsync(TickUpperFunction tickUpperFunction, BlockParameter blockParameter = null);

        public Task<int> TickUpperQueryAsync(BlockParameter blockParameter = null);

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(string newOwner);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
