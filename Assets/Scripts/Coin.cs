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
    }
    Destroy(gameObject);
  }
}
