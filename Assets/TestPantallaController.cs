using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class TestPantallaController : MonoBehaviour
{
    public bool testOpen = false;
    public GameObject testPanel;
    public TextMeshProUGUI text;
    void Start()
    {
       testOpen = false;

       if (testPanel != null)
           testPanel.SetActive(false);
    }


    public void ToggleMenu()
    {
        testOpen = !testOpen;

        if (testOpen)
        {
            if (testPanel != null)
                testPanel.SetActive(true);

            text.text = "X";
        }
        else
        {
            testPanel.SetActive(false);
            text.text = "T";
        }
    }
}
