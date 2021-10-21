using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    [SerializeField]
    int spawnNumber;

    private void Start()
    {
        for (int i = 0; i < spawnNumber; i++)
        {
            GameObject newGameobject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            newGameobject.name = i.ToString();
            Vector3 position = new Vector3(i, 0, 0);
            newGameobject.transform.position = position;
        }
    }
}
