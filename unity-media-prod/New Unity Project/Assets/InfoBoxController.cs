using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter(Collider other){
       Debug.Log("hit");
       GameObject.FindGameObjectWithTag("info").GetComponent<Text>().text = "hello";

    }

    private void OnTriggerExit(Collider other){


    }
}
