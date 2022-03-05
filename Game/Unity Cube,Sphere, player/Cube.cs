using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //public : 접근0, 인스펙터 노출0  private : 접근x, 인스펙터 노출x
    //[HideInInspector] public : 외부 클래스 접근 가능, 인스펙터창 노출 안함
    //[SerializeField] private : 외부 클래스 접근 불가, 인스펙터창 노출함
    // Start is called before the first frame update

    //큐브 이동, 1. 힘을 가한다(물리적) -강체가 필요  2. 오브젝트의 위치 바꿈\
    //큐브 스크립트에서 실제 큐브(게임 오브젝트)의 Transform값을 가져와야 함.

    // this 키워드
    // 객체 자신을 반환하는 키워드 여기선 Cube클래스를 반환하는게 아니라
    //Cube클래스 타입의 객체로 반환
    //this.gameObject는 이 프로젝트를 가지는 오브젝트를 말함.

    public int a = 3;
    private Transform tr;

    Vector3 move; //Update함수에서 받은 입력을 FixedUpdate에서 사용하기 위해

    private void Awake()
    {
        Debug.Log(this);
        Debug.Log(this.gameObject); //this가 어둡게 표시됨 -> 생략가능
        Debug.Log(gameObject);
        //실제 컴포넌트로 초기화하기
        tr= this.gameObject.GetComponent<Transform>(); //이 스크립트를 컴포넌트로 가지는 게임 오브젝트의 Transform을 GetComponent로 얻는다.
        tr= gameObject.GetComponent<Transform>();
        tr=GetComponent<Transform>();
        tr = transform; // 얘가 젤 빠르고 위의 셋이 같다.
    }
    //멤버변수는 Awake에서 초기화


    // Update is called once per frame
    void Start()
    {
        tr.position = Vector3.zero; //0,0,0 으로 position 초기화, 가장 빠른 속도
        

        /*transform.position = Vector3.zero;
        GetComponent<Transform>().position = Vector3.zero;
        gameObject.GetComponent<Transform>().position = Vector3.zero;
        this.gameObject.GetComponent<Transform>().position = Vector3.zero;*/
    }
    void FixedUpdate()
    {
        //position 변경시에는 position의 프레임당 변화 량을 더해주어야 한다. 
        //위치변화량 = 위치/시간
        //프레임 당 변화량(프레임단위 속도) = 거리 / 프레임
        //1프레임 사이의 시간만큼의 거리를 더해줄 것이다. 시간당 거리증가로 표현할거니까0
        //위치변화량 = 프레임 당 위치 변화량(move) * 프레임 수
        //deltaTime -> 프레임 사이의 시간 
        //tr.position += Vector3.forward*Time.deltaTime; -->Update()에서 쓰는 함수
        tr.position += move * Time.fixedDeltaTime; //FixedUpdate()에서 쓰는 함수
    }

    void Update()
    {
        //특정 축에 대한 입력, Input은 FixedUpdate에선 사용불가 
        float h = Input.GetAxis("Horizontal");  //h에 -1 ~ 1사이의 값이 들어옴
        float v = Input.GetAxis("Vertical");
        Debug.Log($"h = {h}, v = {v}"); //실행 후 Game창을 누르면 확인 가능
        move = new Vector3(h, 0, v);
    }
}


