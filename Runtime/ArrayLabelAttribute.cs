using UnityEngine;
namespace Toolkid.Core.Attribute {
    // �۩w�q�ݩʡA�Ω�s�x�}�C���Ҥ�r
    public class ArrayLabelAttribute : PropertyAttribute {
        public string label;
        public ArrayLabelAttribute(string label) => this.label = label;
    }
}