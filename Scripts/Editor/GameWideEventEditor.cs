using UnityEditor;
using UnityEngine;


namespace _mrstruijk.Events
{
	/// <summary>
	/// Adapted from: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/Editor/EventEditor.cs
	/// Author: Ryan Hipple
	/// </summary>
	[CustomEditor(typeof (EventSO), true)]
	public class GameWideEventEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			GUI.enabled = Application.isPlaying;

			var e = target as EventSO;

			if (GUILayout.Button("Raise"))
			{
				e.Raise();
			}
		}
	}
}
