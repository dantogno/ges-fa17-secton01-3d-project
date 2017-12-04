using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateLookedAtObjects : MonoBehaviour {
    [SerializeField]
    private float maxActivateDistance = 4.0f;

    [SerializeField]
    private Text lookedAtObjectText;

    private IActivatable objectLookedAt;

    // Update is called once per frame
    void Update ()
    {
        UpdateObjectLookedAt();
        UpdateLookedAtObjectText();
        HandleInput();
    }

    private void UpdateObjectLookedAt()
    {
        Debug.DrawRay(transform.position, transform.forward * maxActivateDistance, Color.blue);
        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, transform.forward,
            out raycastHit, maxActivateDistance))
        {
            Debug.Log("Racast hit " + raycastHit.transform.name);

            objectLookedAt = raycastHit.transform.GetComponent<IActivatable>();
        }
        else
            objectLookedAt = null;
    }


    private void UpdateLookedAtObjectText()
    {
        if (objectLookedAt == null)
        {
            lookedAtObjectText.text = string.Empty;
        }
        else
            lookedAtObjectText.text = objectLookedAt.NameText;

        // This is functionally identical, just included as reference
        //lookedAtObjectText.text = 
        //    objectLookedAt == null ? string.Empty : objectLookedAt.NameText;
    }

    private void HandleInput()
    {
        if (objectLookedAt != null && Input.GetButtonDown("Activate"))
        {
            objectLookedAt.DoActivate();
        }
    }
}
