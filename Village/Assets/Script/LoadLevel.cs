using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string LevelName;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(LevelName);
    }
}
