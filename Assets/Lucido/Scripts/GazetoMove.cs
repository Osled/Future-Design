using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazetoMove : MonoBehaviour
{
    public GameObject CamR;
    public GameObject CamL;
    public float range = 100f;
    public float timer = 5f;
    public GameObject envo;
    public GameObject pin;
    // Start is called before the first frame update
    void Start()
    {

        gameObject.GetComponent<Camera>().fieldOfView =155f;
        CamR.GetComponent<Camera>().fieldOfView =155f;
        CamL.GetComponent<Camera>().fieldOfView =155f;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
       
        if(Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
           
            if (hit.collider.tag == "Door")
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.tag);
                timer -= 1 *Time.deltaTime;
            }
            
        }
        if (timer <= 0)
        {
            gameObject.GetComponent<Camera>().fieldOfView -=10f *Time.deltaTime;
            CamR.GetComponent<Camera>().fieldOfView -=5f *Time.deltaTime;
            CamL.GetComponent<Camera>().fieldOfView -=5f *Time.deltaTime;
            //SceneManager.LoadScene("SampleScene");
            //envo.SetActive(false);
          //  pin.SetActive(false);
            if( gameObject.GetComponent<Camera>().fieldOfView <=90f)
            {
                timer = 5;
            }
            

            
        }
    }
}
