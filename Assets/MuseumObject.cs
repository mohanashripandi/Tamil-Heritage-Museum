using UnityEngine;

public class MuseumObject : MonoBehaviour
{
    public GameObject infoPanel;

    private void OnMouseDown()
    {
        infoPanel.SetActive(true);
    }
}