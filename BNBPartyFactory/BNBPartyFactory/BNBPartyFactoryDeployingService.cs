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
    public partial class BNBPartyFactoryDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, BNBPartyFactoryDeployment bNBPartyFactoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<BNBPartyFactoryDeployment>().SendRequestAndWaitForReceiptAsync(bNBPartyFactoryDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, BNBPartyFactoryDeployment bNBPartyFactoryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<BNBPartyFactoryDeployment>().SendRequestAsync(bNBPartyFactoryDeployment);
        }

        public virtual async Task<BNBPartyFactoryService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, BNBPartyFactoryDeployment bNBPartyFactoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, bNBPartyFactoryDeployment, cancellationTokenSource);
            return new BNBPartyFactoryService(web3, receipt.ContractAddress);
        }
    }
}
