using System.Collections.Generic;
using System.Text.Json.Serialization;
using Soenneker.Dtos.AdaptiveCard.Attachments;

namespace Soenneker.Dtos.MsTeams.Card;

/// <summary>
/// Represents a Microsoft Teams message containing one or more Adaptive Card attachments.
/// </summary>
public class MsTeamsCard
{
    /// <summary>
    /// Teams message type, such as <c>message</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "message";

    /// <summary>
    /// Adaptive Card attachments included in the Teams message.
    /// </summary>
    [JsonPropertyName("attachments")]
    public List<AdaptiveCardAttachments> Attachments { get; set; } = [];
}
