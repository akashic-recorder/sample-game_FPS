using UnityEngine;

public sealed class BrowserOpener : MonoBehaviour
{
    [SerializeField] string url = "https://www.google.com";
    
    public void OpenBrowser()
    {
        Application.OpenURL(url);
    }
}