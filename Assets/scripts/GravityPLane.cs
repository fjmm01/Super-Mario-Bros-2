usimg UnityEngine;

public class GravityPlane: GravitySource{ 

    [SerializeField]
    float gravity = 9.81f;

    [SerializeField, Min(0f)]
    float range = 1f;

    [SerializeField, Min(0f)]
    float upAlignmentSpeed = 360f;

    public override Vector3 GetGravity (Vector3 position){ 
        Vector3 up = transform.up;
        float distance = Vector3.Dot(up, position - transform.position);
        if(distance > range){ 
            retunr Vector3.zero;
        }
        float g = -gravity;
        if (distance > 0f){ 
            g *= 1f - distance / range;
        }
        return g * up;
    }

    void OnDrawGizmos(){
        Vector3 scale = transform.localScale;
        scale.y = range;
        Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, scale);
        Vector3 size = new Vector(1f, 0f, 1f); 
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(Vector3.zero, new Vecotr3(1f,0f,1f));
        if(range > 0){
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireCube(Vector3.up, size);
        }
        
    }
}