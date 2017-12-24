using System;
using UnityEngine;
public class CameraController : MonoBehaviour
{

    public GameObject cameraObject;
    public GameObject player;

    public float zoomMax            = 100f;
    public float zoomMin            = 20f;
    private new Camera camera;

    //旋转，缩放视角的速度
    public float rototeAngleSpeed   =1;
    public float zoomViewSpeed      =1;
    /// <summary>
    /// 旋转角度
    /// </summary>
    Vector2 rototeAngle;
    /// <summary>
    /// 游戏开始
    /// </summary>
    void Start()
    {
        cameraObject.transform.LookAt(player.transform.position);
        camera = cameraObject.GetComponent<Camera>();
    }

    /// <summary>
    /// Update
    /// </summary>
    void Update()
    {
        RototeAroundPlayer();
        ZoomAngleOfView();
    }

    /// <summary>
    /// 旋转视角
    /// </summary>
    private void RototeAroundPlayer() {
        if (Input.GetMouseButtonDown(1))
        {
            rototeAngle = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            rototeAngle = Vector2.zero;
        }
        if (rototeAngle == Vector2.zero)
        {
            return;
        }
        Vector2 temp = Input.mousePosition;
        float moveX = temp.x - rototeAngle.x;
        cameraObject.transform.RotateAround(player.transform.position, new Vector3(0, 1, 0), moveX * Time.deltaTime* rototeAngleSpeed);
        rototeAngle = Input.mousePosition;
    }

    /// <summary>
    /// 缩放视角
    /// </summary>
    private void ZoomAngleOfView()
    {
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        if (mouseWheel == 0)
            return;
        float temp = camera.fieldOfView;
        temp += mouseWheel * zoomViewSpeed;
        if (temp > zoomMax)
            temp = zoomMax;
        if (temp < zoomMin)
            temp = zoomMin;
        camera.fieldOfView = temp;
    }

}
