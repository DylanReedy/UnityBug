using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MistbornController : MonoBehaviour {

    public GameObject cradle;
    public GameObject chase;
    
    public CharacterController characterController;

    const float cameraLerpSpeed = 3f;
    const int LeftClick = 0;
    const int RightClick = 1;
    const float MinCameraXAngle = -10f;
    const float MaxCameraXAngle = 30f;
    Vector3 lastMousePosition;
    Vector3 currentMousePosition;
    float xAxisMove;
    float yAxisMove;

    // Update is called once per frame
    void Update () {
        Debug.Log(Input.GetAxis("Mouse X"));
        //lastMousePosition = currentMousePosition;
        //currentMousePosition = Input.mousePosition;
        //xAxisMove = currentMousePosition.x - lastMousePosition.x;
        //yAxisMove = currentMousePosition.y - lastMousePosition.y;

        //cradle.transform.position = this.transform.position;
        //Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, chase.transform.position, cameraLerpSpeed * Time.deltaTime);
        //Camera.main.transform.LookAt(this.transform);
        //if (Input.GetMouseButton(RightClick)) {
        //    Vector2 mouseInput = new Vector2(0.1f*xAxisMove, 0.1f * yAxisMove);
        //    Vector3 cradleRotation = cradle.transform.eulerAngles;
        //    cradleRotation.y += mouseInput.x;
        //    cradleRotation.x -= mouseInput.y;
        //    cradle.transform.eulerAngles = cradleRotation;
        //}

        //if (Input.GetAxis("Mouse ScrollWheel") != 0)
        //{
        //    chase.transform.Translate(Vector3.MoveTowards(chase.transform.position,this.transform.position, 0.1f));
        //}
    }
}
