using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MuseumUIManager : MonoBehaviour
{
    public GameObject infoPanel;

    public TMP_Text titleText;
    public TMP_Text descriptionText;
    public Image artifactImage;

    public void ShowInfo(string title, string description)
    {
        infoPanel.SetActive(true);

        titleText.text = title;
        descriptionText.text = description;
    }

    public void ClosePanel()
    {
        infoPanel.SetActive(false);
    }
}