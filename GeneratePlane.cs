using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlane : MonoBehaviour {

  public GameObject thePlatform;
  public Transform generationPoint;
  public float distanceBetween = 0;

  private float platformWidth;

	void Start () {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
	}

	void Update () {

        if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatform, transform.position, transform.rotation);
        }
}
}
