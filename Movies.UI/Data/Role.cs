public class Role
{
    public int Id { get; set; }
    public string CharacterName { get; set; }
    public RoleType RoleType { get; set; }

    public override string ToString()
    {
        var str = "Role:{" + "\n";
        str += $"Id: {Id}" + "\n";
        str += $"CharacterName: {CharacterName}" + "\n";
        str += $"RoleType: {RoleType}" + "\n";
        str += "}" + "\n";
        return str;
    }
}