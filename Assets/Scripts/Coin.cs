using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
  public int score = 50;
  void OnTriggerEnter2D(Collider2D coll)
  {
    if (coll.gameObject.tag == "Player"){
      Info.coins += score;
      gameObject.GetComponent<SpriteRenderer>().enabled = false;
      Invoke("PlayAudio",0f);
    }
    Destroy(gameObject,1f);
  }

  void PlayAudio(){
    AudioSource audio = gameObject.GetComponent<AudioSource>();
        if (!audio.isPlaying)
        {
          audio.Play();
        }
  }
}
