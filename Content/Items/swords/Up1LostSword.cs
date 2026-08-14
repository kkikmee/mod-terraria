using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TERMOD.Content.Items.swords;

namespace TERMOD.Content.Items.swords
{
    public class Up1LostSword : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 35;
            Item.DamageType = DamageClass.Melee;
            Item.width = 44;
            Item.height = 44;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 7;
            Item.value = 25000;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<LostSword>(1)
                .AddIngredient(ItemID.IronBar, 5)   // пример доп. материала
                .AddTile(TileID.Anvils)             // станция крафта — наковальня
                .Register();
        }
    }
}