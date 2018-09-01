using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class BoneDrill : ModProjectile
    {
        public override void SetDefaults()
		{
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
        }
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Projectiles/BoneDrill" + Config.OldBoneDrillSprite; }
        }
    }
}