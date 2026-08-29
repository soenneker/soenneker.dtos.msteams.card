[![](https://img.shields.io/nuget/v/soenneker.dtos.msteams.card.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.msteams.card/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.msteams.card/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.msteams.card/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.msteams.card.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.msteams.card/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.msteams.card/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.msteams.card/actions/workflows/codeql.yml)

# Soenneker.Dtos.MsTeams.Card

Represents a Microsoft Teams message containing one or more Adaptive Card attachments.

## Install

```bash
dotnet add package Soenneker.Dtos.MsTeams.Card
```

## What you get

- `MsTeamsCard` — Represents a Microsoft Teams message containing one or more Adaptive Card attachments.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `MsTeamsCard.Type` | Teams message type, such as `message`. | Teams message type, such as `message`. |
| `MsTeamsCard.Attachments` | Adaptive Card attachments included in the Teams message. | Adaptive Card attachments included in the Teams message. |
