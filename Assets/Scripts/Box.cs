using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
  float t = 0;
  public AnimationCurve curve;
  public GameObject spawnPrefab;
  public GameObject nextPrefab;

  IEnumerator sample(){
    Vector2 pos = transform.position;
    for (float t = 0; t < curve.keys[curve.length - 1].time; t += Time.deltaTime){
      transform.position = new Vector2(pos.x, pos.y + curve.Evaluate(t));
      yield return null;
    }
    if (spawnPrefab)
      Instantiate(spawnPrefab, transform.position + Vector3.up, Quaternion.identity);
    if (nextPrefab)
      Instantiate(nextPrefab, transform.position, Quaternion.identity);
    Destroy(gameObject);
  }

  void OnCollisionEnter2D(Collision2D coll){
    if (coll.contacts[0].point.y < transform.position.y)
      StartCoroutine("sample");
  }

  void Update(){
    if (t < curve.keys[curve.length - 1].time){
      t += Time.deltaTime;
    }
  }
}
