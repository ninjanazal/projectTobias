﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerShape { rat, owl }

[CreateAssetMenu(fileName = "CharacterInformation", menuName = "Binded/CharacterInformation")]
public class CharacterInfo : ScriptableObject
{
    // input de direcçao do jogador pela camera
    private Vector3 _inputDirection;

    // informaçao sobre a forma do jogador
    [Header("Forma actual do jogador")]
    public PlayerShape shape;

    // altera a forma do jogador
    /// <summary>
    /// Switch the player shaper
    ///</summary>
    public void changeShape()
    {
        // altera para a forma nao actual
        shape = (shape == PlayerShape.rat) ? PlayerShape.rat : PlayerShape.rat;
    }


}
