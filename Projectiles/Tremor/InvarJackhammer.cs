using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class InvarJackhammer : ModProjectile
	{
        private static Mod tremor = ModLoader.GetMod("Tremor");
        public override void SetDefaults()
		{
			if(tremor != null)
			{
				projectile.CloneDefaults(ProjectileID.CobaltDrill);
				Main.projFrames[projectile.type] = 4;
			}
		}
		public override void AI()
		{
			if(tremor != null)
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