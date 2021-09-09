using UnityEngine;


namespace _mrstruijk.Events
{
	public class MonoBehaviourEvents : MonoBehaviour
	{
		private void Awake()
		{
			EventsBase.Invoke(EventSystem.OnAwakeAction);
		}


		private void OnEnable()
		{
			EventsBase.Invoke(EventSystem.OnEnableAction);
		}


		private void Start()
		{
			EventsBase.Invoke(EventSystem.OnStartAction);
		}


		private void FixedUpdate()
		{
			EventsBase.Invoke(EventSystem.OnFixedUpdateAction);
		}


		private void Update()
		{
			EventsBase.Invoke(EventSystem.OnUpdateAction);
		}


		private void LateUpdate()
		{
			EventsBase.Invoke(EventSystem.OnLateUpdateAction);
		}


		private void OnApplicationPause(bool pauseStatus)
		{
			if (pauseStatus == true)
			{
				EventsBase.Invoke(EventSystem.OnApplicationPauseAction);
			}
		}


		private void OnApplicationQuit()
		{
			EventsBase.Invoke(EventSystem.OnApplicationQuitAction);
		}


		private void OnDisable()
		{
			EventsBase.Invoke(EventSystem.OnDisableAction);
		}


		private void OnDestroy()
		{
			EventsBase.Invoke(EventSystem.OnDestroyAction);
		}
	}
}
