using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

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
        [Parameter("uint256", "_partyTarget", 1)]
        public BigInteger PartyTarget { get; set; }
        [Parameter("uint256", "_createTokenFee", 2)]
        public BigInteger CreateTokenFee { get; set; }
        [Parameter("uint24", "_partyLpFee", 3)]
        public uint PartyLpFee { get; set; }
        [Parameter("uint24", "_lpFee", 4)]
        public uint LpFee { get; set; }
        [Parameter("uint256", "_initialTokenAmount", 5)]
        public BigInteger InitialTokenAmount { get; set; }
        [Parameter("uint160", "_sqrtPriceX96", 6)]
        public BigInteger SqrtPriceX96 { get; set; }
        [Parameter("address", "_WBNB", 7)]
        public string Wbnb { get; set; }
        [Parameter("uint256", "_bonusTargetReach", 8)]
        public BigInteger BonusTargetReach { get; set; }
        [Parameter("uint256", "_bonusPartyCreator", 9)]
        public BigInteger BonusPartyCreator { get; set; }
        [Parameter("int24", "_tickLower", 10)]
        public int TickLower { get; set; }
        [Parameter("int24", "_tickUpper", 11)]
        public int TickUpper { get; set; }
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

    public partial class BonusPartyCreatorFunction : BonusPartyCreatorFunctionBase { }

    [Function("bonusPartyCreator", "uint256")]
    public class BonusPartyCreatorFunctionBase : FunctionMessage
    {

    }

    public partial class BonusTargetReachFunction : BonusTargetReachFunctionBase { }

    [Function("bonusTargetReach", "uint256")]
    public class BonusTargetReachFunctionBase : FunctionMessage
    {

    }

    public partial class CreatePartyFunction : CreatePartyFunctionBase { }

    [Function("createParty", "address")]
    public class CreatePartyFunctionBase : FunctionMessage
    {
        [Parameter("string", "name", 1)]
        public string Name { get; set; }
        [Parameter("string", "symbol", 2)]
        public string Symbol { get; set; }
    }

    public partial class CreateTokenFeeFunction : CreateTokenFeeFunctionBase { }

    [Function("createTokenFee", "uint256")]
    public class CreateTokenFeeFunctionBase : FunctionMessage
    {

    }

    public partial class HandleSwapFunction : HandleSwapFunctionBase { }

    [Function("handleSwap")]
    public class HandleSwapFunctionBase : FunctionMessage
    {
        [Parameter("address", "recipient", 1)]
        public string Recipient { get; set; }
    }

    public partial class InitialTokenAmountFunction : InitialTokenAmountFunctionBase { }

    [Function("initialTokenAmount", "uint256")]
    public class InitialTokenAmountFunctionBase : FunctionMessage
    {

    }

    public partial class IsPartyFunction : IsPartyFunctionBase { }

    [Function("isParty", "bool")]
    public class IsPartyFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public string ReturnValue1 { get; set; }
    }

    public partial class LpFeeFunction : LpFeeFunctionBase { }

    [Function("lpFee", "uint24")]
    public class LpFeeFunctionBase : FunctionMessage
    {

    }

    public partial class LpToTokenIdFunction : LpToTokenIdFunctionBase { }

    [Function("lpToTokenId", "uint256")]
    public class LpToTokenIdFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public string ReturnValue1 { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PartyLPFeeFunction : PartyLPFeeFunctionBase { }

    [Function("partyLPFee", "uint24")]
    public class PartyLPFeeFunctionBase : FunctionMessage
    {

    }

    public partial class PartyTargetFunction : PartyTargetFunctionBase { }

    [Function("partyTarget", "uint256")]
    public class PartyTargetFunctionBase : FunctionMessage
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

    public partial class ReturnAmountFunction : ReturnAmountFunctionBase { }

    [Function("returnAmount", "uint256")]
    public class ReturnAmountFunctionBase : FunctionMessage
    {

    }

    public partial class SetNonfungiblePositionManagerFunction : SetNonfungiblePositionManagerFunctionBase { }

    [Function("setNonfungiblePositionManager")]
    public class SetNonfungiblePositionManagerFunctionBase : FunctionMessage
    {
        [Parameter("address", "_BNBPositionManager", 1)]
        public string BNBPositionManager { get; set; }
        [Parameter("address", "_positionManager", 2)]
        public string PositionManager { get; set; }
    }

    public partial class SqrtPriceX96Function : SqrtPriceX96FunctionBase { }

    [Function("sqrtPriceX96", "uint160")]
    public class SqrtPriceX96FunctionBase : FunctionMessage
    {

    }

    public partial class TickLowerFunction : TickLowerFunctionBase { }

    [Function("tickLower", "int24")]
    public class TickLowerFunctionBase : FunctionMessage
    {

    }

    public partial class TickUpperFunction : TickUpperFunctionBase { }

    [Function("tickUpper", "int24")]
    public class TickUpperFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public string NewOwner { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public string NewOwner { get; set; }
    }

    public partial class StartPartyEventDTO : StartPartyEventDTOBase { }

    [Event("StartParty")]
    public class StartPartyEventDTOBase : IEventDTO
    {
        [Parameter("address", "tokenAddress", 1, true )]
        public string TokenAddress { get; set; }
        [Parameter("address", "owner", 2, true )]
        public string Owner { get; set; }
        [Parameter("address", "FLPAddress", 3, true )]
        public string FLPAddress { get; set; }
    }

    public partial class OwnableInvalidOwnerError : OwnableInvalidOwnerErrorBase { }

    [Error("OwnableInvalidOwner")]
    public class OwnableInvalidOwnerErrorBase : IErrorDTO
    {
        [Parameter("address", "owner", 1)]
        public string Owner { get; set; }
    }

    public partial class OwnableUnauthorizedAccountError : OwnableUnauthorizedAccountErrorBase { }

    [Error("OwnableUnauthorizedAccount")]
    public class OwnableUnauthorizedAccountErrorBase : IErrorDTO
    {
        [Parameter("address", "account", 1)]
        public string Account { get; set; }
    }

    public partial class ReentrancyGuardReentrantCallError : ReentrancyGuardReentrantCallErrorBase { }
    [Error("ReentrancyGuardReentrantCall")]
    public class ReentrancyGuardReentrantCallErrorBase : IErrorDTO
    {
    }

    public partial class BNBPositionManagerOutputDTO : BNBPositionManagerOutputDTOBase { }

    [FunctionOutput]
    public class BNBPositionManagerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public string ReturnValue1 { get; set; }
    }

    public partial class WbnbOutputDTO : WbnbOutputDTOBase { }

    [FunctionOutput]
    public class WbnbOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public string ReturnValue1 { get; set; }
    }

    public partial class BonusPartyCreatorOutputDTO : BonusPartyCreatorOutputDTOBase { }

    [FunctionOutput]
    public class BonusPartyCreatorOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }

    public partial class BonusTargetReachOutputDTO : BonusTargetReachOutputDTOBase { }

    [FunctionOutput]
    public class BonusTargetReachOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }



    public partial class CreateTokenFeeOutputDTO : CreateTokenFeeOutputDTOBase { }

    [FunctionOutput]
    public class CreateTokenFeeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }



    public partial class InitialTokenAmountOutputDTO : InitialTokenAmountOutputDTOBase { }

    [FunctionOutput]
    public class InitialTokenAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }

    public partial class IsPartyOutputDTO : IsPartyOutputDTOBase { }

    [FunctionOutput]
    public class IsPartyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public bool ReturnValue1 { get; set; }
    }

    public partial class LpFeeOutputDTO : LpFeeOutputDTOBase { }

    [FunctionOutput]
    public class LpFeeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint24", "", 1)]
        public uint ReturnValue1 { get; set; }
    }

    public partial class LpToTokenIdOutputDTO : LpToTokenIdOutputDTOBase { }

    [FunctionOutput]
    public class LpToTokenIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public string ReturnValue1 { get; set; }
    }

    public partial class PartyLPFeeOutputDTO : PartyLPFeeOutputDTOBase { }

    [FunctionOutput]
    public class PartyLPFeeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint24", "", 1)]
        public uint ReturnValue1 { get; set; }
    }

    public partial class PartyTargetOutputDTO : PartyTargetOutputDTOBase { }

    [FunctionOutput]
    public class PartyTargetOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }

    public partial class PositionManagerOutputDTO : PositionManagerOutputDTOBase { }

    [FunctionOutput]
    public class PositionManagerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public string ReturnValue1 { get; set; }
    }



    public partial class ReturnAmountOutputDTO : ReturnAmountOutputDTOBase { }

    [FunctionOutput]
    public class ReturnAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }



    public partial class SqrtPriceX96OutputDTO : SqrtPriceX96OutputDTOBase { }

    [FunctionOutput]
    public class SqrtPriceX96OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint160", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }

    public partial class TickLowerOutputDTO : TickLowerOutputDTOBase { }

    [FunctionOutput]
    public class TickLowerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("int24", "", 1)]
        public int ReturnValue1 { get; set; }
    }

    public partial class TickUpperOutputDTO : TickUpperOutputDTOBase { }

    [FunctionOutput]
    public class TickUpperOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("int24", "", 1)]
        public int ReturnValue1 { get; set; }
    }


}
