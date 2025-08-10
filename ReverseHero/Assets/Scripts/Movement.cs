using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
  public float velocidad = 5f;
  private Rigidbody2D rb;
  private Vector2 direccion;

  void Awake()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  public void OnMoveUp(InputAction.CallbackContext context)
  {
    if (context.performed)
      direccion.y = 1;
    else if (context.canceled)
      direccion.y = 0;
  }

  public void OnMoveDown(InputAction.CallbackContext context)
  {
    if (context.performed)
      direccion.y = -1;
    else if (context.canceled)
      direccion.y = 0;
  }

  public void OnMoveLeft(InputAction.CallbackContext context)
  {
    if (context.performed)
      direccion.x = -1;
    else if (context.canceled)
      direccion.x = 0;
  }

  public void OnMoveRight(InputAction.CallbackContext context)
  {
    if (context.performed)
      direccion.x = 1;
    else if (context.canceled)
      direccion.x = 0;
  }

  void FixedUpdate()
  {
    rb.velocity = direccion.normalized * velocidad;
    Debug.Log("Dirección: " + direccion);
  }
}
