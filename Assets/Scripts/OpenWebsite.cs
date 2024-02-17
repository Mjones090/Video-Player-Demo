using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWebsite : MonoBehaviour

{
    public string targetURL = "https://www.PickAWebsite.com"; // Replace with your desired URL

    public void OpenURLOnClick()
    {
        Application.OpenURL(targetURL);
    }
}