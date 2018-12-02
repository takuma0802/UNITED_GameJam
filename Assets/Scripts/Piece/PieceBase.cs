﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PieceBase : MonoBehaviour, IPieceAction
{
    // Pieceの種類
    protected PieceType pieceType;
    protected PlayerType playerType;
    // Pieceの固有番号（0~14）
    protected int pieceNum;

    private bool isPutted;
    private int row;
    private int column;

    public PieceType PieceType { get { return pieceType; } }
    public PlayerType Player { get { return playerType; } }
    public int PieceNum { get { return pieceNum; } }

    public int Row
    {
        get { return row; }
        set { row = value; }
    }

    public int Column
    {
        get { return column; }
        set { column = value; }
    }

    public bool IsPutted
    {
        get { return isPutted; }
        set { isPutted = value; }
    }

    public PieceBase(PlayerType player, int pieceNum)
    {
        //this.pieceType = type;
        this.playerType = player;
        this.pieceNum = pieceNum;
    }

    public virtual void Move() { }
    public virtual void Attack() { }

    public virtual void Start()
    {

    }


}
