using UnityEngine;
using System.Collections;

public class Carrot : MonoBehaviour
{

  public float range = 4;
  public Vector2 velocity = new Vector2(-4, 0);


	// Use this for initialization
	void Start ()
  {
    GetComponent<Rigidbody2D>().velocity = velocity;
    transform.position = new Vector3(transform.position.x + range * Random.value, transform.position.y , transform.position.z);
	
	}
	
  void OnTriggerEnter2D(Collider2D other)
  {

    if(other.gameObject.tag == "Player") 
      print(" i hit the carrot!");
      gameObject.SetActive(false);
  }
	

}
