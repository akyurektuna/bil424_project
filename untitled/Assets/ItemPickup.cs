using UnityEngine;
using TMPro;

public class ItemPickup : Interactable
{
    public Item item;
    [SerializeField] TextMeshProUGUI clueCountText;
    private int clueCount = 0;
    public override void Interact(){
        base.Interact();
        PickUp();
    }

    void PickUp(){
        Debug.Log("picking up "+ item.name);
        clueCount = clueCount + 1;
        clueCountText.text = "Clues " + clueCount +"/3";
       Destroy(gameObject); 
    }

}
