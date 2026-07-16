using UnityEngine;

public class ArtifactInfo : MonoBehaviour
{
    public string title;

    [TextArea]
    public string description;

    private MuseumUIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<MuseumUIManager>();
    }

    void OnMouseDown()
    {
        uiManager.ShowInfo(title, description);
    }
}