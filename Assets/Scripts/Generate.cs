using UnityEngine;

public class Generate : MonoBehaviour
{
  public GameObject groundTile;
  public GameObject carrot;
  public GameObject rock;


  
  // Use this for initialization
  void Start()
  {
    InvokeRepeating("CreateGround", 0.1f, 2.15f);
    InvokeRepeating("CreateCarrot", 2f, 2.15f);
    InvokeRepeating("CreateObstacle", 2f, 5f);


  }

  
  void CreateGround()
  {
    Instantiate(groundTile);

  }


  void CreateCarrot()
  {
    Instantiate(carrot);

  }

    void CreateObstacle()
  {
    Instantiate(rock);

  }




}

