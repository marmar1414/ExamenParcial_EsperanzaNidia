using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Objetivo : MonoBehaviour
{
    public GameObject Obj;
    public GameObject bala;
    [SerializedField] private TMP_Text Puntaje;
    public Text_textoContador;
    

    public float puntos = 10;
    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj = GameObject.Find("bala");
        if (collision.gameObject == "obj")
        {
            puntos--
            puntaje.text = puntos.ToString();
            puntuacion = "Tu puntuacion es: " + puntos;
        }

    }
}
