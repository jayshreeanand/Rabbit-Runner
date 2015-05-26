using UnityEngine;

public class Player : MonoBehaviour
{
  // The force which is added when the player jumps
  // This can be changed in the Inspector window
  public Vector2 jumpForce = new Vector2(0, 300);
  public Vector2 runVelocity = new Vector2(8, 0);
  public float MoveSpeed = 3.0f;

  void Start()
  {
    GetComponent<Rigidbody2D>().velocity = runVelocity;

  }
  // Update is called once per frame
  void Update()
  {

    // Jump
    if (Input.GetKeyUp("space") || (Input.touchCount == 1))
    {
      GetComponent<Rigidbody2D>().AddForce(jumpForce);
      GetComponent<Rigidbody2D>().velocity = runVelocity;
      
    }

    // Die by being off screen
    Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
    if (screenPosition.y > Screen.height || screenPosition.y < 0)
    {
      Die();
    }

  }

  
  void Die()
  {
    Application.LoadLevel(Application.loadedLevel);
  }
}

