using System.Threading;
using System.Threading.Tasks;
using BNBParty.contracts.csharp.BNBPartyFactory.ContractDefinition;
using Nethereum.RPC.Eth.DTOs;

namespace BNBParty.contracts.csharp.BNBPartyFactory
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
