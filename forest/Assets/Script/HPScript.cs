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
        if (other.tag == "Player")
        {
            healthSlider.value = healthSlider.value - 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(healthSlider.value);
        if (healthSlider.value <= 0)
        {
            Debug.Log("restart");
            SceneManager.LoadScene("Level1");
        }
    }
}