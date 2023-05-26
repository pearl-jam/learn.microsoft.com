﻿namespace TodoApi.Models
{
    /// <summary>
    /// 현재 샘플 앱은 전체 TodoItem 개체를 공개합니다. 
    /// 일반적으로 프로덕션 앱은 모델의 하위 집합을 사용하여 입력 및 반환되는 데이터를 제한합니다. 
    /// 이 동작에는 여러 가지 이유가 있으며, 대표적인 이유는 보안입니다. 
    /// 일반적으로 모델의 하위 집합을 DTO(데이터 전송 개체), 입력 모델 또는 뷰 모델이라고 합니다. 
    /// 이 자습서에서는 DTO가 사용되었습니다.
    ///
    /// DTO는 다음과 같은 용도로 사용할 수 있습니다.
    /// - 과도한 게시를 방지합니다.
    /// - 클라이언트에 표시되지 않아야 하는 속성을 숨깁니다.
    /// - 페이로드 크기를 줄이기 위해 일부 속성을 생략합니다.
    /// - 중첩된 개체를 포함하는 개체 그래프를 평면화합니다. 클라이언트에는 평면화된 개체 그래프가 더 편리할 수 있습니다.
    /// </summary>
    public class TodoItemDTO
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
