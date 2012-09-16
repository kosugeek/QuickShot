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
    static System.Random rnd = new System.Random();

    // 最低timeMin秒以上、ランダムでtimeRangeの範囲で音を出す
    public int timeMin = 3;
    public int timeRange = 5;

    // 計測中の時間
    public float currentTime;
    public AudioClip startClip;
    public AudioClip playingClip;
    public GameObject icon;

    // ゲーム開始状態
    private State gameState = State.READY;

    //
    void Start ()
    {
        // ゲーム終了まで
        currentTime = Time.time + timeMin + (float)rnd.Next(timeRange);
        AudioSource.PlayClipAtPoint(startClip, transform.position);
    }

    // Update is called once per frame
    void Update ()
    {
        if (Time.time > currentTime && State.READY == gameState)
        {
            AudioSource.PlayClipAtPoint(playingClip, transform.position);
            icon.renderer.enabled = true;
            gameState = State.PLAYING;
        }
    }
}
