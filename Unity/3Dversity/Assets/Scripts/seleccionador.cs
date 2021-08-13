using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class seleccionador : MonoBehaviour
{
   public GameObject botonMenu;
   public GameObject botonVolver;
   public GameObject menuSeleccionadorCategorias;
   public GameObject botonCategoria1;
   public GameObject botonCategoria2;
   public GameObject botonCategoria3;
   public GameObject botonCategoria4;
   public GameObject botonCategoria5;
   public GameObject cristal1;
   public GameObject cristal2;
   public GameObject cristal3;
   public GameObject cristal4;
   public GameObject cristal5;
    Vector3 fuera = new Vector3(100.0f,0,0);
    Vector3 enJuego = new Vector3(0,0,0);
    Vector3 enJuegoRomboedro = new Vector3(1.0f,0,0); 
    Vector3 enJuegoPrisma = new Vector3(0,-2.0f,0); 
    public int cristalActual = 1;
    private Simetrias scriptSimetrias;
    
    void Start(){
        menuSeleccionadorCategorias.SetActive(false);
        scriptSimetrias = GameObject.FindObjectOfType<Simetrias>();
    }
    void Update()
    {

        UnityEngine.UI.Button BotonMenu = botonMenu.GetComponent<Button>();
        UnityEngine.UI.Button BotonVolver = botonVolver.GetComponent<Button>();
        UnityEngine.UI.Button BotonCat1 = botonCategoria1.GetComponent<Button>();
        UnityEngine.UI.Button BotonCat2 = botonCategoria2.GetComponent<Button>();
        UnityEngine.UI.Button BotonCat3 = botonCategoria3.GetComponent<Button>();
        UnityEngine.UI.Button BotonCat4 = botonCategoria4.GetComponent<Button>();
        UnityEngine.UI.Button BotonCat5 = botonCategoria5.GetComponent<Button>();

        BotonMenu.onClick.AddListener(mostrarMenuCategorias);
        BotonVolver.onClick.AddListener(ocultarMenuCategorias);
        BotonCat1.onClick.AddListener(cambiarCristal1);
        BotonCat2.onClick.AddListener(cambiarCristal2);
        BotonCat3.onClick.AddListener(cambiarCristal3);
        BotonCat4.onClick.AddListener(cambiarCristal4);
        BotonCat5.onClick.AddListener(cambiarCristal5);

        scriptSimetrias.actualizarCristal(cristalActual);

        

    }

    public void cambiarCristal1(){
        //cristal2.transform.position.Set(30,30,30);
        //cristal1.transform.position.Set(0,0,0);
        cristal2.transform.position = fuera;
        cristal3.transform.position = fuera;
        cristal4.transform.position = fuera;
        cristal5.transform.position = fuera;
        cristal1.transform.position = enJuego;
        menuSeleccionadorCategorias.SetActive(false);
        cristalActual = 1;

    }
    public void cambiarCristal2(){
        cristal2.transform.position = enJuegoPrisma;
        cristal1.transform.position = fuera;
        cristal3.transform.position = fuera;
        cristal4.transform.position = fuera;
        cristal5.transform.position = fuera;
        menuSeleccionadorCategorias.SetActive(false);
        cristalActual = 2;
    }

    public void cambiarCristal3(){
        cristal3.transform.position = enJuego;
        cristal1.transform.position = fuera;
        cristal2.transform.position = fuera;
        cristal4.transform.position = fuera;
        cristal5.transform.position = fuera;
        menuSeleccionadorCategorias.SetActive(false);
        cristalActual = 3;
    }
    public void cambiarCristal4(){
        cristal4.transform.position = enJuego;
        cristal1.transform.position = fuera;
        cristal2.transform.position = fuera;
        cristal3.transform.position = fuera;
        cristal5.transform.position = fuera;
        menuSeleccionadorCategorias.SetActive(false);
        cristalActual = 4;
    }
    public void cambiarCristal5(){
        cristal5.transform.position = enJuegoRomboedro;
        cristal1.transform.position = fuera;
        cristal2.transform.position = fuera;
        cristal3.transform.position = fuera;
        cristal4.transform.position = fuera;
        menuSeleccionadorCategorias.SetActive(false);
        cristalActual = 5;
    }

    private void mostrarMenuCategorias(){
        menuSeleccionadorCategorias.SetActive(true);
    }
    private void ocultarMenuCategorias(){
        menuSeleccionadorCategorias.SetActive(false);
    }
}
