using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class BorealWoodJackhammer : ModProjectile
	{
		public override void SetDefaults()
		{
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
                Main.projFrames[projectile.type] = 4;
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Projectiles/BorealWoodJackhammer" + Config.OldWoodJackhammersSprite + Config.GustoneVersionWoodJackhammersSprite; }
        }
        public override void AI()
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