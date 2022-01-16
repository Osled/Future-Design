using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOopen : MonoBehaviour
{
    public GameObject doorLock;
    public GameObject key;
    public Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Key")
        {
           //key.GetComponent<DistanceGrabbable>().enabled = false;
            key.transform.position= doorLock.transform.position  ;
            key.transform.rotation= doorLock.transform.rotation ;

            key.GetComponent<Rigidbody>().useGravity =false;
            key.GetComponent<Rigidbody>().isKinematic =true;
            m_Animator.SetBool("Open", true);

}
    }

}
