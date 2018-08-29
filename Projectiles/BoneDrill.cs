using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class BoneDrill : ModProjectile
    {
        public override void SetDefaults()
		{		
            if (Config.OldBoneDrillSprite)
            { }
            else
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
            }
        }
	}
}