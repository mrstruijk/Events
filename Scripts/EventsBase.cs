using System;


namespace _mrstruijk.Events
{
	public abstract class EventsBase
	{
		public static void Invoke(Action eventToInvoke)
		{
			eventToInvoke?.Invoke();
		}

		public static void Invoke<T>(Action<T> eventToInvoke, T value)
		{
			eventToInvoke?.Invoke(value);
		}
	}
}