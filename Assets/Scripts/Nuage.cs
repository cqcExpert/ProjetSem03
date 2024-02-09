using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuage : MonoBehaviour
{
    // Start is called before the first frame update

    private float _positionX; 

    private float _positionY;

    private float _positionZ;

    [SerializeField] private float _vitesse = 3;


    void Start()
    {
        _positionX = transform.position.x;
        _positionY = transform.position.y;
        _positionZ = transform.position.z;

        Debug.Log(_positionX);

        
    }

    // Update is called once per frame
    void Update()
    {
        BougeNuage();
    }

    void BougeNuage(){

        //_positionX = _positionX + (1 * Time.deltaTime); 
        //--------------------------------------------------- A quoi ca sert....Direction Globale
        /*transform.position = new Vector3(_positionX,_positionY,_positionZ);
        */

        //Vector3(1,0,0); Direction Locale
        transform.Translate(Vector3.forward * _vitesse);
        transform.Translate(Vector3.left * _vitesse);
    }
}
