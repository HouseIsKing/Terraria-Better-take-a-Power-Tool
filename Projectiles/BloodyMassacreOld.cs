using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class BloodyMassacreOld : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldBloodyMassacreSprite)
            {
                projectile.CloneDefaults(ProjectileID.ButchersChainsaw);
                projectile.scale = 1f;
            }
        }
		public override void AI()
		{
            if (Config.OldBloodyMassacreSprite)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 5, projectile.velocity.X * 0.1f, projectile.velocity.Y * 0.1f, 100, default(Color), 1.9f);
                Main.dust[dust].noGravity = true;
            }
		}
	}
}