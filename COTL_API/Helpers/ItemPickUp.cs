using UnityEngine;

namespace COTL_API.Helpers;

/// <summary>
///     List of defined items from the game. Used to retrieve the game objects prefab object.
/// </summary>
public static class ItemPickUp
{
    public static string GetItemPickUpPath(InventoryItem.ITEM_TYPE type)
    {
        return type switch
        {
            InventoryItem.ITEM_TYPE.LOG => "Log",
            InventoryItem.ITEM_TYPE.STONE => "Rock1",
            InventoryItem.ITEM_TYPE.ROCK2 => "Rock2",
            InventoryItem.ITEM_TYPE.ROCK3 => "Rock3",
            InventoryItem.ITEM_TYPE.SEED_SWORD => "Seed - Sword",
            InventoryItem.ITEM_TYPE.MEAT => "Meat",
            InventoryItem.ITEM_TYPE.WHEAT => "Wheat",
            InventoryItem.ITEM_TYPE.SEED => "Seed",
            InventoryItem.ITEM_TYPE.BONE => "VileBones",
            InventoryItem.ITEM_TYPE.SOUL => "Soul",
            InventoryItem.ITEM_TYPE.VINES => "GildedVine",
            InventoryItem.ITEM_TYPE.RED_HEART => "Red Heart",
            InventoryItem.ITEM_TYPE.HALF_HEART => "Half Heart",
            InventoryItem.ITEM_TYPE.BLUE_HEART => "Blue Heart",
            InventoryItem.ITEM_TYPE.HALF_BLUE_HEART => "Half Blue Heart",
            InventoryItem.ITEM_TYPE.TIME_TOKEN => "Time Token",
            InventoryItem.ITEM_TYPE.GENERIC => "Generic Pick Up",
            InventoryItem.ITEM_TYPE.STAINED_GLASS => "StainedGlass",
            InventoryItem.ITEM_TYPE.FLOWERS => "SacredFlower",
            InventoryItem.ITEM_TYPE.BLACK_GOLD => !DungeonSandboxManager.Active ? "BlackGold" : "ChallengeGold",
            InventoryItem.ITEM_TYPE.BERRY => "Berries",
            InventoryItem.ITEM_TYPE.MONSTER_HEART => "Monster Heart",
            InventoryItem.ITEM_TYPE.TRINKET_CARD => "TarotCard",
            InventoryItem.ITEM_TYPE.SOUL_FRAGMENT => "SoulFragment",
            InventoryItem.ITEM_TYPE.FISH => "Fish",
            InventoryItem.ITEM_TYPE.MUSHROOM_SMALL => "Mushroom Small",
            InventoryItem.ITEM_TYPE.BLACK_SOUL => "Black Soul",
            InventoryItem.ITEM_TYPE.MUSHROOM_BIG => "Mushroom Big",
            InventoryItem.ITEM_TYPE.MEAL => "Assets/Prefabs/Structures/Other/Meal.prefab",
            InventoryItem.ITEM_TYPE.FISH_SMALL => "Fish Small",
            InventoryItem.ITEM_TYPE.FISH_BIG => "Fish Big",
            InventoryItem.ITEM_TYPE.GRASS => "Grass",
            InventoryItem.ITEM_TYPE.THORNS => "Thorns",
            InventoryItem.ITEM_TYPE.KEY_PIECE => "Key Piece",
            InventoryItem.ITEM_TYPE.POOP => "Poop",
            InventoryItem.ITEM_TYPE.FOUND_ITEM_DECORATION => "FoundItem",
            InventoryItem.ITEM_TYPE.FOUND_ITEM_WEAPON => "FoundItemWeapon",
            InventoryItem.ITEM_TYPE.FOUND_ITEM_CURSE => "FoundItemCurse",
            InventoryItem.ITEM_TYPE.GIFT_SMALL => "Gift Small",
            InventoryItem.ITEM_TYPE.GIFT_MEDIUM => "Gift Medium",
            InventoryItem.ITEM_TYPE.Necklace_1 => "Necklace 1",
            InventoryItem.ITEM_TYPE.Necklace_2 => "Necklace 2",
            InventoryItem.ITEM_TYPE.Necklace_3 => "Necklace 3",
            InventoryItem.ITEM_TYPE.Necklace_4 => "Necklace 4",
            InventoryItem.ITEM_TYPE.Necklace_5 => "Necklace 5",
            InventoryItem.ITEM_TYPE.PUMPKIN => "Pumpkin",
            InventoryItem.ITEM_TYPE.SEED_PUMPKIN => "Seed Pumpkin",
            InventoryItem.ITEM_TYPE.FOUND_ITEM_FOLLOWERSKIN => "FoundItemSkin",
            InventoryItem.ITEM_TYPE.BLACK_HEART => "Black Heart",
            InventoryItem.ITEM_TYPE.PERMANENT_HALF_HEART => "Permanent Half Heart",
            InventoryItem.ITEM_TYPE.FLOWER_RED => "Flower_red",
            InventoryItem.ITEM_TYPE.FLOWER_WHITE => "Flower_White",
            InventoryItem.ITEM_TYPE.MEAL_GRASS => "Assets/Prefabs/Structures/Other/Meal Grass.prefab",
            InventoryItem.ITEM_TYPE.MEAL_MEAT => "Assets/Prefabs/Structures/Other/Meal Good.prefab",
            InventoryItem.ITEM_TYPE.MEAL_GREAT => "Assets/Prefabs/Structures/Other/Meal Great.prefab",
            InventoryItem.ITEM_TYPE.MEAL_GOOD_FISH => "Assets/Prefabs/Structures/Other/Meal Good Fish.prefab",
            InventoryItem.ITEM_TYPE.MEAT_ROTTEN => "Meat Rotten",
            InventoryItem.ITEM_TYPE.FOLLOWER_MEAT => "Follower Meat",
            InventoryItem.ITEM_TYPE.FOLLOWER_MEAT_ROTTEN => "Follower Meat",
            InventoryItem.ITEM_TYPE.MEAL_FOLLOWER_MEAT => "Assets/Prefabs/Structures/Other/Meal Follower Meat.prefab",
            InventoryItem.ITEM_TYPE.MEAL_POOP => "Assets/Prefabs/Structures/Other/Meal Poop.prefab",
            InventoryItem.ITEM_TYPE.SEED_MUSHROOM => "Seed Mushroom",
            InventoryItem.ITEM_TYPE.SEED_FLOWER_WHITE => "Seed White Flower",
            InventoryItem.ITEM_TYPE.SEED_FLOWER_RED => "Seed Red Flower",
            InventoryItem.ITEM_TYPE.GRASS2 => "Grass 2",
            InventoryItem.ITEM_TYPE.GRASS3 => "Grass 3",
            InventoryItem.ITEM_TYPE.GRASS4 => "Grass 4",
            InventoryItem.ITEM_TYPE.GRASS5 => "Grass 5",
            InventoryItem.ITEM_TYPE.FLOWER_PURPLE => "Flower_Purple",
            InventoryItem.ITEM_TYPE.SEED_TREE => "Seed_tree",
            InventoryItem.ITEM_TYPE.MAP => "FoundItemMap",
            InventoryItem.ITEM_TYPE.MEAL_MUSHROOMS => "Assets/Prefabs/Structures/Other/Meal Mushrooms.prefab",
            InventoryItem.ITEM_TYPE.LOG_REFINED => "Log Refined",
            InventoryItem.ITEM_TYPE.STONE_REFINED => "Stone Refined",
            InventoryItem.ITEM_TYPE.GOLD_NUGGET => "Gold Nugget",
            InventoryItem.ITEM_TYPE.ROPE => "Rope",
            InventoryItem.ITEM_TYPE.GOLD_REFINED => "Gold Refined",
            InventoryItem.ITEM_TYPE.BLOOD_STONE => "Bloodstone",
            InventoryItem.ITEM_TYPE.TRINKET_CARD_UNLOCKED => "TarotCardUnlocked",
            InventoryItem.ITEM_TYPE.CRYSTAL => "Crystal",
            InventoryItem.ITEM_TYPE.SPIDER_WEB => "Spider Web",
            InventoryItem.ITEM_TYPE.FISH_CRAB => "Fish Crab",
            InventoryItem.ITEM_TYPE.FISH_LOBSTER => "Fish Lobster",
            InventoryItem.ITEM_TYPE.FISH_OCTOPUS => "Fish Octopus",
            InventoryItem.ITEM_TYPE.FISH_SQUID => "Fish Squid",
            InventoryItem.ITEM_TYPE.FISH_SWORDFISH => "Fish Swordfish",
            InventoryItem.ITEM_TYPE.FISH_BLOWFISH => "Fish Blowfish",
            InventoryItem.ITEM_TYPE.BEETROOT => "Beetroot",
            InventoryItem.ITEM_TYPE.SEED_BEETROOT => "Seed Beetroot",
            InventoryItem.ITEM_TYPE.MEAL_GREAT_FISH => "Assets/Prefabs/Structures/Other/Meal Great Fish.prefab",
            InventoryItem.ITEM_TYPE.MEAL_BAD_FISH => "Assets/Prefabs/Structures/Other/Meal Bad Fish.prefab",
            InventoryItem.ITEM_TYPE.BEHOLDER_EYE => "Beholder Eye",
            InventoryItem.ITEM_TYPE.CAULIFLOWER => "Cauliflower",
            InventoryItem.ITEM_TYPE.SEED_CAULIFLOWER => "Seed Cauliflower",
            InventoryItem.ITEM_TYPE.MEAT_MORSEL => "Meat Morsel",
            InventoryItem.ITEM_TYPE.MEAL_BERRIES => "Assets/Prefabs/Structures/Other/Meal Berries.prefab",
            InventoryItem.ITEM_TYPE.MEAL_MEDIUM_VEG => "Assets/Prefabs/Structures/Other/Meal Medium Veg.prefab",
            InventoryItem.ITEM_TYPE.MEAL_BAD_MIXED => "Assets/Prefabs/Structures/Other/Meal Bad Mixed.prefab",
            InventoryItem.ITEM_TYPE.MEAL_MEDIUM_MIXED => "Assets/Prefabs/Structures/Other/Meal Medium Mixed.prefab",
            InventoryItem.ITEM_TYPE.MEAL_GREAT_MIXED => "Assets/Prefabs/Structures/Other/Meal Great Mixed.prefab",
            InventoryItem.ITEM_TYPE.MEAL_DEADLY => "Assets/Prefabs/Structures/Other/Meal Deadly.prefab",
            InventoryItem.ITEM_TYPE.MEAL_BAD_MEAT => "Assets/Prefabs/Structures/Other/Meal Bad Meat.prefab",
            InventoryItem.ITEM_TYPE.MEAL_GREAT_MEAT => "Assets/Prefabs/Structures/Other/Meal Great Meat.prefab",
            InventoryItem.ITEM_TYPE.MEAL_BURNED => "Assets/Prefabs/Structures/Other/Meal Burned.prefab",
            InventoryItem.ITEM_TYPE.DOCTRINE_STONE => "Doctrine Stone Piece",
            InventoryItem.ITEM_TYPE.SHELL => "Shell",
            InventoryItem.ITEM_TYPE.RELIC => "Relic",
            InventoryItem.ITEM_TYPE.GOD_TEAR => "God Tear",
            InventoryItem.ITEM_TYPE.Necklace_Loyalty => "Necklace Loyalty",
            InventoryItem.ITEM_TYPE.Necklace_Demonic => "Necklace Demonic",
            InventoryItem.ITEM_TYPE.Necklace_Dark => "Necklace Dark",
            InventoryItem.ITEM_TYPE.Necklace_Light => "Necklace Light",
            InventoryItem.ITEM_TYPE.Necklace_Missionary => "Necklace Missionary",
            InventoryItem.ITEM_TYPE.Necklace_Gold_Skull => "Necklace Gold Skull",
            InventoryItem.ITEM_TYPE.WEBBER_SKULL => "Assets/Prefabs/Structures/Buildings/Webber Skull.prefab",
            InventoryItem.ITEM_TYPE.SNOW_CHUNK => "Snow Chunk",
            InventoryItem.ITEM_TYPE.CHARCOAL => "Charcoal",
            InventoryItem.ITEM_TYPE.SILK_THREAD => "Silk Thread",
            InventoryItem.ITEM_TYPE.COTTON => "Cotton",
            InventoryItem.ITEM_TYPE.FISH_COD => "Fish Cod",
            InventoryItem.ITEM_TYPE.FISH_PIKE => "Fish Pike",
            InventoryItem.ITEM_TYPE.FISH_CATFISH => "Fish Catfish",
            InventoryItem.ITEM_TYPE.FOUND_ITEM_OUTFIT => "FoundItem_Outfit",
            InventoryItem.ITEM_TYPE.LIGHTNING_SHARD => "Lightning Shard",
            InventoryItem.ITEM_TYPE.SEED_COTTON => "Seed Cotton",
            InventoryItem.ITEM_TYPE.LORE_STONE => "LoreStone",
            InventoryItem.ITEM_TYPE.POOP_GOLD => "Poop Gold",
            InventoryItem.ITEM_TYPE.POOP_RAINBOW => "Poop Rainbow",
            InventoryItem.ITEM_TYPE.POOP_GLOW => "Poop Glow",
            InventoryItem.ITEM_TYPE.HOPS => "Hops",
            InventoryItem.ITEM_TYPE.GRAPES => "Grapes",
            InventoryItem.ITEM_TYPE.SEED_HOPS => "Seed Hops",
            InventoryItem.ITEM_TYPE.SEED_GRAPES => "Seed Grapes",
            InventoryItem.ITEM_TYPE.EGG_FOLLOWER => "Assets/Prefabs/Structures/Buildings/Egg Follower.prefab",
            InventoryItem.ITEM_TYPE.YOLK => "Yolk",
            InventoryItem.ITEM_TYPE.MEAL_EGG => "Assets/Prefabs/Structures/Other/Meal Egg.prefab",
            InventoryItem.ITEM_TYPE.POOP_DEVOTION => "Poop Devotion",
            InventoryItem.ITEM_TYPE.Necklace_Bell => "Necklace Bell",
            _ => "Poop"
        };
    }

