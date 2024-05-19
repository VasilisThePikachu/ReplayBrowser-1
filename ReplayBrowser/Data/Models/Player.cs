﻿using YamlDotNet.Serialization;

namespace ReplayBrowser.Data.Models;

public class Player
{
    public int Id { get; set; }
    
    [YamlMember(Alias = "antagPrototypes")]
    public List<string> AntagPrototypes { get; set; }
    [YamlMember(Alias = "jobPrototypes")]
    public List<string> JobPrototypes { get; set; }
    [YamlMember(Alias = "playerGuid")]
    public Guid PlayerGuid { get; set; }
    [YamlMember(Alias = "playerICName")]
    public string PlayerIcName { get; set; }
    [YamlMember(Alias = "playerOOCName")]
    public string PlayerOocName { get; set; }
    [YamlMember(Alias = "antag")]
    public bool Antag { get; set; }
    
    // Foreign key
    
    public int? ReplayId { get; set; }
    public Replay? Replay { get; set; }

    public void RedactInformation()
    {
        PlayerGuid = Guid.Empty;
        PlayerIcName = "Redacted";
        PlayerOocName = "Redacted";
    }
}