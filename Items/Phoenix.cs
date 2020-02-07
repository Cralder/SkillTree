﻿using Terraria.ID;
using Terraria.ModLoader;

namespace SkillTree.Items
{
    public class Phoenix : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "Phoenix";
            projectile.width = 64;
            projectile.height = 64;
            projectile.timeLeft = 180;
            projectile.penetrate = 10;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = false;
            projectile.ignoreWater = false;
            projectile.melee = true;
            projectile.aiStyle = 0;
            projectile.damage = 30;
            aiType = ProjectileID.DD2PhoenixBowShot;


        }
        public override void AI()
        {
           projectile.type = 706;

            
        }
    }
}