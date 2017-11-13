using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class Jackhamshroom : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ChlorophyteJackhammer);
			Main.projFrames[projectile.type] = 4;
		}
      	public override Color? GetAlpha(Color lightColor)
     	{
			return Color.White;
      	}
		private int shootCounter;
 		public override void AI()
	    {
			shootCounter++;
			if (shootCounter >= 24)
            {
				shootCounter = 0;
				Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X/3, projectile.velocity.Y/3, 131, projectile.damage, 0f, projectile.owner, 0f, 0f);
           	}
     		projectile.frameCounter++;
     		if (projectile.frameCounter >= 4.44444444444f)
    		{
			    projectile.frameCounter = 0;
         		projectile.frame = (projectile.frame + 1) % 4;
           	}
     	}
	}
}