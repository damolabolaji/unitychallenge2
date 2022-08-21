using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogDelay = 3;
    private float counter = 0;



   
    // Update is called once per frame
    void Update()
    {
       
        counter += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && counter > dogDelay)
        // On spacebar press, send dog
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            counter = 0;

        }
        
    }

}
