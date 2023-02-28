using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    public float tiempo = 60f;
    [SerializeField] private TMP_text contar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = Time.deltaTime;
        if (tiempo<= 0)
        {
            tiempo = 60f;
        }
        contar.text = "El tiempo restante es: " + tiempo;
    }
}
