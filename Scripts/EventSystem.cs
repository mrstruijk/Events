using System;


namespace _mrstruijk.Events
{
	public class EventSystem
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
		public static Action<string> OnSaveUIAction;
		public static Action OnSaveAction;
		public static Action OnLoadAction;
		public static Action OnOverseerButtonClicked;
		public static Action OnOverseerTabClicked;
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
