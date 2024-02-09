using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mouton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _zoneDanger;
    [SerializeField] private GameObject _parachute;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    void OnTriggerEnter(Collider other){
        Debug.Log(other);

        if(other.gameObject.tag == _zoneDanger.gameObject.tag){
            Debug.Log("bam");
            _parachute.SetActive(true);
        }


    }
}
