using Microsoft.AspNetCore.Components;

namespace Microsoft.Fast.Components.FluentUI;
public partial class FluentDataGrid<TItem> : FluentComponentBase
{
    // FAST Attributes
    [Parameter]
    public GenerateHeaderOptions? GenerateHeader { get; set; } = GenerateHeaderOptions.Default;
    [Parameter]
    public string? GridTemplateColumns { get; set; } = "";
    //FAST Properties
    [Parameter]
    public List<TItem>? RowsData { get; set; }

    [Parameter]
    public IEnumerable<ColumnDefinition<TItem>>? ColumnDefinitions { get; set; }

    [Parameter]
    public RenderFragment<ColumnDefinition<TItem>>? HeaderCellTemplate { get; set; } = null;
    [Parameter]
    public RenderFragment<TItem>? RowItemTemplate { get; set; } = null;
}