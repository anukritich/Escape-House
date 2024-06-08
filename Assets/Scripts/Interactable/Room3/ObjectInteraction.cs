using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Camera mainCamera;
    public float maxInteractionDistance = 5f;
    private GameObject heldObject;
    private bool isHoldingObject = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isHoldingObject)
            {
                PickUpObject();
            }
            else
            {
                DropObject();
            }
        }
    }
    void PickUpObject()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, maxInteractionDistance))
        {
            if (hit.collider.CompareTag("Interactable"))
            {
                heldObject = hit.collider.gameObject;
                heldObject.GetComponent<Rigidbody>().isKinematic = true;
                heldObject.transform.SetParent(mainCamera.transform);
                isHoldingObject = true;
            }
        }

    }
    void DropObject()
    {
        heldObject.GetComponent<Rigidbody>().isKinematic = false;
        heldObject.transform.SetParent(null);
        heldObject = null;
        isHoldingObject = false;
    }



}


