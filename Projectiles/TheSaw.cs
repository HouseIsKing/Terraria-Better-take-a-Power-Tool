using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class TheSaw : ModProjectile
	{
		int timer = 0;
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.SawtoothShark);
			Main.projFrames[projectile.type] = 4;
		}
		public override bool PreAI()
		{
			projectile.frameCounter++;
			if (projectile.frameCounter >= 3.8f)
			{
				projectile.frameCounter = 0;
				projectile.frame = (projectile.frame + 1) % 4;
			}
			timer++;
			if(timer == 20)
			{
				timer = 0;
				Main.PlaySound(2, -1, -1, 47);
			}
			return true;
		}
	}
}