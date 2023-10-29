using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class StormTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            var storm = GetComponent<CapsuleCollider>();
            var player = other.GetComponent<CharacterController>();
            var dir = player.transform.position - transform.position;
            var len = (storm.radius - dir.magnitude) * 0.01f;
            dir.Normalize();
            player.Move(-dir * len);
        }
    }
}
