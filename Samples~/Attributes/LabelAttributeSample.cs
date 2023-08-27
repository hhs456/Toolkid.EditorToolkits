using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Toolkid.Core.Attribute;

public class LabelAttributeSample : MonoBehaviour
{
    [Label("�ǦC")] public int index = 0;
    [Label("�}�C")] public int[] array = new int[3];
    [Label("���O")] public SampleArgs args = new SampleArgs();
    [Label("���O�}�C")] public SampleArgs[] argsArray = new SampleArgs[3];
    [Label("�}�C���O")]
    public SampleArgsList arrayUnderArgsList;
    [Label("���h�}�C")]
    public SampleArgsList[] argsListArray;
}
[System.Serializable]
public class SampleArgs {
    [Label("�W��")] public string name = "";
    [Label("�y�z")] public string description = "";
}
[System.Serializable]
public class SampleArgsList {
    [Label("���O�}�C")]
    public SampleArgs[] argsArray = new SampleArgs[3];
}