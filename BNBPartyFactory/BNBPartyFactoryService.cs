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
using BNBParty.contracts.csharp.BNBPartyFactory.ContractDefinition;

namespace BNBParty.contracts.csharp.BNBPartyFactory
{
    public partial class BNBPartyFactoryService : ContractWeb3ServiceBase, IBNBPartyFactoryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, BNBPartyFactoryDeployment bNBPartyFactoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<BNBPartyFactoryDeployment>().SendRequestAndWaitForReceiptAsync(bNBPartyFactoryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, BNBPartyFactoryDeployment bNBPartyFactoryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<BNBPartyFactoryDeployment>().SendRequestAsync(bNBPartyFactoryDeployment);
        }

        public static async Task<BNBPartyFactoryService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, BNBPartyFactoryDeployment bNBPartyFactoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, bNBPartyFactoryDeployment, cancellationTokenSource);
            return new BNBPartyFactoryService(web3, receipt.ContractAddress);
        }

        public BNBPartyFactoryService(Nethereum.Web3.IWeb3 web3, string contractAddress) : base(web3, contractAddress)
        {
        }

        public Task<string> BNBPositionManagerQueryAsync(BNBPositionManagerFunction bNBPositionManagerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BNBPositionManagerFunction, string>(bNBPositionManagerFunction, blockParameter);
        }

        
        public Task<string> BNBPositionManagerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BNBPositionManagerFunction, string>(null, blockParameter);
        }

        public Task<string> WbnbQueryAsync(WbnbFunction wbnbFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WbnbFunction, string>(wbnbFunction, blockParameter);
        }

        
        public Task<string> WbnbQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WbnbFunction, string>(null, blockParameter);
        }

        public Task<string> CreatePartyRequestAsync(CreatePartyFunction createPartyFunction)
        {
             return ContractHandler.SendRequestAsync(createPartyFunction);
        }

        public Task<TransactionReceipt> CreatePartyRequestAndWaitForReceiptAsync(CreatePartyFunction createPartyFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createPartyFunction, cancellationToken);
        }

        public Task<string> CreatePartyRequestAsync(string name, string symbol)
        {
            var createPartyFunction = new CreatePartyFunction();
                createPartyFunction.Name = name;
                createPartyFunction.Symbol = symbol;
            
             return ContractHandler.SendRequestAsync(createPartyFunction);
        }

        public Task<TransactionReceipt> CreatePartyRequestAndWaitForReceiptAsync(string name, string symbol, CancellationTokenSource cancellationToken = null)
        {
            var createPartyFunction = new CreatePartyFunction();
                createPartyFunction.Name = name;
                createPartyFunction.Symbol = symbol;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createPartyFunction, cancellationToken);
        }

        public Task<string> HandleSwapRequestAsync(HandleSwapFunction handleSwapFunction)
        {
             return ContractHandler.SendRequestAsync(handleSwapFunction);
        }

        public Task<TransactionReceipt> HandleSwapRequestAndWaitForReceiptAsync(HandleSwapFunction handleSwapFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(handleSwapFunction, cancellationToken);
        }

        public Task<string> HandleSwapRequestAsync(string recipient)
        {
            var handleSwapFunction = new HandleSwapFunction();
                handleSwapFunction.Recipient = recipient;
            
             return ContractHandler.SendRequestAsync(handleSwapFunction);
        }

        public Task<TransactionReceipt> HandleSwapRequestAndWaitForReceiptAsync(string recipient, CancellationTokenSource cancellationToken = null)
        {
            var handleSwapFunction = new HandleSwapFunction();
                handleSwapFunction.Recipient = recipient;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(handleSwapFunction, cancellationToken);
        }

        public Task<bool> IsPartyQueryAsync(IsPartyFunction isPartyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsPartyFunction, bool>(isPartyFunction, blockParameter);
        }

        
        public Task<bool> IsPartyQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var isPartyFunction = new IsPartyFunction();
                isPartyFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsPartyFunction, bool>(isPartyFunction, blockParameter);
        }

        public Task<string> JoinPartyRequestAsync(JoinPartyFunction joinPartyFunction)
        {
             return ContractHandler.SendRequestAsync(joinPartyFunction);
        }

        public Task<TransactionReceipt> JoinPartyRequestAndWaitForReceiptAsync(JoinPartyFunction joinPartyFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(joinPartyFunction, cancellationToken);
        }

        public Task<string> JoinPartyRequestAsync(string tokenOut, BigInteger amountOutMinimum)
        {
            var joinPartyFunction = new JoinPartyFunction();
                joinPartyFunction.TokenOut = tokenOut;
                joinPartyFunction.AmountOutMinimum = amountOutMinimum;
            
             return ContractHandler.SendRequestAsync(joinPartyFunction);
        }

        public Task<TransactionReceipt> JoinPartyRequestAndWaitForReceiptAsync(string tokenOut, BigInteger amountOutMinimum, CancellationTokenSource cancellationToken = null)
        {
            var joinPartyFunction = new JoinPartyFunction();
                joinPartyFunction.TokenOut = tokenOut;
                joinPartyFunction.AmountOutMinimum = amountOutMinimum;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(joinPartyFunction, cancellationToken);
        }

        public Task<string> LeavePartyRequestAsync(LeavePartyFunction leavePartyFunction)
        {
             return ContractHandler.SendRequestAsync(leavePartyFunction);
        }

        public Task<TransactionReceipt> LeavePartyRequestAndWaitForReceiptAsync(LeavePartyFunction leavePartyFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(leavePartyFunction, cancellationToken);
        }

        public Task<string> LeavePartyRequestAsync(string tokenIn, BigInteger amountIn, BigInteger amountOutMinimum)
        {
            var leavePartyFunction = new LeavePartyFunction();
                leavePartyFunction.TokenIn = tokenIn;
                leavePartyFunction.AmountIn = amountIn;
                leavePartyFunction.AmountOutMinimum = amountOutMinimum;
            
             return ContractHandler.SendRequestAsync(leavePartyFunction);
        }

        public Task<TransactionReceipt> LeavePartyRequestAndWaitForReceiptAsync(string tokenIn, BigInteger amountIn, BigInteger amountOutMinimum, CancellationTokenSource cancellationToken = null)
        {
            var leavePartyFunction = new LeavePartyFunction();
                leavePartyFunction.TokenIn = tokenIn;
                leavePartyFunction.AmountIn = amountIn;
                leavePartyFunction.AmountOutMinimum = amountOutMinimum;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(leavePartyFunction, cancellationToken);
        }

        public Task<BigInteger> LpToTokenIdQueryAsync(LpToTokenIdFunction lpToTokenIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LpToTokenIdFunction, BigInteger>(lpToTokenIdFunction, blockParameter);
        }

        
        public Task<BigInteger> LpToTokenIdQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var lpToTokenIdFunction = new LpToTokenIdFunction();
                lpToTokenIdFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<LpToTokenIdFunction, BigInteger>(lpToTokenIdFunction, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<PartyOutputDTO> PartyQueryAsync(PartyFunction partyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<PartyFunction, PartyOutputDTO>(partyFunction, blockParameter);
        }

        public Task<PartyOutputDTO> PartyQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<PartyFunction, PartyOutputDTO>(null, blockParameter);
        }

        public Task<string> PositionManagerQueryAsync(PositionManagerFunction positionManagerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PositionManagerFunction, string>(positionManagerFunction, blockParameter);
        }

        
        public Task<string> PositionManagerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PositionManagerFunction, string>(null, blockParameter);
        }

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public Task<string> SetNonfungiblePositionManagerRequestAsync(SetNonfungiblePositionManagerFunction setNonfungiblePositionManagerFunction)
        {
             return ContractHandler.SendRequestAsync(setNonfungiblePositionManagerFunction);
        }

        public Task<TransactionReceipt> SetNonfungiblePositionManagerRequestAndWaitForReceiptAsync(SetNonfungiblePositionManagerFunction setNonfungiblePositionManagerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setNonfungiblePositionManagerFunction, cancellationToken);
        }

        public Task<string> SetNonfungiblePositionManagerRequestAsync(string bNBPositionManager, string positionManager)
        {
            var setNonfungiblePositionManagerFunction = new SetNonfungiblePositionManagerFunction();
                setNonfungiblePositionManagerFunction.BNBPositionManager = bNBPositionManager;
                setNonfungiblePositionManagerFunction.PositionManager = positionManager;
            
             return ContractHandler.SendRequestAsync(setNonfungiblePositionManagerFunction);
        }

        public Task<TransactionReceipt> SetNonfungiblePositionManagerRequestAndWaitForReceiptAsync(string bNBPositionManager, string positionManager, CancellationTokenSource cancellationToken = null)
        {
            var setNonfungiblePositionManagerFunction = new SetNonfungiblePositionManagerFunction();
                setNonfungiblePositionManagerFunction.BNBPositionManager = bNBPositionManager;
                setNonfungiblePositionManagerFunction.PositionManager = positionManager;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setNonfungiblePositionManagerFunction, cancellationToken);
        }

        public Task<string> SetSwapRouterRequestAsync(SetSwapRouterFunction setSwapRouterFunction)
        {
             return ContractHandler.SendRequestAsync(setSwapRouterFunction);
        }

        public Task<TransactionReceipt> SetSwapRouterRequestAndWaitForReceiptAsync(SetSwapRouterFunction setSwapRouterFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setSwapRouterFunction, cancellationToken);
        }

        public Task<string> SetSwapRouterRequestAsync(string swapRouter)
        {
            var setSwapRouterFunction = new SetSwapRouterFunction();
                setSwapRouterFunction.SwapRouter = swapRouter;
            
             return ContractHandler.SendRequestAsync(setSwapRouterFunction);
        }

        public Task<TransactionReceipt> SetSwapRouterRequestAndWaitForReceiptAsync(string swapRouter, CancellationTokenSource cancellationToken = null)
        {
            var setSwapRouterFunction = new SetSwapRouterFunction();
                setSwapRouterFunction.SwapRouter = swapRouter;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setSwapRouterFunction, cancellationToken);
        }

        public Task<string> SwapRouterQueryAsync(SwapRouterFunction swapRouterFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SwapRouterFunction, string>(swapRouterFunction, blockParameter);
        }

        
        public Task<string> SwapRouterQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SwapRouterFunction, string>(null, blockParameter);
        }

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public override List<Type> GetAllFunctionTypes()
        {
            return new List<Type>
            {
                typeof(BNBPositionManagerFunction),
                typeof(WbnbFunction),
                typeof(CreatePartyFunction),
                typeof(HandleSwapFunction),
                typeof(IsPartyFunction),
                typeof(JoinPartyFunction),
                typeof(LeavePartyFunction),
                typeof(LpToTokenIdFunction),
                typeof(OwnerFunction),
                typeof(PartyFunction),
                typeof(PositionManagerFunction),
                typeof(RenounceOwnershipFunction),
                typeof(SetNonfungiblePositionManagerFunction),
                typeof(SetSwapRouterFunction),
                typeof(SwapRouterFunction),
                typeof(TransferOwnershipFunction)
            };
        }

        public override List<Type> GetAllEventTypes()
        {
            return new List<Type>
            {
                typeof(OwnershipTransferredEventDTO),
                typeof(StartPartyEventDTO)
            };
        }

        public override List<Type> GetAllErrorTypes()
        {
            return new List<Type>
            {
                typeof(AddressEmptyCodeError),
                typeof(AddressInsufficientBalanceError),
                typeof(BonusGreaterThanTargetError),
                typeof(FailedInnerCallError),
                typeof(InsufficientBNBError),
                typeof(LPNotAtPartyError),
                typeof(OwnableInvalidOwnerError),
                typeof(OwnableUnauthorizedAccountError),
                typeof(PositionManagerAlreadySetError),
                typeof(PositionManagerNotSetError),
                typeof(ReentrancyGuardReentrantCallError),
                typeof(SafeERC20FailedOperationError),
                typeof(SwapRouterAlreadySetError),
                typeof(ZeroAddressError),
                typeof(ZeroAmountError)
            };
        }
    }
}
