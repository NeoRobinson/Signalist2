using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerNav : MonoBehaviour
{
    public float maxSpeed = 10f;
    public string lastCollider;
    public int indexCounter = 0;
    public string Signs = "0";
    public TriggerName tN;
    public Transform otherTransform;
    public bool flag1 = false;
    float signTime = 0;

    string roundSign = "123";
    string stopSign = "321";
    string doundSign = "133";
    string forwardSign = "12";

    private string nameGest = "Nil";
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag1 == true)
        {
            otherTransform.Translate(0, 0, -Time.deltaTime);
        }

        signTime += Time.deltaTime;
        //Debug.Log(lastCollider);
        if (lastCollider != tN.triggerName.ToString())
        {
            lastCollider = tN.triggerName.ToString();
            signTime = 0;
            indexCounter++;
            Signs += lastCollider;
        }

        if (signTime >= 2f && indexCounter != 0)
        {
            flag = true;

            Signs = Signs.Replace("0", "");

            Debug.Log(Signs);

            if (Signs == roundSign)
            {
                flag1 = true;
            }

            if (Signs == stopSign)
            {
                flag1 = false;
            }
            if (flag)
            {
                Debug.Log(nameGest);
            }

            else Debug.Log("Error");


            indexCounter = 0;
            tN.triggerName = 0;
            Signs = "0";
        }
    }
}
