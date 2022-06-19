using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MobileController : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private Image joystickBG;
   [SerializeField] private Image joystick;
    private Vector2 inputVector; // got coordinate joustick

    private void Start()
    {
        joystickBG = GetComponent<Image>();
        joystick = transform.GetChild(0).GetComponent<Image>();
    }



    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        //if statment colculate coordinate put on joystick
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickBG.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / joystickBG.rectTransform.sizeDelta.x); //get coordinate x
            pos.y = (pos.y / joystickBG.rectTransform.sizeDelta.y); //get coordinate y

            inputVector = new Vector2(pos.x * 2 - 1, pos.y * 2 - 1); //set coordinate touched
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            joystick.rectTransform.anchoredPosition = new Vector2(inputVector.x * (joystickBG.rectTransform.sizeDelta.x/2), inputVector.y * (joystickBG.rectTransform.sizeDelta.y / 2));
        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        print("PointerDown");
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector2.zero;
        joystick.rectTransform.anchoredPosition = inputVector;
    }
    public float Horizontal()
    {
        if (inputVector.x != 0) return inputVector.x;
        else
        {
            return Input.GetAxis("Horizontal");
        }
    }
    public float Vertical()
    {
        if (inputVector.y != 0) return inputVector.y;
        else return Input.GetAxis("Vertical");
    }

}
