using UnityEngine;

namespace Toolkid.Core.Attribute {
    // �۩w�q�ݩʡA�Ω�s�x���Ҥ�r
    public class LabelAttribute : PropertyAttribute {
        public string label;

        public LabelAttribute(string label) {
            this.label = label;
        }
    }
}