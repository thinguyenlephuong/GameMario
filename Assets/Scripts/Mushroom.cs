using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mushroom : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player") {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Invoke("PlayAudio",0f);
            Invoke("NewLevel",2f);
            Destroy(gameObject,2f);
        }
    }

    void PlayAudio(){
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        if (!audio.isPlaying)
        {
          audio.Play();
        }
        
    }

    void NewLevel(){
        Scene scene = SceneManager.GetActiveScene(); 
        if(scene.name != "Level3"){
            SceneManager.LoadScene(scene.buildIndex + 1);
        } else {
            SceneManager.LoadScene("Win");
        }
    }
}
