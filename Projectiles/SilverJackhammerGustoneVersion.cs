using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class SilverJackhammerGustoneVersion : ModProjectile
	{
        public override void SetDefaults()
        {
            if (Config.MetalJackhammersSprite == 2)
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
                Main.projFrames[projectile.type] = 4;
            }
        }
        public override void AI()
        {
            if (Config.MetalJackhammersSprite == 2)
            {
                projectile.frameCounter++;
                if (projectile.frameCounter >= 5.33333333333f)
                {
                    projectile.frameCounter = 0;
                    projectile.frame = (projectile.frame + 1) % 4;
                }
            }
        }
    }
}