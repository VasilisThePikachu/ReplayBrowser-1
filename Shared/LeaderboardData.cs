﻿namespace Shared;

public class LeaderboardData
{
    public bool IsCache { get; set; } = false;
    
    public List<Leaderboard> Leaderboards { get; set; }
}

public class PlayerCount
{
    public PlayerData Player { get; set; }
    public int Count { get; set; }
    public int Position { get; set; }
}

public class Leaderboard
{
    public string Name { get; set; }
    
    /// <summary>
    /// The text that will appear for the "Count" column.
    /// </summary>
    public string TrackedData { get; set; }
    
    /// <summary>
    /// Will be displayed in a small font below the name.
    /// </summary>
    public string? ExtraInfo { get; set; }
    public Dictionary<string, PlayerCount> Data { get; set; }
}