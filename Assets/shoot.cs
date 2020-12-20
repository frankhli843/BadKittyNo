using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // TODO reference the better solution
    public GameObject WaterGun; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)){
            GameObject Water = Instantiate(WaterGun, transform.position, Quaternion.identity) as GameObject;
            Water.GetComponent<Rigidbody>().addForce(tranform.forward * 12);
        }
    }
}
