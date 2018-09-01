using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class SpectreDrill : ModProjectile
	{
		public override void SetDefaults()
		{
                projectile.CloneDefaults(ProjectileID.SawtoothShark);
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Projectiles/SpectreDrill" + Config.OldSpectreDrillSprite; }
        }
    }
}