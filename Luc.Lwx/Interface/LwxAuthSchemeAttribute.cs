namespace Luc.Lwx.Interface;

/// <summary>
/// This attribute is used to define a class that will be used to configure an authentication scheme.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public class LwxAuthSchemeAttribute : Attribute
{
    /// <summary>
    /// This controls the generated method name. 
    /// </summary>
    public string? GeneratedMethodName { get; set; } = null;
}
