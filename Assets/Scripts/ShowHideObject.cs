using UnityEngine;
using UnityEngine.UI;

public class ShowHideObject : MonoBehaviour
{
    public GameObject objectToShowHide; // Reference to the GameObject you want to show/hide

    private bool isObjectVisible = false;

    public void ToggleObjectVisibility()
    {
        isObjectVisible = !isObjectVisible;
        objectToShowHide.SetActive(isObjectVisible);
    }
}