using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionBombs : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(explotionBomb());
    }


    IEnumerator explotionBomb()
    {

        yield return new WaitForSeconds(3f);

        //Efectos
        Destroy(gameObject);
    }

}
