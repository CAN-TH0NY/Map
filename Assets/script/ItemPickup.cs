using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour

    
{
    public GameObject Flashlight1;
    

    
    public RaycastHit Hit;
    public Camera Camera;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        if (Physics.Raycast(ray, out Hit, 1))
        {
            Debug.Log("hi");
            Flashlight1.GetComponent<Flashlight>().OnLookEnter();
            


            
        }
        if (Physics.Raycast(ray, out Hit, 1) == false)
        {
            Flashlight1.GetComponent<Flashlight>().OnLookExit();
        }

    }

   
}
