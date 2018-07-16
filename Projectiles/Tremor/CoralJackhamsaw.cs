using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class CoralJackhamsaw : ModProjectile
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
				if (projectile.frameCounter >= 5.4f)
				{
					projectile.frameCounter = 0;
					projectile.frame = (projectile.frame + 1) % 4;
				}
			}
		}
	}
}