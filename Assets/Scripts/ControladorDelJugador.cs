using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDelJugador : MonoBehaviour
{
    //parametro de fuerza con la que salta la pelota
    public float fuerzaSalto = 5;
    //referencia al componente rigid body
    private Rigidbody2D miCuerpo;
    public Transform Pelota;

    // Start is called before the first frame update
    void Start()
    {
        //obtengo el componente 
        miCuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            print("Se presionó salto");
            miCuerpo.AddForce(
                new Vector3(0, fuerzaSalto, 0),
                ForceMode2D.Impulse);
        }
    }

}
