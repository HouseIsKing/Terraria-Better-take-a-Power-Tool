using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class CandyCaneDrill : ModProjectile
	{
		public override void SetDefaults()
		{
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
        }
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Projectiles/CandyCaneDrill" + Config.OldCandyCaneDrillSprite; }
        }
    }
}