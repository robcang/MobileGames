using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

  public float speed;

  private Rigidbody2D rb;

  void Start () {

      rb = GetComponent<Rigidbody2D>();

      }

    void Update () {

        float moveHorizontal = Input.GetAxisRaw ("Horizontal");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

        rb.AddForce (movement * speed);

      }

}
