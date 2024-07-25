using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace BNBParty.contracts.csharp.BNBPartyFactory.ContractDefinition
{


    public partial class BNBPartyFactoryDeployment : BNBPartyFactoryDeploymentBase
    {
        public BNBPartyFactoryDeployment() : base(BYTECODE) { }
        public BNBPartyFactoryDeployment(string byteCode) : base(byteCode) { }
    }

    public class BNBPartyFactoryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = string.Empty;
        public BNBPartyFactoryDeploymentBase() : base(BYTECODE) { }
        public BNBPartyFactoryDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("tuple", "_party", 1)]
        public virtual Party Party { get; set; }
        [Parameter("address", "_WBNB", 2)]
        public virtual string Wbnb { get; set; }
    }

    public partial class BNBPositionManagerFunction : BNBPositionManagerFunctionBase { }

    [Function("BNBPositionManager", "address")]
    public class BNBPositionManagerFunctionBase : FunctionMessage
    {

    }

    public partial class WbnbFunction : WbnbFunctionBase { }

    [Function("WBNB", "address")]
    public class WbnbFunctionBase : FunctionMessage
    {

    }

    public partial class CreatePartyFunction : CreatePartyFunctionBase { }

    [Function("createParty", "address")]
    public class CreatePartyFunctionBase : FunctionMessage
    {
        [Parameter("string", "name", 1)]
        public virtual string Name { get; set; }
        [Parameter("string", "symbol", 2)]
        public virtual string Symbol { get; set; }
    }

    public partial class HandleSwapFunction : HandleSwapFunctionBase { }

    [Function("handleSwap")]
    public class HandleSwapFunctionBase : FunctionMessage
    {
        [Parameter("address", "recipient", 1)]
        public virtual string Recipient { get; set; }
    }

    public partial class IsPartyFunction : IsPartyFunctionBase { }

    [Function("isParty", "bool")]
    public class IsPartyFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class JoinPartyFunction : JoinPartyFunctionBase { }

    [Function("joinParty")]
    public class JoinPartyFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenOut", 1)]
        public virtual string TokenOut { get; set; }
        [Parameter("uint256", "amountOutMinimum", 2)]
        public virtual BigInteger AmountOutMinimum { get; set; }
    }

    public partial class LeavePartyFunction : LeavePartyFunctionBase { }

    [Function("leaveParty")]
    public class LeavePartyFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenIn", 1)]
        public virtual string TokenIn { get; set; }
        [Parameter("uint256", "amountIn", 2)]
        public virtual BigInteger AmountIn { get; set; }
        [Parameter("uint256", "amountOutMinimum", 3)]
        public virtual BigInteger AmountOutMinimum { get; set; }
    }

    public partial class LpToTokenIdFunction : LpToTokenIdFunctionBase { }

    [Function("lpToTokenId", "uint256")]
    public class LpToTokenIdFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PartyFunction : PartyFunctionBase { }

    [Function("party", typeof(PartyOutputDTO))]
    public class PartyFunctionBase : FunctionMessage
    {

    }

    public partial class PositionManagerFunction : PositionManagerFunctionBase { }

    [Function("positionManager", "address")]
    public class PositionManagerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SetNonfungiblePositionManagerFunction : SetNonfungiblePositionManagerFunctionBase { }

    [Function("setNonfungiblePositionManager")]
    public class SetNonfungiblePositionManagerFunctionBase : FunctionMessage
    {
        [Parameter("address", "_BNBPositionManager", 1)]
        public virtual string BNBPositionManager { get; set; }
        [Parameter("address", "_positionManager", 2)]
        public virtual string PositionManager { get; set; }
    }

    public partial class SetSwapRouterFunction : SetSwapRouterFunctionBase { }

    [Function("setSwapRouter")]
    public class SetSwapRouterFunctionBase : FunctionMessage
    {
        [Parameter("address", "_swapRouter", 1)]
        public virtual string SwapRouter { get; set; }
    }

    public partial class SwapRouterFunction : SwapRouterFunctionBase { }

    [Function("swapRouter", "address")]
    public class SwapRouterFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class StartPartyEventDTO : StartPartyEventDTOBase { }

    [Event("StartParty")]
    public class StartPartyEventDTOBase : IEventDTO
    {
        [Parameter("address", "tokenAddress", 1, true )]
        public virtual string TokenAddress { get; set; }
        [Parameter("address", "owner", 2, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "FLPAddress", 3, true )]
        public virtual string FLPAddress { get; set; }
    }

    public partial class AddressEmptyCodeError : AddressEmptyCodeErrorBase { }

    [Error("AddressEmptyCode")]
    public class AddressEmptyCodeErrorBase : IErrorDTO
    {
        [Parameter("address", "target", 1)]
        public virtual string Target { get; set; }
    }

    public partial class AddressInsufficientBalanceError : AddressInsufficientBalanceErrorBase { }

    [Error("AddressInsufficientBalance")]
    public class AddressInsufficientBalanceErrorBase : IErrorDTO
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class BonusGreaterThanTargetError : BonusGreaterThanTargetErrorBase { }
    [Error("BonusGreaterThanTarget")]
    public class BonusGreaterThanTargetErrorBase : IErrorDTO
    {
    }

    public partial class FailedInnerCallError : FailedInnerCallErrorBase { }
    [Error("FailedInnerCall")]
    public class FailedInnerCallErrorBase : IErrorDTO
    {
    }

    public partial class InsufficientBNBError : InsufficientBNBErrorBase { }
    [Error("InsufficientBNB")]
    public class InsufficientBNBErrorBase : IErrorDTO
    {
    }

    public partial class LPNotAtPartyError : LPNotAtPartyErrorBase { }
    [Error("LPNotAtParty")]
    public class LPNotAtPartyErrorBase : IErrorDTO
    {
    }

    public partial class OwnableInvalidOwnerError : OwnableInvalidOwnerErrorBase { }

    [Error("OwnableInvalidOwner")]
    public class OwnableInvalidOwnerErrorBase : IErrorDTO
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class OwnableUnauthorizedAccountError : OwnableUnauthorizedAccountErrorBase { }

    [Error("OwnableUnauthorizedAccount")]
    public class OwnableUnauthorizedAccountErrorBase : IErrorDTO
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class PositionManagerAlreadySetError : PositionManagerAlreadySetErrorBase { }
    [Error("PositionManagerAlreadySet")]
    public class PositionManagerAlreadySetErrorBase : IErrorDTO
    {
    }

    public partial class PositionManagerNotSetError : PositionManagerNotSetErrorBase { }
    [Error("PositionManagerNotSet")]
    public class PositionManagerNotSetErrorBase : IErrorDTO
    {
    }

    public partial class ReentrancyGuardReentrantCallError : ReentrancyGuardReentrantCallErrorBase { }
    [Error("ReentrancyGuardReentrantCall")]
    public class ReentrancyGuardReentrantCallErrorBase : IErrorDTO
    {
    }

    public partial class SafeERC20FailedOperationError : SafeERC20FailedOperationErrorBase { }

    [Error("SafeERC20FailedOperation")]
    public class SafeERC20FailedOperationErrorBase : IErrorDTO
    {
        [Parameter("address", "token", 1)]
        public virtual string Token { get; set; }
    }

    public partial class SwapRouterAlreadySetError : SwapRouterAlreadySetErrorBase { }
    [Error("SwapRouterAlreadySet")]
    public class SwapRouterAlreadySetErrorBase : IErrorDTO
    {
    }

    public partial class ZeroAddressError : ZeroAddressErrorBase { }
    [Error("ZeroAddress")]
    public class ZeroAddressErrorBase : IErrorDTO
    {
    }

    public partial class ZeroAmountError : ZeroAmountErrorBase { }
    [Error("ZeroAmount")]
    public class ZeroAmountErrorBase : IErrorDTO
    {
    }

    public partial class BNBPositionManagerOutputDTO : BNBPositionManagerOutputDTOBase { }

    [FunctionOutput]
    public class BNBPositionManagerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class WbnbOutputDTO : WbnbOutputDTOBase { }

    [FunctionOutput]
    public class WbnbOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }





    public partial class IsPartyOutputDTO : IsPartyOutputDTOBase { }

    [FunctionOutput]
    public class IsPartyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class LpToTokenIdOutputDTO : LpToTokenIdOutputDTOBase { }

    [FunctionOutput]
    public class LpToTokenIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PartyOutputDTO : PartyOutputDTOBase { }

    [FunctionOutput]
    public class PartyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "partyTarget", 1)]
        public virtual BigInteger PartyTarget { get; set; }
        [Parameter("uint256", "createTokenFee", 2)]
        public virtual BigInteger CreateTokenFee { get; set; }
        [Parameter("uint24", "partyLpFee", 3)]
        public virtual uint PartyLpFee { get; set; }
        [Parameter("uint24", "lpFee", 4)]
        public virtual uint LpFee { get; set; }
        [Parameter("uint256", "initialTokenAmount", 5)]
        public virtual BigInteger InitialTokenAmount { get; set; }
        [Parameter("uint160", "sqrtPriceX96", 6)]
        public virtual BigInteger SqrtPriceX96 { get; set; }
        [Parameter("uint256", "bonusTargetReach", 7)]
        public virtual BigInteger BonusTargetReach { get; set; }
        [Parameter("uint256", "bonusPartyCreator", 8)]
        public virtual BigInteger BonusPartyCreator { get; set; }
        [Parameter("int24", "tickLower", 9)]
        public virtual int TickLower { get; set; }
        [Parameter("int24", "tickUpper", 10)]
        public virtual int TickUpper { get; set; }
    }

    public partial class PositionManagerOutputDTO : PositionManagerOutputDTOBase { }

    [FunctionOutput]
    public class PositionManagerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SwapRouterOutputDTO : SwapRouterOutputDTOBase { }

    [FunctionOutput]
    public class SwapRouterOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}
