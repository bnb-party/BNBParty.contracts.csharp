using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using BNBParty.contracts.csharp.BNBPartyFactory.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;

namespace BNBParty.contracts.csharp.BNBPartyFactory
{
    public partial class BNBPartyFactoryService : IBNBPartyFactoryService
    {
        protected virtual IWeb3 Web3 { get; private set; }

        public virtual ContractHandler ContractHandler { get; private set; }

        public BNBPartyFactoryService() { }

        public BNBPartyFactoryService(Web3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public BNBPartyFactoryService(IWeb3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public void Initialize(IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        private void EnsureInitialized()
        {
            if (Web3 == null || ContractHandler == null)
            {
                throw new InvalidOperationException("The service has not been initialized. Please call the Initialize method with a valid IWeb3 instance and contract address.");
            }
        }

        public virtual Task<string> BNBPositionManagerQueryAsync(BNBPositionManagerFunction bNBPositionManagerFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BNBPositionManagerFunction, string>(bNBPositionManagerFunction, blockParameter);
        }

        public virtual Task<string> BNBPositionManagerQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BNBPositionManagerFunction, string>(null, blockParameter);
        }

        public virtual Task<string> WbnbQueryAsync(WbnbFunction wbnbFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<WbnbFunction, string>(wbnbFunction, blockParameter);
        }

        public virtual Task<string> WbnbQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<WbnbFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> BonusPartyCreatorQueryAsync(BonusPartyCreatorFunction bonusPartyCreatorFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BonusPartyCreatorFunction, BigInteger>(bonusPartyCreatorFunction, blockParameter);
        }

        public virtual Task<BigInteger> BonusPartyCreatorQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BonusPartyCreatorFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> BonusTargetReachQueryAsync(BonusTargetReachFunction bonusTargetReachFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BonusTargetReachFunction, BigInteger>(bonusTargetReachFunction, blockParameter);
        }

        public virtual Task<BigInteger> BonusTargetReachQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BonusTargetReachFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> CreatePartyRequestAsync(CreatePartyFunction createPartyFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(createPartyFunction);
        }

        public virtual Task<TransactionReceipt> CreatePartyRequestAndWaitForReceiptAsync(CreatePartyFunction createPartyFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(createPartyFunction, cancellationToken);
        }

        public virtual Task<string> CreatePartyRequestAsync(string name, string symbol)
        {
            EnsureInitialized();
            var createPartyFunction = new CreatePartyFunction();
                createPartyFunction.Name = name;
                createPartyFunction.Symbol = symbol;
            
            return ContractHandler.SendRequestAsync(createPartyFunction);
        }

        public virtual Task<TransactionReceipt> CreatePartyRequestAndWaitForReceiptAsync(string name, string symbol, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var createPartyFunction = new CreatePartyFunction();
                createPartyFunction.Name = name;
                createPartyFunction.Symbol = symbol;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(createPartyFunction, cancellationToken);
        }

        public virtual Task<BigInteger> CreateTokenFeeQueryAsync(CreateTokenFeeFunction createTokenFeeFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CreateTokenFeeFunction, BigInteger>(createTokenFeeFunction, blockParameter);
        }

        public virtual Task<BigInteger> CreateTokenFeeQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CreateTokenFeeFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> HandleSwapRequestAsync(HandleSwapFunction handleSwapFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(handleSwapFunction);
        }

        public virtual Task<TransactionReceipt> HandleSwapRequestAndWaitForReceiptAsync(HandleSwapFunction handleSwapFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(handleSwapFunction, cancellationToken);
        }

        public virtual Task<string> HandleSwapRequestAsync(string recipient)
        {
            EnsureInitialized();
            var handleSwapFunction = new HandleSwapFunction();
                handleSwapFunction.Recipient = recipient;
            
            return ContractHandler.SendRequestAsync(handleSwapFunction);
        }

        public virtual Task<TransactionReceipt> HandleSwapRequestAndWaitForReceiptAsync(string recipient, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var handleSwapFunction = new HandleSwapFunction();
                handleSwapFunction.Recipient = recipient;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(handleSwapFunction, cancellationToken);
        }

        public virtual Task<BigInteger> InitialTokenAmountQueryAsync(InitialTokenAmountFunction initialTokenAmountFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<InitialTokenAmountFunction, BigInteger>(initialTokenAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> InitialTokenAmountQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<InitialTokenAmountFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<bool> IsPartyQueryAsync(IsPartyFunction isPartyFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<IsPartyFunction, bool>(isPartyFunction, blockParameter);
        }

        public virtual Task<bool> IsPartyQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var isPartyFunction = new IsPartyFunction();
                isPartyFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsPartyFunction, bool>(isPartyFunction, blockParameter);
        }

        public virtual Task<uint> LpFeeQueryAsync(LpFeeFunction lpFeeFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LpFeeFunction, uint>(lpFeeFunction, blockParameter);
        }

        public virtual Task<uint> LpFeeQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LpFeeFunction, uint>(null, blockParameter);
        }

        public virtual Task<BigInteger> LpToTokenIdQueryAsync(LpToTokenIdFunction lpToTokenIdFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LpToTokenIdFunction, BigInteger>(lpToTokenIdFunction, blockParameter);
        }

        public virtual Task<BigInteger> LpToTokenIdQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var lpToTokenIdFunction = new LpToTokenIdFunction();
                lpToTokenIdFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<LpToTokenIdFunction, BigInteger>(lpToTokenIdFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<uint> PartyLPFeeQueryAsync(PartyLPFeeFunction partyLPFeeFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PartyLPFeeFunction, uint>(partyLPFeeFunction, blockParameter);
        }

        public virtual Task<uint> PartyLPFeeQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PartyLPFeeFunction, uint>(null, blockParameter);
        }

        public virtual Task<BigInteger> PartyTargetQueryAsync(PartyTargetFunction partyTargetFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PartyTargetFunction, BigInteger>(partyTargetFunction, blockParameter);
        }

        public virtual Task<BigInteger> PartyTargetQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PartyTargetFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> PositionManagerQueryAsync(PositionManagerFunction positionManagerFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PositionManagerFunction, string>(positionManagerFunction, blockParameter);
        }

        public virtual Task<string> PositionManagerQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PositionManagerFunction, string>(null, blockParameter);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync()
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public virtual Task<BigInteger> ReturnAmountQueryAsync(ReturnAmountFunction returnAmountFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<ReturnAmountFunction, BigInteger>(returnAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> ReturnAmountQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<ReturnAmountFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> SetNonfungiblePositionManagerRequestAsync(SetNonfungiblePositionManagerFunction setNonfungiblePositionManagerFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setNonfungiblePositionManagerFunction);
        }

        public virtual Task<TransactionReceipt> SetNonfungiblePositionManagerRequestAndWaitForReceiptAsync(SetNonfungiblePositionManagerFunction setNonfungiblePositionManagerFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setNonfungiblePositionManagerFunction, cancellationToken);
        }

        public virtual Task<string> SetNonfungiblePositionManagerRequestAsync(string bNBPositionManager, string positionManager)
        {
            EnsureInitialized();
            var setNonfungiblePositionManagerFunction = new SetNonfungiblePositionManagerFunction();
                setNonfungiblePositionManagerFunction.BNBPositionManager = bNBPositionManager;
                setNonfungiblePositionManagerFunction.PositionManager = positionManager;
            
            return ContractHandler.SendRequestAsync(setNonfungiblePositionManagerFunction);
        }

        public virtual Task<TransactionReceipt> SetNonfungiblePositionManagerRequestAndWaitForReceiptAsync(string bNBPositionManager, string positionManager, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setNonfungiblePositionManagerFunction = new SetNonfungiblePositionManagerFunction();
                setNonfungiblePositionManagerFunction.BNBPositionManager = bNBPositionManager;
                setNonfungiblePositionManagerFunction.PositionManager = positionManager;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setNonfungiblePositionManagerFunction, cancellationToken);
        }

        public virtual Task<BigInteger> SqrtPriceX96QueryAsync(SqrtPriceX96Function sqrtPriceX96Function, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<SqrtPriceX96Function, BigInteger>(sqrtPriceX96Function, blockParameter);
        }

        public virtual Task<BigInteger> SqrtPriceX96QueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<SqrtPriceX96Function, BigInteger>(null, blockParameter);
        }

        public virtual Task<int> TickLowerQueryAsync(TickLowerFunction tickLowerFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TickLowerFunction, int>(tickLowerFunction, blockParameter);
        }

        public virtual Task<int> TickLowerQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TickLowerFunction, int>(null, blockParameter);
        }

        public virtual Task<int> TickUpperQueryAsync(TickUpperFunction tickUpperFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TickUpperFunction, int>(tickUpperFunction, blockParameter);
        }

        public virtual Task<int> TickUpperQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TickUpperFunction, int>(null, blockParameter);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            EnsureInitialized();
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }
    }
}
