# deemo-surface

서피스 터치스크린으로 디모 pc버젼을 플레이하고 싶어서
터치스크린으로 화면 하단 터치하면 노트, 상단 슬라이드하면 슬라이드 노트를 치는게 목적

## 진행상황

마우스 후킹으로 터치 이벤트를 받아내 키보드 이벤트를 보내려고 했다
후킹과 이벤트 보내기는 성공했는데 문제는 터치 이벤트가 완전히 마우스 후킹으로 얻을 수 없더라
멀티터치는 아예 클릭 이벤트로 후킹되질 않고 약간의 딜레이도 있어서

터치 이벤트를 따로 가져오는 그런걸 찾긴했음 이걸 써서 잘 하면 될 것 같음
일단 오늘은 아니고