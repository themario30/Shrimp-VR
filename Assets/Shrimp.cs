using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrimp : MonoBehaviour
{
    public GameObject shrimpPrefab;
    public int shrimpPopulation;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] Shrimps = new GameObject[shrimpPopulation];
        for(int i = 0; i < shrimpPopulation; i++)
        {
            GameObject temp = Instantiate(shrimpPrefab);
            Vector3 pos = Vector3.zero;
            while(-1.5f < pos.x && pos.x < 1.5f && -1.5f < pos.z && pos.z < 1.5f)
            {
                pos = new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 4f), Random.Range(-10f, 10f));
            }
            temp.transform.position = pos;
            temp.transform.parent = this.transform;
            temp.GetComponent<ShrimpController>().name = Random.Range(1000, 9999).ToString();
            if (Random.Range(0, 100) > 90)
                temp.GetComponent<ShrimpController>().BadShrimp = true;
            Shrimps[i] = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
