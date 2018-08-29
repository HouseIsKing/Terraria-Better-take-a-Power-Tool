using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class ShroomiteDiggingDrillclaw : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldShroomiteClawedDrillSprite)
            { }
            else
            {
                projectile.CloneDefaults(ProjectileID.SawtoothShark);
            }
		}
	}
}