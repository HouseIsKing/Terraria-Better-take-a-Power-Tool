using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class WarChainsawoftheNightOld : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldWarChainsawoftheNightSprite)
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
            }
		}

		public override void AI()
		{
            if (Config.OldWarChainsawoftheNightSprite)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 14, projectile.velocity.X * 0.1f, projectile.velocity.Y * 0.1f, 100, default(Color), 1.5f);
                Main.dust[dust].noGravity = true;
            }
		}
	}
}