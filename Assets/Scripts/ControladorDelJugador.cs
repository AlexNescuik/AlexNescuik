using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDelJugador : MonoBehaviour
{
    //parametro de fuerza con la que salta la pelota
    public float fuerzaSalto = 5;
    public float mantequilla = 2;
    public float cottage = -2;
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
        if (Input.GetButton("Fire2"))
        {
            print("Me quiero mover a la derecha");
            miCuerpo.AddForce(new Vector3(mantequilla, 0, 0), ForceMode2D.Force);
        }
        if (Input.GetButton("Fire1"))
        {
            print("Me quiero mover a la izquierda");
            miCuerpo.AddForce(new Vector3(cottage, 0, 0), ForceMode2D.Force);
        }

    }



}
