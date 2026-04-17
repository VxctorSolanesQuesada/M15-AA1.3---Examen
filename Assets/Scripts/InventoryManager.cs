using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public bool invOpen = false;
    public GameObject invPanel;

    private NewInput input;

    private void Start()
    {
        input = new NewInput();
        input.Enable();

        invPanel.SetActive(false);
    }

    private void Update()
    {
        if (input.Player.Inventario.WasPressedThisFrame())
        {
            invOpen = !invOpen;

            if (invOpen)
            {
                if (invPanel != null)
                    invPanel.SetActive(true);

            }
            else
            {
                invPanel.SetActive(false);
            }
        }
    }
    public void CloseMenu()
    {
        invOpen = false;
        invPanel.SetActive(false);
    }
}
