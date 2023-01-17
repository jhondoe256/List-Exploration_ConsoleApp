Console.Clear();

var movie = new Movie();

movie.Id = 1;
movie.Title = "Sparticus";

movie.CastMembers.Add(new CastMember()); // this is empty CastMember Data

System.Console.WriteLine(movie);


var movie2 = new Movie    //HARD CODING VALUES
{
    Id = 2,
    Title = "Im Gonna Get You Sucka!",
    CastMembers = new List<CastMember>
    {
        new CastMember
        {
            Id=2,
            Name = "Keenen Ivory Wayans",
            CurrentRole=new Role
            {
                Id=1,
                CharacterName="Jack Spade",
                RoleType= RoleType.PROTAGONIST,
            },
            PreviouseRoles= new List<Role>
            {
                new Role
                {
                    Id=2,
                    CharacterName="Shame",
                    RoleType=RoleType.PROTAGONIST
                },
                new Role
                {
                    Id=3,
                    CharacterName="Det. Jim Campbell",
                    RoleType=RoleType.PROTAGONIST
                }
            }
        },
        new CastMember
        {
            Id=3,
            Name="Damon Wayans",
            CurrentRole= new Role
            {
                Id=4,
                CharacterName="Idiot #1",
                RoleType= RoleType.COMIC_RELIEF
            },
            PreviouseRoles=new List<Role>{
                new Role
                {
                    Id=5,
                    CharacterName = "Michael / Dad",
                    RoleType= RoleType.PROTAGONIST
                }
            }
        }
    }
};




System.Console.WriteLine("====================================================\n\n");

System.Console.WriteLine(movie2);

System.Console.WriteLine("====================================================\n\n");

movie2.CastMembers[0].PreviouseRoles.ForEach(r => System.Console.WriteLine(r));



System.Console.WriteLine("====================================================\n\n");
//Todo: Annoymous Type.....
var movie3 = new
{
    Name = "Terry Brown",
    Title = "Eleven Fifty Instructor"
};

System.Console.WriteLine(movie3);