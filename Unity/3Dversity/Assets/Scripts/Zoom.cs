using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class Zoom : MonoBehaviour
{
    
    public GameObject palma1;
    public GameObject palma2;
    //public GameObject camara;

    //private float velocidad;
    private int distancia = 0;
    private int zooming;
    
    public void zoomingIn(){
        zooming = 1;
        
    }
    public void stopZoom(){
        zooming = 0;
    }

    /*public float zooming(){
        float distancia = Vector3.Distance(palma1.transform.position, palma2.transform.position);
        return ((distancia-5)/100);
    }*/

    public void hacerZoom(){
        if(( zooming == 1) && (Camera.main.transform.position.z <= -5) && (Camera.main.transform.position.z >= -10)){
            float distancia = Vector3.Distance(palma1.transform.position, palma2.transform.position);
            distancia = ((distancia-3)/50);
            Camera.main.transform.Translate(new Vector3(0.0f, 0.0f, distancia));
            print(distancia);
            if(Camera.main.transform.position.z < -10){
                Camera.main.transform.Translate(new Vector3(0.0f, 0.0f, +1));
            }
            if(Camera.main.transform.position.z > -5){
                Camera.main.transform.Translate(new Vector3(0.0f, 0.0f, -1));
            }
        }
        /* print(distancia);*/
    }

    // Update is called once per frame
    void Update(){
        hacerZoom();
    }

}

