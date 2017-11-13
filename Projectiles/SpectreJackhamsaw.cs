using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class SpectreJackhamsaw : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.SawtoothShark);
			Main.projFrames[projectile.type] = 4;
		}
		public override void AI()
		{
			projectile.frameCounter++;
			if (projectile.frameCounter >= 4f)
			{
				projectile.frameCounter = 0;
				projectile.frame = (projectile.frame + 1) % 4;
			}
		}
	}
}