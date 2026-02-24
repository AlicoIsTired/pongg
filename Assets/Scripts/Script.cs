using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] Transform PaddleLeft;
    [SerializeField] Transform PaddleRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {

    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("aa");
            Vector3 newPosition = PaddleLeft.position;
            newPosition.y -= 0.05f;
            PaddleRight.position = newPosition;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("aa");
            Vector3 newPosition = PaddleRight.position;
            newPosition.y += 0.05f;
            PaddleRight.position = newPosition;
        }
    }
}
