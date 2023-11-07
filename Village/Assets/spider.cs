using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var ac = GetComponent<Animator>();
        ac.Play("Armature|run", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
