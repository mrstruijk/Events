using UnityEngine;


namespace _mrstruijk.Events
{
	public class MonoBehaviourEvents : MonoBehaviour
	{
		private void Awake()
		{
			EventSystem.Invoke(EventSystem.OnAwakeAction);
		}


		private void OnEnable()
		{
			EventSystem.Invoke(EventSystem.OnEnableAction);
		}


		private void Start()
		{
			EventSystem.Invoke(EventSystem.OnStartAction);
		}


		private void FixedUpdate()
		{
			EventSystem.Invoke(EventSystem.OnFixedUpdateAction);
		}


		private void Update()
		{
			EventSystem.Invoke(EventSystem.OnUpdateAction);
		}


		private void LateUpdate()
		{
			EventSystem.Invoke(EventSystem.OnLateUpdateAction);
		}


		private void OnApplicationPause(bool pauseStatus)
		{
			if (pauseStatus == true)
			{
				EventSystem.Invoke(EventSystem.OnApplicationPauseAction);
			}
		}


		private void OnApplicationQuit()
		{
			EventSystem.Invoke(EventSystem.OnApplicationQuitAction);
		}


		private void OnDisable()
		{
			EventSystem.Invoke(EventSystem.OnDisableAction);
		}


		private void OnDestroy()
		{
			EventSystem.Invoke(EventSystem.OnDestroyAction);
		}
	}
}
