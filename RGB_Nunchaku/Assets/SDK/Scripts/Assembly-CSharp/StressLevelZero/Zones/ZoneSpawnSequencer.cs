namespace StressLevelZero.Zones
{
	public class ZoneSpawnSequencer : ZoneItem
	{
		public float frequency;
		public bool randomSequence;
		public float maxConcurrentSpawns;
		public ZoneSpawner[] spawners;
	}
}
