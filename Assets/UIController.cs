using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField SpeedInput;
    [SerializeField]
    private TMP_InputField TimeInput;
    [SerializeField]
    private TMP_InputField RangeInput;

        public void SendSpeed()
    {
        CubeSpawner.instance.SetSpeed(float.Parse(SpeedInput.text));
    }
    public void SendTime()
    {
        CubeSpawner.instance.SetTime(float.Parse(TimeInput.text));
    }
    public void SendRange()
    {
        CubeSpawner.instance.SetRange(float.Parse(RangeInput.text));
    }
}
