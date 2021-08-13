using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Simetrias : MonoBehaviour
{

    public GameObject botonMenuSimetrias;
    public GameObject botonSalirSimetrias;
    public GameObject botonSimetriaCara;
    public GameObject botonSimetriaAristas;
    public GameObject botonSimetriaVertices;
    public GameObject menuCanvasSimetrias;
    public GameObject simetriaCristal1Cara;
    public GameObject simetriaCristal1Arista;
    public GameObject simetriaCristal1Vertice;
    public GameObject simetriaCristal2Cara;
    public GameObject simetriaCristal2Arista;
    public GameObject simetriaCristal2Vertice;
    public GameObject simetriaCristal3Cara;
    public GameObject simetriaCristal3Arista;
    public GameObject simetriaCristal3Vertice;
    public GameObject simetriaCristal4Cara;
    public GameObject simetriaCristal4Arista;
    public GameObject simetriaCristal4Vertice;
    public GameObject simetriaCristal5Cara;
    public GameObject simetriaCristal5Arista;
    public GameObject simetriaCristal5Vertice;
    int estadoSimetriaCara = 0;
    int estadoSimetriaArista = 0;
    int estadoSimetriaVertice = 0;
    

    private seleccionador codigoSeleccionador;

    int cristalEnUso;

    // Start is called before the first frame update
    void Start()
    {
        menuCanvasSimetrias.SetActive(false);
        simetriaCristal1Cara.SetActive(false);
        simetriaCristal1Arista.SetActive(false);
        simetriaCristal1Vertice.SetActive(false);
        simetriaCristal2Cara.SetActive(false);
        simetriaCristal2Arista.SetActive(false);
        simetriaCristal2Vertice.SetActive(false);
        simetriaCristal3Cara.SetActive(false);
        simetriaCristal3Arista.SetActive(false);
        simetriaCristal3Vertice.SetActive(false);
        simetriaCristal4Cara.SetActive(false);
        simetriaCristal4Arista.SetActive(false);
        simetriaCristal4Vertice.SetActive(false);
        simetriaCristal5Cara.SetActive(false);
        simetriaCristal5Arista.SetActive(false);
        simetriaCristal5Vertice.SetActive(false);

        /* codigoSeleccionador = GetComponent<seleccionador>().cristalActual;*/

    }

    // Update is called once per frame
    void Update()
    {
        
        UnityEngine.UI.Button BotonMenuSimetrias = botonMenuSimetrias.GetComponent<Button>();
        UnityEngine.UI.Button BotonSimetriaCara = botonSimetriaCara.GetComponent<Button>();
        UnityEngine.UI.Button BotonSimetriaArista = botonSimetriaAristas.GetComponent<Button>();
        UnityEngine.UI.Button BotonSimetriaVertice = botonSimetriaVertices.GetComponent<Button>();
        UnityEngine.UI.Button BotonSalirSimetrias = botonSalirSimetrias.GetComponent<Button>();

        BotonMenuSimetrias.onClick.AddListener(activarMenu);
        BotonSimetriaCara.onClick.AddListener(simetriaCara);
        BotonSimetriaArista.onClick.AddListener(simetriaArista);
        BotonSimetriaVertice.onClick.AddListener(simetriaVertice);
        BotonSalirSimetrias.onClick.AddListener(desactivarMenu);

        /* cristalEnUso = actualizarCristal();*/

        /* cristalEnUso = GetComponent<seleccionador>().cristalActual;*/
    }

    public void actualizarCristal(int cristal){
        cristalEnUso = cristal;
    }

    public void activarMenu(){
        menuCanvasSimetrias.SetActive(true);
    }
    public void desactivarMenu(){
        menuCanvasSimetrias.SetActive(false);
    }

    public void simetriaCara(){
        if(estadoSimetriaCara == 0){
            if(cristalEnUso == 1){
                simetriaCristal1Cara.SetActive(true);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(false);
            }
            if(cristalEnUso == 2){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(true);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(false);
            }
            if(cristalEnUso == 3){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(true);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(false);
            }
            if(cristalEnUso == 4){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(true);
                simetriaCristal5Cara.SetActive(false);
            }
            if(cristalEnUso == 5){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(true);
            }
            estadoSimetriaCara = 1;
        }
        else{
            if(cristalEnUso == 1){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(false);
            }
            if(cristalEnUso == 2){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(false);
            }
            if(cristalEnUso == 3){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(false);
            }
            if(cristalEnUso == 4){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(false);
            }
            if(cristalEnUso == 5){
                simetriaCristal1Cara.SetActive(false);
                simetriaCristal2Cara.SetActive(false);
                simetriaCristal3Cara.SetActive(false);
                simetriaCristal4Cara.SetActive(false);
                simetriaCristal5Cara.SetActive(false);
            }
            estadoSimetriaCara = 0;
        }
            
    }
    public void simetriaArista(){
        if(estadoSimetriaArista == 0){
            if(cristalEnUso == 1){
                simetriaCristal1Arista.SetActive(true);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(false);
            }
            if(cristalEnUso == 2){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(true);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(false);
            }
            if(cristalEnUso == 3){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(true);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(false);
            }
            if(cristalEnUso == 4){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(true);
                simetriaCristal5Arista.SetActive(false);
            }
            if(cristalEnUso == 5){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(true);
            }
            estadoSimetriaArista = 1;
        }
        else{
            if(cristalEnUso == 1){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(false);
            }
            if(cristalEnUso == 2){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(false);
            }
            if(cristalEnUso == 3){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(false);
            }
            if(cristalEnUso == 4){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(false);
            }
            if(cristalEnUso == 5){
                simetriaCristal1Arista.SetActive(false);
                simetriaCristal2Arista.SetActive(false);
                simetriaCristal3Arista.SetActive(false);
                simetriaCristal4Arista.SetActive(false);
                simetriaCristal5Arista.SetActive(false);
            }
            estadoSimetriaArista = 0;
        }
            
    }
    public void simetriaVertice(){
        if(estadoSimetriaVertice == 0){
            if(cristalEnUso == 1){
                simetriaCristal1Vertice.SetActive(true);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(false);
            }
            if(cristalEnUso == 2){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(true);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(false);
            }
            if(cristalEnUso == 3){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(true);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(false);
            }
            if(cristalEnUso == 4){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(true);
                simetriaCristal5Vertice.SetActive(false);
            }
            if(cristalEnUso == 5){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(true);
            }
            estadoSimetriaVertice = 1;
        }
        else{
            if(cristalEnUso == 1){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(false);
            }
            if(cristalEnUso == 2){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(false);
            }
            if(cristalEnUso == 3){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(false);
            }
            if(cristalEnUso == 4){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(false);
            }
            if(cristalEnUso == 5){
                simetriaCristal1Vertice.SetActive(false);
                simetriaCristal2Vertice.SetActive(false);
                simetriaCristal3Vertice.SetActive(false);
                simetriaCristal4Vertice.SetActive(false);
                simetriaCristal5Vertice.SetActive(false);
            }
            estadoSimetriaVertice = 0;
        }
    }

}
