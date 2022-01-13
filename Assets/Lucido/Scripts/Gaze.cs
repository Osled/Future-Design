using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gaze : MonoBehaviour
{

    public float range = 100f;
    public float timer = 5f;
    public GameObject envo;
    public GameObject pin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
       
        if(Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
           
            if (hit.collider.tag == "Egypt")
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.tag);
                timer -= 1 *Time.deltaTime;
            }
            
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene("SampleScene");
            envo.SetActive(false);
            pin.SetActive(false);
            timer = 5;

            
        }
    }
}
