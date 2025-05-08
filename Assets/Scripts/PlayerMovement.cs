using UnityEngine;
using System;
using UnityEngine.InputSystem;
using UnityEngine.Animations;
using Unity.VisualScripting;
using UnityEngine.InputSystem.Processors;

public class Character_move : MonoBehaviour
{

    public CharacterController cha;
    [SerializeField]
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    InputAction lookAction;

    private void Start()
    {
        lookAction = InputSystem.actions.FindAction("Look");
    }

    void Update()
    {
        cha = GetComponent<CharacterController>();
        
        if (Input.GetAxis("Horizontal") != 0){
           float rotvalue = (float)(1.8 * Input.GetAxis("Horizontal"));
            cha.transform.Rotate(0, rotvalue, 0);
        }
        print(cha.transform.rotation.y+"\t"+ Input.GetAxis("Horizontal"));

        //rotate on y axis 

        // move forward and backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        cha.SimpleMove(forward * curSpeed);
        
    }
}