; 2017-02-22
; 직삼각형 출력하기
; ex) Input : 3
;     Ouput : *
;             **
;             ***
           
(defun star (cnt)
    (let (stars (car ""))
        (loop for x from 1 to cnt do
            (setq stars (concatenate 'string stars "*"))
        )
        (print stars)
    )
)

(defun triangle (size)
    (loop for x from 1 to size
        do (star x))
)

(triangle (parse-integer (elt *args* 0)))
