using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKiller : MonoBehaviour
{
    public float timeToLive = 1.0f;

    private float timeLived = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLived += Time.deltaTime;
        
        if (timeLived > timeToLive )
        {
            Destroy(this.gameObject);
        }
    }
}
