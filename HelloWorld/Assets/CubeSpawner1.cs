using System.Collections;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
  public GameObject cubePrefabVar;

  // Start is called before the first frame update
  void Start()
  {}

  // Update is called once per frame
  void Update()
  {
    Instantiate(cubePrefabVar);
  }
}
