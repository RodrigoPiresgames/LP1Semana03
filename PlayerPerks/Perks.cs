using System;

public class Perks
{
    [Flags]
    enum WoWRoles
    {
        Tank = 1 << 0, // 1
        Healer = 1 << 1, // 2
        Damage = 1 << 2 // 4
    };

}
