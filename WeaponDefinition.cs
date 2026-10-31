namespace DooDesch.Weapons
{
    internal static class WeaponDefinition
    {
        internal const string Name = "ShotgunPlus";
        internal static readonly int ItemId = 1000;
        internal static bool IsGun => true;
        internal static bool IsBat => false;
        internal static bool IsReload(int skill) => skill == 10901;
        internal static bool HasSkill(int skill) => skill == 10900 || skill == 10901;
    }
}
