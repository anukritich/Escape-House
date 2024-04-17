using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]private float distance = 3f;
    [SerializeField]private LayerMask mask;
    private PLayerUi PLayerUi;
    private InputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        PLayerUi= GetComponent<PLayerUi>(); 
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        PLayerUi.UpdateText(string.Empty);
        //ray creating for interaction 
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction*distance);
        RaycastHit hit; //to dtetct the collision
        if(Physics.Raycast(ray, out hit, distance, mask))
        {
            if(hit.collider.GetComponent<Interactable>() != null) 
            {
                Interactable interactable = hit.collider.gameObject.GetComponent<Interactable>();
                PLayerUi.UpdateText(interactable.PromptMessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                       interactable.BaseInteract();
                }
            }
        }
    }
}
