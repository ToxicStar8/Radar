namespace Radar;

public static class RadarEnum
{
    public enum MyObjectKind
    {
        None,
        Pet,
        Chocobo,
        Player,
        BattleNpc,
        EventNpc,
        Treasure,
        Aetheryte,
        GatheringPoint,
        EventObj,
        MountType,
        Companion,
        Retainer,
        Area,
        Housing,
        Cutscene,
        CardStand,
        Unknown
    }

    public enum MapMode
    {
        Free,
        Snap,
        SnapRotate
    }

    public enum DetailLevel
    {
        仅图标,
        仅物体名,
        物体名距离,
        详细信息
    }

    public enum RingSegmentsType
    {
        Quad = 4,
        Hexagon = 6,
        Circle = 0
    }

    public enum DeepDungeonType
    {
        Trap,
        AccursedHoard,
        Wall,
        Room,
        Mob,
        CairnOfReturn,
        CairnOfPassage
    }

    public enum SubKind : byte
    {
        Pet = 2,
        Chocobo,
    }

    public enum DeepDungeonBg
    {
        notInDeepDungeon,
        f1c1,
        f1c2,
        f1c3,
        f1c4,
        f1c5,
        f1c6,
        f1c8,
        f1c9,
        f1c7,
        e3c1,
        e3c2,
        e3c3,
        e3c4,
        e3c5,
        e3c6
    }
}

