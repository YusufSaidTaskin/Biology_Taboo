using UnityEngine;

public class SureDropdown : MonoBehaviour
{
    public void SureDropdownSample(int index)
    {
        switch (index)
        {
            case 0: Debug.Log("30 sn"); break;
            case 1: Debug.Log("45 sn"); break;
            case 2: Debug.Log("60 sn"); break;
            case 3: Debug.Log("90 sn"); break;
            case 4: Debug.Log("120 sn"); break;
        }
    }
}
