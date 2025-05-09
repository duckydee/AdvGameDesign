using UnityEngine;

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Text textbox;
    [SerializeField] private Health hp;

    void Start()
    {
        //textbox = GetComponent<Text>();
    }

    void Update()
    {
        textbox.text = "HP: " + hp.playerHealth;

        if (hp.playerHealth <= 0)
            Destroy(gameObject);
    }
}
