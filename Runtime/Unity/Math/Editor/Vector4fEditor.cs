// SPDX-License-Identifier: MIT
// Copyright (c) 2016-2021 Juan Delgado (@JuDelCo)

#if UNITY_2019_3_OR_NEWER
#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

namespace Ju.Math
{
	[CustomPropertyDrawer(typeof(Vector4f))]
	public class Vector4fDrawer : PropertyDrawer
	{
		private const float SubLabelSpacing = 4;
		private const float BottomSpacing = 2;

		public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label)
		{
			pos.height -= BottomSpacing;
			label = EditorGUI.BeginProperty(pos, label, prop);
			var contentRect = EditorGUI.PrefixLabel(pos, GUIUtility.GetControlID(FocusType.Passive), label);
			var labels = new[] { new GUIContent("X"), new GUIContent("Y"), new GUIContent("Z"), new GUIContent("W") };
			var properties = new[] { prop.FindPropertyRelative("x"), prop.FindPropertyRelative("y"), prop.FindPropertyRelative("z"), prop.FindPropertyRelative("w") };
			DrawMultiplePropertyFields(contentRect, labels, properties);

			EditorGUI.EndProperty();
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return base.GetPropertyHeight(property, label) + BottomSpacing;
		}

		private static void DrawMultiplePropertyFields(Rect pos, GUIContent[] subLabels, SerializedProperty[] props)
		{
			var indent = EditorGUI.indentLevel;
			var labelWidth = EditorGUIUtility.labelWidth;

			var propsCount = props.Length;
			var width = (pos.width - (propsCount - 1) * SubLabelSpacing) / propsCount;
			var contentPos = new Rect(pos.x, pos.y, width, pos.height);
			EditorGUI.indentLevel = 0;
			for (var i = 0; i < propsCount; i++)
			{
				EditorGUIUtility.labelWidth = EditorStyles.label.CalcSize(subLabels[i]).x;
				EditorGUI.PropertyField(contentPos, props[i], subLabels[i]);
				contentPos.x += width + SubLabelSpacing;
			}

			EditorGUIUtility.labelWidth = labelWidth;
			EditorGUI.indentLevel = indent;
		}
	}
}

#endif
#endif
