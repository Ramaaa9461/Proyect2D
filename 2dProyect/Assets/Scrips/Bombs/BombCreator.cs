using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCreator : MonoBehaviour
{
    [SerializeField] GameObject bombPrefab;
    [SerializeField] Transform player;

    public void CreateBomb()
    {
        Instantiate(bombPrefab,player.position, player.rotation);

    }




}
