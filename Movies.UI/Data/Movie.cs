
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<CastMember> CastMembers { get; set; } = new List<CastMember>();

    public override string ToString()
    {
        var str = "Movie:{" + "\n";
        str += $"Id: {Id}" + "\n";
        str += $"Title: {Title}" + "\n";
        if (CastMembers.Count > 0)
        {
            foreach (var member in CastMembers)
            {
                str += member;
            }
            str+="==========================\n";
        }
        str += "}" + "\n";
        return str;
    }
}
