using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class CandyCaneDrill : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldCandyCaneDrillSprite)
            { }
            else
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
            }
        }
	}
}