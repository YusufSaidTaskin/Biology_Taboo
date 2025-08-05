using TMPro;
using UnityEngine;

public class SureDropdown : MonoBehaviour
{
    //[SerializeField]TextMeshProUGUI timerText;

    public TimeHolder timeholder;
    public void SureDropdownSample(int index)
    {
        switch (index)
        {
            case 0: Debug.Log("30 sn");
                timeholder.totalTime= 30;
                break;
            case 1: Debug.Log("45 sn");
                timeholder.totalTime = 45;
                break;
            case 2: Debug.Log("60 sn");
                timeholder.totalTime = 60;
                break;
            case 3: Debug.Log("90 sn");
                timeholder.totalTime = 90;
                break;
            case 4: Debug.Log("120 sn");
                timeholder.totalTime = 120;
                break;
        }
    }
}
