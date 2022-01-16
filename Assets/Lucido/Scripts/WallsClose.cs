using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsClose : MonoBehaviour
{
    public Animator  m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       public void OnCollisionExit(Collision other)
    {
       if(other.gameObject.tag=="Pyram")
        {
             m_Animator.SetBool("Open", true);
        }
    }
    
 
}
