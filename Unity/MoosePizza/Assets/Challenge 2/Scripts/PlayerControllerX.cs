using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public Vector3 offset = new Vector3(0, 28, 0);
    private float timeStamp = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeStamp <= 0)
        {
            timeStamp = 1;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        timeStamp -= Time.deltaTime;
    }
}
