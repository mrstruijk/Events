using System;


namespace _mrstruijk.Events
{
	public static class EventSystem
	{
		#region MonoBehaviour Cycle
		public static Action OnAwakeAction;
		public static Action OnEnableAction;
		public static Action OnStartAction;
		public static Action OnFixedUpdateAction;
		public static Action OnUpdateAction;
		public static Action OnLateUpdateAction;
		public static Action OnApplicationPauseAction;
		public static Action OnApplicationQuitAction;
		public static Action OnDisableAction;
		public static Action OnDestroyAction;
		#endregion

		#region Define Custom Actions here
		public static Action OnLoadAction;

		#endregion

		#region Methods
		public static void Invoke(Action eventToInvoke)
		{
			eventToInvoke?.Invoke();
		}

		public static void Invoke<T>(Action<T> eventToInvoke, T value)
		{
			eventToInvoke?.Invoke(value);
		}
		#endregion
	}
}
