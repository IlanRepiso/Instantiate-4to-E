using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CloneAmount;
    public Text txtUserCloneAmount;
    GameObject clon;

    public void MultiInstantiate()
    {
        CloneAmount = int.Parse(txtUserCloneAmount.text);
        for (int i = 0; i < CloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 3);
        }
    }
}
