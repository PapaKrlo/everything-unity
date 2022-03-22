using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollisions : MonoBehaviour
{

    public float fogValue;
    public float fogDensityIncrement;
    public string rockName;

    private GameObject [] rocks;

    // Start is called before the first frame update
    void Start()
    {
      RenderSettings.fogDensity = 0.01f;  
      rocks = GameObject.FindGameObjectsWithTag("rock");
      foreach (GameObject r in rocks)
      {
          Debug.Log(r);
      }
    }

    // Update is called once per frame
    void Update()
    {
       fogValue = RenderSettings.fogDensity;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit){
        if (hit.gameObject.tag == "rock" && hit.gameObject.name !=rockName)
        {
            Debug.Log (hit.gameObject.name);
            RenderSettings.fogDensity += fogDensityIncrement;
            rockName = hit.gameObject.name;
        }
    }
}
