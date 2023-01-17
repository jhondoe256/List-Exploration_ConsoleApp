public class CastMember
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Role CurrentRole { get; set; }
    public List<Role> PreviouseRoles { get; set; } = new List<Role>();

    public override string ToString()
    {
        var str = "CastMember:{" + "\n";
        str += $"\tId: {Id}" + "\n";
        str += $"\tName: {Name}" + "\n";
        str += $"\tRole: {CurrentRole}" + "\n";

        if (PreviouseRoles.Count > 0)
        {
            foreach (var role in PreviouseRoles)
            {
                str += role.ToString();
            }
        }
        else
        {
            str += "\tThere are no current Roles For this Actor.\n";
        }

        str += "\t}" + "\n";
        return str;
    }
}