using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using BNBParty.contracts.csharp.BNBPartyFactory.ContractDefinition;
using Nethereum.RPC.Eth.DTOs;

namespace BNBParty.contracts.csharp.BNBPartyFactory
{
    public interface IBNBPartyFactoryService
    {
        Task<string> BNBPositionManagerQueryAsync(BNBPositionManagerFunction bNBPositionManagerFunction, BlockParameter blockParameter = null);
        Task<string> BNBPositionManagerQueryAsync(BlockParameter blockParameter = null);

        Task<string> WbnbQueryAsync(WbnbFunction wbnbFunction, BlockParameter blockParameter = null);
        Task<string> WbnbQueryAsync(BlockParameter blockParameter = null);

        Task<string> CreatePartyRequestAsync(CreatePartyFunction createPartyFunction);
        Task<TransactionReceipt> CreatePartyRequestAndWaitForReceiptAsync(CreatePartyFunction createPartyFunction, CancellationTokenSource cancellationToken = null);
        Task<string> CreatePartyRequestAsync(string name, string symbol);
        Task<TransactionReceipt> CreatePartyRequestAndWaitForReceiptAsync(string name, string symbol, CancellationTokenSource cancellationToken = null);

        Task<string> HandleSwapRequestAsync(HandleSwapFunction handleSwapFunction);
        Task<TransactionReceipt> HandleSwapRequestAndWaitForReceiptAsync(HandleSwapFunction handleSwapFunction, CancellationTokenSource cancellationToken = null);
        Task<string> HandleSwapRequestAsync(string recipient);
        Task<TransactionReceipt> HandleSwapRequestAndWaitForReceiptAsync(string recipient, CancellationTokenSource cancellationToken = null);

        Task<bool> IsPartyQueryAsync(IsPartyFunction isPartyFunction, BlockParameter blockParameter = null);
        Task<bool> IsPartyQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        Task<string> JoinPartyRequestAsync(JoinPartyFunction joinPartyFunction);
        Task<TransactionReceipt> JoinPartyRequestAndWaitForReceiptAsync(JoinPartyFunction joinPartyFunction, CancellationTokenSource cancellationToken = null);
        Task<string> JoinPartyRequestAsync(string tokenOut, BigInteger amountOutMinimum);
        Task<TransactionReceipt> JoinPartyRequestAndWaitForReceiptAsync(string tokenOut, BigInteger amountOutMinimum, CancellationTokenSource cancellationToken = null);

        Task<string> LeavePartyRequestAsync(LeavePartyFunction leavePartyFunction);
        Task<TransactionReceipt> LeavePartyRequestAndWaitForReceiptAsync(LeavePartyFunction leavePartyFunction, CancellationTokenSource cancellationToken = null);
        Task<string> LeavePartyRequestAsync(string tokenIn, BigInteger amountIn, BigInteger amountOutMinimum);
        Task<TransactionReceipt> LeavePartyRequestAndWaitForReceiptAsync(string tokenIn, BigInteger amountIn, BigInteger amountOutMinimum, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> LpToTokenIdQueryAsync(LpToTokenIdFunction lpToTokenIdFunction, BlockParameter blockParameter = null);
        Task<BigInteger> LpToTokenIdQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null);
        Task<string> OwnerQueryAsync(BlockParameter blockParameter = null);

        Task<PartyOutputDTO> PartyQueryAsync(PartyFunction partyFunction, BlockParameter blockParameter = null);
        Task<PartyOutputDTO> PartyQueryAsync(BlockParameter blockParameter = null);

        Task<string> PositionManagerQueryAsync(PositionManagerFunction positionManagerFunction, BlockParameter blockParameter = null);
        Task<string> PositionManagerQueryAsync(BlockParameter blockParameter = null);

        Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction);
        Task<string> RenounceOwnershipRequestAsync();
        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);
        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        Task<string> SetNonfungiblePositionManagerRequestAsync(SetNonfungiblePositionManagerFunction setNonfungiblePositionManagerFunction);
        Task<TransactionReceipt> SetNonfungiblePositionManagerRequestAndWaitForReceiptAsync(SetNonfungiblePositionManagerFunction setNonfungiblePositionManagerFunction, CancellationTokenSource cancellationToken = null);
        Task<string> SetNonfungiblePositionManagerRequestAsync(string bNBPositionManager, string positionManager);
        Task<TransactionReceipt> SetNonfungiblePositionManagerRequestAndWaitForReceiptAsync(string bNBPositionManager, string positionManager, CancellationTokenSource cancellationToken = null);

        Task<string> SetSwapRouterRequestAsync(SetSwapRouterFunction setSwapRouterFunction);
        Task<TransactionReceipt> SetSwapRouterRequestAndWaitForReceiptAsync(SetSwapRouterFunction setSwapRouterFunction, CancellationTokenSource cancellationToken = null);
        Task<string> SetSwapRouterRequestAsync(string swapRouter);
        Task<TransactionReceipt> SetSwapRouterRequestAndWaitForReceiptAsync(string swapRouter, CancellationTokenSource cancellationToken = null);

        Task<string> SwapRouterQueryAsync(SwapRouterFunction swapRouterFunction, BlockParameter blockParameter = null);
        Task<string> SwapRouterQueryAsync(BlockParameter blockParameter = null);

        Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction);
        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);
        Task<string> TransferOwnershipRequestAsync(string newOwner);
        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null);
    }
}
