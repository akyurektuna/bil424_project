using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public HUD hud;
    public GameObject itemcol;

    public float speed = 6f;
    public float turnSmoothTime = 0.1f;

    public Interactable item = null;

    float turnSmoothVelocity;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if(direction.magnitude >= 0.1f){
            float targetAngle = Mathf.Atan2(direction.x, direction.z)*Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle,0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f)*Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        //right mouse button to pickup objects
        if(Input.GetKeyDown("e")){
            if(item != null){
                float distance = Vector3.Distance(item.transform.position, transform.position);
                if(distance<=item.radius){
                    item.Interact();
                    hud.CloseMessagePanel();
                }
            }
            
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other == item.GetComponent<Collider>())
            hud.OpenMessagePanel("");
    }

}
