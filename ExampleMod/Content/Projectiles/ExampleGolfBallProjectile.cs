﻿using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Content.Projectiles
{
	public class ExampleGolfBallProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			ProjectileID.Sets.IsAGolfBall[Type] = true; // Allows the projectile to be placed on the tee.
			ProjectileID.Sets.TrailingMode[Type] = 0; // Creates a trail behind the golf ball.
			ProjectileID.Sets.TrailCacheLength[Type] = 20; // Sets the length of the trail.
			DisplayName.SetDefault("Example Golf Ball"); // Note that the classname will appear in chat when the golf ball is sunk if you don't set a display name.
		}

		public override void SetDefaults() {
			projectile.netImportant = true; // Indicates that this projectile will be synced to a joining player (by default, any projectiles active before the player joins (besides pets) are not synced over).
			projectile.width = 7; // The width of the projectile's hitbox.
			projectile.height = 7; // The height of the projectile's hitbox.
			projectile.friendly = true; // Setting this to anything other than true causes an index out of bounds error.
			projectile.penetrate = -1; // Number of times the projectile can penetrate enemies. -1 sets it to infinite penetration.
			projectile.aiStyle = 149; // 149 is the golf ball AI.
			projectile.tileCollide = false; // Tile Collision is set to false, as it's handled in the AI.
		}
	}
}