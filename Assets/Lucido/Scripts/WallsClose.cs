using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsClose : MonoBehaviour
{
    public Animator  m_Animator;
    public Animator  m_AnimatorW;
    public GameObject effect0;
    public GameObject effect1;
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
            effect0.SetActive(true);
             effect1.SetActive(true);
             m_AnimatorW.SetBool("Open", true);
              this.GetComponent<AudioSource>().enabled =false;
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
