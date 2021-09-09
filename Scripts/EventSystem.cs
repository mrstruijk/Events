using System;


namespace _mrstruijk.Events
{
	/// <summary>
	/// Maintain a list of Actions here
	/// </summary>
	public class EventSystem : EventsBase
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

		#region Custom Actions
		public static Action OnLoadAction;

		#endregion
	}
}
