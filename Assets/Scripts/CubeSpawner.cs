using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    public Vector3 spawnOffset;
    public float xRange = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B) || OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            float x = Random.Range(-xRange, xRange);

            Vector3 spawnPos = transform.position + new Vector3(x, spawnOffset.y, spawnOffset.z);

            // Spawn Cube
            GameObject go = GameObject.Instantiate(cube, spawnPos, Quaternion.identity);

            go = go.transform.Find("Cube").gameObject;

            Rigidbody rb = go.GetComponent<Rigidbody>();

            float theta = Random.Range(Mathf.PI / 4.0f, 3.0f * Mathf.PI / 4.0f);

            float mag = Random.Range(1.0f, 3.0f);

            Vector3 addedVelcity = new Vector3(Mathf.Cos(theta), Mathf.Sin(theta), 0.0f) * mag;

            rb.AddForce(addedVelcity, ForceMode.VelocityChange);

            float scale = Random.Range(0.1f, 0.25f);

            go.transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
