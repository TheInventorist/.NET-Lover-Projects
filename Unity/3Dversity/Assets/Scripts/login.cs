using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour{

    public GameObject email;
    public GameObject passwd;
    public GameObject btnLogin;
     //public GameObject logear;
     private string Email;
     private string Passwd;

    public GameObject pantallaDeCarga;
    public Slider slider;
    //public Text progreso;

    private int validarLogin(string Email, string Passwd){
        if((Email == "User1@gmail.com") && (Passwd ==  "admin")){
            return 1;
        }
        else{
            return 0;
        }
    }

    private void cargador(){
        SceneManager.LoadScene(1);
    }

    void Update(){
        Email = email.GetComponent<InputField>().text;
        Passwd = passwd.GetComponent<InputField>().text;
        
        UnityEngine.UI.Button btn = btnLogin.GetComponent<Button>();
        
        if(validarLogin(Email, Passwd) == 1){
            btn.onClick.AddListener(cargador);
        }
        
    }
}