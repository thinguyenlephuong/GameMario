using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3;
    Vector2 dir = Vector2.right;
    public float upForce = 800;
    public int score = 200;
    void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }

    void OnTriggerEnter2D(Collider2D coll) {
        transform.localScale = new Vector2(-1*transform.localScale.x,
                                          transform.localScale.y);
        dir = new Vector2(-1 * dir.x, dir.y);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.name == "BabyMario") {
            if (coll.contacts[0].point.y > transform.position.y) {
                GetComponent<Animator>().SetTrigger("Died");
                GetComponent<Collider2D>().enabled = false;
                coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * upForce);
                Invoke("Die", 5);
                Info.coins += score;
            } else {
                coll.gameObject.GetComponent<Collider2D>().enabled = false;
                coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * upForce);
                coll.gameObject.GetComponent<PlayerMovement>().Die(2);
            }
        }
        if (coll.gameObject.tag == "Enemy"){
            transform.localScale = new Vector2(-1*transform.localScale.x,
                                          transform.localScale.y);
            dir = new Vector2(-1 * dir.x, dir.y);
        }
    }

    void Die() {
        Destroy(gameObject);
    }
}
