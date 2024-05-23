namespace RazorNullableIssue;

public partial class Component1 : GenericComponentBase<string?>
{
    public string? Value { get; set; }
}