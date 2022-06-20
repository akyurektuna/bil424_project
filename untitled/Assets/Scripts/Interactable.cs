
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    // Transform player;
    //  void Update() {
        
    // }
    public virtual void Interact(){
        //will be overwritten by different interactables
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
