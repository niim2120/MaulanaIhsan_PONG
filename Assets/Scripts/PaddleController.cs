using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
  public float speed;
  public float speedReset;
  public KeyCode upKey;
  public KeyCode downKey;
  private Rigidbody2D rig;

  private void Start()
  {
    rig = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    Vector3 movement = GetInput();

    MoveObject(GetInput());
  }
  private Vector2 GetInput()
  {
    if (Input.GetKey(upKey))
    {
      return Vector2.up * speed;
    }
    else if (Input.GetKey(downKey))
    {
      return Vector2.down * speed;
    }
    return Vector2.zero;
  }

  private void MoveObject(Vector2 movement)
  {

    rig.velocity = movement;
  }

  public void ActivatePUExtend(float effect)
  {
    rig.transform.localScale *= new Vector2(1, effect);
  }

  public void ActivatePUSpeedUp(float effect)
  {
    speed *= effect;

  }
  public void DeactivatePUSpeedUp(float effect)
  {
    speed = speedReset;
  }
}
