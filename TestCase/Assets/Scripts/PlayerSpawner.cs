using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject[] players = new GameObject[11];
    void Start()
    {
        Spawn();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Wait());
        }
    }
    void Spawn()
    {
       
        GameObject _player = Instantiate(players[Random.Range(0, GameObject.Find("BiggestNumber").GetComponent<BiggestNumber>().biggestId)], new Vector3(0, 0.5f, -7.5f), Quaternion.identity);
        _player.AddComponent<PlayerXMovement>();
        _player.AddComponent<PlayerThrow>();
        
    }
    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        Spawn();
    }
}

