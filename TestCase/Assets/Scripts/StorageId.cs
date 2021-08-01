using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageId : MonoBehaviour {
    [SerializeField]
    public int id;
    private void Start()
    {
        Manager();
    }
    public void Manager()
    {
        if (id> GameObject.Find("BiggestNumber").GetComponent<BiggestNumber>().biggestId)
        {
            GameObject.Find("BiggestNumber").GetComponent<BiggestNumber>().biggestId = id;
        }
        
    }
}
