using UnityEngine;
using UnityEditor;
using Toolkid.Core.Attribute;

namespace Toolkid.Editor.Attributes {
    // �۩w�q�ݩ�ø�s���A�Ω�ø�s�a���۩w�q���Ҫ��ݩ�
    [CustomPropertyDrawer(typeof(ArrayLabelAttribute))]
    public class ArrayLabelAttributeDrawer : PropertyDrawer {
        // �bGUI��ø�s�ݩ�
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            var arrayLabelAttribute = (ArrayLabelAttribute)attribute;
            label.text = arrayLabelAttribute.label;

            EditorGUI.PropertyField(position, property, label, true);
        }

        // ����ݩʪ�����
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {            
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}
