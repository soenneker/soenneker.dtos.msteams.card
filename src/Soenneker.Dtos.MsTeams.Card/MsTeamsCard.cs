using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
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
    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    /// <summary>
    /// Adaptive Card attachments included in the Teams message.
    /// </summary>
    [JsonProperty("attachments")]
    [JsonPropertyName("attachments")]
    public List<AdaptiveCardAttachments> Attachments { get; set; } = null!;
}
