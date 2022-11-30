using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStickMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform rect_Background;
    [SerializeField] private RectTransform rect_JoyStick;

    private float radius;

    [SerializeField] private GameObject go_Player;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float runSpeed;

    private bool isTouch = false;
    private bool Speed = false;
    private Vector3 movePosition;

    // Start is called before the first frame update
    void Start()
    {
        radius = rect_Background.rect.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouch)
        {
            go_Player.transform.position += movePosition;
        }
    }

    public void Running()
    {
        Speed = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 value = eventData.position - (Vector2)rect_Background.position;

        value = Vector2.ClampMagnitude(value, radius);
        rect_JoyStick.localPosition = value;

        value = value.normalized;
        if (Speed == false)
        {
            movePosition = new Vector3(value.x * moveSpeed * Time.deltaTime, 0f, value.y * moveSpeed * Time.deltaTime);
        }
        else if (Speed == true)
        {
            movePosition = new Vector3(value.x * runSpeed * Time.deltaTime, 0f, value.y * runSpeed * Time.deltaTime);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isTouch = false;
        Speed = false;
        rect_JoyStick.localPosition = Vector3.zero;
    }
}
