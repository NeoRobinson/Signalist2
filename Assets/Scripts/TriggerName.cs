using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerName : MonoBehaviour
{
    public int triggerName = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider myTrigger)
    {
        //triggerName = myTrigger.gameObject.name;
        if (!int.TryParse(myTrigger.gameObject.name, out triggerName)) 
        {
            //triggerName = 0;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        triggerName = 0;
    }
}
