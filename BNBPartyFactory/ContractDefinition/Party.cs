using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace BNBParty.contracts.csharp.BNBPartyFactory.ContractDefinition
{
    public partial class Party : PartyBase { }

    public class PartyBase 
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
}
