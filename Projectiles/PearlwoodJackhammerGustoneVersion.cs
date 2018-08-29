using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class PearlwoodJackhammerGustoneVersion : ModProjectile
	{
        public override void SetDefaults()
        {
            if (Config.WoodJackhammersSprite == 2)
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
                Main.projFrames[projectile.type] = 4;
            }
        }
        public override void AI()
        {
            if (Config.WoodJackhammersSprite == 2)
            {
                projectile.frameCounter++;
                if (projectile.frameCounter >= 6.66666666667f)
                {
                    projectile.frameCounter = 0;
                    projectile.frame = (projectile.frame + 1) % 4;
                }
            }
        }
    }
}