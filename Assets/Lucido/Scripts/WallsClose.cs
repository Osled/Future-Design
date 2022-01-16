using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsClose : MonoBehaviour
{
    public Animator  m_Animator;
    public Animator  m_AnimatorW;
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
          if(other.gameObject.tag=="Wall")
        {
            Debug.Log("fly");
             m_AnimatorW.SetBool("Open", true);
        }
    }
   
       public void OnCollisionExit(Collision other)
    {
       if(other.gameObject.tag=="Pyram")
        {
             m_Animator.SetBool("Open", true);
             this.GetComponent<AudioSource>().enabled =true;
        }
    }
   
    
 
}
