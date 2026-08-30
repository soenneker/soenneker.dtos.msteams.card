[![](https://img.shields.io/nuget/v/soenneker.dtos.msteams.card.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.msteams.card/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.msteams.card/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.msteams.card/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.msteams.card.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.msteams.card/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.msteams.card/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.msteams.card/actions/workflows/codeql.yml)

# Soenneker.Dtos.MsTeams.Card

Builds the outer Microsoft Teams message payload used to send one or more Adaptive Card attachments. The model works with both `System.Text.Json` and Newtonsoft.Json.

## Install

```bash
dotnet add package Soenneker.Dtos.MsTeams.Card
```

## Create a Teams card payload

```csharp
using AdaptiveCards;
using Soenneker.Dtos.AdaptiveCard.Attachments;
using Soenneker.Dtos.MsTeams.Card;

var adaptiveCard = new AdaptiveCard(new AdaptiveSchemaVersion(1, 5));
adaptiveCard.Body.Add(new AdaptiveTextBlock
{
    Text = "Deployment completed",
    Weight = AdaptiveTextWeight.Bolder
});

var payload = new MsTeamsCard();
payload.Attachments.Add(new AdaptiveCardAttachments(adaptiveCard));
```

`Type` defaults to `message`, and `Attachments` starts as an empty list. Serializing `payload` produces the Teams envelope around the Adaptive Card:

```json
{
  "type": "message",
  "attachments": [
    {
      "contentType": "application/vnd.microsoft.card.adaptive",
      "contentUrl": null,
      "content": {
        "type": "AdaptiveCard",
        "version": "1.5"
      }
    }
  ]
}
```

The exact `content` object and treatment of null properties depend on the Adaptive Card and serializer settings. This package only models the payload; it does not validate card schema support or send the message to Teams.
