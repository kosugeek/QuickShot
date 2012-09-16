using UnityEngine;
using System.Collections;

// ゲームの状態を管理する為のENUM
// READY : ENTER待ち状態(この状態でボタンを押すとフライング)
// PLAYING : 正式にENTERが押せる状態(プレイヤーの押下したタイミングの比較)
// RESULT : 結果表示(勝敗/フライングの状態を表示)
enum State
{
    READY, PLAYING, RESULT
}

public class GameManager : MonoBehaviour
{
    // ゲーム開始状態
    private State gameState = State.READY;
    public GameObject startLogo;

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
    }
}
