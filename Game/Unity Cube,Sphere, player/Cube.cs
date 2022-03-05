using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //public : ����0, �ν����� ����0  private : ����x, �ν����� ����x
    //[HideInInspector] public : �ܺ� Ŭ���� ���� ����, �ν�����â ���� ����
    //[SerializeField] private : �ܺ� Ŭ���� ���� �Ұ�, �ν�����â ������
    // Start is called before the first frame update

    //ť�� �̵�, 1. ���� ���Ѵ�(������) -��ü�� �ʿ�  2. ������Ʈ�� ��ġ �ٲ�\
    //ť�� ��ũ��Ʈ���� ���� ť��(���� ������Ʈ)�� Transform���� �����;� ��.

    // this Ű����
    // ��ü �ڽ��� ��ȯ�ϴ� Ű���� ���⼱ CubeŬ������ ��ȯ�ϴ°� �ƴ϶�
    //CubeŬ���� Ÿ���� ��ü�� ��ȯ
    //this.gameObject�� �� ������Ʈ�� ������ ������Ʈ�� ����.

    public int a = 3;
    private Transform tr;

    Vector3 move; //Update�Լ����� ���� �Է��� FixedUpdate���� ����ϱ� ����

    private void Awake()
    {
        Debug.Log(this);
        Debug.Log(this.gameObject); //this�� ��Ӱ� ǥ�õ� -> ��������
        Debug.Log(gameObject);
        //���� ������Ʈ�� �ʱ�ȭ�ϱ�
        tr= this.gameObject.GetComponent<Transform>(); //�� ��ũ��Ʈ�� ������Ʈ�� ������ ���� ������Ʈ�� Transform�� GetComponent�� ��´�.
        tr= gameObject.GetComponent<Transform>();
        tr=GetComponent<Transform>();
        tr = transform; // �갡 �� ������ ���� ���� ����.
    }
    //��������� Awake���� �ʱ�ȭ


    // Update is called once per frame
    void Start()
    {
        tr.position = Vector3.zero; //0,0,0 ���� position �ʱ�ȭ, ���� ���� �ӵ�
        

        /*transform.position = Vector3.zero;
        GetComponent<Transform>().position = Vector3.zero;
        gameObject.GetComponent<Transform>().position = Vector3.zero;
        this.gameObject.GetComponent<Transform>().position = Vector3.zero;*/
    }
    void FixedUpdate()
    {
        //position ����ÿ��� position�� �����Ӵ� ��ȭ ���� �����־�� �Ѵ�. 
        //��ġ��ȭ�� = ��ġ/�ð�
        //������ �� ��ȭ��(�����Ӵ��� �ӵ�) = �Ÿ� / ������
        //1������ ������ �ð���ŭ�� �Ÿ��� ������ ���̴�. �ð��� �Ÿ������� ǥ���ҰŴϱ�0
        //��ġ��ȭ�� = ������ �� ��ġ ��ȭ��(move) * ������ ��
        //deltaTime -> ������ ������ �ð� 
        //tr.position += Vector3.forward*Time.deltaTime; -->Update()���� ���� �Լ�
        tr.position += move * Time.fixedDeltaTime; //FixedUpdate()���� ���� �Լ�
    }

    void Update()
    {
        //Ư�� �࿡ ���� �Է�, Input�� FixedUpdate���� ���Ұ� 
        float h = Input.GetAxis("Horizontal");  //h�� -1 ~ 1������ ���� ����
        float v = Input.GetAxis("Vertical");
        Debug.Log($"h = {h}, v = {v}"); //���� �� Gameâ�� ������ Ȯ�� ����
        move = new Vector3(h, 0, v);
    }
}


