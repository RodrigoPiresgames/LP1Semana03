using System;

namespace PlayerPerks
{
    [Flags]
    enum PPerks
    {
        Nothing = 0,
        Waterbreathing = 1 << 1,
        AutoHeal = 1 << 2,
        Stealth = 1 << 3,
        DoubleJump = 1 << 4
    };

}
