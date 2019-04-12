using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterInteractionModel : MonoBehaviour
{
    private List<InteractableBase> interactables = new List<InteractableBase>();
    private Collider2D mCollider;

    void Start()
    {
    }


    private void Awake()
    {
        mCollider = GetComponent<Collider2D>();
    }


    void Update()
    {
    }

    public void OnInteract()
    {
        InteractableBase interactable = FindUsableInteractable();
        if (null != interactable)
        {
            interactable.OnInteract();
        }
    }

    public void RegisterInteractable(InteractableBase newInteractable)
    {
        if (interactables.Contains(newInteractable))
        {
            return;
        }
        interactables.Add(newInteractable);
        Debug.Log("Intereactable registered " + newInteractable.name, newInteractable);
    }

    public void RemoveInteractable(InteractableBase oldInteractable)
    {
        if (interactables.Contains(oldInteractable))
        {
            return;
        }
        interactables.Remove(oldInteractable);
        Debug.Log("Intereactable registered " + oldInteractable.name, oldInteractable);
    }

    public InteractableBase FindUsableInteractable()
    {
        foreach(InteractableBase interactable in interactables)
        {
            if (mCollider.IsTouching(interactable.GetComponent<Collider2D>()))
            {
                return interactable;
            }
        }
        return null;
    }
}