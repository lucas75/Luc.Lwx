namespace Luc.Lwx.Interface;

[AttributeUsage(AttributeTargets.Method)]
public class LwxAuthPolicyAttribute : Attribute
{
    /// <summary>
    /// This controls the generated method name.
    /// 
    /// By default the mehod name is MapAuthPolicy_CompanyAppModule
    /// 
    /// where CompanyAppModule is the name of the assembly that contains the class with this attribute.
    /// </summary>
    public string? GeneratedMethodName { get; set; } = null;
}
