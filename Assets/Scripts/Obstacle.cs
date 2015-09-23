using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

  public float range = 4;
  public Vector2 velocity = new Vector2(-4, 0);


	// Use this for initialization
	void Start () {
    GetComponent<Rigidbody2D>().velocity = velocity;
    
    //transform.position = new Vector3(transform.position.x + range * Random.value, transform.position.y , transform.position.z);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
