namespace Core.entities
{
    public class Owner :EntityBase
    {

     public string FullName { get; set; } = string.Empty;
     public string Profil { get; set; } = string.Empty;
     public string Avatar { get; set; } = string.Empty;
     public Adress? Adress { get; set; }


    }

}
