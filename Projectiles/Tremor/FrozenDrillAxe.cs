using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class FrozenDrillAxe : ModProjectile
	{
        public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				projectile.CloneDefaults(ProjectileID.Hamdrax);
			}
		}
        public override void AI()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 80, projectile.velocity.X * 0.1f, projectile.velocity.Y * 0.1f, 100, default(Color), 1.25f);
                Main.dust[dust].noGravity = true;
            }
        }
    }
}