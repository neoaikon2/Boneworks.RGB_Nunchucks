using System;

[Serializable]
public class HallwayData
{
	public bool isNewSaveFile;
	public int currGroup;
	public HallwayObjGroup defaultGroup;
	public HallwayObjGroup[] customGroups;
	public HallwayObjGroup[] definedGroups;
}
