using System;

[Serializable]
public class HallwayObjGroup
{
	public SerializableVector3[] destObjectPositions;
	public SerializableQuaternion[] destObjectRotations;
	public SerializableVector3[] indestObjectPositions;
	public SerializableQuaternion[] indestObjectRotations;
}
