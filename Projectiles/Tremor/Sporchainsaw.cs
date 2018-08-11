using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class Sporchainsaw : ModProjectile
	{
        public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				projectile.CloneDefaults(ProjectileID.CobaltDrill);
			}
		}
		public override void AI()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 61, projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default(Color), 1.9f);
				Main.dust[dust].noGravity = true;
			}
            projectile.frameCounter++;
            if (projectile.frameCounter >= 20f)
            {
                projectile.frameCounter = 0;
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X / 3.5f, projectile.velocity.Y / 3.5f, 569, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X / 3.5f + 1, projectile.velocity.Y / 3.5f + 1, 569, projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X / 3.5f - 1, projectile.velocity.Y / 3.5f - 1, 569, projectile.damage, 0f, projectile.owner, 0f, 0f);
            }
        }
    }
}