using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class BronzeDrill : ModProjectile
	{
        private static Mod tremor = ModLoader.GetMod("Tremor");
        public override void SetDefaults()
		{
			if(tremor != null)
			{
				projectile.CloneDefaults(ProjectileID.CobaltDrill);
			}
		}
	}
}