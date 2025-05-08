using UnityEngine;

public class PlayOnMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public AudioSource walkSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            if (!walkSound.isPlaying)
            {
                walkSound.Play();
            }
        } 
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (walkSound.isPlaying){
                walkSound.Stop();
            }
            
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            if (!walkSound.isPlaying)
            {
                walkSound.Play();
            }
        } 
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (walkSound.isPlaying){
                walkSound.Stop();
            }
            
        }
    }
}
