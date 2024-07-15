# BNBParty.contracts.csharp

This repository contains the C# contracts for the BNBParty project.
				
## Installation

To install the contracts, you can use the following command:

```bash
dotnet add package BNBParty.contracts.csharp
```

## Usage

```csharp
using BNBParty.contracts.csharp.BNBPartyFactory.ContractDefinition;

public class PartyService
{
    public EventLog<StartPartyEventDTOBase> GetStartPartyEvent(Web3 web3, string contractAddress, JArray logs)
    {
        return web3.Eth.GetEvent<StartPartyEventDTOBase>(contractAddress).DecodeAllEventsForEvent(logs)[0];
    }
}

```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
This project is licensed under the [MIT](https://choosealicense.com/licenses/mit/)