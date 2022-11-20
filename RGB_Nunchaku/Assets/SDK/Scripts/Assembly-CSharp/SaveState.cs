using System;

[Serializable]
public class SaveState
{
	public enum Type
	{
		NONE = 0,
		ITEM = 1,
		AMMO = 2,
		SAVESPOT = 3,
	}

	public enum ItemSource
	{
		NONE = 0,
		SCENE = 1,
		MONOMAT = 2,
		DESTRUCTABLE = 3,
	}

	public enum ItemDestination
	{
		NONE = 0,
		PLATFORM = 1,
		BODYSLOT = 2,
		BATTERYSLOT = 3,
		KEYSLOT = 4,
	}

	public enum BodySlot
	{
		NONE = 0,
		LSHOULDER = 1,
		RSHOULDER = 2,
		LSIDEARM = 3,
		RSIDEARM = 4,
		BACK = 5,
		HEAD = 6,
	}

	public Type type;
	public ItemSource source;
	public ItemDestination destination;
	public BodySlot bodySlot;
	public float savedTarget;
	public float savedValue;
	public int lightCollected;
	public int mediumCollected;
	public int heavyCollected;
	public string socketSaveableItemUUID;
	public string spawnableObjectUUID;
	public bool hasSecondaryOneTime;
	public bool hasPrimaryOneTime;
	public float saveTime;
}
