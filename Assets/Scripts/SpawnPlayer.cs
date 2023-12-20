using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public static SpawnPlayer isntance;
    public GameObject playerPrefab;

    private void Awake()
    {
        isntance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            PlayerSpawner();
        }
    }

    public void PlayerSpawner() // spawnaplyer() in video
    {
        Transform spawnpoint = SpawnManager.instance.GetSpawnPoint();
        PhotonNetwork.Instantiate(playerPrefab.name, spawnpoint.transform.position, spawnpoint.transform.rotation);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}