using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SandZone : MonoBehaviour
{
    public Slider healthSlider;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            healthSlider.value = healthSlider.value - 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider.value == 0)
        {
            SceneManager.LoadScene("level1");
        }
    }
}
