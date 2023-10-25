namespace _03_WetterApp.Models.Abstraction.Interfaces
{
    interface ILocateable
    {
        string GetLocation(UserIp ipAdress);
    }
}
