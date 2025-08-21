﻿using System.Text;

namespace MareSynchronosShared.Utils.Configuration;

public class ServicesConfiguration : MareConfigurationBase
{
    public string DiscordBotToken { get; set; } = string.Empty;
    public ulong? DiscordChannelForMessages { get; set; } = null;
    public ulong? DiscordChannelForReports { get; set; } = null;

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"{nameof(DiscordBotToken)} => {DiscordBotToken}");
        sb.AppendLine($"{nameof(MainServerAddress)} => {MainServerAddress}");
        sb.AppendLine($"{nameof(DiscordChannelForMessages)} => {DiscordChannelForMessages}");
        sb.AppendLine($"{nameof(DiscordChannelForReports)} => {DiscordChannelForReports}");
        return sb.ToString();
    }
}