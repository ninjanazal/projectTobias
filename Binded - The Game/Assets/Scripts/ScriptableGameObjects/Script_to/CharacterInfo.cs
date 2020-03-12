﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerShape { Aike, Arif }

[CreateAssetMenu(fileName = "CharacterInformation", menuName = "Binded/CharacterInformation")]
public class CharacterInfo : ScriptableObject
{
   // fields -----------------------------------------
   // input de direcçao do jogador pela camera
   private Vector3 _input_cam_dir;

   // informaçao sobre a forma do jogador
   [Header("Forma actual do jogador")]
   public PlayerShape shape;

   #region AikeVars
   // variavies relacionada com Aike
   [Header("Aike")]
   public float AikeGravityReflexition= 3.051f; // valor que simula a variaçao da gravidade com o peso
   public float AikeMaxWalkingSpeed= 2.5f;   // valor da velocidade maxima que aike consegue andar
   public float AikeMaxSpeed = 3.0f;      // velocidade maxima
   public float AikeAceleration = 3.0f;   // aceleraçao
   public float AikeRotationSpeed = 5f;   // velocidade de rotaçao
   public float AikeDrag = 5f;      // drag de movimento
   public float AikeJumpHeight = 50f;      // força de salto
   #endregion

   #region ArifVars
   // variavies relacionada com Aike
   [Header("Aike")]
   public float ArifMaxBaseSpeed = 10.0f;     // velocidade maxima
   public float ArifMaxSpeed = 20.0f;  // velocidade maxima em "corrida"
   public float ArifMinSpeed = 1.0f;   // velocidade minima que pode ter
   public float ArifAceleration = 5.0f;   // aceleraçao
   public float ArifBreakSpeed = 10f;  // força de travagem 
   public float ArifRotationSpeed = 4f;   // velocidade de rotaçao
   public float ArifRollSpeed = 10f;   // rotaçao de roll
   public float ArifDrag = 6f;      // drag de movimento
   #endregion

   // metodos  --------------------------------
   #region Methods
   // altera a forma do jogador
   /// <summary>
   /// Switch the player shaper
   ///</summary>
   public void changeShape()
   {
      // altera para a forma nao actual
      shape = (shape == PlayerShape.Aike) ? PlayerShape.Arif : PlayerShape.Aike;
   }

   // atribui e retorna valor de direcçao de input
   public void UpdateInputDir(Vector3 direction) => _input_cam_dir = direction;
   public Vector3 GetInputDir() { return _input_cam_dir; }

   #endregion
}
