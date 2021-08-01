using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merging : MonoBehaviour {
    public bool change { get; set; }
    public int id { get; set; }
    public Vector3 pos { get; set; }
    public Quaternion dir { get; set; }
    [SerializeField]
    GameObject[] blocks = new GameObject[11];
    private void Update()
    {
        Merge();
    }
    public void Merge()
    {
        if (change == true)
        {

            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().score += int.Parse(blocks[id + 1].name);
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Manage(); 
            GameObject block = Instantiate(blocks[id + 1],pos,dir);
            block.GetComponent<StorageId>().Manager();
            block.GetComponent<Rigidbody>().AddForce(Vector2.up*500);
            change = false;
        }
    }
}
