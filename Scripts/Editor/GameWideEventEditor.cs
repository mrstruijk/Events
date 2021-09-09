// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// Adapted from: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/Editor/EventEditor.cs
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------


using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EventSO), editorForChildClasses: true)]
public class GameWideEventEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		GUI.enabled = Application.isPlaying;

		EventSO e = target as EventSO;

		if (GUILayout.Button("Raise"))
		{
			e.Raise();
		}
	}
}
