namespace app07.Model;

public class PermissionRole
{
     public int RoleId { get; set; }
     public int PermissionId { get; set; }

    public Role Role { get; set; }
    public Permission Permission { get; set; }
}