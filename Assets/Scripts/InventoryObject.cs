using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable {
    [SerializeField]
    private string nameText;

    //[name of editor tag thing]
    [SerializeField]
    private string descriptionText;


    private MeshRenderer meshRenderer;
    private Collider collider;
    private List<InventoryObject> playerInventory;


    public string DescriptionText
    {
        get { return descriptionText; }
    }
    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        playerInventory.Add(this);
        meshRenderer.enabled = false;
        collider.enabled = false;
    }

    // Use this for initialization
    void Start ()
    {
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
        collider = GetComponent<Collider>();
        meshRenderer = GetComponent<MeshRenderer>();
	}
}
