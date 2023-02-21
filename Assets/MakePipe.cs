using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;

    public float timeDiff;

    float timer = 0;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > timeDiff){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(8, Random.Range(-18.9f, 6.1f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }

        
    }
}
