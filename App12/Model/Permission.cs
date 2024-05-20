namespace app07.Model;

public class Permission
{
    public int Id { get; set; }
    public string FormName { get; set; }
    public string ButtonName { get; set; }
    public string ButtonTitle { get; set; }

    public ICollection<PermissionRole> PermissionRoles { get; set; }
}
