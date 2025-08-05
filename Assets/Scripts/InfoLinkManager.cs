using UnityEngine;

public class InfoLinkManager : MonoBehaviour
{
    public void OpenLinks(string link)
    {
        Application.OpenURL(link);
    }
}
