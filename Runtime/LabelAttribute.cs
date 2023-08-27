using UnityEngine;

namespace Toolkid.Core.Attribute {
    // �۩w�q�ݩʡA�Ω�s�x���Ҥ�r
    public class LabelAttribute : PropertyAttribute {
        public string label;
        public bool expanded;

        public LabelAttribute(string label, bool expanded = true) {
            this.label = label;
            this.expanded = expanded;
        }
    }
}