    /// <summary>
    ///     Returns a GameObject of the specified item type (if it exists). Will return poop if the item type is not
    ///     found.
    /// </summary>
    /// <param name="type">The type of item to return.</param>
    /// <returns>The specified item as a game object.</returns>
    public static GameObject? GetItemPickUpObject(InventoryItem.ITEM_TYPE type)
    {
        LogWarning($"ImitatePickUpObject: {type}");

        var itemText = GetItemPickUpPath(type);

        LogWarning($"ImitateItemPickUpText: {itemText}");

        if (!itemText.EndsWith(".prefab", StringComparison.InvariantCultureIgnoreCase))
            return Resources.Load("Prefabs/Resources/" + itemText) as GameObject;

        return Resources.Load(itemText) as GameObject;
    }

    public static bool ShouldUseObjectPool(InventoryItem.ITEM_TYPE type)
    {
        return type switch
        {
            InventoryItem.ITEM_TYPE.MEAL => true,
            InventoryItem.ITEM_TYPE.MEAL_GRASS => true,
            InventoryItem.ITEM_TYPE.MEAL_MEAT => true,
            InventoryItem.ITEM_TYPE.MEAL_GREAT => true,
            InventoryItem.ITEM_TYPE.MEAL_GOOD_FISH => true,
            InventoryItem.ITEM_TYPE.MEAL_FOLLOWER_MEAT => true,
            InventoryItem.ITEM_TYPE.MEAL_POOP => true,
            InventoryItem.ITEM_TYPE.MEAL_MUSHROOMS => true,
            InventoryItem.ITEM_TYPE.MEAL_GREAT_FISH => true,
            InventoryItem.ITEM_TYPE.MEAL_BAD_FISH => true,
            InventoryItem.ITEM_TYPE.MEAL_BERRIES => true,
            InventoryItem.ITEM_TYPE.MEAL_MEDIUM_VEG => true,
            InventoryItem.ITEM_TYPE.MEAL_BAD_MIXED => true,
            InventoryItem.ITEM_TYPE.MEAL_MEDIUM_MIXED => true,
            InventoryItem.ITEM_TYPE.MEAL_GREAT_MIXED => true,
            InventoryItem.ITEM_TYPE.MEAL_DEADLY => true,
            InventoryItem.ITEM_TYPE.MEAL_BAD_MEAT => true,
            InventoryItem.ITEM_TYPE.MEAL_GREAT_MEAT => true,
            InventoryItem.ITEM_TYPE.MEAL_BURNED => true,
            InventoryItem.ITEM_TYPE.WEBBER_SKULL => true,
            InventoryItem.ITEM_TYPE.EGG_FOLLOWER => true,
            InventoryItem.ITEM_TYPE.MEAL_EGG => true,
            _ => false
        };
    }
}