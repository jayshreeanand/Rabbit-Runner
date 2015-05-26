using UnityEngine;

public class Generate : MonoBehaviour
{
  public GameObject groundTile;

  
  // Use this for initialization
  void Start()
  {
    InvokeRepeating("CreateObstacle", 0.1f, 2.15f);
  }

  
  void CreateObstacle()
  {
    Instantiate(groundTile);

  }
}

