using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace SkillTree.Items
{
    [AutoloadEquip(EquipType.Body)]
    public class AssaultCuirass : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Assault Cuirass");
            Tooltip.SetDefault("Grants 25 attack speed and 5 armor to nearby allies, and reduces nearby enemy armor by 5.");
        }

        public override void SetDefaults()
        {
            item.value = Item.buyPrice(5,2,0,0);
            item.rare = 5;

            item.defense = 10;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return false;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 1;
        }

    }
}
