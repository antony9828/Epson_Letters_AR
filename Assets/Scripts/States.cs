using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States : MonoBehaviour
{
    [SerializeField] public static bool State_A;
    [SerializeField] public static bool State_B;
    [SerializeField] public static bool State_C;
    [SerializeField] public static bool State_D;
    [SerializeField] public static bool State_E;
    [SerializeField] public static bool State_F;
    [SerializeField] public static bool State_G;
    [SerializeField] public static bool State_H;
    [SerializeField] public static bool State_I;
    [SerializeField] public static bool State_J;
    [SerializeField] public static bool State_K;
    [SerializeField] public static bool State_L;
    [SerializeField] public static bool State_M;
    [SerializeField] public static bool State_N;
    [SerializeField] public static bool State_O;
    [SerializeField] public static bool State_P;
    [SerializeField] public static bool State_Q;
    [SerializeField] public static bool State_R;
    [SerializeField] public static bool State_S;
    [SerializeField] public static bool State_T;
    [SerializeField] public static bool State_U;
    [SerializeField] public static bool State_V;
    [SerializeField] public static bool State_W;
    [SerializeField] public static bool State_X;
    [SerializeField] public static bool State_Y;
    [SerializeField] public static bool State_Z;

    [SerializeField] public static bool State_Next;
    [SerializeField] public static bool State_Back;
    [SerializeField] public static bool State_Restart;


    public bool A;
    public bool B;
    public bool C;
    public bool D;
    public bool E;
    public bool F;
    public bool G;
    public bool H;
    public bool I;
    public bool J;
    public bool K;
    public bool L;
    public bool M;
    public bool N;
    public bool O;
    public bool P;
    public bool Q;
    public bool R;
    public bool S;
    public bool T;
    public bool U;
    public bool V;
    public bool W;
    public bool X;
    public bool Y;
    public bool Z;

    public bool Next;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        A = State_A;
        B = State_B;
        C = State_C;
        D = State_D;
        E = State_E;
        F = State_F;
        G = State_G;
        H = State_H;
        I = State_I;
        J = State_J;
        K = State_K;
        L = State_L;
        M = State_M;
        N = State_N;
        O = State_O;
        P = State_P;
        Q = State_Q;
        R = State_R;
        S = State_S;
        T = State_T;
        U = State_U;
        V = State_V;
        W = State_W;
        X = State_X;
        Y = State_Y;
        Z = State_Z;

        Next = State_Next;
    }
}
