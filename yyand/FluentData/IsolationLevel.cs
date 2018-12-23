namespace FluentData
{
	public enum IsolationLevel
	{
		Unspecified = -1,
		Chaos = 0x10,
		ReadUncommitted = 0x100,
		ReadCommitted = 0x1000,
		RepeatableRead = 0x10000,
		Serializable = 0x100000,
		Snapshot = 0x1000000
	}
}
