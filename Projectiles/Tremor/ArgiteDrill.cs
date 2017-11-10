using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class ArgiteDrill : ModProjectile
	{
		public override void SetDefaults()
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				projectile.CloneDefaults(ProjectileID.ChlorophyteDrill);
			}
		}
		public override void AI()
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 61, projectile.velocity.X * 0.4f, projectile.velocity.Y * 0.4f, 100, default(Color), 1.9f);
				Main.dust[dust].noGravity = true;
			}
		}
	}
}