namespace DesignPattern.Bridge
{
	public abstract class DisplayImpl	// internal はアセンブリスコープ。
	{
		public abstract void RawOpen();
		public abstract void RawPrint();
		public abstract void RawClose();
	}
}