using UnityEngine;

public class fireFlare : MonoBehaviour
{
    public Transform flare;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flare = GameObject.FindGameObjectWithTag("flare").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(flare, transform.position, transform.rotation);
        } 
    }
}
