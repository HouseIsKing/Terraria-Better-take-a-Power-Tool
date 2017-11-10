using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class MoltenJackhamsaw : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.SawtoothShark);
			Main.projFrames[projectile.type] = 4;
		}
      		public override Color? GetAlpha(Color lightColor)
     		{
			return Color.White;
      		}
		public override void AI()
		{
			projectile.frameCounter++;
			if (projectile.frameCounter >= 5.13333333333f)
			{
				projectile.frameCounter = 0;
				projectile.frame = (projectile.frame + 1) % 4;
			}
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default(Color), 1.9f);
			Main.dust[dust].noGravity = true;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(5) == 0)
			{
				target.AddBuff(BuffID.OnFire, 180, false);
			}
		}
		public override void OnHitPvp(Player target, int damage, bool crit)
		{
			if (Main.rand.Next(5) == 0)
			{
				target.AddBuff(BuffID.OnFire, 180, false);
			}
		}
	}
}