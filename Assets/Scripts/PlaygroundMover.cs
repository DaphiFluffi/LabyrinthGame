using UnityEngine;

public class PlaygroundMover : MonoBehaviour
{
    public float speed = 50f;
    public float maxAngle = 20f;

    private StateMachine st;

    private void Start()
    {
       st =  FindObjectOfType<StateMachine>();
       st.Trigger(Event.WASDClicked);

    }
    
    private void FixedUpdate()
    { //die Bewegung ist unabhängig von der Frame Rate

        // Tasteninput um das Spielfeld nach vorne, hinten und zur Seite zu bewegen
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.back * (speed * Time.fixedDeltaTime)); //negative z-axis
        
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.forward * (speed * Time.fixedDeltaTime)); //positive z-axis

        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.left * (speed * Time.fixedDeltaTime)); //negative x-axis 

        if (Input.GetKey(KeyCode.S))
            transform.Rotate(Vector3.right * (speed * Time.fixedDeltaTime)); //positive x-axisw
    }
}
