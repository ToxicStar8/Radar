using System.Numerics;

namespace Radar;

public static class DeepDungeonObjectExtension
{
	public static unsafe bool IsTrap(GameObject* obj)
	{
		if (obj->NpcBase == 6388 && obj->Location != Vector3.Zero)
		{
			return true;
		}
		if ((obj->NpcBase >= 2007182 && obj->NpcBase <= 2007186) || obj->NpcBase == 2009504)
		{
			return true;
		}
		return false;
	}

	public static unsafe bool IsAccursedHoard(GameObject* obj)
	{
		if (obj->NpcBase != 2007542)
		{
			return obj->NpcBase == 2007543;
		}
		return true;
	}

	public static unsafe bool IsSilverCoffer(GameObject* obj)
	{
		return obj->NpcBase == 2007357;
	}
}
