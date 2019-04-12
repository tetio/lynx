using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBase : MonoBehaviour
{
    void Start()
    {
        RegisterInteractable();
    }

    private void OnDestroy()
    {
        UnregisterInteractable();
    }


    void RegisterInteractable()
    {
        CharacterInteractionModel characterInteractionModel = GetCharacterInteractionModel();
        if (characterInteractionModel == null)
        {
            return;
        }
        characterInteractionModel.RegisterInteractable(this);
    }


    void UnregisterInteractable()
    {
        CharacterInteractionModel characterInteractionModel = GetCharacterInteractionModel();
        if (characterInteractionModel == null)
        {
            return;
        }
        characterInteractionModel.RemoveInteractable(this);
    }

    private CharacterInteractionModel GetCharacterInteractionModel()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject == null)
        {
            Debug.LogWarning("Interactable: playerObject not found");
            return null;
        }
        CharacterInteractionModel characterInteractionModel = playerObject.GetComponent<CharacterInteractionModel>();
        if (characterInteractionModel == null)
        {
            Debug.LogWarning("Interactable: characterInteractionModel not found");
            return null;
        }
        return characterInteractionModel;
    }

    public virtual void OnInteract() 
    {
    }
}
