using Microsoft.AspNetCore.Components;

namespace Microsoft.Fast.Components.FluentUI;

public partial class FluentTooltip : FluentComponentBase
{
    [Parameter]
    public string? Anchor { get; set; }

    [Parameter]
    public TooltipPosition? Position { get; set; }

    [Parameter]
    public int? Delay { get; set; } = 300;
    [Parameter]
    public bool? Visible { get; set; } = false;
    [Parameter]
    public bool? HorizontalViewportLock { get; set; } = false;
    [Parameter]
    public bool? VerticalViewportLock { get; set; } = false;
}