using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksMerging : MonoBehaviour {
    GameObject MergeObject;
    [SerializeField]
    void Merge()
    {
        MergeObject = GameObject.Find("Merger");
        MergeObject.GetComponent<Merging>().id = GetComponent<StorageId>().id;
        MergeObject.GetComponent<Merging>().change = true;
        MergeObject.GetComponent<Merging>().pos = transform.position;
        MergeObject.GetComponent<Merging>().dir = transform.rotation;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (transform.tag == collision.transform.tag)
        {
            Merge();
            Destroy(transform.gameObject);
            Destroy(collision.transform.gameObject);
        }
    }
}
