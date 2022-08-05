using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckpointPos;
    }

    // Update is called once per frame
    void Update()
    {
        // change this test code for when user dies
       if(Input.GetKeyDown("g")){
            Debug.Log("e bastin");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       } 
    }
}
