using Terraria.ModLoader;
using Terraria.ID;
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

namespace MPA
{
	public class MPA : Mod
	{
		public MPA()
		{

		}
		public override void AddRecipeGroups()
		{
			RecipeGroup evilmat = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Evil Material", new int[]
			{
				ItemID.ShadowScale,
				ItemID.TissueSample
			});
			RecipeGroup.RegisterGroup("EvilMaterial", evilmat);

			RecipeGroup evilbar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Evil Bars", new int[]
			{			
				ItemID.DemoniteBar,
				ItemID.CrimtaneBar
			});
			RecipeGroup.RegisterGroup("EvilBar", evilbar);

			RecipeGroup evilseed = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Evil Seeds", new int[]
			{
				ItemID.CorruptSeeds,
				ItemID.CrimsonSeeds
			});
			RecipeGroup.RegisterGroup("EvilSeed", evilseed);

			RecipeGroup silverbar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Silver Bar", new int[]
			{
				ItemID.SilverBar,
				ItemID.TungstenBar
			});
			RecipeGroup.RegisterGroup("SilverBar", silverbar);

			RecipeGroup copperbar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Copper Bar", new int[]
			{
				ItemID.CopperBar,
				ItemID.TinBar
			});
			RecipeGroup.RegisterGroup("CopperBar", copperbar);

			RecipeGroup cobaltbar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Cobalt Bar", new int[]
			{
				ItemID.CobaltBar,
				ItemID.PalladiumBar
			});
			RecipeGroup.RegisterGroup("CobaltBar", cobaltbar);

			RecipeGroup goldbar = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Gold Bar", new int[]
			{
				ItemID.GoldBar,
				ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("GoldBar", goldbar);
		}

		public override void AddRecipes()
		{
			//Sky Mill
			ModRecipe Skymill = new ModRecipe(this);
			Skymill.AddIngredient(ItemID.SunplateBlock, 10);
			Skymill.AddRecipeGroup("IronBar", 2);
			Skymill.AddIngredient(ItemID.Chain, 1);
			Skymill.AddTile(TileID.WorkBenches);
			Skymill.SetResult(ItemID.SkyMill);
			Skymill.AddRecipe();

			//Leather
			ModRecipe Leather = new ModRecipe(this);
			Leather.AddIngredient(ItemID.Vertebrae, 5);
			Leather.AddTile(TileID.WorkBenches);
			Leather.SetResult(ItemID.Leather);
			Leather.AddRecipe();

			//Hermes Boots
			ModRecipe HermesBoots = new ModRecipe(this);
			HermesBoots.AddIngredient(ItemID.Leather);
			HermesBoots.AddIngredient(ItemID.FallenStar);
			HermesBoots.AddIngredient(ItemID.Silk, 5);
			HermesBoots.AddRecipeGroup("SilverBar", 5);
			HermesBoots.AddTile(TileID.Anvils);
			HermesBoots.SetResult(ItemID.HermesBoots);
			HermesBoots.AddRecipe();

			//Cloud in a Bottle
			ModRecipe CloudinaBottle = new ModRecipe(this);
			CloudinaBottle.AddIngredient(ItemID.Cloud, 10);
			CloudinaBottle.AddIngredient(ItemID.Bottle);
			CloudinaBottle.AddIngredient(ItemID.FallenStar);
			CloudinaBottle.AddTile(TileID.Anvils);
			CloudinaBottle.SetResult(ItemID.CloudinaBottle);
			CloudinaBottle.AddRecipe();

			//Sandstorm in a Bottle
			ModRecipe SandstorminaBottle = new ModRecipe(this);
			SandstorminaBottle.AddIngredient(ItemID.CloudinaBottle);
			SandstorminaBottle.AddIngredient(ItemID.FossilOre, 5);
			SandstorminaBottle.AddIngredient(ItemID.SandBlock, 10);
			SandstorminaBottle.AddTile(TileID.Anvils);
			SandstorminaBottle.SetResult(ItemID.SandstorminaBottle);
			SandstorminaBottle.AddRecipe();

			//Blizzard in a Bottle
			ModRecipe BlizzardinaBottle = new ModRecipe(this);
			BlizzardinaBottle.AddIngredient(ItemID.CloudinaBottle);
			BlizzardinaBottle.AddIngredient(ItemID.IceBlock, 5);
			BlizzardinaBottle.AddIngredient(ItemID.SnowBlock, 10);
			BlizzardinaBottle.AddTile(TileID.Anvils);
			BlizzardinaBottle.SetResult(ItemID.BlizzardinaBottle);
			BlizzardinaBottle.AddRecipe();

			//AnkletoftheWind
			ModRecipe AnkletoftheWind = new ModRecipe(this);
			AnkletoftheWind.AddIngredient(ItemID.JungleSpores, 10);
			AnkletoftheWind.AddRecipeGroup("EvilMaterial", 1);
			AnkletoftheWind.AddTile(TileID.Anvils);
			AnkletoftheWind.SetResult(ItemID.AnkletoftheWind);
			AnkletoftheWind.AddRecipe();

			//Aglet
			ModRecipe Aglet = new ModRecipe(this);
			Aglet.AddRecipeGroup("CopperBar", 5);
			Aglet.AddTile(TileID.Anvils);
			Aglet.SetResult(ItemID.Aglet);
			Aglet.AddRecipe();

			//IceSkates
			ModRecipe IceSkates = new ModRecipe(this);
			IceSkates.AddIngredient(ItemID.Silk, 5);
			IceSkates.AddIngredient(ItemID.Leather, 2);
			IceSkates.AddRecipeGroup("IronBar", 2);
			IceSkates.AddTile(TileID.Anvils);
			IceSkates.SetResult(ItemID.IceSkates);
			IceSkates.AddRecipe();

			//WaterWalkingBoots
			ModRecipe WaterWalkingBoots = new ModRecipe(this);
			WaterWalkingBoots.AddIngredient(ItemID.Silk, 5);
			WaterWalkingBoots.AddIngredient(ItemID.Leather);
			WaterWalkingBoots.AddIngredient(ItemID.WaterWalkingPotion);
			WaterWalkingBoots.AddTile(TileID.Anvils);
			WaterWalkingBoots.SetResult(ItemID.WaterWalkingBoots);
			WaterWalkingBoots.AddRecipe();

			//LavaCharm
			ModRecipe LavaCharm = new ModRecipe(this);
			LavaCharm.AddIngredient(ItemID.Silk, 5);
			LavaCharm.AddIngredient(ItemID.HellstoneBar, 5);
			LavaCharm.AddRecipeGroup("EvilMaterial", 5);
			LavaCharm.AddIngredient(ItemID.ObsidianSkinPotion);
			LavaCharm.AddTile(TileID.Anvils);
			LavaCharm.SetResult(ItemID.LavaCharm);
			LavaCharm.AddRecipe();

			//Flipper
			ModRecipe Flipper = new ModRecipe(this);
			Flipper.AddIngredient(ItemID.Silk, 3);
			Flipper.AddIngredient(ItemID.Leather, 1);
			Flipper.AddIngredient(ItemID.SharkFin, 2);
			Flipper.AddTile(TileID.Anvils);
			Flipper.SetResult(ItemID.Flipper);
			Flipper.AddRecipe();

			//DivingHelmet
			ModRecipe DivingHelmet = new ModRecipe(this);
			DivingHelmet.AddRecipeGroup("CopperBar", 5);
			DivingHelmet.AddIngredient(ItemID.SharkFin, 5);
			DivingHelmet.AddTile(TileID.Anvils);
			DivingHelmet.SetResult(ItemID.DivingHelmet);
			DivingHelmet.AddRecipe();

			//CobaltShield
			ModRecipe CobaltShield = new ModRecipe(this);
			CobaltShield.AddRecipeGroup("CobaltBar", 10);
			CobaltShield.AddTile(TileID.Anvils);
			CobaltShield.SetResult(ItemID.CobaltShield);
			CobaltShield.AddRecipe();

			//DivingHelmet
			ModRecipe MagicMirror = new ModRecipe(this);
			MagicMirror.AddRecipeGroup("SilverBar", 5);
			MagicMirror.AddIngredient(ItemID.Glass, 10);
			MagicMirror.AddIngredient(ItemID.RecallPotion);
			MagicMirror.AddTile(TileID.Anvils);
			MagicMirror.SetResult(ItemID.MagicMirror);
			MagicMirror.AddRecipe();

			//Dart Trap
			ModRecipe DartTrap = new ModRecipe(this);
			DartTrap.AddIngredient(ItemID.Wire, 5);
			DartTrap.AddIngredient(ItemID.WoodenArrow, 5);
			DartTrap.AddIngredient(ItemID.StoneBlock, 10);
			DartTrap.AddTile(TileID.TinkerersWorkbench);
			DartTrap.SetResult(ItemID.DartTrap);
			DartTrap.AddRecipe();

			//ShinyRedBalloon
			ModRecipe ShinyRedBalloon = new ModRecipe(this);
			ShinyRedBalloon.AddIngredient(ItemID.WhiteString);
			ShinyRedBalloon.AddIngredient(ItemID.Gel, 20);
			ShinyRedBalloon.AddIngredient(ItemID.FallenStar);
			ShinyRedBalloon.AddTile(TileID.SkyMill);
			ShinyRedBalloon.SetResult(ItemID.ShinyRedBalloon);
			ShinyRedBalloon.AddRecipe();

			//ShinyRedBalloon
			ModRecipe LuckyHorseshoe = new ModRecipe(this);
			LuckyHorseshoe.AddIngredient(ItemID.SunplateBlock, 10);
			LuckyHorseshoe.AddRecipeGroup("GoldBar", 5);
			LuckyHorseshoe.AddIngredient(ItemID.FallenStar);
			LuckyHorseshoe.AddTile(TileID.SkyMill);
			LuckyHorseshoe.SetResult(ItemID.LuckyHorseshoe);
			LuckyHorseshoe.AddRecipe();
		}

	}
}