using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
    public class Doomjackhammer : ModProjectile
    {
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                projectile.CloneDefaults(ProjectileID.SawtoothShark);
                Main.projFrames[projectile.type] = 4;
            }
        }
        public override void AI()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                projectile.frameCounter++;
                if (projectile.frameCounter >= 3f)
                {
                    projectile.frameCounter = 0;
                    projectile.frame = (projectile.frame + 1) % 4;
                }
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 27, projectile.velocity.X * 0.1f, projectile.velocity.Y * 0.1f, 100, default(Color), 1f);
                Main.dust[dust].noGravity = true;
            }
        }
    }
}