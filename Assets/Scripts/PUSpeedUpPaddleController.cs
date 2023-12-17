using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpPaddleController : MonoBehaviour
{
  public Collider2D ball;
  public BallController ballController;
  public PowerUpManager manager;
  public float effect;
  public int Duration;
  private float timerSpeedUp;
  private bool isSpeedUp;
  private GameObject namePaddle;

  private void Start()
  {
    isSpeedUp = true;
  }

  private void Update()
  {
    if (isSpeedUp == true)
    {
      if (timerSpeedUp >= 0)
      {
        timerSpeedUp -= Time.deltaTime;
      }
      else
      {
        DeactivePUSpeedUp();
        timerSpeedUp = 0;
      }
    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision == ball)
    {
      namePaddle = GameObject.Find(ballController.touchPaddle);

      namePaddle.GetComponent<PaddleController>().ActivatePUSpeedUp(effect);
      timerSpeedUp = 0;

      isSpeedUp = true;

      manager.RemovePowerUp(gameObject);
    }
  }

  private void DeactivePUSpeedUp()
  {
    namePaddle = GameObject.Find(ballController.touchPaddle);
    namePaddle.GetComponent<PaddleController>().DeactivatePUSpeedUp(effect);
    isSpeedUp = false;
  }
}
