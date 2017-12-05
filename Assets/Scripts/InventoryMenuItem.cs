using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryMenuItem : MonoBehaviour
{
    Text displayText;
    InventoryObject objectRepresented;
    public void InventoryObjectWasClicked()
    {
        // todo: update display text
        displayText.text = objectRepresented.DescriptionText;
    }

}
