namespace StressLevelZero.Pool
{
	public enum PoolMode
	{
		GROW = 0,
		REUSEOLDEST = 1,
		REUSENEWEST = 2,
		REUSENONE = 3,
		REUSEDEADORGROW = 4,
	}
}
