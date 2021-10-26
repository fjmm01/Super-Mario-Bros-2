using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CustomGravityRigidBody : MonoBehaviour{ 

    [SerializeField]
    bool floatToSleep = false;

    Rigidbody body;

    float floatDelay;

    void Awake(){ 
        body = GetComponent<RigidBody>();
        body.useGravity = false;
    }

    void FixedUpdate (){
        if(floatToSLeep){ 
            if(body.IsSleeping()){
                floatDelay = 0f;
                retunr;
            }
        } 

        if(body.velocity.sqrMagnitude < 0.0001f){ 
            floatDelay += Time.deltaTime;
            if(floatDelay >= 1f){ 
                return;
            }
        }
        else{ 
            floatDelay = 0f;
        }


        body.AddForce(CustomGravity.GetGravity(body.position), ForceMode.Acceleration);
    }
}