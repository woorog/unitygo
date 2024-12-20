using UnityEngine;

public class temp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
// Assets/
// ├── Scripts/
// │   ├── Server/               # 서버 관련 코드
// │   │   ├── ServerGameManager.cs   # 타일 상태 관리, 이벤트 처리
// │   │   └── ServerInitializer.cs  # 서버 초기화 및 관리
// │   ├── Client/               # 클라이언트 관련 코드
// │   │   ├── TileClickHandler.cs    # 타일 클릭 이벤트 처리
// │   │   ├── ClientGameManager.cs   # UI 업데이트
// │   │   └── NetworkManager.cs      # 네트워크 초기화
// │   ├── Shared/               # 공통 코드
// │   │   ├── TileState.cs           # 타일 상태 정의
// │   │   ├── NetworkMessages.cs     # 서버-클라이언트 메시지 정의
// │   │   └── GameConstants.cs       # 공통 상수
// ├── Prefabs/                  # 타일과 UI 요소
// │   ├── Tile.prefab
// │   └── Board.prefab
// └── Scenes/                   # 씬 파일
//     ├── ServerScene.unity          # 서버 전용
//     └── ClientScene.unity          # 클라이언트 전용