using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
    public class ShroomiteDiggingDrillclaw : ModProjectile
	{
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SawtoothShark);
        }
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Projectiles/ShroomiteDiggingDrillclaw" + Config.OldShroomiteClawedDrillSprite; }
        }
    }
}