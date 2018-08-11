using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
    public class BrassJackhammer : ModProjectile
    {
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                projectile.CloneDefaults(ProjectileID.ChlorophyteDrill);
                Main.projFrames[projectile.type] = 4;
            }
        }
        public override void AI()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                if (projectile.frameCounter >= 3f)
                {
                    projectile.frameCounter = 0;
                    projectile.frame = (projectile.frame + 1) % 4;
                }
                projectile.frameCounter++;
            }
        }
    }
}
