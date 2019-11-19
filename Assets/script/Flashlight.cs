using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    public GameObject CharacterFlashlight;
    public GameObject CharacterLight;
    private float ButtonActivable;
    private float FlashlightOpened;
    private float FlashlightObtained;
    public GameObject FlashlightObj;
    public GameObject Character;
    public Text PickupText;
    private float TriggerDetection;
    private float LookDetection;
    // Start is called before the first frame update
    void Start()
    {
        Character = GameObject.Find("BatonCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonActivable == 1f && Input.GetKeyDown(KeyCode.E)) {
            FlashlightObj.transform.Translate(1000, 1000, 1000);
            FlashlightObtained = 1f;
            Debug.Log("Flashlight Obtained");
            CharacterFlashlight.gameObject.SetActive(true);
        }
        if (FlashlightOpened == 2f && Input.GetKeyDown(KeyCode.F) && FlashlightObtained == 1f)
        {
            CharacterLight.gameObject.SetActive(false);
            FlashlightOpened = 1f;
            Debug.Log("Closed");
            StartCoroutine(FlashlightCloseVerification());

        }
        if (FlashlightObtained == 1f && Input.GetKeyDown(KeyCode.F) && FlashlightOpened == 0f)
        {
            CharacterLight.gameObject.SetActive(true);
            FlashlightOpened = 1f;
            Debug.Log("Opened");
            StartCoroutine(FlashlightVerfication());
            


        }
       

    }



    IEnumerator FlashlightCloseVerification()
    {
        yield return new WaitForSeconds(1f);
        FlashlightOpened = 0f;
        Debug.Log("close verfication done");

    }


    IEnumerator FlashlightVerfication()
    {
        yield return new WaitForSeconds(1f);
        FlashlightOpened = 2f;
        Debug.Log("verification done");

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        TriggerDetection = 1f;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        TriggerDetection = 0f;
    }

    public void OnLookExit()
    {
        PickupText.gameObject.SetActive(false);


    }

   public void OnLookEnter()
    {

        LookDetection = 1f;
        if (TriggerDetection == LookDetection)
        {
            PickupText.gameObject.SetActive(true);
            ButtonActivable = 1f;
            
        }
        else if (TriggerDetection == 0f)
        {
            LookDetection = 0f;
            Debug.Log("Look Canceled");

        }
    }

    
}
