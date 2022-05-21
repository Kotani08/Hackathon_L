using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerr : MonoBehaviour
{
#region 移動関連
private Vector3 movingDirecion;
private Vector3 movingVelocity;
public float speed = 1000f;
public float JumpPower = 1000f;
public int jumpmax=2;
#endregion

// PlayerのRigidbody取得
[SerializeField]
private Rigidbody2D player;
[SerializeField]
private MagnetTypeDisplay magnetSystem;

    #region 移動関連
    public void Playerwalk()
    {
      #region 移動関連
      float x = Input.GetAxisRaw("Horizontal");
      float z = Input.GetAxisRaw("Vertical");
      movingDirecion = new Vector2(x,z);
	    movingDirecion.Normalize();
	    movingVelocity = movingDirecion * speed;
      if (Input.GetKeyDown(KeyCode.Space)) {Jump();}
      if (Input.GetKeyDown(KeyCode.Z)) {magnetSystem.MagTypeDisp();}
      if (Gamepad.current != null)
      {
        if (Gamepad.current.buttonSouth.wasPressedThisFrame){Jump();}
        if(Gamepad.current.buttonEast.wasPressedThisFrame){magnetSystem.MagTypeDisp();}
      }
       
      player.velocity = new Vector2(movingVelocity.x, player.velocity.y);
      #endregion
    }
    void Jump()
    {
    if(jumpmax>=1){
		player.AddForce(transform.up * JumpPower, ForceMode2D.Impulse);
    jumpmax--;
    }
    }
    #endregion
}
