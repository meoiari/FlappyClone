using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    public float TimeDiff;
    float fTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fTimer += Time.deltaTime;
        if(fTimer > TimeDiff)
        {
            GameObject NewPipe = Instantiate(Pipe);
            NewPipe.transform.position = new Vector3(5, Random.Range(-1.6f, 5.2f), 0);
            fTimer = 0;
            Destroy(NewPipe, 8.0f);
        }
        
    }
}
