using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class MagmarBreaker : ModProjectile
	{
        private static Mod tremor = ModLoader.GetMod("Tremor");
        public override void SetDefaults()
		{
			if(tremor != null)
			{
				projectile.CloneDefaults(ProjectileID.SawtoothShark);
				Main.projFrames[projectile.type] = 4;
			}
		}
		public override void AI()
		{
			if(tremor != null)
			{
				projectile.frameCounter++;
				if (projectile.frameCounter >= 3f)
				{
					projectile.frameCounter = 0;
					projectile.frame = (projectile.frame + 1) % 4;
				}
			}
		}
	}
}