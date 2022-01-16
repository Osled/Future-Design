using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localScale.x >=0.3f)
        {
        Vector3 vec = new Vector3(0.1f,0.1f, 0.1f);
 
         transform.localScale -= vec *Time.deltaTime;
        }
      
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag =="Hand")
        {
            this.GetComponent<SpinFree>().spin = false;
        }
    }
     public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="Hand")
        {
            this.GetComponent<SpinFree>().spin = true;
        }
    }
   
        
    
}
