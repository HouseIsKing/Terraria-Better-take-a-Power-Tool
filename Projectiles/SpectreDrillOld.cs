using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class SpectreDrillOld : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldSpectreDrillSprite)
            {
                projectile.CloneDefaults(ProjectileID.SawtoothShark);
            }
		}
	}
}