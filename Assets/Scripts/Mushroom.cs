using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mushroom : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player") {
            Destroy(gameObject);

            Scene scene = SceneManager.GetActiveScene(); 
            if(scene.name != "Level3"){
                SceneManager.LoadScene(scene.buildIndex + 1);
            } else {
                SceneManager.LoadScene("Win");
            }
        }
    }
}
