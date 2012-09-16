using UnityEngine;
using System.Collections;

public class NPCPlayer : Player
{
    // エンターが押せるようになった後、何秒待ってEnterを押すか
    public float delay = 1f;

    // コンピュータがエンターを押す時間の計算
    public float fireTime = -1;
    public float FireTime
    {
        set
        {
            // エンターを押すべき時間にディレイを加算した時間に押す
            fireTime = value + delay;
        }
    }

    // Enter押下待ちかどうか
    public bool isRunning = false;

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        if (isRunning && Time.time > fireTime + delay)
        {
            manager.PushButton(this.gameObject);
            isRunning = false;
        }
    }
}
