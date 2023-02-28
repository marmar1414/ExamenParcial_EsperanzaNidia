using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public GameObject Peronaje;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyCode(GetKey.W))
        {
            transform.position.left += (Vector3 * speed * Time.deltaTime);
        }
        if (KeyCode(GetKey.S))
        {
            transform.position.right += (Vector3 * speed * Time.deltaTime);
        }
        if (KeyCode(GetKey.A))
        {
           
        }
        if (KeyCode(GetKey.D))
        {
            
        }
    }
}
