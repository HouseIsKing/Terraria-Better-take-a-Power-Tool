using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class SpectreDrill : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldSpectreDrillSprite)
            { }
            else
            {
                projectile.CloneDefaults(ProjectileID.SawtoothShark);
            }
		}
	}
}