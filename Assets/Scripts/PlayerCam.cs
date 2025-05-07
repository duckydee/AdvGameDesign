using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [SerializeField]
    public Transform player;

    private void Update(){
        //rotate camera
        transform.localRotation = Quaternion.Euler(0, player.rotation.y, 0);
    }
}
