namespace app07.Model;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<PermissionRole> PermissionRoles { get; set;}
    public ICollection<User> Users { get; set; }
}
