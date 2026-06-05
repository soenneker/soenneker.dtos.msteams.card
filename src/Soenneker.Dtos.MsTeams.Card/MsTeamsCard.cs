using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Dtos.AdaptiveCard.Attachments;

namespace Soenneker.Dtos.MsTeams.Card;

/// <summary>
/// A DTO for Microsoft Teams card (de)serialization.
/// </summary>
public class MsTeamsCard
{
    /// <summary>
    /// Gets or sets type.
    /// </summary>
    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    /// <summary>
    /// Gets or sets attachments.
    /// </summary>
    [JsonProperty("attachments")]
    [JsonPropertyName("attachments")]
    public List<AdaptiveCardAttachments> Attachments { get; set; } = null!;
}