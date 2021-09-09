using UnityEngine;


namespace _mrstruijk.Events
{
	[RequireComponent(typeof(AudioSource))]
	public abstract class BasePlayAudio : MonoBehaviour
	{
		[SerializeField] private AudioClip audioClip;

		private AudioSource source;


		private void Awake()
		{
			source = GetComponent<AudioSource>();
		}


		public void ListenerAction()
		{
			PlayAudio();
		}


		private void PlayAudio()
		{
			source.clip = audioClip;
			source.Play();
		}
	}
}
