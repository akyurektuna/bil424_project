using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            Debug.Log("ending cp");
            StartCoroutine(loadScene());
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    IEnumerator loadScene(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
