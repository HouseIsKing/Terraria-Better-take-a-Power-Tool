using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class PalmWoodJackhammer : ModProjectile
	{
        public override void SetDefaults()
        {
            if (Config.WoodJackhammersSprite == 0)
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
                Main.projFrames[projectile.type] = 4;
            }
        }
        public override void AI()
        {
            if (Config.WoodJackhammersSprite == 0)
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