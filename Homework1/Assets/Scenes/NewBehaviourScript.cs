using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Testobj;
    public void Deactive()
    {
        if (Testobj.activeSelf == true)
            Testobj.SetActive(false);
        else
            Testobj.SetActive(true);
    }
}
