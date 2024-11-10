namespace Backbone.General.CoreApp.Abstractions.Settings;

/// <summary>
/// Represents core domain business settings
/// </summary>
public sealed record AppSettings
{
    /// <summary>
    /// Gets application official name
    /// </summary>
    public string AppName { get; init; } = default!;

    /// <summary>
    /// Gets application domain URL
    /// </summary>
    public string AppUrl { get; init; } = default!;
}