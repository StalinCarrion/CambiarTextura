using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarMateria : MonoBehaviour {

    public Material color1;
    public Material color2;

    public Texture imagen;
	
	// Update is called once per frame
	void Update () {
        //PARA CAMBIAR DE MATERIAL UN OBJETO
        //if (Input.GetKey(KeyCode.A))
        //{
        //    //color1
        //    transform.GetComponent<MeshRenderer>().material = color1;

        //}
        //else if (Input.GetKey(KeyCode.B))
        //{
        //    transform.GetComponent<MeshRenderer>().material = color2;

        //}
        //fIN
        //Cambiar Textura de un objeto 
        if (Input.GetKey(KeyCode.A))
        {
            //El "_MainTex" se ve en Inspector clik derecho MainTex 
            transform.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", imagen);

        }
        //Fin

		
	}
}
