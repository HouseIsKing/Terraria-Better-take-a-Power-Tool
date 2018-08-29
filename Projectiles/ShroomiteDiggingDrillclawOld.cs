using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class ShroomiteDiggingDrillclawOld : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldShroomiteClawedDrillSprite)
            {
                projectile.CloneDefaults(ProjectileID.SawtoothShark);
            }
        }
	}
}