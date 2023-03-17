using System;

namespace PlayerPerks
{
    [Flags]
    enum PPerks
    {
        waterbreathing = 1 << 0,
        AutoHeal = 1 << 1,
        Stealth = 1 << 2,
        DoubleJump = 1 << 3
    };

}
