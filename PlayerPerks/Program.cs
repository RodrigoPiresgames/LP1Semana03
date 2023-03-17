using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            PPerks player = PPerks.Nothing;

            string str = args[0];

            foreach (char command in str)
            {
                if (command != 'w' && command != 'a' && command != 's' && command != 'd')
                {
                    Console.WriteLine("Unknown perk!");
                    break;
                }

                else
                {
                    switch (command)
                    {
                        case 'w':
                            if ((player & PPerks.Waterbreathing) == PPerks.Waterbreathing)
                            {
                                player &= ~PPerks.Waterbreathing;
                                break;
                            }
                            player |= PPerks.Waterbreathing;
                            break;

                        case 'a':
                            if ((player & PPerks.AutoHeal) == PPerks.AutoHeal)
                            {
                                player &= ~PPerks.AutoHeal;
                                break;
                            }
                            player |= PPerks.AutoHeal;
                            break;

                        case 's':
                            if ((player & PPerks.Stealth) == PPerks.Stealth)
                            {
                                player &= ~PPerks.Stealth;
                                break;
                            }
                            player |= PPerks.Stealth;
                            break;

                        case 'd':
                            if ((player & PPerks.DoubleJump) == PPerks.DoubleJump)
                            {
                                player &= ~PPerks.DoubleJump;
                                break;
                            }
                            player |= PPerks.DoubleJump;
                            break;

                    }
                }
            }

            Console.WriteLine($"{player}");

            if (((player & PPerks.DoubleJump) == PPerks.DoubleJump) & ((player & PPerks.Stealth) == PPerks.Stealth))
            {
                Console.WriteLine("Silent jumper!");
            }
                
            if ((player & PPerks.AutoHeal) != PPerks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it");
            }

            if (player == PPerks.Nothing)
            {
                Console.WriteLine("No perks at all!");
            }
        }
    }
}
